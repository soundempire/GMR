namespace GMR
{
    partial class AddTransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransactionForm));
            this.addTransactionPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.contractorCmBox = new System.Windows.Forms.ComboBox();
            this.transactionPriceTBox = new System.Windows.Forms.TextBox();
            this.transactionValueTBox = new System.Windows.Forms.TextBox();
            this.transactionCurrencyTBox = new System.Windows.Forms.TextBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.importBtn = new System.Windows.Forms.Button();
            this.controlBtnsPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.addTransactionPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.controlBtnsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTransactionPanel
            // 
            this.addTransactionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTransactionPanel.Controls.Add(this.label4);
            this.addTransactionPanel.Controls.Add(this.label3);
            this.addTransactionPanel.Controls.Add(this.label2);
            this.addTransactionPanel.Controls.Add(this.label1);
            this.addTransactionPanel.Controls.Add(this.transactionDateDTPicker);
            this.addTransactionPanel.Controls.Add(this.contractorCmBox);
            this.addTransactionPanel.Controls.Add(this.transactionPriceTBox);
            this.addTransactionPanel.Controls.Add(this.transactionValueTBox);
            this.addTransactionPanel.Controls.Add(this.transactionCurrencyTBox);
            this.addTransactionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTransactionPanel.Location = new System.Drawing.Point(0, 0);
            this.addTransactionPanel.Name = "addTransactionPanel";
            this.addTransactionPanel.Size = new System.Drawing.Size(605, 316);
            this.addTransactionPanel.TabIndex = 0;
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
            this.transactionDateDTPicker.Location = new System.Drawing.Point(385, 33);
            this.transactionDateDTPicker.Name = "transactionDateDTPicker";
            this.transactionDateDTPicker.Size = new System.Drawing.Size(175, 24);
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
            this.contractorCmBox.Location = new System.Drawing.Point(134, 74);
            this.contractorCmBox.Name = "contractorCmBox";
            this.contractorCmBox.Size = new System.Drawing.Size(234, 24);
            this.contractorCmBox.TabIndex = 3;
            // 
            // transactionPriceTBox
            // 
            this.transactionPriceTBox.Enabled = false;
            this.transactionPriceTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionPriceTBox.Location = new System.Drawing.Point(134, 161);
            this.transactionPriceTBox.Name = "transactionPriceTBox";
            this.transactionPriceTBox.Size = new System.Drawing.Size(234, 24);
            this.transactionPriceTBox.TabIndex = 2;
            this.transactionPriceTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // transactionValueTBox
            // 
            this.transactionValueTBox.Enabled = false;
            this.transactionValueTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionValueTBox.Location = new System.Drawing.Point(134, 117);
            this.transactionValueTBox.Name = "transactionValueTBox";
            this.transactionValueTBox.Size = new System.Drawing.Size(234, 24);
            this.transactionValueTBox.TabIndex = 1;
            this.transactionValueTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // transactionCurrencyTBox
            // 
            this.transactionCurrencyTBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transactionCurrencyTBox.Location = new System.Drawing.Point(134, 33);
            this.transactionCurrencyTBox.Name = "transactionCurrencyTBox";
            this.transactionCurrencyTBox.Size = new System.Drawing.Size(234, 24);
            this.transactionCurrencyTBox.TabIndex = 0;
            this.transactionCurrencyTBox.TextChanged += new System.EventHandler(this.TransactionCurrencyTBox_TextChanged);
            this.transactionCurrencyTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // controlsPanel
            // 
            this.controlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlsPanel.Controls.Add(this.importBtn);
            this.controlsPanel.Controls.Add(this.controlBtnsPanel);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsPanel.Location = new System.Drawing.Point(0, 263);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(605, 53);
            this.controlsPanel.TabIndex = 1;
            // 
            // importBtn
            // 
            this.importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importBtn.Location = new System.Drawing.Point(29, 12);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(139, 26);
            this.importBtn.TabIndex = 22;
            this.importBtn.Text = "Импорт из Excel";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // controlBtnsPanel
            // 
            this.controlBtnsPanel.Controls.Add(this.closeBtn);
            this.controlBtnsPanel.Controls.Add(this.cancelBtn);
            this.controlBtnsPanel.Controls.Add(this.okBtn);
            this.controlBtnsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBtnsPanel.Location = new System.Drawing.Point(290, 0);
            this.controlBtnsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlBtnsPanel.Name = "controlBtnsPanel";
            this.controlBtnsPanel.Size = new System.Drawing.Size(313, 51);
            this.controlBtnsPanel.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.Location = new System.Drawing.Point(215, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(87, 26);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(111, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 26);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBtn.Location = new System.Drawing.Point(13, 12);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(80, 26);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "Ок";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 316);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.addTransactionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddContractorForm_FormClosing);
            this.Load += new System.EventHandler(this.AddContractorForm_Load);
            this.addTransactionPanel.ResumeLayout(false);
            this.addTransactionPanel.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.controlBtnsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addTransactionPanel;
        private System.Windows.Forms.ComboBox contractorCmBox;
        private System.Windows.Forms.TextBox transactionPriceTBox;
        private System.Windows.Forms.TextBox transactionValueTBox;
        private System.Windows.Forms.TextBox transactionCurrencyTBox;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.DateTimePicker transactionDateDTPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlBtnsPanel;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}