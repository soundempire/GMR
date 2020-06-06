using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
using GMR.Controls.ServiceClass;
using GMR.LayoutRoot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMR
{
    //TODO: Vadim add GMR icon to app header 
    public partial class MainForm : Form
    {
        private readonly IContractorService _contractorService;
        
        private readonly ITransactionService _transactionService;

        private List<TransactionModel> _loadedTransactions;

        private (ContractorModel Contractor, TransactionModel Transaction) _previousEditableModel;

        private bool _contractorsCBoxValueSelected = false;

        private bool _isSignOut;

        private const string allContractorsValue = "Все";

        public MainForm(IContractorService contractorService, ITransactionService transactionService)
        {
            InitializeComponent();

            _contractorService = contractorService;
            _transactionService = transactionService;
        }

        #region Main Form EventHandlers

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadFormDataAsync();

            userAccountToolStrip.Text = Session.Person.FullName;

            SetFormsSizes();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => CloseForm(e);

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
            _previousEditableModel.Contractor = (ContractorModel)(contractorsDGView.Rows[e.RowIndex].DataBoundItem as ICloneable).Clone();
        }

        private async void ContractorsDGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentContractor = contractorsDGView.Rows[e.RowIndex].DataBoundItem as ContractorModel;

            if (!currentContractor.Equals(_previousEditableModel.Contractor))
            {
                await _contractorService.UpdateContractorAsync(currentContractor);

                contractorsCBox.Items.Clear();
                contractorsCBox.Items.AddRange((await _contractorService.GetContractorsAsync(Session.Person.ID)).Select(c => c.Name).ToArray());
            }

            _previousEditableModel.Contractor = null;
        }

        private void ContractorsDGView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                contractorContextMenu.Show(Cursor.Position.X, Cursor.Position.Y);
                var currentContractor = contractorsDGView.Rows[e.RowIndex].DataBoundItem as ContractorModel;

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
                await LoadFormDataAsync();
            }
            else
            {
                if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
                    UpdateContractorsCBoxText((contractorsDGView.Rows[e.RowIndex].DataBoundItem as ContractorModel).Name);
            } 
        }

        private async void ContractorsDGView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //TODO: Vadim think about userfriendly header width
            if (e.Button == MouseButtons.Left)
                await BindTransactionsToDataGridViewAsync();
        }

        private async void ContractorsDGView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.T) && contractorsDGView.CurrentRow != null)
                await AddTransactionsAsync((contractorsDGView.CurrentRow.DataBoundItem as ContractorModel).Name);
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
            _previousEditableModel.Transaction = (TransactionModel)(transactionsDGView.Rows[e.RowIndex].DataBoundItem as ICloneable).Clone();
        }

        private async void TransactionsDGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentTransaction = transactionsDGView.Rows[e.RowIndex].DataBoundItem as TransactionModel;

            if (!currentTransaction.Equals(_previousEditableModel.Transaction))
                await _transactionService.UpdateTransactionAsync(currentTransaction);

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

        #endregion

        #region ContractorsCBox EventHandlers

        private async void ContractorsCBox_SelectedValueChanged(object sender, EventArgs e)
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

        private void AccountSettingsMenuItem_Click(object sender, EventArgs e) => DIContainer.Resolve<UserAccountForm>().ShowDialog();

        private void CloseMenuItem_Click(object sender, EventArgs e) => CloseForm();

        private void SignOutMenuItem_Click(object sender, EventArgs e)
        {
            _isSignOut = true;
            DialogResult = DialogResult.OK;
        }

        #endregion

        #region ContractorToolStripMenuItems EventHandlers

        private async void AddTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
            => await AddTransactionsAsync((((ToolStripMenuItem)sender).Tag as ContractorModel).Name);

        private void RenameContractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedContractorId = (((ToolStripMenuItem)sender).Tag as ContractorModel).ID;

            var editingCell = contractorsDGView.Rows
                                               .OfType<DataGridViewRow>()
                                               .Where(x => (x.DataBoundItem as ContractorModel).ID == clickedContractorId)
                                               .First()
                                               .Cells[nameof(ContractorModel.Name)];

            contractorsDGView.CurrentCell = editingCell;
            contractorsDGView.BeginEdit(true);
        }

        private async void RemoveContractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedContractorId = (((ToolStripMenuItem)sender).Tag as ContractorModel).ID;
            SelectContractorById(clickedContractorId, out _);
            await RemoveSelectedContractorsAsync();
        }

        #endregion

        #region Control buttons EventHandlers

        private async void AddBtn_Click(object sender, EventArgs e)
            => await AddTransactionsAsync();

        private void CloseBtn_Click(object sender, EventArgs e) => CloseForm();

        private async void DeleteBtn_Click(object sender, EventArgs e) => await RemoveSelectedTransactionsAsync();

        #endregion

        private async Task AddTransactionsAsync(string contractorName = default)
        {
            var addForm = DIContainer.Resolve<AddContractorForm>(new Parameter { Name = "defaultContractorName", Value = contractorName });
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
                    await LoadFormDataAsync();
                }
            }
        }

        private void CloseForm(CancelEventArgs eventArgs = null)
        {
            if (_isSignOut)
            {
                (_contractorService as IDisposable).Dispose();
                (_transactionService as IDisposable).Dispose();

                return;
            }

            //TODO: double call issue
            if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                (_contractorService as IDisposable).Dispose();
                (_transactionService as IDisposable).Dispose();

                Application.Exit();// think about it
            }
            else if (eventArgs != null)
            {
                eventArgs.Cancel = true;
            }
        }

        private async Task LoadFormDataAsync() //TODO: change name
        {
            var contractorNames = await BindContractorsToDataGridViewAsync(allContractorsValue);

            contractorsCBox.Items.Clear();
            contractorsCBox.Items.Add(allContractorsValue);
            contractorsCBox.Items.AddRange(contractorNames.ToArray());
        }

        private async Task<bool> RemoveSelectedContractorsAsync()
        {
            if (contractorsDGView.SelectedRows.Count > 0 &&
                MessageBox.Show($"Вы действительно хотите удалить {(contractorsDGView.SelectedRows.Count == 1 ? (contractorsDGView.SelectedRows[0].DataBoundItem as ContractorModel).Name + " и"  : "выбранных контрагентов и их" )} транзакции?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                var ids = contractorsDGView.SelectedRows.OfType<DataGridViewRow>().Select(_ => (_.DataBoundItem as ContractorModel).ID).ToArray();
                foreach (var id in ids)
                    await _contractorService.RemoveContractorAsync(id);

                await LoadFormDataAsync();
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
                var ids = transactionsDGView.SelectedRows.OfType<DataGridViewRow>().Select(_ => (_.DataBoundItem as TransactionModel).ID).ToArray();
                foreach (var id in ids)
                    await _transactionService.RemoveTransactionAsync(id);

                await BindTransactionsToDataGridViewAsync();
                return true;
            }

            return false;
        }

        private async Task<IEnumerable<string>> BindContractorsToDataGridViewAsync(string nameFilter = null)
        {
            List<ContractorModel> contractors;
            if (nameFilter == allContractorsValue || string.IsNullOrWhiteSpace(nameFilter))
            {
                if (contractorsCBox.Text != allContractorsValue)
                    UpdateContractorsCBoxText(allContractorsValue);

                contractors = (await _contractorService.GetContractorsAsync(Session.Person.ID, includes: new[] { nameof(ContractorModel.Transactions).ToLower() }))
                              .ToList();
                _loadedTransactions = contractors.SelectMany(_ => _.Transactions).ToList();
                transactionsDGView.DataSource = Enumerable.Empty<TransactionModel>();
                CalculateTotalTransactions(true);

                contractorsDGView.DataSource = new SortableBindingList<ContractorModel>(contractors);
                contractorsDGView.ClearSelection();
            }
            else
            {
                contractors = (await _contractorService.GetContractorsAsync(Session.Person.ID, nameFilter)).ToList();
                contractorsDGView.DataSource = new SortableBindingList<ContractorModel>(contractors);

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
            var selectedContractorID = (contractorsDGView.SelectedRows[0].DataBoundItem as ContractorModel).ID;
            var contractor = await _contractorService.GetContractorAsync(selectedContractorID);
            _loadedTransactions = contractor.Transactions
                                                .Where(tr => tr.Date.Value.Date >= startsDTP.Value.Date && tr.Date.Value.Date <= endsDTP.Value.Date).ToList();

            transactionsDGView.DataSource = new SortableBindingList<TransactionModel>(_loadedTransactions);

            CalculateTotalTransactions();
        }

        private void SelectContractorById(long id, out ContractorModel contractor)
        {
            contractor = default;
            contractorsDGView.ClearSelection();
            var row = contractorsDGView.Rows
                                       .OfType<DataGridViewRow>()
                                       .Where(x => (x.DataBoundItem as ContractorModel).ID == id)
                                       .FirstOrDefault();
            if (row != null)
            {
                contractor = row.DataBoundItem as ContractorModel;
                row.Selected = true;
            }
        }

        private void UpdateContractorsCBoxText(string value)
        {
            contractorsCBox.SelectedIndexChanged -= ContractorsCBox_SelectedValueChanged;
            contractorsCBox.Text = value;
            contractorsCBox.SelectedIndexChanged += ContractorsCBox_SelectedValueChanged;
        }

        private void CalculateTotalTransactions(bool allTransactions = default)
        {
            if (_loadedTransactions.Count > 0)
            {
                SetTotalTransactionsLineVisibility(true);
                if (allTransactions)
                {
                    totalSumTB.Font = new Font(totalSumTB.Font.FontFamily.Name, 9, totalSumTB.Font.Style);
                    totalSumTB.Text = $"Итого: {_loadedTransactions.Min(_ => _.Date).Value.ToShortDateString()} - {_loadedTransactions.Max(_ => _.Date).Value.ToShortDateString()}";
                }
                else
                {
                    totalSumTB.Font = new Font(totalSumTB.Font.FontFamily.Name, 16, totalSumTB.Font.Style);
                    totalSumTB.Text = "Итого:";
                }
                totalTransactionTB.Text = _loadedTransactions.Sum(t => t.Value).ToString();
                totalPriceTB.Text = _loadedTransactions.Sum(t => t.Price).ToString();
                totalCurencyTB.Text = _loadedTransactions.Average(t => t.Currency).ToString("0.00##");
            }
            else
                SetTotalTransactionsLineVisibility(false);
        }

        private void SetTotalTransactionsLineVisibility(bool visible)
        {
            //TODO: Vadim enable/disable panel visibility
            totalSumTB.Visible = visible;
            totalTransactionTB.Visible = visible;
            totalPriceTB.Visible = visible;
            totalCurencyTB.Visible = visible;
        }

        //TODO: Vadim investigate potential exceptions by resizing
        private void SetFormsSizes()
        {
            personPanel.SetBounds(personPanel.Location.X, personPanel.Location.Y, contractorsDGView.Size.Width, personPanel.Size.Height);
            contractorsCBox.SetBounds(contractorsCBox.Location.X, contractorsCBox.Location.Y, contractorsDGView.Size.Width, contractorsCBox.Size.Height);

            if (_loadedTransactions != null)
            {
                //total line form bounding
                totalSumTB.SetBounds(totalSumTB.Location.X, totalSumTB.Location.Y, transactionsDGView.Columns[0].Width, totalSumTB.Height);
                totalTransactionTB.SetBounds(totalSumTB.Width, totalTransactionTB.Location.Y, transactionsDGView.Columns[1].Width, totalTransactionTB.Height);
                totalPriceTB.SetBounds(totalTransactionTB.Location.X + totalTransactionTB.Width, totalPriceTB.Location.Y, transactionsDGView.Columns[2].Width, totalPriceTB.Height);
                totalCurencyTB.SetBounds(totalPriceTB.Location.X + totalPriceTB.Width, totalCurencyTB.Location.Y, transactionsDGView.Columns[3].Width, totalCurencyTB.Height);
            }

            controlBtnsPanel.SetBounds(personPanel.Width, controlBtnsPanel.Location.Y, bottomPanel.Width - personPanel.Width, controlBtnsPanel.Height);
            addBtn.SetBounds(addBtn.Location.X, 10, 110, 30);
            deleteBtn.SetBounds(addBtn.Location.X + addBtn.Width + 5, 10, 100, 30);
            printBtn.SetBounds(deleteBtn.Location.X + deleteBtn.Width + 5, 10, 95, 30);
            closeBtn.SetBounds(controlBtnsPanel.Width - 120, 10, 105, 30);

            //addBtn.Font = deleteBtn.Font = printBtn.Font = closeBtn.Font = new System.Drawing.Font("Tahoma", (float)(addBtn.Width * 0.09), FontStyle.Bold);

            if (contractorsDGView.DataSource != null)
            {
                var contractorIdColumn = contractorsDGView.Columns[nameof(ContractorModel.ContractorID)];
                contractorIdColumn.MinimumWidth = 40;
                contractorIdColumn.Width = (int)(contractorsDGView.Size.Width * 0.15);
                contractorsDGView.Columns[nameof(ContractorModel.Name)].Width = (int)(contractorsDGView.Size.Width * 0.85);
            }
        }

        private void CenterSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            //TODO: Vadim use constants
            if (e.SplitX < 300)
                CenterSplitContainer.Panel1MinSize = (int)(CenterSplitContainer.Width * 0.3);
            else if (e.SplitX>CenterSplitContainer.Width-450)
                CenterSplitContainer.Panel2MinSize = (int)(CenterSplitContainer.Width * 0.3);

            SetFormsSizes();
        }
    }
}
