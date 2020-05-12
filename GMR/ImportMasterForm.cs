using GMR.Animation.Controls.ToggleSwitch;
using GMR.BLL.Abstractions.Models;
using GMR.BLL.Abstractions.Services;
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
    public partial class ImportMasterForm : Form
    {
        private readonly IImportService _importService;

        private readonly IPotentialContractorsService _potentialContractorsService;

        private readonly GMRToggleSwitch[] _transactionsToggles;

        public ImportMasterForm(IImportService importService, IPotentialContractorsService potentialContractorsService)
        {
            InitializeComponent();

            _importService = importService;
            _potentialContractorsService = potentialContractorsService;
            _transactionsToggles = new GMRToggleSwitch[3] { dateToggleSwitch, transactionToggleSwitch, priceToggleSwitch };
        }

        #region ImportMasterForm EventHandlers

        private void ImportMasterForm_FormClosing(object sender, FormClosingEventArgs e)
            => (_potentialContractorsService as IDisposable).Dispose();

        #endregion

        #region Control buttons EventHandlers

        private async void OpenFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                okBtn.Enabled = true;
                Text = $"{Text} ({openFileDialog.FileName})";

                var importedContractors = await _importService.ImportContractors(openFileDialog.FileName);
                importingDataDGV.DataSource = Mapper.Map<IEnumerable<ContractorModel>, IEnumerable<ImportContractorViewModel>>(importedContractors);

                SetImportDataToDataGridViewColumnsSize();

                numericUpDownLeft.Enabled = numericUpDownRight.Enabled = true;
                numericUpDownLeft.Maximum = numericUpDownRight.Maximum = importingDataDGV.Rows.Count;
            }
        }

        private async void OkBtn_Click(object sender, EventArgs e)
        {
            var selectedContractors = Mapper.Map<IEnumerable<ImportContractorViewModel>, IEnumerable<ContractorModel>>(importingDataDGV.DataSource as IEnumerable<ImportContractorViewModel>);

            //TODO: switch off properties by columns here

            var potentialContractorsGroups = (await _potentialContractorsService.ValidateContractors(selectedContractors, Session.Person.ID))
                                             .GroupBy(_ => _.IsValid).ToDictionary(g => g.Key, g => g.Select(_ => _));

            if (potentialContractorsGroups.TryGetValue(false, out var invalidPotentialContractors))
            {
                //DisplayImportResult(importResult);
            }

            if (potentialContractorsGroups.TryGetValue(true, out var successPotentialContractors) && successPotentialContractors.Any())
            {
                //TODO: do not use bll.mapper
                Tag = GMR.BLL.Mapper.Map<IEnumerable<PotentialContractorModel>, IEnumerable<ContractorModel>>(successPotentialContractors);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Не удалось загрузить контрагентов.", "Ошибка импорта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        #endregion

        #region Toggle EventHandlers

        private void ToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((GMRToggleSwitch)sender).Checked;

            if (_transactionsToggles.Any(_ => _.Checked) && !isChecked)
                return;

            currencyToggleSwitch.Checked = isChecked;
            currencyToggleSwitch.Enabled = !isChecked;
        }

        private void ToggleSwitch_MouseEnter(object sender, EventArgs e)
        {
            var currentToggle = ((GMRToggleSwitch)sender);
            currentToggle.Cursor = currentToggle.Enabled ? Cursors.Hand : Cursors.Default;
        }

        #endregion

        #region Numerics EventHandlers

        private void NumericUpDownLeft_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownLeft.Value > 0 && numericUpDownRight.Value == 0 ||
                numericUpDownLeft.Value == 0 ||
                numericUpDownLeft.Value > numericUpDownRight.Value)
            {
                numericUpDownRight.Value = numericUpDownLeft.Value;
            }

            SelectRows((int)numericUpDownLeft.Value, (int)numericUpDownRight.Value);
        }

        private void NumericUpDownRight_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownRight.Value > 0 && numericUpDownLeft.Value == 0)
            {
                numericUpDownLeft.Value = 1;
            }
            else if (numericUpDownRight.Value < numericUpDownLeft.Value)
            {
                numericUpDownLeft.Value = numericUpDownRight.Value;
            }

            SelectRows((int)numericUpDownLeft.Value, (int)numericUpDownRight.Value);
        }

        #endregion

        private void SelectRows(int left, int right)
        {
            importingDataDGV.ClearSelection();

            if (left > 0 && right > 0)
            {
                importingDataDGV.Rows.OfType<DataGridViewRow>()
                                     .Where(_ => _.Index >= left - 1 && _.Index <= right - 1)
                                     .ToList()
                                     .ForEach(_ => _.Selected = true);
            }
        }

        private void SetImportDataToDataGridViewColumnsSize()
        {
            var buttons = importTabPage.Controls.OfType<Control>().OrderBy(c => c.Name).ToList();

            for (int i = 0; i < importingDataDGV.Columns.Count; i++)
                importingDataDGV.Columns[i].Width = buttons[i].Width;
            tabControl.Visible = true;
        }

        private void DisplayImportResult(List<PotentialContractorModel> importResult)
        {
            var errors = new StringBuilder();

            for (var i = 0; i < importResult.Count; i++)
                if (!importResult[i].IsValid)
                    errors.AppendLine($"Строка {i + 1}: {importResult[i].Error}");

            var sb = new StringBuilder();
            sb.AppendLine($"{importResult.Count(x => x.IsValid)} из {importResult.Count} строк было импортировано удачно.");

            if (errors.Length > 0)
            {
                sb.AppendLine("Ошибки импорта: ");
                sb.Append(errors);
            }

            MessageBox.Show(sb.ToString(), "Импорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
