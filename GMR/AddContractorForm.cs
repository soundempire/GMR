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

        public long SelectedContractorId { get; set; }

        public AddContractorForm(IContractorService contractorService, ITransactionService transactionService)
        {
            InitializeComponent();

            _contractorService = contractorService;
            _transactionService = transactionService;
        }

        private async void AddContractorForm_Load(object sender, EventArgs e)
        {
            contractorCmBox.DataSource = await _contractorService.GetContractorsAsync(Session.Person.ID);
            contractorCmBox.DisplayMember = "Name";
        }

        private async void OkBtn_Click(object sender, EventArgs e)
        {
            if (contractorCmBox.SelectedItem is ContractorModel contractor)
            {
                SelectedContractorId = contractor.ID;

                TransactionModel transaction = new TransactionModel
                {
                    ContractorID = SelectedContractorId,
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
            transactionValueTBox.Enabled = isCurrencyValueEntered;
            transactionPriceTBox.Enabled = isCurrencyValueEntered;
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Книга Excel 97-2003|*.xls|" +
                                                                       "Книга Excel|*.xlsx|" +
                                                                       "CSV (разделитель - запятая)|*.csv",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                ValidateNames = true
            })

            {
                string fileName = string.Empty;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                }
                else
                    return;

                try
                {
                    var importResult = new List<ImportResultRow<ContractorModel>>();

                    importResult = _contractorService.ImportContractors(fileName);

                    DisplayImportResult(importResult);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void DisplayImportResult(List<ImportResultRow<ContractorModel>> importResult)
        {
            var errors = new StringBuilder();

            for (var i = 0; i < importResult.Count; i++)
                if (!importResult[i].IsSuccess)
                    errors.AppendLine($"Строка {i + 1}: {importResult[i].Error}");

            var sb = new StringBuilder();
            sb.AppendLine($"{importResult.Count(x => x.IsSuccess)} из {importResult.Count} строк было импортировано удачно.");

            if (errors.Length > 0)
            {
                sb.AppendLine("Ошибки импорта: ");
                sb.Append(errors);
            }

            MessageBox.Show(sb.ToString(), "Импорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
