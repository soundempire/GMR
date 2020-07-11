using GMR.Animation.Controls.ToggleSwitch;
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
    public partial class ImportMasterForm : Form
    {
        private readonly ITransferContractorsService _transferContractorsService;

        private readonly IPotentialContractorsService _potentialContractorsService;

        private readonly GMRToggleSwitch[] _requiredToggles;

        private readonly GMRToggleSwitch[] _unRequiredToggles;

        public ImportMasterForm(ITransferContractorsService transferContractorsService, IPotentialContractorsService potentialContractorsService)
        {
            InitializeComponent();

            _transferContractorsService = transferContractorsService;
            _potentialContractorsService = potentialContractorsService;
            _requiredToggles = new GMRToggleSwitch[2] { dateToggleSwitch, currencyToggleSwitch };
            _unRequiredToggles = new GMRToggleSwitch[2] { transactionToggleSwitch, priceToggleSwitch };
        }

        #region ImportMasterForm EventHandlers
        
        private void ImportMasterForm_FormClosing(object sender, FormClosingEventArgs e)
            => (_potentialContractorsService as IDisposable).Dispose();

        private void ImportingDataDGV_Resize(object sender, EventArgs e) => FitFormSize();

        #endregion

        #region Control buttons EventHandlers

        private async void OpenFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                okBtn.Enabled = true;
                Text = $"{Text} ({openFileDialog.FileName})";

                var importedContractors = await _transferContractorsService.ImportContractors(openFileDialog.FileName);
                importingDataDGV.DataSource = Mapper.Map<IEnumerable<ContractorModel>, IEnumerable<ImportContractorViewModel>>(importedContractors);

                SetImportDataToDataGridViewColumnsSize();

                numericUpDownLeft.Enabled = numericUpDownRight.Enabled = true;
                numericUpDownLeft.Maximum = numericUpDownRight.Maximum = importingDataDGV.Rows.Count;
            }
            FitFormSize();
        }

        private async void OkBtn_Click(object sender, EventArgs e)
        {
            IEnumerable<ImportContractorViewModel> tableEntities;
            if (importingDataDGV.SelectedRows.Count > 0)
                tableEntities = importingDataDGV.SelectedRows.OfType<DataGridViewRow>().Select(_ => _.DataBoundItem as ImportContractorViewModel);
            else
                tableEntities = (IEnumerable<ImportContractorViewModel>)importingDataDGV.DataSource;

            var selectedContractors = Mapper.Map<IEnumerable<ImportContractorViewModel>, List<ContractorModel>>(tableEntities);

            FilterContractorsAccordingToggles(ref selectedContractors);

            var potentialContractorsGroups = (await _potentialContractorsService.ValidateContractors(selectedContractors, Session.Person.ID))
                                             .GroupBy(_ => _.IsValid).ToDictionary(g => g.Key, g => g.ToList());

            if (potentialContractorsGroups.TryGetValue(false, out var invalidPotentialContractors))
            {
                DisplayPotentialContractorsErrors(invalidPotentialContractors.ToArray());
                return;
            }

            if (potentialContractorsGroups.TryGetValue(true, out var successPotentialContractors) && successPotentialContractors.Any())
            {
                Tag = new ImportResult {
                            SuccessContractors = Mapper.Map<IEnumerable<PotentialContractorModel>, IEnumerable<ContractorViewModel>>(successPotentialContractors).ToArray(),
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
        //TODO: Vadim fix toggle switching behavior (first order)
        //TODO: Vadim aspose

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
                    tog.ForceCheckedChanged = false;
                    tog.Checked = isChecked;
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
                    selectedContractors = selectedContractors.Where(_ => _.Transactions[0].Value.HasValue).ToList();
                else if (priceToggleSwitch.Checked)
                    selectedContractors = selectedContractors.Where(_ => _.Transactions[0].Price.HasValue).ToList();
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
        
        private void DisplayPotentialContractorsErrors(PotentialContractorModel[] contractors)
        {
            var errors = new StringBuilder();
            for (var i = 0; i < contractors.Length; i++)
                if (!contractors[i].IsValid)
                    errors.AppendLine($"{contractors[i].ContractorID} {contractors[i].Name}: {contractors[i].Error}");

            if (errors.Length > 0)
                MessageBox.Show(errors.ToString(), "Ошибка импорта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FitFormSize()
        {
            if (importingDataDGV.DataSource != null)
            {
                choosePanel1.SetBounds(choosePanel1.Location.X, choosePanel1.Location.Y, importingDataDGV.Columns[nameof(ImportContractorViewModel.ID)].Width, choosePanel1.Size.Height);
                choosePanel2.SetBounds(choosePanel1.Location.X + choosePanel1.Size.Width, choosePanel2.Location.Y, importingDataDGV.Columns[nameof(ImportContractorViewModel.Name)].Width, choosePanel2.Size.Height);
                choosePanel3.SetBounds(choosePanel2.Location.X + choosePanel2.Size.Width, choosePanel3.Location.Y, importingDataDGV.Columns[nameof(ImportContractorViewModel.ContractorID)].Width, choosePanel3.Size.Height);
                choosePanel4.SetBounds(choosePanel3.Location.X + choosePanel3.Size.Width, choosePanel4.Location.Y, importingDataDGV.Columns[nameof(ImportContractorViewModel.Date)].Width, choosePanel4.Size.Height);
                choosePanel5.SetBounds(choosePanel4.Location.X + choosePanel4.Size.Width, choosePanel5.Location.Y, importingDataDGV.Columns[nameof(ImportContractorViewModel.Value)].Width, choosePanel5.Size.Height);
                choosePanel7.SetBounds(chooseColumnsPanel.Width - importingDataDGV.Columns[nameof(ImportContractorViewModel.Currency)].Width, choosePanel7.Location.Y, importingDataDGV.Columns[nameof(ImportContractorViewModel.Price)].Width, choosePanel7.Size.Height);
                choosePanel6.SetBounds(chooseColumnsPanel.Width - importingDataDGV.Columns[nameof(ImportContractorViewModel.Currency)].Width - importingDataDGV.Columns[nameof(ImportContractorViewModel.Price)].Width, choosePanel6.Location.Y, importingDataDGV.Columns[nameof(ImportContractorViewModel.Price)].Width, choosePanel6.Size.Height);
            }
        }
    }
}
