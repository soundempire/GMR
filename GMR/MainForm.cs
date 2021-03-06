﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMR;
using GMR.BLL;
using GMR.Controls.ServiceClass;
using GMR.Models;
using Context = GMR.ApplicationContext;

namespace GMR
{
    public partial class MainForm : Form
    {
        private readonly IContractorService _contractorService;

        private readonly ITransactionService _transactionService;

        private readonly ILanguagesService _languagesService;

        private readonly ITransferContractorsService _transferContractorsService;

        private readonly IRecycleBinService _recycleBinService;

        private List<TransactionViewModel> _loadedTransactions;

        private (ContractorViewModel Contractor, TransactionViewModel Transaction) _previousEditableModel;

        private bool _contractorsCBoxValueSelected = false;

        private bool _isSignOut;

        private const string allContractorsValue = "Все";

        public MainForm(IContractorService contractorService, ITransactionService transactionService, ILanguagesService languagesService, ITransferContractorsService transferContractorsService, IRecycleBinService recycleBinService)
        {
            InitializeComponent();

            _contractorService = contractorService;
            _transactionService = transactionService;
            _languagesService = languagesService;
            _transferContractorsService = transferContractorsService;
            _recycleBinService = recycleBinService;
        }

        #region Main Form EventHandlers

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadContractorsAsync();

            userAccountToolStrip.Text = Session.Person.FullName;

            foreach (var language in (Mapper.Map<IEnumerable<LanguageModel>, IEnumerable<LanguageViewModel>>(await _languagesService.GetLanguages())).OrderBy(_ => _.Name))
            {
                var languageToolstripMenuItem = new ToolStripMenuItem(language.Name);
                languageMenuItem.DropDownItems.Add(languageToolstripMenuItem);
            }

            SetFormsSizes();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isSignOut)
            {
                DisposeServices();
                return;
            }

            if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                DisposeServices();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isSignOut)
            {
                Context.SetExecutableForm(DIContainer.Resolve<LoginForm>());
                Context.ShowExecutableForm();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e) => SetFormsSizes();

        #endregion

        #region DateTimePickers EventHandlers

        private async void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (contractorsDGView.SelectedRows.Count == 1)
                await BindTransactionsToDataGridViewAsync();
            else
                MessageBox.Show("Должен быть активен один контрагент.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region ContractorsDGView EventHandlers

        private void ContractorsDGView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _previousEditableModel.Contractor = (ContractorViewModel)(contractorsDGView.Rows[e.RowIndex].DataBoundItem as ICloneable).Clone();
        }

        private async void ContractorsDGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentContractor = contractorsDGView.Rows[e.RowIndex].DataBoundItem as ContractorViewModel;

            var isModelValid = true;
            if (string.IsNullOrWhiteSpace(currentContractor.Name))
            {
                MessageBox.Show("У контрагента не может быть пустого имени.", "Переименование контрагента", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isModelValid = false;
            }
            else if (!ValidateModel(currentContractor, "Некорректно заполнены значения контрагента."))
            {
                isModelValid = false;
            }

            if (!isModelValid)
                currentContractor.Name = _previousEditableModel.Contractor.Name;

            if (!currentContractor.Equals(_previousEditableModel.Contractor))
            {
                await _contractorService.UpdateContractorAsync(Mapper.Map<ContractorViewModel, ContractorModel>(currentContractor));

                contractorsCBox.Items.Clear();
                contractorsCBox.Items.Add(allContractorsValue);
                contractorsCBox.Items.AddRange((await _contractorService.GetContractorsAsync(Session.Person.ID)).Select(c => c.Name).ToArray());
                contractorsCBox.SelectedIndexChanged -= ContractorsCBox_SelectedIndexChanged;
                contractorsCBox.Text = currentContractor.Name;
                contractorsCBox.SelectedIndexChanged += ContractorsCBox_SelectedIndexChanged;
            }

            _previousEditableModel.Contractor = null;
        }

        private void ContractorsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
            => MessageBox.Show($"Некорректно заполнены значения контрагента.\n{e.Exception.Message.ToString()}", "Ошибочный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void ContractorsDGView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                contractorContextMenu.Show(Cursor.Position.X, Cursor.Position.Y);
                var currentContractor = contractorsDGView.Rows[e.RowIndex].DataBoundItem as ContractorViewModel;

                foreach (ToolStripMenuItem item in contractorContextMenu.Items)
                {
                    item.Tag = currentContractor;
                }
            }
        }

        private async void ContractorsDGView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 && e.RowIndex < 0)
            {
                await LoadContractorsAsync();
            }
            else
            {
                if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
                    UpdateContractorsCBoxText((contractorsDGView.Rows[e.RowIndex].DataBoundItem as ContractorViewModel).Name);
            }
        }

        private async void ContractorsDGView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && contractorsDGView.SelectedRows.Count == 1)
                await BindTransactionsToDataGridViewAsync();
        }

        private async void ContractorsDGView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.T) && contractorsDGView.CurrentRow != null)
                await AddTransactionsAsync((contractorsDGView.CurrentRow.DataBoundItem as ContractorViewModel).Name);
            else if (e.KeyCode == Keys.Delete)
            {
                if (!(await RemoveSelectedContractorsAsync()))
                    e.Handled = true;
            }
        }

        #endregion

        #region TransactionsDGView EventHandlers

        private void TransactionsDGView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _previousEditableModel.Transaction = (TransactionViewModel)(transactionsDGView.Rows[e.RowIndex].DataBoundItem as ICloneable).Clone();
        }

        private async void TransactionsDGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentTransaction = transactionsDGView.Rows[e.RowIndex].DataBoundItem as TransactionViewModel;

            var isModelValid = true;
            if (!currentTransaction.Value.HasValue && !currentTransaction.Price.HasValue)
            {
                MessageBox.Show("Значение транзакции и платежа не могут быть пустыми одновременно.", "Редактирование транзакции", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isModelValid = false;
            }
            else if (!ValidateModel(currentTransaction, "Некорректно заполнены значения транзакции."))
            {
                isModelValid = false;
            }

            if (!isModelValid)
            {
                currentTransaction.Value = _previousEditableModel.Transaction.Value;
                currentTransaction.Price = _previousEditableModel.Transaction.Price;
            }

            if (!currentTransaction.Equals(_previousEditableModel.Transaction))
            {
                await _transactionService.UpdateTransactionAsync(Mapper.Map<TransactionViewModel, TransactionModel>(currentTransaction));
                CalculateTotalTransactions();
            }

            _previousEditableModel.Transaction = null;
        }

        private async void TransactionsDGView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (!(await RemoveSelectedTransactionsAsync()))
                    e.Handled = true;
            }
        }

        private void TransactionsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
           => MessageBox.Show($"Некорректно заполнены значения транзакции.\n{e.Exception.Message.ToString()}\nПример ввода: 15 или 15,34", "Ошибочный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);

        #endregion

        #region ContractorsCBox EventHandlers

        private async void ContractorsCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _contractorsCBoxValueSelected = true;

            await BindContractorsToDataGridViewAsync(contractorsCBox.Text);

            _contractorsCBoxValueSelected = false;
        }

        private async void ContractorsCBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !_contractorsCBoxValueSelected)
                await BindContractorsToDataGridViewAsync(contractorsCBox.Text);
        }

        #endregion

        #region AccountMenu EventHandlers

        private void AccountSettingsMenuItem_Click(object sender, EventArgs e)
        {
            if (DIContainer.Resolve<UpdateUserAccountForm>().ShowDialog() == DialogResult.OK)
                userAccountToolStrip.Text = Session.Person.FullName;
        }

        private void CloseMenuItem_Click(object sender, EventArgs e) => Close();

        private void SignOutMenuItem_Click(object sender, EventArgs e)
        {
            _isSignOut = true;
            Close();
        }

        #endregion

        #region ContractorToolStripMenuItems EventHandlers

        private async void AddTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
            => await AddTransactionsAsync((((ToolStripMenuItem)sender).Tag as ContractorViewModel).Name);

        private void RenameContractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedContractorId = (((ToolStripMenuItem)sender).Tag as ContractorViewModel).ID;

            var editingCell = contractorsDGView.Rows
                                               .OfType<DataGridViewRow>()
                                               .Where(x => (x.DataBoundItem as ContractorViewModel).ID == clickedContractorId)
                                               .First()
                                               .Cells[nameof(ContractorViewModel.Name)];

            contractorsDGView.CurrentCell = editingCell;
            contractorsDGView.BeginEdit(true);
        }

        private async void RemoveContractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedContractorId = (((ToolStripMenuItem)sender).Tag as ContractorViewModel).ID;
            SelectContractorById(clickedContractorId, out _);
            await RemoveSelectedContractorsAsync();
        }

        #endregion

        #region Control buttons EventHandlers

        private async void AddBtn_Click(object sender, EventArgs e)
            => await AddTransactionsAsync();

        private void CloseBtn_Click(object sender, EventArgs e) => Close();

        private async void DeleteBtn_Click(object sender, EventArgs e) => await RemoveSelectedTransactionsAsync();

        private async void ExportBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var contractors = await _contractorService.GetContractorsAsync(Session.Person.ID, includes: new[] { nameof(ContractorViewModel.Transactions).ToLower() });

                if (contractors.Count() == 0)
                {
                    MessageBox.Show("Список контрагентов пуст", "Экспорт в файл", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await _transferContractorsService.ExportContractors(contractors, saveFileDialog.FileName);

                MessageBox.Show($"Файл '{saveFileDialog.FileName}' сохранен на диск", "Экспорт в файл", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void TrashBtn_Click(object sender, EventArgs e)
        {
            var recycleBinForm = DIContainer.Resolve<RecycleBinForm>();
            recycleBinForm.ShowDialog();

            if (recycleBinForm.Tag is bool isRetrieved && isRetrieved)
                await LoadContractorsAsync();
        }

        #endregion

        private void DisposeServices()
        {
            (_contractorService as IDisposable)?.Dispose();
            (_transactionService as IDisposable)?.Dispose();
            (_recycleBinService as IDisposable)?.Dispose();
        }

        private void CenterSplitContainer_SplitterMoved(object sender, SplitterEventArgs e) => SetFormsSizes();

        private async Task AddTransactionsAsync(string contractorName = default)
        {
            var addForm = DIContainer.Resolve<AddTransactionForm>(new Parameter { Name = "defaultContractorName", Value = contractorName });
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                if (addForm.Tag is long selectedContractorId)
                {
                    SelectContractorById(selectedContractorId, out var contractor);
                    await BindTransactionsToDataGridViewAsync();
                    UpdateContractorsCBoxText(contractor?.Name ?? string.Empty);
                }
                else
                {
                    await LoadContractorsAsync();
                }
            }
        }

        private async Task LoadContractorsAsync()
        {
            var contractorNames = await BindContractorsToDataGridViewAsync(allContractorsValue);

            contractorsCBox.Items.Clear();
            contractorsCBox.Items.Add(allContractorsValue);
            contractorsCBox.Items.AddRange(contractorNames.OrderBy(_ => _).ToArray());
        }

        private async Task<bool> RemoveSelectedContractorsAsync()
        {
            if (contractorsDGView.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show($"Вы действительно хотите безвозвратно удалить {(contractorsDGView.SelectedRows.Count == 1 ? (contractorsDGView.SelectedRows[0].DataBoundItem as ContractorViewModel).Name + " и" : "выбранных контрагентов и их")} транзакции?\nДля помещения в корзину нажмите 'Нет'", "Удаление", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var ids = contractorsDGView.SelectedRows.OfType<DataGridViewRow>().Select(_ => (_.DataBoundItem as ContractorViewModel).ID).ToArray();
                    foreach (var id in ids)
                        await _contractorService.RemoveContractorAsync(id);
                }
                else if(dialogResult == DialogResult.No)
                {
                    var contractors = contractorsDGView.SelectedRows.OfType<DataGridViewRow>().Select(_ => _.DataBoundItem as ContractorViewModel).ToArray();
                    await _recycleBinService.PutContractorsAsync(Mapper.Map<IEnumerable<ContractorViewModel>, IEnumerable<ContractorModel>>(contractors));
                }
                else
                {
                    return false;
                }

                await LoadContractorsAsync();
                return true;
            }

            return false;
        }

        private async Task<bool> RemoveSelectedTransactionsAsync()
        {
            if (contractorsDGView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбран контрагент, для которого будут удаляться транзакции.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (transactionsDGView.SelectedRows.Count > 0 &&
                MessageBox.Show("Вы действительно хотите удалить выбранные транзакции?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var ids = transactionsDGView.SelectedRows.OfType<DataGridViewRow>().Select(_ => (_.DataBoundItem as TransactionViewModel).ID).ToArray();
                foreach (var id in ids)
                    await _transactionService.RemoveTransactionAsync(id);

                await BindTransactionsToDataGridViewAsync();
                return true;
            }

            return false;
        }

        private async Task<IEnumerable<string>> BindContractorsToDataGridViewAsync(string nameFilter = null)
        {
            List<ContractorViewModel> contractors;
            if (nameFilter == allContractorsValue || string.IsNullOrWhiteSpace(nameFilter))
            {
                if (contractorsCBox.Text != allContractorsValue)
                    UpdateContractorsCBoxText(allContractorsValue);

                contractors = Mapper.Map<IEnumerable<ContractorModel>, List<ContractorViewModel>>(
                    await _contractorService.GetContractorsAsync(Session.Person.ID, includes: new[] { nameof(ContractorViewModel.Transactions).ToLower() }));
                _loadedTransactions = contractors.SelectMany(_ => _.Transactions).ToList();
                transactionsDGView.DataSource = Enumerable.Empty<TransactionViewModel>();
                CalculateTotalTransactions(true);

                contractorsDGView.DataSource = new SortableBindingList<ContractorViewModel>(contractors.OrderBy(_ => _.Name).ToList());
                contractorsDGView.ClearSelection();
            }
            else
            {
                contractors = Mapper.Map<IEnumerable<ContractorModel>, List<ContractorViewModel>>(
                    await _contractorService.GetContractorsAsync(Session.Person.ID, nameFilter));
                contractorsDGView.DataSource = new SortableBindingList<ContractorViewModel>(contractors.OrderBy(_ => _.Name).ToList());

                if (contractors.Count == 1)
                {
                    var contractorId = contractors.Single().ID;
                    SelectContractorById(contractorId, out _);

                    await BindTransactionsToDataGridViewAsync();
                }
                else
                    transactionsDGView.DataSource = null;
            }

            return contractors.Select(c => c.Name);
        }

        private async Task BindTransactionsToDataGridViewAsync()
        {
            var selectedContractorID = (contractorsDGView.SelectedRows[0].DataBoundItem as ContractorViewModel).ID;
            _loadedTransactions = Mapper.Map<IEnumerable<TransactionModel>, List<TransactionViewModel>>(
                                    await _transactionService.GetTransactionsAsync(selectedContractorID, startsDTP.Value, endsDTP.Value));

            transactionsDGView.DataSource = new SortableBindingList<TransactionViewModel>(_loadedTransactions);

            CalculateTotalTransactions();
        }

        private void SelectContractorById(long id, out ContractorViewModel contractor)
        {
            contractor = default;
            contractorsDGView.ClearSelection();
            var row = contractorsDGView.Rows
                                       .OfType<DataGridViewRow>()
                                       .Where(x => (x.DataBoundItem as ContractorViewModel).ID == id)
                                       .FirstOrDefault();
            if (row != null)
            {
                contractor = row.DataBoundItem as ContractorViewModel;
                row.Selected = true;
            }
        }

        private void UpdateContractorsCBoxText(string value)
        {
            contractorsCBox.SelectedIndexChanged -= ContractorsCBox_SelectedIndexChanged;
            contractorsCBox.Text = value;
            contractorsCBox.SelectedIndexChanged += ContractorsCBox_SelectedIndexChanged;
        }

        private void CalculateTotalTransactions(bool allTransactions = default)
        {
            if (_loadedTransactions.Count > 0)
            {
                totalTransactionsPanel.Visible = true;
                if (allTransactions)
                {
                    totalSumTB.Font = new Font(totalSumTB.Font.FontFamily.Name, 9, totalSumTB.Font.Style);
                    totalSumTB.Text = $"Итого: {_loadedTransactions.Min(_ => _.Date).ToShortDateString()} - {_loadedTransactions.Max(_ => _.Date).ToShortDateString()}";
                }
                else
                {
                    totalSumTB.Font = new Font(totalSumTB.Font.FontFamily.Name, 16, totalSumTB.Font.Style);
                    totalSumTB.Text = "Итого:";
                }
                totalTransactionTB.Text = _loadedTransactions.Sum(t => t.Value)?.ToString("#,##0.##") ?? string.Empty;
                totalPriceTB.Text = _loadedTransactions.Sum(t => t.Price)?.ToString("#,##0.##") ?? string.Empty;
                totalCurencyTB.Text = _loadedTransactions.Average(t => t.Currency).ToString("#,##0.##");
            }
            else
                totalTransactionsPanel.Visible = false;
        }

        private bool ValidateModel<T>(T viewModel, string errorMessage)
        {
            var validationErrors = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(viewModel, new ValidationContext(viewModel), validationErrors, true);

            if (!isValid)
            {
                StringBuilder errors = new StringBuilder();
                validationErrors.ForEach(_ => errors.AppendLine(_.ErrorMessage));
                MessageBox.Show($"{errorMessage}\nСписок ошибок:\n{errors.ToString()}", "Ошибочный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void SetFormsSizes()
        {
            trashPanel.SetBounds(trashPanel.Location.X, trashPanel.Location.Y, contractorsDGView.Size.Width, trashPanel.Size.Height);
            contractorsCBox.SetBounds(contractorsCBox.Location.X, contractorsCBox.Location.Y, contractorsDGView.Size.Width, contractorsCBox.Size.Height);

            if (_loadedTransactions != null)
            {
                totalSumTB.SetBounds(totalSumTB.Location.X, totalSumTB.Location.Y, transactionsDGView.Columns[0].Width, totalSumTB.Height);
                totalTransactionTB.SetBounds(totalSumTB.Width, totalTransactionTB.Location.Y, transactionsDGView.Columns[1].Width, totalTransactionTB.Height);
                totalPriceTB.SetBounds(totalTransactionTB.Location.X + totalTransactionTB.Width, totalPriceTB.Location.Y, transactionsDGView.Columns[2].Width, totalPriceTB.Height);
                totalCurencyTB.SetBounds(totalPriceTB.Location.X + totalPriceTB.Width, totalCurencyTB.Location.Y, transactionsDGView.Columns[3].Width, totalCurencyTB.Height);
            }

            controlBtnsPanel.SetBounds(trashPanel.Width, controlBtnsPanel.Location.Y, bottomPanel.Width - trashPanel.Width, controlBtnsPanel.Height);
            addBtn.SetBounds(addBtn.Location.X, 10, 110, 30);
            deleteBtn.SetBounds(addBtn.Location.X + addBtn.Width + 5, 10, 100, 30);
            exportBtn.SetBounds(deleteBtn.Location.X + deleteBtn.Width + 5, 10, 125, 30);
            closeBtn.SetBounds(controlBtnsPanel.Width - 120, 10, 105, 30);

            if (contractorsDGView.DataSource != null)
            {
                var contractorIdColumn = contractorsDGView.Columns[nameof(ContractorViewModel.ContractorID)];
                contractorIdColumn.MinimumWidth = 40;
                contractorIdColumn.Width = (int)(contractorsDGView.Size.Width * 0.15);
                contractorsDGView.Columns[nameof(ContractorViewModel.Name)].Width = (int)(contractorsDGView.Size.Width * 0.85);
            }
        }
    }
}
