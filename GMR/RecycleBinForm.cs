using GMR.BLL;
using GMR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMR
{
    public partial class RecycleBinForm : Form
    {
        private readonly IRecycleBinService _recycleBinService;

        private readonly ITransactionService _transactionService;

        private long _selectedContractorId;

        public RecycleBinForm(IRecycleBinService recycleBinService, ITransactionService transactionService)
        {
            InitializeComponent();

            _recycleBinService = recycleBinService;
            _transactionService = transactionService;
        }

        private void RecycleBinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (_recycleBinService as IDisposable)?.Dispose();
            (_transactionService as IDisposable)?.Dispose();
        }

        private async void RecycleBinForm_Load(object sender, EventArgs e)
        {
            var deletedContractors = Mapper.Map<IEnumerable<ContractorModel>, List<DeletedContractorViewModel>>(
                                     await _recycleBinService.GetContractorsAsync(Session.Person.ID));

            contractorsDGView.DataSource = new SortableBindingList<DeletedContractorViewModel>(deletedContractors.OrderBy(_ => _.Name).ToList());
            contractorsDGView.ClearSelection();

            if (contractorsDGView.DataSource != null)
                contractorsDGView.Columns[nameof(DeletedContractorViewModel.ContractorID)].MinimumWidth = 40;

            SetFormsSizes();
        }

        private async void ContractorsDGView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 && e.RowIndex < 0)
            {
                transactionsDGView.DataSource = null;
                return;
            }

            if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
            {
                var id = (contractorsDGView.Rows[e.RowIndex].DataBoundItem as DeletedContractorViewModel).ID;
                if (id != _selectedContractorId)
                {
                    _selectedContractorId = id;
                    var transactions = Mapper.Map<IEnumerable<TransactionModel>, List<TransactionViewModel>>(
                                       await _transactionService.GetTransactionsAsync(_selectedContractorId));

                    transactionsDGView.DataSource = new SortableBindingList<TransactionViewModel>(transactions);
                    transactionsDGView.ClearSelection();
                }
            }
        }

        private async void RetrieveBtn_Click(object sender, EventArgs e)
        {

        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void RecycleBinForm_Resize(object sender, EventArgs e) => SetFormsSizes();

        private void DeletedContractorsSplitContainer_SplitterMoved(object sender, SplitterEventArgs e) => SetFormsSizes();

        private void CloseBtn_Click(object sender, EventArgs e) => Close();

        private void SetFormsSizes()
        {
            if (contractorsDGView.DataSource != null)
            {
                contractorsDGView.Columns[nameof(DeletedContractorViewModel.ContractorID)].Width = (int)(contractorsDGView.Size.Width * 0.15);
                contractorsDGView.Columns[nameof(DeletedContractorViewModel.Name)].Width = (int)(contractorsDGView.Size.Width * 0.85);
            }
        }
    }
}
