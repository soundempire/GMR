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
        }


        #region Control buttons EventHandlers

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

        private void CancelBtn_Click(object sender, EventArgs e) => Close();

        #endregion

        private async Task BindImportDataToDataGridViewAsync(ICollection<ImportDataModel> importResult)
        {

            importingDataDGV.DataSource = importResult;

            SetImportDataToDataGridViewColumnsSize();
        }

        private void SetImportDataToDataGridViewColumnsSize()
        {
            var buttons = importTabPage.Controls.OfType<Control>().OrderBy(c => c.Name).ToList();

            for (int i = 0; i < importingDataDGV.Columns.Count; i++)
                importingDataDGV.Columns[i].Width = buttons[i].Width;
            tabControl.Visible = true;
        }
    }
}
