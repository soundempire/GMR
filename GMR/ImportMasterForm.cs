using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
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
    public partial class ImportMasterForm : Form
    {
        private readonly IContractorService _contractorService;

        private readonly ITransactionService _transactionService;

        private readonly IImportService _importService;
        private readonly Image _greenPlus = Properties.Resources.greenPlus;

        public ImportMasterForm(IContractorService contractorService, ITransactionService transactionService, IImportService importService)
        {
            InitializeComponent();

            _contractorService = contractorService;
            _transactionService = transactionService;
            _importService = importService;

            InitializeChooseColumnsDataGridView();
        }

        private void InitializeChooseColumnsDataGridView()
        {
            chooseColumnsDGV.Rows.Clear();

            // Set the row header style.
            DataGridViewCellStyle rowHeaderStyle = new DataGridViewCellStyle();
            rowHeaderStyle.BackColor = SystemColors.ControlLight;
            rowHeaderStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);

            chooseColumnsDGV.RowHeadersDefaultCellStyle = rowHeaderStyle;

            chooseColumnsDGV.Rows.Add("ID", "", _greenPlus, null, null, null, null, null);
            chooseColumnsDGV.Rows.Add("Контрагент", "", null, _greenPlus, null, null, null, null);
            chooseColumnsDGV.Rows.Add("Дата", "", null, null, null, null, null, null);
            chooseColumnsDGV.Rows.Add("Транзакция", "", null, null, null, null, null, null);
            chooseColumnsDGV.Rows.Add("Платеж", "", null, null, null, null, null, null);
            chooseColumnsDGV.Rows.Add("Курс", "", null, null, null, null, null, null);

            chooseColumnsDGV.Columns[0].DefaultCellStyle = rowHeaderStyle;
            chooseColumnsDGV.Update();
        }

        private void chooseColumnsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isCellChecked = chooseColumnsDGV[e.ColumnIndex, e.RowIndex].Value != null;
            bool isRowChecked = chooseColumnsDGV.Rows[e.RowIndex].Cells.OfType<DataGridViewCell>().Any(c => c.Value == _greenPlus);
            bool isColumnChecked = chooseColumnsDGV.Rows.Cast<DataGridViewRow>().Any(r => r.Cells[e.ColumnIndex].Value == _greenPlus);

            if (e.ColumnIndex != chooseColumnsDGV.Columns["idImageColumn"].Index && e.ColumnIndex != chooseColumnsDGV.Columns["contractorImageColumn"].Index)
            {
                if (isCellChecked)
                    chooseColumnsDGV[e.ColumnIndex, e.RowIndex].Value = null;
                else
                if (!isRowChecked && !isColumnChecked)
                    chooseColumnsDGV[e.ColumnIndex, e.RowIndex].Value = _greenPlus;
            }
        }

        private async void OpenFileBtn_Click(object sender, EventArgs e)
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
                    fileName = ofd.FileName;
                else
                    return;

                var importResult = (await _importService.ImportContractors(fileName));
                await BindImportDataToDataGridViewAsync(importResult.ToList());
                //DisplayImportResult(importResult);
            }
        }

        private async Task BindImportDataToDataGridViewAsync(ICollection<ImportDataModel> importResult)
        {

            importingDataDGV.DataSource = importResult;

        }

    }
}
