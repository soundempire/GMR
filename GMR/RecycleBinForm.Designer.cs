﻿namespace GMR
{
    partial class RecycleBinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecycleBinForm));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.retrieveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.deletedContractorsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.contractorsDGView = new System.Windows.Forms.DataGridView();
            this.transactionsDGView = new System.Windows.Forms.DataGridView();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletedContractorsSplitContainer)).BeginInit();
            this.deletedContractorsSplitContainer.Panel1.SuspendLayout();
            this.deletedContractorsSplitContainer.Panel2.SuspendLayout();
            this.deletedContractorsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.retrieveBtn);
            this.controlPanel.Controls.Add(this.deleteBtn);
            this.controlPanel.Controls.Add(this.closeBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 374);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(856, 54);
            this.controlPanel.TabIndex = 0;
            // 
            // retrieveBtn
            // 
            this.retrieveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrieveBtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.retrieveBtn.Location = new System.Drawing.Point(12, 17);
            this.retrieveBtn.Name = "retrieveBtn";
            this.retrieveBtn.Size = new System.Drawing.Size(100, 26);
            this.retrieveBtn.TabIndex = 21;
            this.retrieveBtn.Text = "Вернуть";
            this.retrieveBtn.UseVisualStyleBackColor = true;
            this.retrieveBtn.Click += new System.EventHandler(this.RetrieveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.deleteBtn.Location = new System.Drawing.Point(137, 17);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 26);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.closeBtn.Location = new System.Drawing.Point(744, 17);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 26);
            this.closeBtn.TabIndex = 19;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // deletedContractorsSplitContainer
            // 
            this.deletedContractorsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletedContractorsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.deletedContractorsSplitContainer.Name = "deletedContractorsSplitContainer";
            // 
            // deletedContractorsSplitContainer.Panel1
            // 
            this.deletedContractorsSplitContainer.Panel1.Controls.Add(this.contractorsDGView);
            this.deletedContractorsSplitContainer.Panel1MinSize = 250;
            // 
            // deletedContractorsSplitContainer.Panel2
            // 
            this.deletedContractorsSplitContainer.Panel2.Controls.Add(this.transactionsDGView);
            this.deletedContractorsSplitContainer.Panel2MinSize = 550;
            this.deletedContractorsSplitContainer.Size = new System.Drawing.Size(856, 374);
            this.deletedContractorsSplitContainer.SplitterDistance = 300;
            this.deletedContractorsSplitContainer.TabIndex = 1;
            this.deletedContractorsSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.DeletedContractorsSplitContainer_SplitterMoved);
            // 
            // contractorsDGView
            // 
            this.contractorsDGView.AllowUserToAddRows = false;
            this.contractorsDGView.AllowUserToResizeColumns = false;
            this.contractorsDGView.AllowUserToResizeRows = false;
            this.contractorsDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contractorsDGView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.contractorsDGView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contractorsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractorsDGView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contractorsDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractorsDGView.Location = new System.Drawing.Point(0, 0);
            this.contractorsDGView.Name = "contractorsDGView";
            this.contractorsDGView.ReadOnly = true;
            this.contractorsDGView.RowHeadersWidth = 25;
            this.contractorsDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.contractorsDGView.RowTemplate.Height = 28;
            this.contractorsDGView.Size = new System.Drawing.Size(300, 374);
            this.contractorsDGView.TabIndex = 0;
            this.contractorsDGView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContractorsDGView_CellMouseClick);
            this.contractorsDGView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContractorsDGView_KeyDown);
            // 
            // transactionsDGView
            // 
            this.transactionsDGView.AllowUserToAddRows = false;
            this.transactionsDGView.AllowUserToDeleteRows = false;
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
            this.transactionsDGView.ReadOnly = true;
            this.transactionsDGView.RowHeadersVisible = false;
            this.transactionsDGView.RowTemplate.Height = 28;
            this.transactionsDGView.Size = new System.Drawing.Size(552, 374);
            this.transactionsDGView.TabIndex = 0;
            // 
            // RecycleBinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 428);
            this.Controls.Add(this.deletedContractorsSplitContainer);
            this.Controls.Add(this.controlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(872, 467);
            this.Name = "RecycleBinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecycleBinForm_FormClosing);
            this.Load += new System.EventHandler(this.RecycleBinForm_Load);
            this.Resize += new System.EventHandler(this.RecycleBinForm_Resize);
            this.controlPanel.ResumeLayout(false);
            this.deletedContractorsSplitContainer.Panel1.ResumeLayout(false);
            this.deletedContractorsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deletedContractorsSplitContainer)).EndInit();
            this.deletedContractorsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractorsDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.SplitContainer deletedContractorsSplitContainer;
        private System.Windows.Forms.DataGridView contractorsDGView;
        private System.Windows.Forms.DataGridView transactionsDGView;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button retrieveBtn;
    }
}