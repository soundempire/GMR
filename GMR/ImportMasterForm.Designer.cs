namespace GMR
{
    partial class ImportMasterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportMasterForm));
            this.chooseColumnsPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.importTabPage = new System.Windows.Forms.TabPage();
            this.choosePanel6 = new System.Windows.Forms.Panel();
            this.priceToggleSwitch = new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch();
            this.choosePanel5 = new System.Windows.Forms.Panel();
            this.transactionToggleSwitch = new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch();
            this.choosePanel4 = new System.Windows.Forms.Panel();
            this.dateToggleSwitch = new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch();
            this.choosePanel3 = new System.Windows.Forms.Panel();
            this.idToggleSwitch = new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch();
            this.choosePanel2 = new System.Windows.Forms.Panel();
            this.contractorToggleSwitch = new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch();
            this.choosePanel7 = new System.Windows.Forms.Panel();
            this.currencyToggleSwitch = new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch();
            this.choosePanel1 = new System.Windows.Forms.Panel();
            this.importingDataPanel = new System.Windows.Forms.Panel();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.overwriteNamesCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileBtn = new GMR.Controls.GMRButton();
            this.numericUpDownRight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new GMR.Controls.GMRButton();
            this.okBtn = new GMR.Controls.GMRButton();
            this.importingDataDGV = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseColumnsPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.importTabPage.SuspendLayout();
            this.choosePanel6.SuspendLayout();
            this.choosePanel5.SuspendLayout();
            this.choosePanel4.SuspendLayout();
            this.choosePanel3.SuspendLayout();
            this.choosePanel2.SuspendLayout();
            this.choosePanel7.SuspendLayout();
            this.importingDataPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importingDataDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseColumnsPanel
            // 
            this.chooseColumnsPanel.Controls.Add(this.tabControl);
            this.chooseColumnsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chooseColumnsPanel.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseColumnsPanel.Location = new System.Drawing.Point(0, 0);
            this.chooseColumnsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.chooseColumnsPanel.Name = "chooseColumnsPanel";
            this.chooseColumnsPanel.Size = new System.Drawing.Size(884, 54);
            this.chooseColumnsPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.importTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.HotTrack = true;
            this.tabControl.ItemSize = new System.Drawing.Size(140, 20);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 54);
            this.tabControl.TabIndex = 0;
            this.tabControl.Visible = false;
            // 
            // importTabPage
            // 
            this.importTabPage.BackColor = System.Drawing.Color.Transparent;
            this.importTabPage.Controls.Add(this.choosePanel6);
            this.importTabPage.Controls.Add(this.choosePanel5);
            this.importTabPage.Controls.Add(this.choosePanel4);
            this.importTabPage.Controls.Add(this.choosePanel3);
            this.importTabPage.Controls.Add(this.choosePanel2);
            this.importTabPage.Controls.Add(this.choosePanel7);
            this.importTabPage.Controls.Add(this.choosePanel1);
            this.importTabPage.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importTabPage.Location = new System.Drawing.Point(4, 24);
            this.importTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.importTabPage.Name = "importTabPage";
            this.importTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.importTabPage.Size = new System.Drawing.Size(876, 26);
            this.importTabPage.TabIndex = 0;
            this.importTabPage.Text = "Импорт данных";
            // 
            // choosePanel6
            // 
            this.choosePanel6.Controls.Add(this.priceToggleSwitch);
            this.choosePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choosePanel6.Location = new System.Drawing.Point(611, 2);
            this.choosePanel6.Margin = new System.Windows.Forms.Padding(2);
            this.choosePanel6.Name = "choosePanel6";
            this.choosePanel6.Size = new System.Drawing.Size(140, 22);
            this.choosePanel6.TabIndex = 5;
            // 
            // priceToggleSwitch
            // 
            this.priceToggleSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceToggleSwitch.ForceCheckedChanged = true;
            this.priceToggleSwitch.GrayWhenDisabled = false;
            this.priceToggleSwitch.Location = new System.Drawing.Point(0, 0);
            this.priceToggleSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.priceToggleSwitch.Name = "priceToggleSwitch";
            this.priceToggleSwitch.OffFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.priceToggleSwitch.OffText = "OFF";
            this.priceToggleSwitch.OnFont = new System.Drawing.Font("Tahoma", 9F);
            this.priceToggleSwitch.OnText = "ON";
            this.priceToggleSwitch.Size = new System.Drawing.Size(140, 22);
            this.priceToggleSwitch.Style = GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.ToggleSwitchStyle.Carbon;
            this.priceToggleSwitch.TabIndex = 3;
            this.priceToggleSwitch.CheckedChanged += new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.CheckedChangedDelegate(this.ToggleSwitch_CheckedChanged);
            this.priceToggleSwitch.MouseEnter += new System.EventHandler(this.ToggleSwitch_MouseEnter);
            // 
            // choosePanel5
            // 
            this.choosePanel5.Controls.Add(this.transactionToggleSwitch);
            this.choosePanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.choosePanel5.Location = new System.Drawing.Point(488, 2);
            this.choosePanel5.Margin = new System.Windows.Forms.Padding(2);
            this.choosePanel5.Name = "choosePanel5";
            this.choosePanel5.Size = new System.Drawing.Size(123, 22);
            this.choosePanel5.TabIndex = 4;
            // 
            // transactionToggleSwitch
            // 
            this.transactionToggleSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionToggleSwitch.ForceCheckedChanged = true;
            this.transactionToggleSwitch.GrayWhenDisabled = false;
            this.transactionToggleSwitch.Location = new System.Drawing.Point(0, 0);
            this.transactionToggleSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.transactionToggleSwitch.Name = "transactionToggleSwitch";
            this.transactionToggleSwitch.OffFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.transactionToggleSwitch.OffText = "OFF";
            this.transactionToggleSwitch.OnFont = new System.Drawing.Font("Tahoma", 9F);
            this.transactionToggleSwitch.OnText = "ON";
            this.transactionToggleSwitch.Size = new System.Drawing.Size(123, 22);
            this.transactionToggleSwitch.Style = GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.ToggleSwitchStyle.Carbon;
            this.transactionToggleSwitch.TabIndex = 2;
            this.transactionToggleSwitch.CheckedChanged += new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.CheckedChangedDelegate(this.ToggleSwitch_CheckedChanged);
            this.transactionToggleSwitch.MouseEnter += new System.EventHandler(this.ToggleSwitch_MouseEnter);
            // 
            // choosePanel4
            // 
            this.choosePanel4.Controls.Add(this.dateToggleSwitch);
            this.choosePanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.choosePanel4.Location = new System.Drawing.Point(365, 2);
            this.choosePanel4.Margin = new System.Windows.Forms.Padding(2);
            this.choosePanel4.Name = "choosePanel4";
            this.choosePanel4.Size = new System.Drawing.Size(123, 22);
            this.choosePanel4.TabIndex = 4;
            // 
            // dateToggleSwitch
            // 
            this.dateToggleSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateToggleSwitch.ForceCheckedChanged = true;
            this.dateToggleSwitch.GrayWhenDisabled = false;
            this.dateToggleSwitch.Location = new System.Drawing.Point(0, 0);
            this.dateToggleSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.dateToggleSwitch.Name = "dateToggleSwitch";
            this.dateToggleSwitch.OffFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dateToggleSwitch.OffText = "OFF";
            this.dateToggleSwitch.OnFont = new System.Drawing.Font("Tahoma", 9F);
            this.dateToggleSwitch.OnText = "ON";
            this.dateToggleSwitch.Size = new System.Drawing.Size(123, 22);
            this.dateToggleSwitch.Style = GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.ToggleSwitchStyle.Carbon;
            this.dateToggleSwitch.TabIndex = 1;
            this.dateToggleSwitch.CheckedChanged += new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.CheckedChangedDelegate(this.ToggleSwitch_CheckedChanged);
            this.dateToggleSwitch.MouseEnter += new System.EventHandler(this.ToggleSwitch_MouseEnter);
            // 
            // choosePanel3
            // 
            this.choosePanel3.Controls.Add(this.idToggleSwitch);
            this.choosePanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.choosePanel3.Location = new System.Drawing.Point(242, 2);
            this.choosePanel3.Margin = new System.Windows.Forms.Padding(2);
            this.choosePanel3.Name = "choosePanel3";
            this.choosePanel3.Size = new System.Drawing.Size(123, 22);
            this.choosePanel3.TabIndex = 3;
            // 
            // idToggleSwitch
            // 
            this.idToggleSwitch.Checked = true;
            this.idToggleSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idToggleSwitch.Enabled = false;
            this.idToggleSwitch.ForceCheckedChanged = true;
            this.idToggleSwitch.GrayWhenDisabled = false;
            this.idToggleSwitch.Location = new System.Drawing.Point(0, 0);
            this.idToggleSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.idToggleSwitch.Name = "idToggleSwitch";
            this.idToggleSwitch.OffFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.idToggleSwitch.OffText = "OFF";
            this.idToggleSwitch.OnFont = new System.Drawing.Font("Tahoma", 9F);
            this.idToggleSwitch.OnText = "ON";
            this.idToggleSwitch.Size = new System.Drawing.Size(123, 22);
            this.idToggleSwitch.Style = GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.ToggleSwitchStyle.Carbon;
            this.idToggleSwitch.TabIndex = 1;
            this.idToggleSwitch.MouseEnter += new System.EventHandler(this.ToggleSwitch_MouseEnter);
            // 
            // choosePanel2
            // 
            this.choosePanel2.Controls.Add(this.contractorToggleSwitch);
            this.choosePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.choosePanel2.Location = new System.Drawing.Point(42, 2);
            this.choosePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.choosePanel2.Name = "choosePanel2";
            this.choosePanel2.Size = new System.Drawing.Size(200, 22);
            this.choosePanel2.TabIndex = 2;
            // 
            // contractorToggleSwitch
            // 
            this.contractorToggleSwitch.Checked = true;
            this.contractorToggleSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractorToggleSwitch.Enabled = false;
            this.contractorToggleSwitch.ForceCheckedChanged = true;
            this.contractorToggleSwitch.GrayWhenDisabled = false;
            this.contractorToggleSwitch.Location = new System.Drawing.Point(0, 0);
            this.contractorToggleSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.contractorToggleSwitch.Name = "contractorToggleSwitch";
            this.contractorToggleSwitch.OffFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractorToggleSwitch.OffText = "OFF";
            this.contractorToggleSwitch.OnFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractorToggleSwitch.OnText = "ON";
            this.contractorToggleSwitch.Size = new System.Drawing.Size(200, 22);
            this.contractorToggleSwitch.Style = GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.ToggleSwitchStyle.Carbon;
            this.contractorToggleSwitch.TabIndex = 0;
            this.contractorToggleSwitch.MouseEnter += new System.EventHandler(this.ToggleSwitch_MouseEnter);
            // 
            // choosePanel7
            // 
            this.choosePanel7.Controls.Add(this.currencyToggleSwitch);
            this.choosePanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.choosePanel7.Location = new System.Drawing.Point(751, 2);
            this.choosePanel7.Margin = new System.Windows.Forms.Padding(2);
            this.choosePanel7.Name = "choosePanel7";
            this.choosePanel7.Size = new System.Drawing.Size(123, 22);
            this.choosePanel7.TabIndex = 1;
            // 
            // currencyToggleSwitch
            // 
            this.currencyToggleSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currencyToggleSwitch.ForceCheckedChanged = true;
            this.currencyToggleSwitch.GrayWhenDisabled = false;
            this.currencyToggleSwitch.Location = new System.Drawing.Point(0, 0);
            this.currencyToggleSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.currencyToggleSwitch.Name = "currencyToggleSwitch";
            this.currencyToggleSwitch.OffFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.currencyToggleSwitch.OffText = "OFF";
            this.currencyToggleSwitch.OnFont = new System.Drawing.Font("Tahoma", 9F);
            this.currencyToggleSwitch.OnText = "ON";
            this.currencyToggleSwitch.Size = new System.Drawing.Size(123, 22);
            this.currencyToggleSwitch.Style = GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.ToggleSwitchStyle.Carbon;
            this.currencyToggleSwitch.TabIndex = 3;
            this.currencyToggleSwitch.CheckedChanged += new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.CheckedChangedDelegate(this.ToggleSwitch_CheckedChanged);
            this.currencyToggleSwitch.MouseEnter += new System.EventHandler(this.ToggleSwitch_MouseEnter);
            // 
            // choosePanel1
            // 
            this.choosePanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.choosePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.choosePanel1.Location = new System.Drawing.Point(2, 2);
            this.choosePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.choosePanel1.Name = "choosePanel1";
            this.choosePanel1.Size = new System.Drawing.Size(40, 22);
            this.choosePanel1.TabIndex = 0;
            // 
            // importingDataPanel
            // 
            this.importingDataPanel.Controls.Add(this.controlsPanel);
            this.importingDataPanel.Controls.Add(this.importingDataDGV);
            this.importingDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importingDataPanel.Location = new System.Drawing.Point(0, 54);
            this.importingDataPanel.Margin = new System.Windows.Forms.Padding(2);
            this.importingDataPanel.Name = "importingDataPanel";
            this.importingDataPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.importingDataPanel.Size = new System.Drawing.Size(884, 407);
            this.importingDataPanel.TabIndex = 1;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.overwriteNamesCheckBox);
            this.controlsPanel.Controls.Add(this.openFileBtn);
            this.controlsPanel.Controls.Add(this.numericUpDownRight);
            this.controlsPanel.Controls.Add(this.numericUpDownLeft);
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Controls.Add(this.cancelBtn);
            this.controlsPanel.Controls.Add(this.okBtn);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsPanel.Location = new System.Drawing.Point(3, 363);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(878, 44);
            this.controlsPanel.TabIndex = 2;
            // 
            // overwriteNamesCheckBox
            // 
            this.overwriteNamesCheckBox.AutoSize = true;
            this.overwriteNamesCheckBox.Checked = true;
            this.overwriteNamesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteNamesCheckBox.Location = new System.Drawing.Point(321, 16);
            this.overwriteNamesCheckBox.Name = "overwriteNamesCheckBox";
            this.overwriteNamesCheckBox.Size = new System.Drawing.Size(134, 17);
            this.overwriteNamesCheckBox.TabIndex = 29;
            this.overwriteNamesCheckBox.Text = "Перезаписать имена";
            this.overwriteNamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.openFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.openFileBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.openFileBtn.Location = new System.Drawing.Point(476, 9);
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Rounding = 80;
            this.openFileBtn.RoundingEnabled = true;
            this.openFileBtn.Size = new System.Drawing.Size(113, 26);
            this.openFileBtn.TabIndex = 28;
            this.openFileBtn.Text = "Открыть файл";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // numericUpDownRight
            // 
            this.numericUpDownRight.Enabled = false;
            this.numericUpDownRight.Location = new System.Drawing.Point(217, 14);
            this.numericUpDownRight.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownRight.Name = "numericUpDownRight";
            this.numericUpDownRight.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownRight.TabIndex = 27;
            this.numericUpDownRight.ValueChanged += new System.EventHandler(this.NumericUpDownRight_ValueChanged);
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Enabled = false;
            this.numericUpDownLeft.Location = new System.Drawing.Point(125, 14);
            this.numericUpDownLeft.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownLeft.TabIndex = 26;
            this.numericUpDownLeft.ValueChanged += new System.EventHandler(this.NumericUpDownLeft_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Выбирать строки с:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cancelBtn.Location = new System.Drawing.Point(753, 9);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Rounding = 80;
            this.cancelBtn.RoundingEnabled = true;
            this.cancelBtn.Size = new System.Drawing.Size(87, 26);
            this.cancelBtn.TabIndex = 24;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.Enabled = false;
            this.okBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.okBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.okBtn.Location = new System.Drawing.Point(653, 9);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Rounding = 80;
            this.okBtn.RoundingEnabled = true;
            this.okBtn.Size = new System.Drawing.Size(80, 26);
            this.okBtn.TabIndex = 23;
            this.okBtn.Text = "Ок";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // importingDataDGV
            // 
            this.importingDataDGV.AllowUserToOrderColumns = true;
            this.importingDataDGV.AllowUserToResizeColumns = false;
            this.importingDataDGV.AllowUserToResizeRows = false;
            this.importingDataDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.importingDataDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.importingDataDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.importingDataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importingDataDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.importingDataDGV.Location = new System.Drawing.Point(3, 0);
            this.importingDataDGV.Margin = new System.Windows.Forms.Padding(2);
            this.importingDataDGV.Name = "importingDataDGV";
            this.importingDataDGV.ReadOnly = true;
            this.importingDataDGV.RowHeadersVisible = false;
            this.importingDataDGV.RowHeadersWidth = 62;
            this.importingDataDGV.RowTemplate.Height = 28;
            this.importingDataDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.importingDataDGV.Size = new System.Drawing.Size(878, 356);
            this.importingDataDGV.TabIndex = 0;
            this.importingDataDGV.Resize += new System.EventHandler(this.ImportingDataDGV_Resize);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "new file";
            this.openFileDialog.Filter = "Книга Excel 97-2003|*.xls|Книга Excel|*.xlsx|CSV (разделитель - запятая)|*.csv";
            // 
            // ImportMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.importingDataPanel);
            this.Controls.Add(this.chooseColumnsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "ImportMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мастер импорта из Excel ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportMasterForm_FormClosing);
            this.chooseColumnsPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.importTabPage.ResumeLayout(false);
            this.choosePanel6.ResumeLayout(false);
            this.choosePanel5.ResumeLayout(false);
            this.choosePanel4.ResumeLayout(false);
            this.choosePanel3.ResumeLayout(false);
            this.choosePanel2.ResumeLayout(false);
            this.choosePanel7.ResumeLayout(false);
            this.importingDataPanel.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importingDataDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chooseColumnsPanel;
        private System.Windows.Forms.Panel importingDataPanel;
        private System.Windows.Forms.Panel controlsPanel;
        private Controls.GMRButton okBtn;
        private Controls.GMRButton cancelBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage importTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView importingDataDGV;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownRight;
        private Controls.GMRButton openFileBtn;
        private System.Windows.Forms.Panel choosePanel3;
        private System.Windows.Forms.Panel choosePanel2;
        private System.Windows.Forms.Panel choosePanel7;
        private System.Windows.Forms.Panel choosePanel1;
        private System.Windows.Forms.Panel choosePanel5;
        private System.Windows.Forms.Panel choosePanel4;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch contractorToggleSwitch;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch dateToggleSwitch;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch idToggleSwitch;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch transactionToggleSwitch;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch currencyToggleSwitch;
        private System.Windows.Forms.Panel choosePanel6;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch priceToggleSwitch;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox overwriteNamesCheckBox;
    }
}