namespace BankingApplication
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.mainLogoutButton = new System.Windows.Forms.ToolStripButton();
            this.mainTransactionButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.transactionDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.transactionTypeLabel = new System.Windows.Forms.Label();
            this.accountNum = new System.Windows.Forms.Label();
            this.accountNumLabel = new System.Windows.Forms.Label();
            this.sessionDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.sessionVariance = new System.Windows.Forms.Label();
            this.sessionVarianceLabel = new System.Windows.Forms.Label();
            this.sessionDebits = new System.Windows.Forms.Label();
            this.sessionDebitsLabel = new System.Windows.Forms.Label();
            this.sessionCredits = new System.Windows.Forms.Label();
            this.sessionCreditsLabel = new System.Windows.Forms.Label();
            this.accountsSum = new System.Windows.Forms.Label();
            this.accountSumNumLabel = new System.Windows.Forms.Label();
            this.sessionItemTotal = new System.Windows.Forms.Label();
            this.sessionNumLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionTitle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addTransactionButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.depositButton = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.transferButton = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editTransactionButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.transactionType = new System.Windows.Forms.Label();
            this.transactionAmountLabel = new System.Windows.Forms.Label();
            this.transactionAmount = new System.Windows.Forms.Label();
            this.transactionDestIDLabel = new System.Windows.Forms.Label();
            this.transactionDestID = new System.Windows.Forms.Label();
            this.transactionDestAcctLabel = new System.Windows.Forms.Label();
            this.transactionDestAcct = new System.Windows.Forms.Label();
            this.depositPanel = new System.Windows.Forms.Panel();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.depositAmountTextBox = new System.Windows.Forms.TextBox();
            this.depositExchangeTypeLabel = new System.Windows.Forms.Label();
            this.depositExchangeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.depositTitle = new System.Windows.Forms.Label();
            this.depositAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.transactionDetailsGroupBox.SuspendLayout();
            this.sessionDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.depositPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AllowMerge = false;
            this.mainToolStrip.BackColor = System.Drawing.Color.LightGray;
            this.mainToolStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainLogoutButton,
            this.toolStripSeparator4,
            this.mainTransactionButton,
            this.toolStripSeparator3});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.mainToolStrip.Size = new System.Drawing.Size(644, 28);
            this.mainToolStrip.Stretch = true;
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "mainToolStrip";
            // 
            // mainLogoutButton
            // 
            this.mainLogoutButton.BackColor = System.Drawing.Color.LightGray;
            this.mainLogoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainLogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("mainLogoutButton.Image")));
            this.mainLogoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainLogoutButton.Name = "mainLogoutButton";
            this.mainLogoutButton.Size = new System.Drawing.Size(50, 21);
            this.mainLogoutButton.Text = "Cancel";
            // 
            // mainTransactionButton
            // 
            this.mainTransactionButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mainTransactionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainTransactionButton.Image = ((System.Drawing.Image)(resources.GetObject("mainTransactionButton.Image")));
            this.mainTransactionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainTransactionButton.Name = "mainTransactionButton";
            this.mainTransactionButton.Size = new System.Drawing.Size(128, 21);
            this.mainTransactionButton.Text = "Submit Transactions";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 392);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.transactionDetailsGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.sessionDetailsGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.transactionTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.depositPanel);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(619, 392);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // transactionDetailsGroupBox
            // 
            this.transactionDetailsGroupBox.Controls.Add(this.transactionDestAcct);
            this.transactionDetailsGroupBox.Controls.Add(this.transactionDestAcctLabel);
            this.transactionDetailsGroupBox.Controls.Add(this.transactionDestID);
            this.transactionDetailsGroupBox.Controls.Add(this.transactionDestIDLabel);
            this.transactionDetailsGroupBox.Controls.Add(this.transactionAmount);
            this.transactionDetailsGroupBox.Controls.Add(this.transactionAmountLabel);
            this.transactionDetailsGroupBox.Controls.Add(this.transactionType);
            this.transactionDetailsGroupBox.Controls.Add(this.transactionTypeLabel);
            this.transactionDetailsGroupBox.Controls.Add(this.accountNum);
            this.transactionDetailsGroupBox.Controls.Add(this.accountNumLabel);
            this.transactionDetailsGroupBox.Location = new System.Drawing.Point(21, 189);
            this.transactionDetailsGroupBox.Name = "transactionDetailsGroupBox";
            this.transactionDetailsGroupBox.Size = new System.Drawing.Size(216, 96);
            this.transactionDetailsGroupBox.TabIndex = 3;
            this.transactionDetailsGroupBox.TabStop = false;
            this.transactionDetailsGroupBox.Text = "Transaction Details";
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Location = new System.Drawing.Point(7, 43);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.transactionTypeLabel.TabIndex = 2;
            this.transactionTypeLabel.Text = "Type:";
            // 
            // accountNum
            // 
            this.accountNum.AutoSize = true;
            this.accountNum.Location = new System.Drawing.Point(82, 20);
            this.accountNum.Name = "accountNum";
            this.accountNum.Size = new System.Drawing.Size(0, 13);
            this.accountNum.TabIndex = 1;
            // 
            // accountNumLabel
            // 
            this.accountNumLabel.AutoSize = true;
            this.accountNumLabel.Location = new System.Drawing.Point(7, 20);
            this.accountNumLabel.Name = "accountNumLabel";
            this.accountNumLabel.Size = new System.Drawing.Size(60, 13);
            this.accountNumLabel.TabIndex = 0;
            this.accountNumLabel.Text = "Account #:";
            // 
            // sessionDetailsGroupBox
            // 
            this.sessionDetailsGroupBox.Controls.Add(this.sessionVariance);
            this.sessionDetailsGroupBox.Controls.Add(this.sessionVarianceLabel);
            this.sessionDetailsGroupBox.Controls.Add(this.sessionDebits);
            this.sessionDetailsGroupBox.Controls.Add(this.sessionDebitsLabel);
            this.sessionDetailsGroupBox.Controls.Add(this.sessionCredits);
            this.sessionDetailsGroupBox.Controls.Add(this.sessionCreditsLabel);
            this.sessionDetailsGroupBox.Controls.Add(this.accountsSum);
            this.sessionDetailsGroupBox.Controls.Add(this.accountSumNumLabel);
            this.sessionDetailsGroupBox.Controls.Add(this.sessionItemTotal);
            this.sessionDetailsGroupBox.Controls.Add(this.sessionNumLabel);
            this.sessionDetailsGroupBox.Location = new System.Drawing.Point(21, 291);
            this.sessionDetailsGroupBox.Name = "sessionDetailsGroupBox";
            this.sessionDetailsGroupBox.Size = new System.Drawing.Size(216, 89);
            this.sessionDetailsGroupBox.TabIndex = 2;
            this.sessionDetailsGroupBox.TabStop = false;
            this.sessionDetailsGroupBox.Text = "Session Details";
            this.sessionDetailsGroupBox.Enter += new System.EventHandler(this.SessionDetailsGroupBox_Enter);
            // 
            // sessionVariance
            // 
            this.sessionVariance.AutoSize = true;
            this.sessionVariance.Location = new System.Drawing.Point(99, 65);
            this.sessionVariance.Name = "sessionVariance";
            this.sessionVariance.Size = new System.Drawing.Size(0, 13);
            this.sessionVariance.TabIndex = 9;
            // 
            // sessionVarianceLabel
            // 
            this.sessionVarianceLabel.AutoSize = true;
            this.sessionVarianceLabel.Location = new System.Drawing.Point(4, 65);
            this.sessionVarianceLabel.Name = "sessionVarianceLabel";
            this.sessionVarianceLabel.Size = new System.Drawing.Size(52, 13);
            this.sessionVarianceLabel.TabIndex = 8;
            this.sessionVarianceLabel.Text = "Variance:";
            // 
            // sessionDebits
            // 
            this.sessionDebits.AutoSize = true;
            this.sessionDebits.Location = new System.Drawing.Point(145, 40);
            this.sessionDebits.Name = "sessionDebits";
            this.sessionDebits.Size = new System.Drawing.Size(0, 13);
            this.sessionDebits.TabIndex = 7;
            // 
            // sessionDebitsLabel
            // 
            this.sessionDebitsLabel.AutoSize = true;
            this.sessionDebitsLabel.Location = new System.Drawing.Point(99, 40);
            this.sessionDebitsLabel.Name = "sessionDebitsLabel";
            this.sessionDebitsLabel.Size = new System.Drawing.Size(40, 13);
            this.sessionDebitsLabel.TabIndex = 6;
            this.sessionDebitsLabel.Text = "Debits:";
            // 
            // sessionCredits
            // 
            this.sessionCredits.AutoSize = true;
            this.sessionCredits.Location = new System.Drawing.Point(52, 40);
            this.sessionCredits.Name = "sessionCredits";
            this.sessionCredits.Size = new System.Drawing.Size(0, 13);
            this.sessionCredits.TabIndex = 5;
            // 
            // sessionCreditsLabel
            // 
            this.sessionCreditsLabel.AutoSize = true;
            this.sessionCreditsLabel.Location = new System.Drawing.Point(4, 40);
            this.sessionCreditsLabel.Name = "sessionCreditsLabel";
            this.sessionCreditsLabel.Size = new System.Drawing.Size(42, 13);
            this.sessionCreditsLabel.TabIndex = 4;
            this.sessionCreditsLabel.Text = "Credits:";
            // 
            // accountsSum
            // 
            this.accountsSum.AutoSize = true;
            this.accountsSum.Location = new System.Drawing.Point(160, 16);
            this.accountsSum.Name = "accountsSum";
            this.accountsSum.Size = new System.Drawing.Size(0, 13);
            this.accountsSum.TabIndex = 3;
            // 
            // accountSumNumLabel
            // 
            this.accountSumNumLabel.AutoSize = true;
            this.accountSumNumLabel.Location = new System.Drawing.Point(99, 16);
            this.accountSumNumLabel.Name = "accountSumNumLabel";
            this.accountSumNumLabel.Size = new System.Drawing.Size(55, 13);
            this.accountSumNumLabel.TabIndex = 2;
            this.accountSumNumLabel.Text = "Accounts:";
            // 
            // sessionItemTotal
            // 
            this.sessionItemTotal.AutoSize = true;
            this.sessionItemTotal.Location = new System.Drawing.Point(67, 16);
            this.sessionItemTotal.Name = "sessionItemTotal";
            this.sessionItemTotal.Size = new System.Drawing.Size(0, 13);
            this.sessionItemTotal.TabIndex = 1;
            // 
            // sessionNumLabel
            // 
            this.sessionNumLabel.AutoSize = true;
            this.sessionNumLabel.Location = new System.Drawing.Point(4, 16);
            this.sessionNumLabel.Name = "sessionNumLabel";
            this.sessionNumLabel.Size = new System.Drawing.Size(57, 13);
            this.sessionNumLabel.TabIndex = 0;
            this.sessionNumLabel.Text = "# of Items:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(216, 122);
            this.dataGridView1.TabIndex = 1;
            // 
            // transactionTitle
            // 
            this.transactionTitle.AutoSize = true;
            this.transactionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTitle.Location = new System.Drawing.Point(16, 16);
            this.transactionTitle.Name = "transactionTitle";
            this.transactionTitle.Size = new System.Drawing.Size(221, 25);
            this.transactionTitle.TabIndex = 0;
            this.transactionTitle.Text = "Pending Transactions";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionButton,
            this.toolStripSeparator1,
            this.editTransactionButton,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(365, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addTransactionButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositButton,
            this.withdrawalButton,
            this.transferButton,
            this.paymentButton});
            this.addTransactionButton.Image = ((System.Drawing.Image)(resources.GetObject("addTransactionButton.Image")));
            this.addTransactionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(106, 22);
            this.addTransactionButton.Text = "Add Transaction";
            // 
            // depositButton
            // 
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(180, 22);
            this.depositButton.Text = "Deposit";
            this.depositButton.ToolTipText = "Deposit into an account";
            // 
            // withdrawalButton
            // 
            this.withdrawalButton.Name = "withdrawalButton";
            this.withdrawalButton.Size = new System.Drawing.Size(180, 22);
            this.withdrawalButton.Text = "Withdrawal";
            this.withdrawalButton.ToolTipText = "Withdraw from an account";
            // 
            // transferButton
            // 
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(180, 22);
            this.transferButton.Text = "Transfer";
            this.transferButton.ToolTipText = "Trasnfer between accounts";
            // 
            // paymentButton
            // 
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(180, 22);
            this.paymentButton.Text = "Payment";
            this.paymentButton.ToolTipText = "Make a payment on an account";
            // 
            // editTransactionButton
            // 
            this.editTransactionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editTransactionButton.Image = ((System.Drawing.Image)(resources.GetObject("editTransactionButton.Image")));
            this.editTransactionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editTransactionButton.Name = "editTransactionButton";
            this.editTransactionButton.Size = new System.Drawing.Size(31, 22);
            this.editTransactionButton.Text = "Edit";
            this.editTransactionButton.ToolTipText = "Edit selected transaction";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripDropDownButton1.Text = "Cancel";
            this.toolStripDropDownButton1.ToolTipText = "Cancel selected transaction";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 24);
            // 
            // transactionType
            // 
            this.transactionType.AutoSize = true;
            this.transactionType.Location = new System.Drawing.Point(47, 43);
            this.transactionType.Name = "transactionType";
            this.transactionType.Size = new System.Drawing.Size(0, 13);
            this.transactionType.TabIndex = 3;
            // 
            // transactionAmountLabel
            // 
            this.transactionAmountLabel.AutoSize = true;
            this.transactionAmountLabel.Location = new System.Drawing.Point(104, 43);
            this.transactionAmountLabel.Name = "transactionAmountLabel";
            this.transactionAmountLabel.Size = new System.Drawing.Size(46, 13);
            this.transactionAmountLabel.TabIndex = 4;
            this.transactionAmountLabel.Text = "Amount:";
            // 
            // transactionAmount
            // 
            this.transactionAmount.AutoSize = true;
            this.transactionAmount.Location = new System.Drawing.Point(160, 43);
            this.transactionAmount.Name = "transactionAmount";
            this.transactionAmount.Size = new System.Drawing.Size(0, 13);
            this.transactionAmount.TabIndex = 5;
            // 
            // transactionDestIDLabel
            // 
            this.transactionDestIDLabel.AutoSize = true;
            this.transactionDestIDLabel.Location = new System.Drawing.Point(7, 67);
            this.transactionDestIDLabel.Name = "transactionDestIDLabel";
            this.transactionDestIDLabel.Size = new System.Drawing.Size(49, 13);
            this.transactionDestIDLabel.TabIndex = 6;
            this.transactionDestIDLabel.Text = "Dest. ID:";
            // 
            // transactionDestID
            // 
            this.transactionDestID.AutoSize = true;
            this.transactionDestID.Location = new System.Drawing.Point(62, 67);
            this.transactionDestID.Name = "transactionDestID";
            this.transactionDestID.Size = new System.Drawing.Size(0, 13);
            this.transactionDestID.TabIndex = 7;
            // 
            // transactionDestAcctLabel
            // 
            this.transactionDestAcctLabel.AutoSize = true;
            this.transactionDestAcctLabel.Location = new System.Drawing.Point(104, 67);
            this.transactionDestAcctLabel.Name = "transactionDestAcctLabel";
            this.transactionDestAcctLabel.Size = new System.Drawing.Size(60, 13);
            this.transactionDestAcctLabel.TabIndex = 8;
            this.transactionDestAcctLabel.Text = "Dest. Acct:";
            // 
            // transactionDestAcct
            // 
            this.transactionDestAcct.AutoSize = true;
            this.transactionDestAcct.Location = new System.Drawing.Point(170, 67);
            this.transactionDestAcct.Name = "transactionDestAcct";
            this.transactionDestAcct.Size = new System.Drawing.Size(0, 13);
            this.transactionDestAcct.TabIndex = 9;
            // 
            // depositPanel
            // 
            this.depositPanel.Controls.Add(this.label1);
            this.depositPanel.Controls.Add(this.depositAddButton);
            this.depositPanel.Controls.Add(this.depositTitle);
            this.depositPanel.Controls.Add(this.dataGridView2);
            this.depositPanel.Controls.Add(this.depositExchangeTypeComboBox);
            this.depositPanel.Controls.Add(this.depositExchangeTypeLabel);
            this.depositPanel.Controls.Add(this.depositAmountTextBox);
            this.depositPanel.Controls.Add(this.depositAmountLabel);
            this.depositPanel.Location = new System.Drawing.Point(3, 28);
            this.depositPanel.Name = "depositPanel";
            this.depositPanel.Size = new System.Drawing.Size(359, 361);
            this.depositPanel.TabIndex = 1;
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.AutoSize = true;
            this.depositAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAmountLabel.Location = new System.Drawing.Point(46, 80);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(120, 16);
            this.depositAmountLabel.TabIndex = 0;
            this.depositAmountLabel.Text = "Amount to Deposit:";
            // 
            // depositAmountTextBox
            // 
            this.depositAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAmountTextBox.Location = new System.Drawing.Point(172, 77);
            this.depositAmountTextBox.Name = "depositAmountTextBox";
            this.depositAmountTextBox.Size = new System.Drawing.Size(104, 22);
            this.depositAmountTextBox.TabIndex = 1;
            // 
            // depositExchangeTypeLabel
            // 
            this.depositExchangeTypeLabel.AutoSize = true;
            this.depositExchangeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositExchangeTypeLabel.Location = new System.Drawing.Point(61, 114);
            this.depositExchangeTypeLabel.Name = "depositExchangeTypeLabel";
            this.depositExchangeTypeLabel.Size = new System.Drawing.Size(105, 16);
            this.depositExchangeTypeLabel.TabIndex = 2;
            this.depositExchangeTypeLabel.Text = "Type Received:";
            // 
            // depositExchangeTypeComboBox
            // 
            this.depositExchangeTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositExchangeTypeComboBox.FormattingEnabled = true;
            this.depositExchangeTypeComboBox.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Cashier\'s Check",
            "Money Order"});
            this.depositExchangeTypeComboBox.Location = new System.Drawing.Point(172, 111);
            this.depositExchangeTypeComboBox.Name = "depositExchangeTypeComboBox";
            this.depositExchangeTypeComboBox.Size = new System.Drawing.Size(104, 24);
            this.depositExchangeTypeComboBox.TabIndex = 3;
            this.depositExchangeTypeComboBox.Text = "--Type--";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(306, 124);
            this.dataGridView2.TabIndex = 4;
            // 
            // depositTitle
            // 
            this.depositTitle.AutoSize = true;
            this.depositTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositTitle.Location = new System.Drawing.Point(125, 14);
            this.depositTitle.Name = "depositTitle";
            this.depositTitle.Size = new System.Drawing.Size(85, 25);
            this.depositTitle.TabIndex = 5;
            this.depositTitle.Text = "Deposit";
            // 
            // depositAddButton
            // 
            this.depositAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAddButton.Location = new System.Drawing.Point(224, 303);
            this.depositAddButton.Name = "depositAddButton";
            this.depositAddButton.Size = new System.Drawing.Size(107, 23);
            this.depositAddButton.TabIndex = 6;
            this.depositAddButton.Text = "Add Deposit";
            this.depositAddButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Available Shares:";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(644, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "TransactionForm";
            this.Text = "Banking App | Transactions";
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.transactionDetailsGroupBox.ResumeLayout(false);
            this.transactionDetailsGroupBox.PerformLayout();
            this.sessionDetailsGroupBox.ResumeLayout(false);
            this.sessionDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.depositPanel.ResumeLayout(false);
            this.depositPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton mainLogoutButton;
        private System.Windows.Forms.ToolStripButton mainTransactionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox sessionDetailsGroupBox;
        private System.Windows.Forms.Label sessionVariance;
        private System.Windows.Forms.Label sessionVarianceLabel;
        private System.Windows.Forms.Label sessionDebits;
        private System.Windows.Forms.Label sessionDebitsLabel;
        private System.Windows.Forms.Label sessionCredits;
        private System.Windows.Forms.Label sessionCreditsLabel;
        private System.Windows.Forms.Label accountsSum;
        private System.Windows.Forms.Label accountSumNumLabel;
        private System.Windows.Forms.Label sessionItemTotal;
        private System.Windows.Forms.Label sessionNumLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label transactionTitle;
        private System.Windows.Forms.GroupBox transactionDetailsGroupBox;
        private System.Windows.Forms.Label transactionTypeLabel;
        private System.Windows.Forms.Label accountNum;
        private System.Windows.Forms.Label accountNumLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton addTransactionButton;
        private System.Windows.Forms.ToolStripMenuItem depositButton;
        private System.Windows.Forms.ToolStripMenuItem withdrawalButton;
        private System.Windows.Forms.ToolStripMenuItem transferButton;
        private System.Windows.Forms.ToolStripMenuItem paymentButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton editTransactionButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripDropDownButton1;
        private System.Windows.Forms.Label transactionDestAcct;
        private System.Windows.Forms.Label transactionDestAcctLabel;
        private System.Windows.Forms.Label transactionDestID;
        private System.Windows.Forms.Label transactionDestIDLabel;
        private System.Windows.Forms.Label transactionAmount;
        private System.Windows.Forms.Label transactionAmountLabel;
        private System.Windows.Forms.Label transactionType;
        private System.Windows.Forms.Panel depositPanel;
        private System.Windows.Forms.Label depositExchangeTypeLabel;
        private System.Windows.Forms.TextBox depositAmountTextBox;
        private System.Windows.Forms.Label depositAmountLabel;
        private System.Windows.Forms.Button depositAddButton;
        private System.Windows.Forms.Label depositTitle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox depositExchangeTypeComboBox;
        private System.Windows.Forms.Label label1;
    }
}