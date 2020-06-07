using GMR;
using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
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

        private Dictionary<string, ContractorModel> _contractors;

        public AddContractorForm(IContractorService contractorService, ITransactionService transactionService, string defaultContractorName = default)
        {
            InitializeComponent();

            _defaultContractorName = defaultContractorName;
            _contractorService = contractorService;
            _transactionService = transactionService;
        }

        private async void AddContractorForm_Load(object sender, EventArgs e)
        {
            _contractors = (await _contractorService.GetContractorsAsync(Session.Person.ID, includes: new[] { nameof(ContractorModel.Transactions).ToLower() }))
                           .ToDictionary(_ => _.ContractorID);

            contractorCmBox.DataSource = _contractors.Values.ToList();
            contractorCmBox.DisplayMember = nameof(ContractorModel.Name);
            if (!string.IsNullOrEmpty(_defaultContractorName))
            {
                contractorCmBox.Text = _defaultContractorName;
            }

            SetCurrencyByDate();
        }

        private async void OkBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(transactionCurrencyTBox.Text))
            {
                MessageBox.Show($"Поле Курс должно быть заполнено.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(transactionValueTBox.Text) && string.IsNullOrWhiteSpace(transactionPriceTBox.Text))
            {
                MessageBox.Show($"Поля Транзакция или Платёж должны быть заполнены.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contractorCmBox.SelectedItem is ContractorModel contractor)
            {
                Tag = contractor.ID;

                TransactionModel transaction = new TransactionModel
                {
                    ContractorID = contractor.ID,
                    Date = transactionDateDTPicker.Value,
                    Currency = double.Parse(transactionCurrencyTBox.Text),
                    Price = string.IsNullOrWhiteSpace(transactionPriceTBox.Text) ? default(double?) : double.Parse(transactionPriceTBox.Text.Trim()),
                    Value = string.IsNullOrWhiteSpace(transactionValueTBox.Text) ? default(double?) : double.Parse(transactionValueTBox.Text.Trim())
                };

                await _transactionService.AddTransactionAsync(transaction);

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show($"Контрагент с именем '{contractorCmBox.Text}' не найден.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        private void CloseBtn_Click(object sender, EventArgs e) => Close();

        private void AddContractorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (_contractorService as IDisposable).Dispose();
            (_transactionService as IDisposable).Dispose();
        }

        private void TransactionCurrencyTBox_TextChanged(object sender, EventArgs e)
        {
            var isCurrencyValueEntered = !string.IsNullOrWhiteSpace(transactionCurrencyTBox.Text);
            transactionValueTBox.Enabled = transactionPriceTBox.Enabled = isCurrencyValueEntered;
        }

        private async void ImportBtn_Click(object sender, EventArgs e)
        {            
            var importForm = DIContainer.Resolve<ImportMasterForm>();
            if (importForm.ShowDialog() == DialogResult.OK)
            {
                var importResult = (ImportResult)importForm.Tag;
                foreach (var contractor in importResult.SuccessContractors)
                {
                    if (contractor.ID > 0)
                    {
                        foreach (var transaction in contractor.Transactions)
                        {
                            transaction.ContractorID = contractor.ID;
                            await _transactionService.AddTransactionAsync(transaction);
                        }
                    }
                    else
                    {
                        if (importResult.OverwriteExistingNames && _contractors.TryGetValue(contractor.ContractorID, out var currentContractor))
                        {
                            currentContractor.Name = contractor.Name;
                            await _contractorService.UpdateContractorAsync(currentContractor);
                            foreach (var transaction in contractor.Transactions)
                            {
                                transaction.ContractorID = currentContractor.ID;
                                await _transactionService.AddTransactionAsync(transaction);
                            }
                        }
                        else
                            await _contractorService.AddContractorAsync(contractor);
                    }
                    
                }

                DialogResult = DialogResult.OK;
            }  
        }

        private void TransactionDateDTPicker_ValueChanged(object sender, EventArgs e) => SetCurrencyByDate();

        private void SetCurrencyByDate()
        {
            var transaction = _contractors.Values.SelectMany(contractor => contractor.Transactions, (c, t) => new { Transaction = t })
                                                 .Where(_ => _.Transaction.Date.HasValue && _.Transaction.Date.Value.Date.Equals(transactionDateDTPicker.Value.Date))
                                                 .Select(_ => _.Transaction)
                                                 .FirstOrDefault();

            if (transaction != null)
            {
                transactionCurrencyTBox.Text = transaction.Currency.ToString();
                transactionCurrencyTBox.Enabled = false;
            }
            else
            {
                transactionCurrencyTBox.Clear();
                transactionCurrencyTBox.Enabled = true;
            }
        }
    }
}
