namespace GMR
{
    partial class AddContractorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.importBtn = new GMR.Controls.GMRButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.contractorCmBox = new System.Windows.Forms.ComboBox();
            this.transactionPriceTBox = new System.Windows.Forms.TextBox();
            this.transactionValueTBox = new System.Windows.Forms.TextBox();
            this.transactionCurrencyTBox = new System.Windows.Forms.TextBox();
            this.currentUserPanel = new System.Windows.Forms.Panel();
            this.controlBtnsPanel = new System.Windows.Forms.Panel();
            this.okBtn = new GMR.Controls.GMRButton();
            this.cancelBtn = new GMR.Controls.GMRButton();
            this.closeBtn = new GMR.Controls.GMRButton();
            this.panel1.SuspendLayout();
            this.currentUserPanel.SuspendLayout();
            this.controlBtnsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.importBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.transactionDateDTPicker);
            this.panel1.Controls.Add(this.contractorCmBox);
            this.panel1.Controls.Add(this.transactionPriceTBox);
            this.panel1.Controls.Add(this.transactionValueTBox);
            this.panel1.Controls.Add(this.transactionCurrencyTBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 316);
            this.panel1.TabIndex = 0;
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.importBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.importBtn.Location = new System.Drawing.Point(29, 220);
            this.importBtn.Margin = new System.Windows.Forms.Padding(2);
            this.importBtn.Name = "importBtn";
            this.importBtn.Rounding = 80;
            this.importBtn.RoundingEnabled = true;
            this.importBtn.Size = new System.Drawing.Size(139, 26);
            this.importBtn.TabIndex = 21;
            this.importBtn.Text = "Импорт из Excel";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Платёж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Транзакция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Контрагент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Курс";
            // 
            // transactionDateDTPicker
            // 
            this.transactionDateDTPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactionDateDTPicker.CustomFormat = "\"yyyy/MM/dd\"";
            this.transactionDateDTPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.transactionDateDTPicker.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionDateDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transactionDateDTPicker.Location = new System.Drawing.Point(386, 27);
            this.transactionDateDTPicker.Name = "transactionDateDTPicker";
            this.transactionDateDTPicker.Size = new System.Drawing.Size(152, 24);
            this.transactionDateDTPicker.TabIndex = 4;
            this.transactionDateDTPicker.ValueChanged += new System.EventHandler(this.TransactionDateDTPicker_ValueChanged);
            // 
            // contractorCmBox
            // 
            this.contractorCmBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.contractorCmBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contractorCmBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contractorCmBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractorCmBox.FormattingEnabled = true;
            this.contractorCmBox.Location = new System.Drawing.Point(135, 68);
            this.contractorCmBox.Name = "contractorCmBox";
            this.contractorCmBox.Size = new System.Drawing.Size(121, 24);
            this.contractorCmBox.TabIndex = 3;
            // 
            // transactionPriceTBox
            // 
            this.transactionPriceTBox.Enabled = false;
            this.transactionPriceTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionPriceTBox.Location = new System.Drawing.Point(135, 155);
            this.transactionPriceTBox.Name = "transactionPriceTBox";
            this.transactionPriceTBox.Size = new System.Drawing.Size(121, 24);
            this.transactionPriceTBox.TabIndex = 2;
            // 
            // transactionValueTBox
            // 
            this.transactionValueTBox.Enabled = false;
            this.transactionValueTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionValueTBox.Location = new System.Drawing.Point(135, 111);
            this.transactionValueTBox.Name = "transactionValueTBox";
            this.transactionValueTBox.Size = new System.Drawing.Size(121, 24);
            this.transactionValueTBox.TabIndex = 1;
            // 
            // transactionCurrencyTBox
            // 
            this.transactionCurrencyTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionCurrencyTBox.Location = new System.Drawing.Point(135, 27);
            this.transactionCurrencyTBox.Name = "transactionCurrencyTBox";
            this.transactionCurrencyTBox.Size = new System.Drawing.Size(121, 24);
            this.transactionCurrencyTBox.TabIndex = 0;
            this.transactionCurrencyTBox.TextChanged += new System.EventHandler(this.transactionCurrencyTBox_TextChanged);
            // 
            // currentUserPanel
            // 
            this.currentUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentUserPanel.Controls.Add(this.controlBtnsPanel);
            this.currentUserPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.currentUserPanel.Location = new System.Drawing.Point(0, 263);
            this.currentUserPanel.Name = "currentUserPanel";
            this.currentUserPanel.Size = new System.Drawing.Size(605, 53);
            this.currentUserPanel.TabIndex = 1;
            // 
            // controlBtnsPanel
            // 
            this.controlBtnsPanel.Controls.Add(this.okBtn);
            this.controlBtnsPanel.Controls.Add(this.cancelBtn);
            this.controlBtnsPanel.Controls.Add(this.closeBtn);
            this.controlBtnsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBtnsPanel.Location = new System.Drawing.Point(290, 0);
            this.controlBtnsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlBtnsPanel.Name = "controlBtnsPanel";
            this.controlBtnsPanel.Size = new System.Drawing.Size(313, 51);
            this.controlBtnsPanel.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.Enabled = false;
            this.okBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.okBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.okBtn.Location = new System.Drawing.Point(20, 12);
            this.okBtn.Margin = new System.Windows.Forms.Padding(2);
            this.okBtn.Name = "okBtn";
            this.okBtn.Rounding = 80;
            this.okBtn.RoundingEnabled = true;
            this.okBtn.Size = new System.Drawing.Size(80, 26);
            this.okBtn.TabIndex = 22;
            this.okBtn.Text = "Ок";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cancelBtn.Location = new System.Drawing.Point(107, 12);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Rounding = 80;
            this.cancelBtn.RoundingEnabled = true;
            this.cancelBtn.Size = new System.Drawing.Size(87, 26);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.closeBtn.Location = new System.Drawing.Point(210, 12);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Rounding = 80;
            this.closeBtn.RoundingEnabled = true;
            this.closeBtn.Size = new System.Drawing.Size(93, 26);
            this.closeBtn.TabIndex = 20;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 316);
            this.Controls.Add(this.currentUserPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddContractorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddContractorForm_FormClosing);
            this.Load += new System.EventHandler(this.AddContractorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.currentUserPanel.ResumeLayout(false);
            this.controlBtnsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox contractorCmBox;
        private System.Windows.Forms.TextBox transactionPriceTBox;
        private System.Windows.Forms.TextBox transactionValueTBox;
        private System.Windows.Forms.TextBox transactionCurrencyTBox;
        private System.Windows.Forms.Panel currentUserPanel;
        private System.Windows.Forms.DateTimePicker transactionDateDTPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlBtnsPanel;
        private Controls.GMRButton closeBtn;
        private Controls.GMRButton okBtn;
        private Controls.GMRButton cancelBtn;
        private Controls.GMRButton importBtn;
    }
}