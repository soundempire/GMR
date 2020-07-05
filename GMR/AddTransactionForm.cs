using GMR;
using GMR.BLL;
using GMR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMR
{
    public partial class AddTransactionForm : Form
    {
        private readonly IContractorService _contractorService;

        private readonly ITransactionService _transactionService;

        private readonly string _defaultContractorName;

        private Dictionary<string, ContractorViewModel> _contractors;

        public AddTransactionForm(IContractorService contractorService, ITransactionService transactionService, string defaultContractorName = default)
        {
            InitializeComponent();

            _defaultContractorName = defaultContractorName;
            _contractorService = contractorService;
            _transactionService = transactionService;
        }
        
        private async void AddContractorForm_Load(object sender, EventArgs e)
        {
            _contractors = Mapper.Map<IEnumerable<ContractorModel>, IEnumerable<ContractorViewModel>>(
                            await _contractorService.GetContractorsAsync(Session.Person.ID, includes: new[] { nameof(ContractorViewModel.Transactions).ToLower() }))
                           .ToDictionary(_ => _.ContractorID);

            contractorCmBox.DataSource = _contractors.Values.ToList();
            contractorCmBox.DisplayMember = nameof(ContractorViewModel.Name);
            if (!string.IsNullOrEmpty(_defaultContractorName))
                contractorCmBox.Text = _defaultContractorName;

            SetCurrencyByDate();
        }
        
        private async void OkBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(transactionCurrencyTBox.Text))
            {
                MessageBox.Show("Поле Курс должно быть заполнено.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(transactionValueTBox.Text) && string.IsNullOrWhiteSpace(transactionPriceTBox.Text))
            {
                MessageBox.Show("Поля Транзакция или Платёж должны быть заполнены.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contractorCmBox.SelectedItem is ContractorViewModel contractor)
            {
                Tag = contractor.ID;

                TransactionViewModel transaction = new TransactionViewModel
                {
                    ContractorID = contractor.ID,
                    Date = transactionDateDTPicker.Value,
                    Currency = double.Parse(transactionCurrencyTBox.Text),
                    Price = string.IsNullOrWhiteSpace(transactionPriceTBox.Text) ? default(double?) : double.Parse(transactionPriceTBox.Text.Trim()),
                    Value = string.IsNullOrWhiteSpace(transactionValueTBox.Text) ? default(double?) : double.Parse(transactionValueTBox.Text.Trim())
                };

                if (!ValidateModel(transaction, "Некорректно заполнены значения транзакции."))
                    return;

                await _transactionService.AddTransactionAsync(Mapper.Map<TransactionViewModel, TransactionModel>(transaction));

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
                foreach (var contractor in Mapper.Map<ContractorViewModel[], ContractorModel[]>(importResult.SuccessContractors))
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
                            await _contractorService.UpdateContractorAsync(Mapper.Map<ContractorViewModel, ContractorModel>(currentContractor));
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
            var transaction = _contractors.Values.SelectMany(contractor => contractor.Transactions, (c, t) => t )
                                                 .Where(_ => _.Date.Date.Equals(transactionDateDTPicker.Value.Date))
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
    }
}
