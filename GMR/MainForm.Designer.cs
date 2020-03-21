namespace GMR
{
    partial class MainForm
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
            this.contractorsDGView = new System.Windows.Forms.DataGridView();
            this.transactionsDGView = new System.Windows.Forms.DataGridView();
            this.startsDTP = new System.Windows.Forms.DateTimePicker();
            this.endsDTP = new System.Windows.Forms.DateTimePicker();
            this.lblStarts = new System.Windows.Forms.Label();
            this.lblEnds = new System.Windows.Forms.Label();
            this.contractorsCBox = new System.Windows.Forms.ComboBox();
            this.personNameLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.contractorsCBoxPanel = new System.Windows.Forms.Panel();
            this.datesPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.personPanel = new System.Windows.Forms.Panel();
            this.controlBtnsPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new GMR.Controls.GMRButton();
            this.addBtn = new GMR.Controls.GMRButton();
            this.deleteBtn = new GMR.Controls.GMRButton();
            this.printBtn = new GMR.Controls.GMRButton();
            this.CenterSplitContainer = new System.Windows.Forms.SplitContainer();
            this.transactionsDGVPanel = new System.Windows.Forms.Panel();
            this.totalTransactionsPanel = new System.Windows.Forms.Panel();
            this.totalCurencyTB = new System.Windows.Forms.TextBox();
            this.totalPriceTB = new System.Windows.Forms.TextBox();
            this.totalTransactionTB = new System.Windows.Forms.TextBox();
            this.totalSumTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDGView)).BeginInit();
            this.topPanel.SuspendLayout();
            this.contractorsCBoxPanel.SuspendLayout();
            this.datesPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.personPanel.SuspendLayout();
            this.controlBtnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterSplitContainer)).BeginInit();
            this.CenterSplitContainer.Panel1.SuspendLayout();
            this.CenterSplitContainer.Panel2.SuspendLayout();
            this.CenterSplitContainer.SuspendLayout();
            this.transactionsDGVPanel.SuspendLayout();
            this.totalTransactionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contractorsDGView
            // 
            this.contractorsDGView.AllowUserToResizeColumns = false;
            this.contractorsDGView.AllowUserToResizeRows = false;
            this.contractorsDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contractorsDGView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.contractorsDGView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contractorsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractorsDGView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contractorsDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractorsDGView.Location = new System.Drawing.Point(4, 0);
            this.contractorsDGView.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.contractorsDGView.Name = "contractorsDGView";
            this.contractorsDGView.RowHeadersWidth = 15;
            this.contractorsDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.contractorsDGView.RowTemplate.Height = 28;
            this.contractorsDGView.Size = new System.Drawing.Size(425, 538);
            this.contractorsDGView.TabIndex = 0;
            this.contractorsDGView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ContractorsDGView_CellBeginEdit);
            this.contractorsDGView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContractorsDGView_CellEndEdit);
            this.contractorsDGView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContractorsDGView_RowHeaderMouseClick);
            // 
            // transactionsDGView
            // 
            this.transactionsDGView.AllowUserToOrderColumns = true;
            this.transactionsDGView.AllowUserToResizeColumns = false;
            this.transactionsDGView.AllowUserToResizeRows = false;
            this.transactionsDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsDGView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.transactionsDGView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDGView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactionsDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsDGView.Location = new System.Drawing.Point(0, 0);
            this.transactionsDGView.Name = "transactionsDGView";
            this.transactionsDGView.RowHeadersWidth = 15;
            this.transactionsDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.transactionsDGView.RowTemplate.Height = 28;
            this.transactionsDGView.Size = new System.Drawing.Size(856, 486);
            this.transactionsDGView.TabIndex = 1;
            this.transactionsDGView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.TransactionsDGView_CellBeginEdit);
            this.transactionsDGView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionsDGView_CellEndEdit);
            this.transactionsDGView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TransactionsDGView_KeyDown);
            // 
            // startsDTP
            // 
            this.startsDTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startsDTP.CustomFormat = "\"yyyy/MM/dd\"";
            this.startsDTP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.startsDTP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startsDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startsDTP.Location = new System.Drawing.Point(57, 12);
            this.startsDTP.Name = "startsDTP";
            this.startsDTP.Size = new System.Drawing.Size(132, 32);
            this.startsDTP.TabIndex = 9;
            this.startsDTP.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.startsDTP.ValueChanged += new System.EventHandler(this.DtpStarts_ValueChanged);
            // 
            // endsDTP
            // 
            this.endsDTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endsDTP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.endsDTP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endsDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endsDTP.Location = new System.Drawing.Point(249, 12);
            this.endsDTP.Name = "endsDTP";
            this.endsDTP.Size = new System.Drawing.Size(128, 32);
            this.endsDTP.TabIndex = 10;
            this.endsDTP.ValueChanged += new System.EventHandler(this.DtpEnds_ValueChanged);
            // 
            // lblStarts
            // 
            this.lblStarts.AutoSize = true;
            this.lblStarts.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblStarts.Location = new System.Drawing.Point(24, 15);
            this.lblStarts.Name = "lblStarts";
            this.lblStarts.Size = new System.Drawing.Size(27, 27);
            this.lblStarts.TabIndex = 11;
            this.lblStarts.Text = "C";
            // 
            // lblEnds
            // 
            this.lblEnds.AutoSize = true;
            this.lblEnds.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblEnds.Location = new System.Drawing.Point(196, 17);
            this.lblEnds.Name = "lblEnds";
            this.lblEnds.Size = new System.Drawing.Size(46, 27);
            this.lblEnds.TabIndex = 12;
            this.lblEnds.Text = "ПО";
            // 
            // contractorsCBox
            // 
            this.contractorsCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.contractorsCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contractorsCBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contractorsCBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractorsCBox.FormattingEnabled = true;
            this.contractorsCBox.Location = new System.Drawing.Point(4, 12);
            this.contractorsCBox.Name = "contractorsCBox";
            this.contractorsCBox.Size = new System.Drawing.Size(427, 32);
            this.contractorsCBox.TabIndex = 14;
            this.contractorsCBox.SelectedIndexChanged += new System.EventHandler(this.ContractorsCBox_SelectedValueChanged);
            this.contractorsCBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContractorsCBox_KeyDown);
            // 
            // personNameLabel
            // 
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personNameLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personNameLabel.Location = new System.Drawing.Point(38, 15);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(126, 24);
            this.personNameLabel.TabIndex = 15;
            this.personNameLabel.Text = "person name";
            this.personNameLabel.DoubleClick += new System.EventHandler(this.PersonNameLabel_DoubleClick);
            this.personNameLabel.MouseEnter += new System.EventHandler(this.PersonNameLabel_MouseEnter);
            this.personNameLabel.MouseLeave += new System.EventHandler(this.PersonNameLabel_MouseLeave);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.contractorsCBoxPanel);
            this.topPanel.Controls.Add(this.datesPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1293, 52);
            this.topPanel.TabIndex = 16;
            // 
            // contractorsCBoxPanel
            // 
            this.contractorsCBoxPanel.Controls.Add(this.contractorsCBox);
            this.contractorsCBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractorsCBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.contractorsCBoxPanel.Name = "contractorsCBoxPanel";
            this.contractorsCBoxPanel.Size = new System.Drawing.Size(911, 52);
            this.contractorsCBoxPanel.TabIndex = 16;
            // 
            // datesPanel
            // 
            this.datesPanel.Controls.Add(this.lblEnds);
            this.datesPanel.Controls.Add(this.startsDTP);
            this.datesPanel.Controls.Add(this.lblStarts);
            this.datesPanel.Controls.Add(this.endsDTP);
            this.datesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.datesPanel.Location = new System.Drawing.Point(911, 0);
            this.datesPanel.Name = "datesPanel";
            this.datesPanel.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.datesPanel.Size = new System.Drawing.Size(382, 52);
            this.datesPanel.TabIndex = 15;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.personPanel);
            this.bottomPanel.Controls.Add(this.controlBtnsPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 590);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1293, 69);
            this.bottomPanel.TabIndex = 17;
            // 
            // personPanel
            // 
            this.personPanel.Controls.Add(this.personNameLabel);
            this.personPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.personPanel.Location = new System.Drawing.Point(0, 0);
            this.personPanel.Name = "personPanel";
            this.personPanel.Size = new System.Drawing.Size(432, 69);
            this.personPanel.TabIndex = 21;
            // 
            // controlBtnsPanel
            // 
            this.controlBtnsPanel.Controls.Add(this.closeBtn);
            this.controlBtnsPanel.Controls.Add(this.addBtn);
            this.controlBtnsPanel.Controls.Add(this.deleteBtn);
            this.controlBtnsPanel.Controls.Add(this.printBtn);
            this.controlBtnsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBtnsPanel.Location = new System.Drawing.Point(433, 0);
            this.controlBtnsPanel.Name = "controlBtnsPanel";
            this.controlBtnsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.controlBtnsPanel.Size = new System.Drawing.Size(860, 69);
            this.controlBtnsPanel.TabIndex = 20;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.closeBtn.Location = new System.Drawing.Point(710, 15);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Rounding = 80;
            this.closeBtn.RoundingEnabled = true;
            this.closeBtn.Size = new System.Drawing.Size(140, 40);
            this.closeBtn.TabIndex = 19;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addBtn.Location = new System.Drawing.Point(10, 15);
            this.addBtn.Name = "addBtn";
            this.addBtn.Rounding = 80;
            this.addBtn.RoundingEnabled = true;
            this.addBtn.Size = new System.Drawing.Size(150, 40);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deleteBtn.Location = new System.Drawing.Point(166, 15);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rounding = 80;
            this.deleteBtn.RoundingEnabled = true;
            this.deleteBtn.Size = new System.Drawing.Size(135, 40);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.printBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.printBtn.Location = new System.Drawing.Point(307, 15);
            this.printBtn.Name = "printBtn";
            this.printBtn.Rounding = 80;
            this.printBtn.RoundingEnabled = true;
            this.printBtn.Size = new System.Drawing.Size(120, 40);
            this.printBtn.TabIndex = 18;
            this.printBtn.Text = "Печать";
            this.printBtn.UseVisualStyleBackColor = false;
            // 
            // CenterSplitContainer
            // 
            this.CenterSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterSplitContainer.Location = new System.Drawing.Point(0, 52);
            this.CenterSplitContainer.Name = "CenterSplitContainer";
            // 
            // CenterSplitContainer.Panel1
            // 
            this.CenterSplitContainer.Panel1.AutoScroll = true;
            this.CenterSplitContainer.Panel1.Controls.Add(this.contractorsDGView);
            this.CenterSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            // 
            // CenterSplitContainer.Panel2
            // 
            this.CenterSplitContainer.Panel2.Controls.Add(this.transactionsDGVPanel);
            this.CenterSplitContainer.Panel2.Controls.Add(this.totalTransactionsPanel);
            this.CenterSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.CenterSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CenterSplitContainer.Size = new System.Drawing.Size(1293, 538);
            this.CenterSplitContainer.SplitterDistance = 429;
            this.CenterSplitContainer.TabIndex = 18;
            this.CenterSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.CenterSplitContainer_SplitterMoved);
            // 
            // transactionsDGVPanel
            // 
            this.transactionsDGVPanel.Controls.Add(this.transactionsDGView);
            this.transactionsDGVPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsDGVPanel.Location = new System.Drawing.Point(0, 0);
            this.transactionsDGVPanel.Name = "transactionsDGVPanel";
            this.transactionsDGVPanel.Size = new System.Drawing.Size(856, 486);
            this.transactionsDGVPanel.TabIndex = 4;
            // 
            // totalTransactionsPanel
            // 
            this.totalTransactionsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalTransactionsPanel.Controls.Add(this.totalCurencyTB);
            this.totalTransactionsPanel.Controls.Add(this.totalPriceTB);
            this.totalTransactionsPanel.Controls.Add(this.totalTransactionTB);
            this.totalTransactionsPanel.Controls.Add(this.totalSumTB);
            this.totalTransactionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.totalTransactionsPanel.Location = new System.Drawing.Point(0, 486);
            this.totalTransactionsPanel.Name = "totalTransactionsPanel";
            this.totalTransactionsPanel.Size = new System.Drawing.Size(856, 52);
            this.totalTransactionsPanel.TabIndex = 3;
            // 
            // totalCurencyTB
            // 
            this.totalCurencyTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalCurencyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalCurencyTB.Enabled = false;
            this.totalCurencyTB.Font = new System.Drawing.Font("Tahoma", 17F);
            this.totalCurencyTB.Location = new System.Drawing.Point(634, 0);
            this.totalCurencyTB.Multiline = true;
            this.totalCurencyTB.Name = "totalCurencyTB";
            this.totalCurencyTB.Size = new System.Drawing.Size(220, 52);
            this.totalCurencyTB.TabIndex = 2;
            this.totalCurencyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalCurencyTB.Visible = false;
            // 
            // totalPriceTB
            // 
            this.totalPriceTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPriceTB.Enabled = false;
            this.totalPriceTB.Font = new System.Drawing.Font("Tahoma", 17F);
            this.totalPriceTB.Location = new System.Drawing.Point(422, 0);
            this.totalPriceTB.Multiline = true;
            this.totalPriceTB.Name = "totalPriceTB";
            this.totalPriceTB.Size = new System.Drawing.Size(215, 52);
            this.totalPriceTB.TabIndex = 2;
            this.totalPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalPriceTB.Visible = false;
            // 
            // totalTransactionTB
            // 
            this.totalTransactionTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalTransactionTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTransactionTB.Enabled = false;
            this.totalTransactionTB.Font = new System.Drawing.Font("Tahoma", 17F);
            this.totalTransactionTB.Location = new System.Drawing.Point(213, 0);
            this.totalTransactionTB.Multiline = true;
            this.totalTransactionTB.Name = "totalTransactionTB";
            this.totalTransactionTB.Size = new System.Drawing.Size(213, 54);
            this.totalTransactionTB.TabIndex = 1;
            this.totalTransactionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalTransactionTB.Visible = false;
            // 
            // totalSumTB
            // 
            this.totalSumTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalSumTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalSumTB.Enabled = false;
            this.totalSumTB.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.totalSumTB.Location = new System.Drawing.Point(0, 0);
            this.totalSumTB.Multiline = true;
            this.totalSumTB.Name = "totalSumTB";
            this.totalSumTB.Size = new System.Drawing.Size(213, 54);
            this.totalSumTB.TabIndex = 0;
            this.totalSumTB.Text = " Итого:";
            this.totalSumTB.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 659);
            this.Controls.Add(this.CenterSplitContainer);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.contractorsDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDGView)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.contractorsCBoxPanel.ResumeLayout(false);
            this.datesPanel.ResumeLayout(false);
            this.datesPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.personPanel.ResumeLayout(false);
            this.personPanel.PerformLayout();
            this.controlBtnsPanel.ResumeLayout(false);
            this.CenterSplitContainer.Panel1.ResumeLayout(false);
            this.CenterSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CenterSplitContainer)).EndInit();
            this.CenterSplitContainer.ResumeLayout(false);
            this.transactionsDGVPanel.ResumeLayout(false);
            this.totalTransactionsPanel.ResumeLayout(false);
            this.totalTransactionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView contractorsDGView;
        private System.Windows.Forms.DataGridView transactionsDGView;
        private System.Windows.Forms.DateTimePicker startsDTP;
        private System.Windows.Forms.DateTimePicker endsDTP;
        private System.Windows.Forms.Label lblStarts;
        private System.Windows.Forms.Label lblEnds;
        private System.Windows.Forms.ComboBox contractorsCBox;
        private System.Windows.Forms.Label personNameLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.SplitContainer CenterSplitContainer;
        private System.Windows.Forms.Panel datesPanel;
        private System.Windows.Forms.Panel contractorsCBoxPanel;
        private Controls.GMRButton addBtn;
        private Controls.GMRButton closeBtn;
        private Controls.GMRButton printBtn;
        private Controls.GMRButton deleteBtn;
        private System.Windows.Forms.Panel controlBtnsPanel;
        private System.Windows.Forms.Panel personPanel;
        private System.Windows.Forms.Panel transactionsDGVPanel;
        private System.Windows.Forms.Panel totalTransactionsPanel;
        private System.Windows.Forms.TextBox totalCurencyTB;
        private System.Windows.Forms.TextBox totalPriceTB;
        private System.Windows.Forms.TextBox totalTransactionTB;
        private System.Windows.Forms.TextBox totalSumTB;
    }
}