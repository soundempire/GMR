using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contractorsDGView = new System.Windows.Forms.DataGridView();
            this.transactionsDGView = new System.Windows.Forms.DataGridView();
            this.startsDTP = new System.Windows.Forms.DateTimePicker();
            this.endsDTP = new System.Windows.Forms.DateTimePicker();
            this.lblStarts = new System.Windows.Forms.Label();
            this.lblEnds = new System.Windows.Forms.Label();
            this.contractorsCBox = new System.Windows.Forms.ComboBox();
            this.datesPanel = new System.Windows.Forms.Panel();
            this.contractorsCBoxPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.personPanel = new System.Windows.Forms.Panel();
            this.controlBtnsPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new GMR.Controls.GMRButton();
            this.addBtn = new GMR.Controls.GMRButton();
            this.deleteBtn = new GMR.Controls.GMRButton();
            this.printBtn = new GMR.Controls.GMRButton();
            this.CenterSplitContainer = new System.Windows.Forms.SplitContainer();
            this.contractorDGVPanel = new System.Windows.Forms.Panel();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.contractorContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameContractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.transactionsDGVPanel = new System.Windows.Forms.Panel();
            this.totalTransactionsPanel = new System.Windows.Forms.Panel();
            this.totalSumTB = new System.Windows.Forms.TextBox();
            this.totalTransactionTB = new System.Windows.Forms.TextBox();
            this.totalPriceTB = new System.Windows.Forms.TextBox();
            this.totalCurencyTB = new System.Windows.Forms.TextBox();
            this.topRightPanel = new System.Windows.Forms.Panel();
            this.userAccountMenuStrip = new System.Windows.Forms.MenuStrip();
            this.userAccountToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountMenuPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDGView)).BeginInit();
            this.datesPanel.SuspendLayout();
            this.contractorsCBoxPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.controlBtnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterSplitContainer)).BeginInit();
            this.CenterSplitContainer.Panel1.SuspendLayout();
            this.CenterSplitContainer.Panel2.SuspendLayout();
            this.CenterSplitContainer.SuspendLayout();
            this.contractorDGVPanel.SuspendLayout();
            this.topLeftPanel.SuspendLayout();
            this.contractorContextMenu.SuspendLayout();
            this.transactionsDGVPanel.SuspendLayout();
            this.totalTransactionsPanel.SuspendLayout();
            this.topRightPanel.SuspendLayout();
            this.userAccountMenuStrip.SuspendLayout();
            this.userAccountMenuPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.contractorsDGView.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.contractorsDGView.Name = "contractorsDGView";
            this.contractorsDGView.RowHeadersWidth = 25;
            this.contractorsDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.contractorsDGView.RowTemplate.Height = 28;
            this.contractorsDGView.Size = new System.Drawing.Size(283, 351);
            this.contractorsDGView.TabIndex = 0;
            this.contractorsDGView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ContractorsDGView_CellBeginEdit);
            this.contractorsDGView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContractorsDGView_CellEndEdit);
            this.contractorsDGView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContractorsDGView_CellMouseClick);
            this.contractorsDGView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContractorsDGView_CellMouseDown);
            this.contractorsDGView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ContractorsDGView_RowHeaderMouseClick);
            this.contractorsDGView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContractorsDGView_KeyDown);
            // 
            // transactionsDGView
            // 
            this.transactionsDGView.AllowUserToAddRows = false;
            this.transactionsDGView.AllowUserToResizeColumns = false;
            this.transactionsDGView.AllowUserToResizeRows = false;
            this.transactionsDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsDGView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.transactionsDGView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDGView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactionsDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsDGView.Location = new System.Drawing.Point(0, 0);
            this.transactionsDGView.Margin = new System.Windows.Forms.Padding(2);
            this.transactionsDGView.Name = "transactionsDGView";
            this.transactionsDGView.RowHeadersWidth = 25;
            this.transactionsDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.transactionsDGView.RowTemplate.Height = 28;
            this.transactionsDGView.Size = new System.Drawing.Size(570, 317);
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
            this.startsDTP.Location = new System.Drawing.Point(26, 6);
            this.startsDTP.Margin = new System.Windows.Forms.Padding(2);
            this.startsDTP.Name = "startsDTP";
            this.startsDTP.Size = new System.Drawing.Size(89, 24);
            this.startsDTP.TabIndex = 9;
            this.startsDTP.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.startsDTP.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // endsDTP
            // 
            this.endsDTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endsDTP.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.endsDTP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endsDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endsDTP.Location = new System.Drawing.Point(154, 6);
            this.endsDTP.Margin = new System.Windows.Forms.Padding(2);
            this.endsDTP.Name = "endsDTP";
            this.endsDTP.Size = new System.Drawing.Size(87, 24);
            this.endsDTP.TabIndex = 10;
            this.endsDTP.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // lblStarts
            // 
            this.lblStarts.AutoSize = true;
            this.lblStarts.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblStarts.Location = new System.Drawing.Point(4, 8);
            this.lblStarts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStarts.Name = "lblStarts";
            this.lblStarts.Size = new System.Drawing.Size(18, 18);
            this.lblStarts.TabIndex = 11;
            this.lblStarts.Text = "C";
            // 
            // lblEnds
            // 
            this.lblEnds.AutoSize = true;
            this.lblEnds.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblEnds.Location = new System.Drawing.Point(119, 9);
            this.lblEnds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnds.Name = "lblEnds";
            this.lblEnds.Size = new System.Drawing.Size(31, 18);
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
            this.contractorsCBox.Location = new System.Drawing.Point(0, 6);
            this.contractorsCBox.Margin = new System.Windows.Forms.Padding(2);
            this.contractorsCBox.Name = "contractorsCBox";
            this.contractorsCBox.Size = new System.Drawing.Size(278, 24);
            this.contractorsCBox.TabIndex = 14;
            this.contractorsCBox.Text = "Все";
            this.contractorsCBox.SelectedIndexChanged += new System.EventHandler(this.ContractorsCBox_SelectedValueChanged);
            this.contractorsCBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContractorsCBox_KeyDown);
            // 
            // datesPanel
            // 
            this.datesPanel.Controls.Add(this.lblEnds);
            this.datesPanel.Controls.Add(this.lblStarts);
            this.datesPanel.Controls.Add(this.startsDTP);
            this.datesPanel.Controls.Add(this.endsDTP);
            this.datesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.datesPanel.Location = new System.Drawing.Point(0, 0);
            this.datesPanel.Name = "datesPanel";
            this.datesPanel.Size = new System.Drawing.Size(256, 32);
            this.datesPanel.TabIndex = 18;
            // 
            // contractorsCBoxPanel
            // 
            this.contractorsCBoxPanel.Controls.Add(this.contractorsCBox);
            this.contractorsCBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractorsCBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.contractorsCBoxPanel.Margin = new System.Windows.Forms.Padding(2);
            this.contractorsCBoxPanel.Name = "contractorsCBoxPanel";
            this.contractorsCBoxPanel.Size = new System.Drawing.Size(283, 32);
            this.contractorsCBoxPanel.TabIndex = 16;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.personPanel);
            this.bottomPanel.Controls.Add(this.controlBtnsPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 383);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(862, 45);
            this.bottomPanel.TabIndex = 17;
            // 
            // personPanel
            // 
            this.personPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.personPanel.Location = new System.Drawing.Point(0, 0);
            this.personPanel.Margin = new System.Windows.Forms.Padding(2);
            this.personPanel.Name = "personPanel";
            this.personPanel.Size = new System.Drawing.Size(288, 45);
            this.personPanel.TabIndex = 21;
            // 
            // controlBtnsPanel
            // 
            this.controlBtnsPanel.Controls.Add(this.closeBtn);
            this.controlBtnsPanel.Controls.Add(this.addBtn);
            this.controlBtnsPanel.Controls.Add(this.deleteBtn);
            this.controlBtnsPanel.Controls.Add(this.printBtn);
            this.controlBtnsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBtnsPanel.Location = new System.Drawing.Point(289, 0);
            this.controlBtnsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlBtnsPanel.Name = "controlBtnsPanel";
            this.controlBtnsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.controlBtnsPanel.Size = new System.Drawing.Size(573, 45);
            this.controlBtnsPanel.TabIndex = 20;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.closeBtn.Location = new System.Drawing.Point(473, 10);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Rounding = 80;
            this.closeBtn.RoundingEnabled = true;
            this.closeBtn.Size = new System.Drawing.Size(93, 26);
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
            this.addBtn.Location = new System.Drawing.Point(7, 10);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Rounding = 80;
            this.addBtn.RoundingEnabled = true;
            this.addBtn.Size = new System.Drawing.Size(100, 26);
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
            this.deleteBtn.Location = new System.Drawing.Point(111, 10);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rounding = 80;
            this.deleteBtn.RoundingEnabled = true;
            this.deleteBtn.Size = new System.Drawing.Size(90, 26);
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
            this.printBtn.Location = new System.Drawing.Point(205, 10);
            this.printBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printBtn.Name = "printBtn";
            this.printBtn.Rounding = 80;
            this.printBtn.RoundingEnabled = true;
            this.printBtn.Size = new System.Drawing.Size(80, 26);
            this.printBtn.TabIndex = 18;
            this.printBtn.Text = "Печать";
            this.printBtn.UseVisualStyleBackColor = false;
            // 
            // CenterSplitContainer
            // 
            this.CenterSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.CenterSplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.CenterSplitContainer.Name = "CenterSplitContainer";
            // 
            // CenterSplitContainer.Panel1
            // 
            this.CenterSplitContainer.Panel1.AutoScroll = true;
            this.CenterSplitContainer.Panel1.Controls.Add(this.contractorDGVPanel);
            this.CenterSplitContainer.Panel1.Controls.Add(this.topLeftPanel);
            this.CenterSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CenterSplitContainer.Panel1MinSize = 200;
            // 
            // CenterSplitContainer.Panel2
            // 
            this.CenterSplitContainer.Panel2.Controls.Add(this.transactionsDGVPanel);
            this.CenterSplitContainer.Panel2.Controls.Add(this.topRightPanel);
            this.CenterSplitContainer.Panel2.Controls.Add(this.totalTransactionsPanel);
            this.CenterSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.CenterSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CenterSplitContainer.Panel2MinSize = 450;
            this.CenterSplitContainer.Size = new System.Drawing.Size(862, 383);
            this.CenterSplitContainer.SplitterDistance = 286;
            this.CenterSplitContainer.SplitterWidth = 3;
            this.CenterSplitContainer.TabIndex = 18;
            this.CenterSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.CenterSplitContainer_SplitterMoved);
            // 
            // contractorDGVPanel
            // 
            this.contractorDGVPanel.Controls.Add(this.contractorsDGView);
            this.contractorDGVPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractorDGVPanel.Location = new System.Drawing.Point(3, 32);
            this.contractorDGVPanel.Name = "contractorDGVPanel";
            this.contractorDGVPanel.Size = new System.Drawing.Size(283, 351);
            this.contractorDGVPanel.TabIndex = 18;
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.Controls.Add(this.contractorsCBoxPanel);
            this.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLeftPanel.Location = new System.Drawing.Point(3, 0);
            this.topLeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(283, 32);
            this.topLeftPanel.TabIndex = 17;
            // 
            // contractorContextMenu
            // 
            this.contractorContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contractorContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionsToolStripMenuItem,
            this.renameContractorToolStripMenuItem,
            this.removeContractorToolStripMenuItem});
            this.contractorContextMenu.Name = "contractorContextMenu";
            this.contractorContextMenu.Size = new System.Drawing.Size(237, 70);
            // 
            // addTransactionsToolStripMenuItem
            // 
            this.addTransactionsToolStripMenuItem.Name = "addTransactionsToolStripMenuItem";
            this.addTransactionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.addTransactionsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.addTransactionsToolStripMenuItem.Text = "Добавить транзакцию";
            this.addTransactionsToolStripMenuItem.Click += new System.EventHandler(this.AddTransactionsToolStripMenuItem_Click);
            // 
            // renameContractorToolStripMenuItem
            // 
            this.renameContractorToolStripMenuItem.Name = "renameContractorToolStripMenuItem";
            this.renameContractorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.renameContractorToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.renameContractorToolStripMenuItem.Text = "Переименовать";
            this.renameContractorToolStripMenuItem.Click += new System.EventHandler(this.RenameContractorToolStripMenuItem_Click);
            // 
            // removeContractorToolStripMenuItem
            // 
            this.removeContractorToolStripMenuItem.Name = "removeContractorToolStripMenuItem";
            this.removeContractorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeContractorToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.removeContractorToolStripMenuItem.Text = "Удалить";
            this.removeContractorToolStripMenuItem.Click += new System.EventHandler(this.RemoveContractorToolStripMenuItem_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.miniToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.miniToolStrip.Location = new System.Drawing.Point(127, 34);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.miniToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.miniToolStrip.Size = new System.Drawing.Size(109, 32);
            this.miniToolStrip.TabIndex = 0;
            // 
            // transactionsDGVPanel
            // 
            this.transactionsDGVPanel.Controls.Add(this.transactionsDGView);
            this.transactionsDGVPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsDGVPanel.Location = new System.Drawing.Point(0, 32);
            this.transactionsDGVPanel.Margin = new System.Windows.Forms.Padding(2);
            this.transactionsDGVPanel.Name = "transactionsDGVPanel";
            this.transactionsDGVPanel.Size = new System.Drawing.Size(570, 317);
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
            this.totalTransactionsPanel.Location = new System.Drawing.Point(0, 349);
            this.totalTransactionsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.totalTransactionsPanel.Name = "totalTransactionsPanel";
            this.totalTransactionsPanel.Size = new System.Drawing.Size(570, 34);
            this.totalTransactionsPanel.TabIndex = 3;
            this.totalTransactionsPanel.Visible = false;
            // 
            // totalSumTB
            // 
            this.totalSumTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalSumTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalSumTB.Enabled = false;
            this.totalSumTB.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSumTB.Location = new System.Drawing.Point(0, 0);
            this.totalSumTB.Margin = new System.Windows.Forms.Padding(2);
            this.totalSumTB.Multiline = true;
            this.totalSumTB.Name = "totalSumTB";
            this.totalSumTB.Size = new System.Drawing.Size(142, 35);
            this.totalSumTB.TabIndex = 0;
            // 
            // totalTransactionTB
            // 
            this.totalTransactionTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalTransactionTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTransactionTB.Enabled = false;
            this.totalTransactionTB.Font = new System.Drawing.Font("Tahoma", 17F);
            this.totalTransactionTB.Location = new System.Drawing.Point(142, 0);
            this.totalTransactionTB.Margin = new System.Windows.Forms.Padding(2);
            this.totalTransactionTB.Multiline = true;
            this.totalTransactionTB.Name = "totalTransactionTB";
            this.totalTransactionTB.Size = new System.Drawing.Size(142, 35);
            this.totalTransactionTB.TabIndex = 1;
            this.totalTransactionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalPriceTB
            // 
            this.totalPriceTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPriceTB.Enabled = false;
            this.totalPriceTB.Font = new System.Drawing.Font("Tahoma", 17F);
            this.totalPriceTB.Location = new System.Drawing.Point(281, 0);
            this.totalPriceTB.Margin = new System.Windows.Forms.Padding(2);
            this.totalPriceTB.Multiline = true;
            this.totalPriceTB.Name = "totalPriceTB";
            this.totalPriceTB.Size = new System.Drawing.Size(143, 34);
            this.totalPriceTB.TabIndex = 2;
            this.totalPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalCurencyTB
            // 
            this.totalCurencyTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalCurencyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalCurencyTB.Enabled = false;
            this.totalCurencyTB.Font = new System.Drawing.Font("Tahoma", 17F);
            this.totalCurencyTB.Location = new System.Drawing.Point(423, 0);
            this.totalCurencyTB.Margin = new System.Windows.Forms.Padding(2);
            this.totalCurencyTB.Multiline = true;
            this.totalCurencyTB.Name = "totalCurencyTB";
            this.totalCurencyTB.Size = new System.Drawing.Size(147, 34);
            this.totalCurencyTB.TabIndex = 2;
            this.totalCurencyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // topRightPanel
            // 
            this.topRightPanel.Controls.Add(this.userAccountMenuPanel);
            this.topRightPanel.Controls.Add(this.datesPanel);
            this.topRightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topRightPanel.Location = new System.Drawing.Point(0, 0);
            this.topRightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topRightPanel.Name = "topRightPanel";
            this.topRightPanel.Size = new System.Drawing.Size(570, 32);
            this.topRightPanel.TabIndex = 16;
            // 
            // userAccountMenuStrip
            // 
            this.userAccountMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.userAccountMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userAccountMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAccountMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.userAccountMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountToolStrip});
            this.userAccountMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.userAccountMenuStrip.Name = "userAccountMenuStrip";
            this.userAccountMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.userAccountMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userAccountMenuStrip.Size = new System.Drawing.Size(314, 32);
            this.userAccountMenuStrip.TabIndex = 0;
            this.userAccountMenuStrip.Text = "Hello World";
            // 
            // userAccountToolStrip
            // 
            this.userAccountToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountSettingsMenuItem,
            this.languageMenuItem,
            this.signOutMenuItem,
            this.closeMenuItem});
            this.userAccountToolStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userAccountToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("userAccountToolStrip.Image")));
            this.userAccountToolStrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userAccountToolStrip.Name = "userAccountToolStrip";
            this.userAccountToolStrip.Size = new System.Drawing.Size(105, 30);
            this.userAccountToolStrip.Text = "user name";
            this.userAccountToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // accountSettingsMenuItem
            // 
            this.accountSettingsMenuItem.Name = "accountSettingsMenuItem";
            this.accountSettingsMenuItem.Size = new System.Drawing.Size(193, 22);
            this.accountSettingsMenuItem.Text = "Настройка аккаунта";
            this.accountSettingsMenuItem.Click += new System.EventHandler(this.AccountSettingsMenuItem_Click);
            // 
            // languageMenuItem
            // 
            this.languageMenuItem.Name = "languageMenuItem";
            this.languageMenuItem.Size = new System.Drawing.Size(193, 22);
            this.languageMenuItem.Text = "Язык";
            // 
            // signOutMenuItem
            // 
            this.signOutMenuItem.Name = "signOutMenuItem";
            this.signOutMenuItem.Size = new System.Drawing.Size(193, 22);
            this.signOutMenuItem.Text = "Выйти";
            this.signOutMenuItem.Click += new System.EventHandler(this.SignOutMenuItem_Click);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(193, 22);
            this.closeMenuItem.Text = "Закрыть";
            this.closeMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // userAccountMenuPanel
            // 
            this.userAccountMenuPanel.Controls.Add(this.userAccountMenuStrip);
            this.userAccountMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAccountMenuPanel.Location = new System.Drawing.Point(256, 0);
            this.userAccountMenuPanel.Name = "userAccountMenuPanel";
            this.userAccountMenuPanel.Size = new System.Drawing.Size(314, 32);
            this.userAccountMenuPanel.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 428);
            this.Controls.Add(this.CenterSplitContainer);
            this.Controls.Add(this.bottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.miniToolStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.contractorsDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDGView)).EndInit();
            this.datesPanel.ResumeLayout(false);
            this.datesPanel.PerformLayout();
            this.contractorsCBoxPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.controlBtnsPanel.ResumeLayout(false);
            this.CenterSplitContainer.Panel1.ResumeLayout(false);
            this.CenterSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CenterSplitContainer)).EndInit();
            this.CenterSplitContainer.ResumeLayout(false);
            this.contractorDGVPanel.ResumeLayout(false);
            this.topLeftPanel.ResumeLayout(false);
            this.contractorContextMenu.ResumeLayout(false);
            this.transactionsDGVPanel.ResumeLayout(false);
            this.totalTransactionsPanel.ResumeLayout(false);
            this.totalTransactionsPanel.PerformLayout();
            this.topRightPanel.ResumeLayout(false);
            this.userAccountMenuStrip.ResumeLayout(false);
            this.userAccountMenuStrip.PerformLayout();
            this.userAccountMenuPanel.ResumeLayout(false);
            this.userAccountMenuPanel.PerformLayout();
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
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.SplitContainer CenterSplitContainer;
        private System.Windows.Forms.Panel contractorsCBoxPanel;
        private Controls.GMRButton addBtn;
        private Controls.GMRButton closeBtn;
        private Controls.GMRButton printBtn;
        private Controls.GMRButton deleteBtn;
        private System.Windows.Forms.Panel controlBtnsPanel;
        private System.Windows.Forms.Panel personPanel;
        private System.Windows.Forms.ContextMenuStrip contractorContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addTransactionsToolStripMenuItem;
        private ToolStripMenuItem renameContractorToolStripMenuItem;
        private ToolStripMenuItem removeContractorToolStripMenuItem;
        private Panel datesPanel;
        private Panel topLeftPanel;
        private Panel contractorDGVPanel;
        private Panel transactionsDGVPanel;
        private Panel topRightPanel;
        private Panel userAccountMenuPanel;
        private MenuStrip userAccountMenuStrip;
        private ToolStripMenuItem userAccountToolStrip;
        private ToolStripMenuItem accountSettingsMenuItem;
        private ToolStripMenuItem languageMenuItem;
        private ToolStripMenuItem signOutMenuItem;
        private ToolStripMenuItem closeMenuItem;
        private Panel totalTransactionsPanel;
        private TextBox totalCurencyTB;
        private TextBox totalPriceTB;
        private TextBox totalTransactionTB;
        private TextBox totalSumTB;
        private MenuStrip miniToolStrip;
    }
}