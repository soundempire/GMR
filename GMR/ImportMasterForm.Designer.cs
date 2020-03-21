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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chooseColumnsPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.importTabPage = new System.Windows.Forms.TabPage();
            this.chooseColumnsDGV = new System.Windows.Forms.DataGridView();
            this.importingDataPanel = new System.Windows.Forms.Panel();
            this.importingDataDGV = new System.Windows.Forms.DataGridView();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new GMR.Controls.GMRButton();
            this.okBtn = new GMR.Controls.GMRButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.headers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.contractorImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.openFileBtn = new GMR.Controls.GMRButton();
            this.chooseColumnsPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.importTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseColumnsDGV)).BeginInit();
            this.importingDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importingDataDGV)).BeginInit();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseColumnsPanel
            // 
            this.chooseColumnsPanel.Controls.Add(this.tabControl);
            this.chooseColumnsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chooseColumnsPanel.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseColumnsPanel.Location = new System.Drawing.Point(0, 0);
            this.chooseColumnsPanel.Name = "chooseColumnsPanel";
            this.chooseColumnsPanel.Size = new System.Drawing.Size(1278, 210);
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
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1278, 210);
            this.tabControl.TabIndex = 0;
            // 
            // importTabPage
            // 
            this.importTabPage.BackColor = System.Drawing.Color.Transparent;
            this.importTabPage.Controls.Add(this.chooseColumnsDGV);
            this.importTabPage.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importTabPage.Location = new System.Drawing.Point(4, 24);
            this.importTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.importTabPage.Name = "importTabPage";
            this.importTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.importTabPage.Size = new System.Drawing.Size(1270, 182);
            this.importTabPage.TabIndex = 0;
            this.importTabPage.Text = "Импорт данных";
            // 
            // chooseColumnsDGV
            // 
            this.chooseColumnsDGV.AllowUserToAddRows = false;
            this.chooseColumnsDGV.AllowUserToResizeColumns = false;
            this.chooseColumnsDGV.AllowUserToResizeRows = false;
            this.chooseColumnsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chooseColumnsDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.chooseColumnsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chooseColumnsDGV.ColumnHeadersVisible = false;
            this.chooseColumnsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headers,
            this.orders,
            this.idImageColumn,
            this.contractorImageColumn,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.chooseColumnsDGV.DefaultCellStyle = dataGridViewCellStyle28;
            this.chooseColumnsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseColumnsDGV.Location = new System.Drawing.Point(3, 3);
            this.chooseColumnsDGV.Name = "chooseColumnsDGV";
            this.chooseColumnsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chooseColumnsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.chooseColumnsDGV.RowHeadersVisible = false;
            this.chooseColumnsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Arial", 8F);
            this.chooseColumnsDGV.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.chooseColumnsDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.chooseColumnsDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseColumnsDGV.RowTemplate.DefaultCellStyle.Format = " ";
            this.chooseColumnsDGV.RowTemplate.DefaultCellStyle.NullValue = null;
            this.chooseColumnsDGV.RowTemplate.Height = 17;
            this.chooseColumnsDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chooseColumnsDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.chooseColumnsDGV.Size = new System.Drawing.Size(1264, 176);
            this.chooseColumnsDGV.TabIndex = 0;
            this.chooseColumnsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chooseColumnsDGV_CellClick);
            // 
            // importingDataPanel
            // 
            this.importingDataPanel.Controls.Add(this.importingDataDGV);
            this.importingDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importingDataPanel.Location = new System.Drawing.Point(0, 210);
            this.importingDataPanel.Name = "importingDataPanel";
            this.importingDataPanel.Size = new System.Drawing.Size(1278, 449);
            this.importingDataPanel.TabIndex = 1;
            // 
            // importingDataDGV
            // 
            this.importingDataDGV.AllowUserToOrderColumns = true;
            this.importingDataDGV.AllowUserToResizeColumns = false;
            this.importingDataDGV.AllowUserToResizeRows = false;
            this.importingDataDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.importingDataDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.importingDataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importingDataDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importingDataDGV.Location = new System.Drawing.Point(0, 0);
            this.importingDataDGV.Name = "importingDataDGV";
            this.importingDataDGV.RowHeadersVisible = false;
            this.importingDataDGV.RowHeadersWidth = 62;
            this.importingDataDGV.RowTemplate.Height = 28;
            this.importingDataDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.importingDataDGV.Size = new System.Drawing.Size(1278, 449);
            this.importingDataDGV.TabIndex = 0;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.openFileBtn);
            this.controlsPanel.Controls.Add(this.numericUpDown2);
            this.controlsPanel.Controls.Add(this.numericUpDown1);
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Controls.Add(this.cancelBtn);
            this.controlsPanel.Controls.Add(this.okBtn);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsPanel.Location = new System.Drawing.Point(0, 592);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(1278, 67);
            this.controlsPanel.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(326, 21);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(187, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Выбирать строки с:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cancelBtn.Location = new System.Drawing.Point(1004, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Rounding = 80;
            this.cancelBtn.RoundingEnabled = true;
            this.cancelBtn.Size = new System.Drawing.Size(130, 40);
            this.cancelBtn.TabIndex = 24;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.okBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.okBtn.Location = new System.Drawing.Point(843, 12);
            this.okBtn.Name = "okBtn";
            this.okBtn.Rounding = 80;
            this.okBtn.RoundingEnabled = true;
            this.okBtn.Size = new System.Drawing.Size(120, 40);
            this.okBtn.TabIndex = 23;
            this.okBtn.Text = "Ок";
            this.okBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GMR.Properties.Resources.greenPlus;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // headers
            // 
            this.headers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.headers.DefaultCellStyle = dataGridViewCellStyle21;
            this.headers.Frozen = true;
            this.headers.HeaderText = "";
            this.headers.MinimumWidth = 8;
            this.headers.Name = "headers";
            this.headers.Width = 138;
            // 
            // orders
            // 
            this.orders.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orders.Frozen = true;
            this.orders.HeaderText = "";
            this.orders.MinimumWidth = 8;
            this.orders.Name = "orders";
            this.orders.Width = 137;
            // 
            // idImageColumn
            // 
            this.idImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idImageColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.idImageColumn.HeaderText = "";
            this.idImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.idImageColumn.MinimumWidth = 8;
            this.idImageColumn.Name = "idImageColumn";
            // 
            // contractorImageColumn
            // 
            this.contractorImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.NullValue = " ";
            this.contractorImageColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.contractorImageColumn.HeaderText = "";
            this.contractorImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.contractorImageColumn.MinimumWidth = 8;
            this.contractorImageColumn.Name = "contractorImageColumn";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle24;
            this.Column3.HeaderText = "";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle25;
            this.Column4.HeaderText = "";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle26;
            this.Column5.HeaderText = "";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle27;
            this.Column6.HeaderText = "";
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.openFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.openFileBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.openFileBtn.Location = new System.Drawing.Point(514, 11);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Rounding = 80;
            this.openFileBtn.RoundingEnabled = true;
            this.openFileBtn.Size = new System.Drawing.Size(170, 40);
            this.openFileBtn.TabIndex = 28;
            this.openFileBtn.Text = "Открыть файл";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // ImportMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 659);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.importingDataPanel);
            this.Controls.Add(this.chooseColumnsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImportMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мастер импорта из Excel ";
            this.chooseColumnsPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.importTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chooseColumnsDGV)).EndInit();
            this.importingDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.importingDataDGV)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.DataGridView chooseColumnsDGV;
        private System.Windows.Forms.DataGridView importingDataDGV;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn headers;
        private System.Windows.Forms.DataGridViewTextBoxColumn orders;
        private System.Windows.Forms.DataGridViewImageColumn idImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn contractorImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private Controls.GMRButton openFileBtn;
    }
}