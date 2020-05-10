using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
using GMR.LayoutRoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMR
{
    public partial class AddContractorForm : Form
    {
        private readonly IContractorService _contractorService;

        private readonly ITransactionService _transactionService;

        private readonly string _defaultContractorName;

        public AddContractorForm(IContractorService contractorService, ITransactionService transactionService, string defaultContractorName = default)
        {
            InitializeComponent();

            _defaultContractorName = defaultContractorName;
            _contractorService = contractorService;
            _transactionService = transactionService;
        }

        private async void AddContractorForm_Load(object sender, EventArgs e)
        {
            contractorCmBox.DataSource = await _contractorService.GetContractorsAsync(Session.Person.ID);
            contractorCmBox.DisplayMember = nameof(ContractorModel.Name);
            if (!string.IsNullOrEmpty(_defaultContractorName))
            {
                contractorCmBox.Text = _defaultContractorName;
            }
        }

        private async void OkBtn_Click(object sender, EventArgs e)
        {
            if (contractorCmBox.SelectedItem is ContractorModel contractor)
            {
                Tag = contractor.ID;

                TransactionModel transaction = new TransactionModel
                {
                    ContractorID = contractor.ID,
                    Date = transactionDateDTPicker.Value,
                    Currency = double.Parse(transactionCurrencyTBox.Text),
                    Price = double.Parse(transactionPriceTBox.Text),
                    Value = double.Parse(transactionValueTBox.Text)
                };

                await _transactionService.AddTransactionAsync(transaction);

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show($"Контрагент с именем '{contractorCmBox.Text}' не найден.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        private void CloseBtn_Click(object sender, EventArgs e) => Close();

        private void AddContractorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (_contractorService as IDisposable).Dispose();
            (_transactionService as IDisposable).Dispose();
        }

        private void transactionCurrencyTBox_TextChanged(object sender, EventArgs e)
        {
            var isCurrencyValueEntered = !string.IsNullOrWhiteSpace(transactionCurrencyTBox.Text);
            okBtn.Enabled = transactionValueTBox.Enabled = transactionPriceTBox.Enabled = isCurrencyValueEntered;
        }

        private async void ImportBtn_Click(object sender, EventArgs e)
        {            
            var importForm = DIContainer.Resolve<ImportMasterForm>();
            if (importForm.ShowDialog() == DialogResult.OK)
            {
                var successImportedContractors = (IEnumerable<ContractorModel>)importForm.Tag;
                foreach (var contractor in successImportedContractors)
                {
                    await _contractorService.AddContractorAsync(contractor);
                }

                DialogResult = DialogResult.OK;
            }  
        }
    }
}
