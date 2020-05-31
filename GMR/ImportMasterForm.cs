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
    //TODO: Vadim full screen opportunity
    //TODO: Vadim think about tab panel (not main order)
    public partial class ImportMasterForm : Form
    {
        private readonly IImportService _importService;

        private readonly IPotentialContractorsService _potentialContractorsService;

        private readonly GMRToggleSwitch[] _requiredToggles;
        private readonly GMRToggleSwitch[] _unRequiredToggles;

        public ImportMasterForm(IImportService importService, IPotentialContractorsService potentialContractorsService)
        {
            InitializeComponent();

            _importService = importService;
            _potentialContractorsService = potentialContractorsService;
            _requiredToggles = new GMRToggleSwitch[2] { dateToggleSwitch, currencyToggleSwitch };
            _unRequiredToggles = new GMRToggleSwitch[2] { transactionToggleSwitch, priceToggleSwitch };
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
            IEnumerable<ImportContractorViewModel> tableEntities;
            if (importingDataDGV.SelectedRows.Count > 0)
                tableEntities = importingDataDGV.SelectedRows.OfType<DataGridViewRow>().Select(_ => _.DataBoundItem as ImportContractorViewModel);
            else
                tableEntities = (IEnumerable<ImportContractorViewModel>)importingDataDGV.DataSource;

            var selectedContractors = Mapper.Map<IEnumerable<ImportContractorViewModel>, IEnumerable<ContractorModel>>(tableEntities).ToList();

            FilterContractorsAccordingToggles(ref selectedContractors);

            var potentialContractorsGroups = (await _potentialContractorsService.ValidateContractors(selectedContractors, Session.Person.ID))
                                             .GroupBy(_ => _.IsValid).ToDictionary(g => g.Key, g => g.Select(_ => _));

            if (potentialContractorsGroups.TryGetValue(false, out var invalidPotentialContractors))
            {
                //DisplayImportResult(importResult);
            }

            if (potentialContractorsGroups.TryGetValue(true, out var successPotentialContractors) && successPotentialContractors.Any())
            {
                //TODO: do not use bll.mapper
                Tag = new ImportResult {
                            SuccessContractors = GMR.BLL.Mapper.Map<IEnumerable<PotentialContractorModel>, IEnumerable<ContractorModel>>(successPotentialContractors),
                            OverwriteExistingNames = overwriteNamesCheckBox.Checked
                                       };
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
        //TODO: Vadim fix toggle switching behavior (second order)
        private void ToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            var toggle = (GMRToggleSwitch)sender;

            if (_requiredToggles.Contains(toggle))
            {
                foreach (var tog in _requiredToggles)
                    checkToggle(tog, toggle.Checked);

                foreach (var tog in _unRequiredToggles)
                    checkToggle(tog, toggle.Checked);
            }
            else
            {
                if (toggle.Checked)
                {
                    foreach (var tog in _requiredToggles)
                        checkToggle(tog, toggle.Checked);
                }
                else if (_unRequiredToggles.All(_ => !_.Checked))
                {
                    foreach (var tog in _requiredToggles)
                        checkToggle(tog, toggle.Checked);
                }
            }

            void checkToggle(GMRToggleSwitch tog, bool isChecked)
            {
                if (!tog.Equals(toggle))
                {
                    tog.CheckedChanged -= ToggleSwitch_CheckedChanged;
                    tog.Checked = isChecked;
                    tog.CheckedChanged += ToggleSwitch_CheckedChanged;
                }              
            }
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

        private void FilterContractorsAccordingToggles(ref List<ContractorModel> selectedContractors)
        {
            if (_unRequiredToggles.Any(_ => !_.Checked))
            {
                if (transactionToggleSwitch.Checked)
                    selectedContractors = selectedContractors.Where(_ => _.Transactions.Single().Value.HasValue).ToList();
                else if (priceToggleSwitch.Checked)
                    selectedContractors = selectedContractors.Where(_ => _.Transactions.Single().Price.HasValue).ToList();
                else
                    selectedContractors.ForEach(_ => _.Transactions.Clear());
            }
        }

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
