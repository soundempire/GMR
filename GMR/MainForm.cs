using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
using GMR.Controls.ServiceClass;
using GMR.LayoutRoot;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMR
{
    public partial class MainForm : Form
    {
        private readonly IContractorService _contractorService;

        private readonly ITransactionService _transactionService;

        private List<TransactionModel> _selectedContractorTransactions;

        private (ContractorModel Contractor, TransactionModel Transaction) _previousEditableModel;

        private bool _contractorsCBoxValueSelected = false;

        public MainForm(IContractorService contractorService, ITransactionService transactionService)
        {
            InitializeComponent();

            _contractorService = contractorService;
            _transactionService = transactionService;
        }

        #region Main Form EventHandlers

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var contractorNames = await BindContractorsToDataGridViewAsync();

            contractorsCBox.Items.Clear();
            contractorsCBox.Items.AddRange(contractorNames.ToArray());

            personNameLabel.Text = Session.Person.FullName;
            SetFormsSizes();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => CloseForm();

        private void MainForm_Resize(object sender, EventArgs e) => SetFormsSizes();

        #endregion

        #region DateTimePickers EventHandlers

        private async void DtpStarts_ValueChanged(object sender, EventArgs e)
        {
            if (contractorsDGView.SelectedRows.Count > 0)
                await BindTransactionsToDataGridViewAsync();
        }

        private async void DtpEnds_ValueChanged(object sender, System.EventArgs e)
        {
            if (contractorsDGView.SelectedRows.Count > 0)
                await BindTransactionsToDataGridViewAsync();
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

        private async void ContractorsDGView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) => await BindTransactionsToDataGridViewAsync();


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
                await RemoveSelectedTransactionsAsync();
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

        #region PersonNameLabel EventHandlers

        private void PersonNameLabel_DoubleClick(object sender, EventArgs e) => DIContainer.Resolve<UserAccountForm>().ShowDialog();

        private void PersonNameLabel_MouseEnter(object sender, EventArgs e) => personNameLabel.ForeColor = Color.ForestGreen;

        private void PersonNameLabel_MouseLeave(object sender, EventArgs e) => personNameLabel.ForeColor = SystemColors.ControlText;

        #endregion

        #region Control buttons EventHandlers

        private async void AddBtn_Click(object sender, System.EventArgs e)
        {
            var addForm = DIContainer.Resolve<AddContractorForm>();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                if (contractorsDGView.SelectedRows.Count == 0)
                {
                    contractorsDGView.ClearSelection();
                    contractorsDGView.Rows
                                     .OfType<DataGridViewRow>()
                                     .Where(x => (x.DataBoundItem as ContractorModel).ID == addForm.SelectedContractorId)
                                     .ToArray<DataGridViewRow>()[0]
                                     .Selected = true;
                }

                await BindTransactionsToDataGridViewAsync();
            }
        }

        private void CloseBtn_Click(object sender, System.EventArgs e) => CloseForm();

        private async void DeleteBtn_Click(object sender, EventArgs e) => await RemoveSelectedTransactionsAsync();

        #endregion

        private void CloseForm()
        {
            (_contractorService as IDisposable).Dispose();
            (_transactionService as IDisposable).Dispose();

            Application.Exit();
        }

        private async Task RemoveSelectedTransactionsAsync()
        {
            if (transactionsDGView.SelectedRows.Count > 0 &&
                MessageBox.Show("Вы действительно хотите удалить выбранные транзакции?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in transactionsDGView.SelectedRows)
                    await _transactionService.RemoveTransactionAsync((row.DataBoundItem as TransactionModel).ID);

                await BindTransactionsToDataGridViewAsync();
            }
        }

        private async Task<IEnumerable<string>> BindContractorsToDataGridViewAsync(string nameFilter = null)
        {
            var contractors = await _contractorService.GetContractorsAsync(Session.Person.ID, nameFilter);
            contractorsDGView.DataSource = contractors;

            transactionsDGView.DataSource = null;

            return contractors.Select(c => c.Name);
        }

        private async Task BindTransactionsToDataGridViewAsync()
        {
            var selectedContractorID = (contractorsDGView.SelectedRows[0].DataBoundItem as ContractorModel).ID;
            var contractor = await _contractorService.GetContractorAsync(selectedContractorID);
            _selectedContractorTransactions = contractor.Transactions
                                                .Where(tr => tr.Date.Value.Date >= startsDTP.Value.Date && tr.Date.Value.Date <= endsDTP.Value.Date).ToList();

            transactionsDGView.DataSource = _selectedContractorTransactions;

            CalculateTotalTransactions();
        }

        private void CalculateTotalTransactions()
        {
            if (_selectedContractorTransactions.Count > 0)
            {
                SetTotalTransactionsLineVisibility(true);

                totalTransactionTB.Text = _selectedContractorTransactions.Sum(t => t.Value).ToString();
                totalPriceTB.Text = _selectedContractorTransactions.Sum(t => t.Price).ToString();
                totalCurencyTB.Text = $"{((_selectedContractorTransactions.Sum(t => t.Currency) / _selectedContractorTransactions.Count)):#.##}";
            }
            else
                SetTotalTransactionsLineVisibility(false);
        }

        private void SetTotalTransactionsLineVisibility(bool visible)
        {
            totalSumTB.Visible = visible;
            totalTransactionTB.Visible = visible;
            totalPriceTB.Visible = visible;
            totalCurencyTB.Visible = visible;
        }

        private void SetFormsSizes()
        {
            personPanel.SetBounds(personPanel.Location.X, personPanel.Location.Y, contractorsDGView.Size.Width, personPanel.Size.Height);
            contractorsCBox.SetBounds(contractorsCBox.Location.X, contractorsCBox.Location.Y, contractorsDGView.Size.Width, contractorsCBox.Size.Height);

            if (_selectedContractorTransactions != null)
            {
                //total line form bounding
                totalSumTB.SetBounds(totalSumTB.Location.X, totalSumTB.Location.Y, transactionsDGView.Columns[0].Width, totalSumTB.Height);
                totalTransactionTB.SetBounds(totalSumTB.Width, totalTransactionTB.Location.Y, transactionsDGView.Columns[1].Width, totalTransactionTB.Height);
                totalPriceTB.SetBounds(totalTransactionTB.Location.X + totalTransactionTB.Width, totalPriceTB.Location.Y, transactionsDGView.Columns[2].Width, totalPriceTB.Height);
                totalCurencyTB.SetBounds(totalPriceTB.Location.X + totalPriceTB.Width, totalCurencyTB.Location.Y, transactionsDGView.Columns[3].Width, totalCurencyTB.Height);

            }

            controlBtnsPanel.SetBounds(transactionsDGView.Location.X, controlBtnsPanel.Location.Y, transactionsDGView.Width, controlBtnsPanel.Height);
            addBtn.SetBounds(addBtn.Location.X, 10, (int)(controlBtnsPanel.Width * 0.175), (int)(controlBtnsPanel.Height * 0.58));
            deleteBtn.SetBounds(addBtn.Location.X + addBtn.Width + 5, 10, (int)(controlBtnsPanel.Width * 0.157), (int)(controlBtnsPanel.Height * 0.58));
            printBtn.SetBounds(deleteBtn.Location.X + deleteBtn.Width + 5, 10, (int)(controlBtnsPanel.Width * 0.139), (int)(controlBtnsPanel.Height * 0.58));
            closeBtn.SetBounds(printBtn.Location.X + printBtn.Width + (int)(controlBtnsPanel.Width * 0.32), 10, (int)(controlBtnsPanel.Width * 0.163), (int)(controlBtnsPanel.Height * 0.58));
            
            addBtn.Font = deleteBtn.Font = printBtn.Font = closeBtn.Font = new System.Drawing.Font("Tahoma", (float)(addBtn.Width * 0.09), FontStyle.Bold);

            if (contractorsDGView.DataSource != null)
            {
                contractorsDGView.Columns[nameof(ContractorModel.ContractorID)].Width = (int)(contractorsDGView.Size.Width * 0.15);
                contractorsDGView.Columns[nameof(ContractorModel.Name)].Width = (int)(contractorsDGView.Size.Width * 0.85);
            }

            //controlBtnsPanel.SetBounds(transactionsDGView.Location.X, controlBtnsPanel.Location.Y, controlBtnsPanel.Size.Width, controlBtnsPanel.Size.Height);
        }

        private void CenterSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SetFormsSizes();
        }
    }
}
