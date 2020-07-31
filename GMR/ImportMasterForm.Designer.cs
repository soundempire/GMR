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
            this.contractorToggleSwitch = new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch();
            this.choosePanel2 = new System.Windows.Forms.Panel();
            this.idToggleSwitch = new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch();
            this.choosePanel7 = new System.Windows.Forms.Panel();
            this.currencyToggleSwitch = new GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch();
            this.choosePanel1 = new System.Windows.Forms.Panel();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.overwriteNamesCheckBox = new System.Windows.Forms.CheckBox();
            this.numericUpDownRight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.importingDataDGV = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnsPanel = new System.Windows.Forms.Panel();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.okCancelPanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.botomPanel = new System.Windows.Forms.Panel();
            this.loadingPictureBox = new System.Windows.Forms.PictureBox();
            this.chooseColumnsPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.importTabPage.SuspendLayout();
            this.choosePanel6.SuspendLayout();
            this.choosePanel5.SuspendLayout();
            this.choosePanel4.SuspendLayout();
            this.choosePanel3.SuspendLayout();
            this.choosePanel2.SuspendLayout();
            this.choosePanel7.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importingDataDGV)).BeginInit();
            this.btnsPanel.SuspendLayout();
            this.okCancelPanel.SuspendLayout();
            this.botomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).BeginInit();
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
            this.choosePanel3.Controls.Add(this.contractorToggleSwitch);
            this.choosePanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.choosePanel3.Location = new System.Drawing.Point(165, 2);
            this.choosePanel3.Margin = new System.Windows.Forms.Padding(2);
            this.choosePanel3.Name = "choosePanel3";
            this.choosePanel3.Size = new System.Drawing.Size(200, 22);
            this.choosePanel3.TabIndex = 3;
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
            this.contractorToggleSwitch.OffFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.contractorToggleSwitch.OffText = "OFF";
            this.contractorToggleSwitch.OnFont = new System.Drawing.Font("Tahoma", 9F);
            this.contractorToggleSwitch.OnText = "ON";
            this.contractorToggleSwitch.Size = new System.Drawing.Size(200, 22);
            this.contractorToggleSwitch.Style = GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.ToggleSwitchStyle.Carbon;
            this.contractorToggleSwitch.TabIndex = 1;
            this.contractorToggleSwitch.MouseEnter += new System.EventHandler(this.ToggleSwitch_MouseEnter);
            // 
            // choosePanel2
            // 
            this.choosePanel2.Controls.Add(this.idToggleSwitch);
            this.choosePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.choosePanel2.Location = new System.Drawing.Point(42, 2);
            this.choosePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.choosePanel2.Name = "choosePanel2";
            this.choosePanel2.Size = new System.Drawing.Size(123, 22);
            this.choosePanel2.TabIndex = 2;
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
            this.idToggleSwitch.OffFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idToggleSwitch.OffText = "OFF";
            this.idToggleSwitch.OnFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idToggleSwitch.OnText = "ON";
            this.idToggleSwitch.Size = new System.Drawing.Size(123, 22);
            this.idToggleSwitch.Style = GMR.Animation.Controls.ToggleSwitch.GMRToggleSwitch.ToggleSwitchStyle.Carbon;
            this.idToggleSwitch.TabIndex = 0;
            this.idToggleSwitch.MouseEnter += new System.EventHandler(this.ToggleSwitch_MouseEnter);
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
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.overwriteNamesCheckBox);
            this.controlsPanel.Controls.Add(this.numericUpDownRight);
            this.controlsPanel.Controls.Add(this.numericUpDownLeft);
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlsPanel.Location = new System.Drawing.Point(0, 0);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(455, 46);
            this.controlsPanel.TabIndex = 2;
            // 
            // overwriteNamesCheckBox
            // 
            this.overwriteNamesCheckBox.AutoSize = true;
            this.overwriteNamesCheckBox.Checked = true;
            this.overwriteNamesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteNamesCheckBox.Location = new System.Drawing.Point(315, 15);
            this.overwriteNamesCheckBox.Name = "overwriteNamesCheckBox";
            this.overwriteNamesCheckBox.Size = new System.Drawing.Size(134, 17);
            this.overwriteNamesCheckBox.TabIndex = 29;
            this.overwriteNamesCheckBox.Text = "Перезаписать имена";
            this.overwriteNamesCheckBox.UseVisualStyleBackColor = true;
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
            this.importingDataDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importingDataDGV.Location = new System.Drawing.Point(0, 54);
            this.importingDataDGV.Margin = new System.Windows.Forms.Padding(2);
            this.importingDataDGV.Name = "importingDataDGV";
            this.importingDataDGV.ReadOnly = true;
            this.importingDataDGV.RowHeadersVisible = false;
            this.importingDataDGV.RowHeadersWidth = 62;
            this.importingDataDGV.RowTemplate.Height = 28;
            this.importingDataDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.importingDataDGV.Size = new System.Drawing.Size(884, 361);
            this.importingDataDGV.TabIndex = 0;
            this.importingDataDGV.Resize += new System.EventHandler(this.ImportingDataDGV_Resize);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "new file";
            this.openFileDialog.Filter = "Книга Excel 97-2003|*.xls|Книга Excel|*.xlsx|CSV (разделитель - запятая)|*.csv";
            // 
            // btnsPanel
            // 
            this.btnsPanel.Controls.Add(this.openFileBtn);
            this.btnsPanel.Controls.Add(this.okCancelPanel);
            this.btnsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsPanel.Location = new System.Drawing.Point(455, 0);
            this.btnsPanel.Name = "btnsPanel";
            this.btnsPanel.Size = new System.Drawing.Size(429, 46);
            this.btnsPanel.TabIndex = 30;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileBtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.openFileBtn.Location = new System.Drawing.Point(6, 10);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(129, 26);
            this.openFileBtn.TabIndex = 30;
            this.openFileBtn.Text = "Открыть файл";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // okCancelPanel
            // 
            this.okCancelPanel.Controls.Add(this.loadingPictureBox);
            this.okCancelPanel.Controls.Add(this.cancelBtn);
            this.okCancelPanel.Controls.Add(this.okBtn);
            this.okCancelPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.okCancelPanel.Location = new System.Drawing.Point(141, 0);
            this.okCancelPanel.Name = "okCancelPanel";
            this.okCancelPanel.Size = new System.Drawing.Size(288, 46);
            this.okCancelPanel.TabIndex = 29;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cancelBtn.Location = new System.Drawing.Point(189, 10);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 26);
            this.cancelBtn.TabIndex = 26;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.Enabled = false;
            this.okBtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.okBtn.Location = new System.Drawing.Point(96, 10);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(87, 26);
            this.okBtn.TabIndex = 25;
            this.okBtn.Text = "Ок";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // botomPanel
            // 
            this.botomPanel.Controls.Add(this.btnsPanel);
            this.botomPanel.Controls.Add(this.controlsPanel);
            this.botomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botomPanel.Location = new System.Drawing.Point(0, 415);
            this.botomPanel.Name = "botomPanel";
            this.botomPanel.Size = new System.Drawing.Size(884, 46);
            this.botomPanel.TabIndex = 31;
            // 
            // loadingPictureBox
            // 
            this.loadingPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.loadingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loadingPictureBox.Image")));
            this.loadingPictureBox.Location = new System.Drawing.Point(0, 0);
            this.loadingPictureBox.Name = "loadingPictureBox";
            this.loadingPictureBox.Size = new System.Drawing.Size(87, 46);
            this.loadingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingPictureBox.TabIndex = 27;
            this.loadingPictureBox.TabStop = false;
            this.loadingPictureBox.Visible = false;
            // 
            // ImportMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.importingDataDGV);
            this.Controls.Add(this.botomPanel);
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
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importingDataDGV)).EndInit();
            this.btnsPanel.ResumeLayout(false);
            this.okCancelPanel.ResumeLayout(false);
            this.botomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chooseColumnsPanel;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage importTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView importingDataDGV;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownRight;
        private System.Windows.Forms.Panel choosePanel3;
        private System.Windows.Forms.Panel choosePanel2;
        private System.Windows.Forms.Panel choosePanel7;
        private System.Windows.Forms.Panel choosePanel1;
        private System.Windows.Forms.Panel choosePanel5;
        private System.Windows.Forms.Panel choosePanel4;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch idToggleSwitch;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch dateToggleSwitch;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch contractorToggleSwitch;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch transactionToggleSwitch;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch currencyToggleSwitch;
        private System.Windows.Forms.Panel choosePanel6;
        private Animation.Controls.ToggleSwitch.GMRToggleSwitch priceToggleSwitch;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox overwriteNamesCheckBox;
        private System.Windows.Forms.Panel botomPanel;
        private System.Windows.Forms.Panel btnsPanel;
        private System.Windows.Forms.Panel okCancelPanel;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox loadingPictureBox;
    }
}