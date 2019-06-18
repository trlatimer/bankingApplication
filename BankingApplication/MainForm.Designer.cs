namespace BankingApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.mainLogoutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainTransactionButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainAccountButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewAccounButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMemberButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openAccountButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mainReportButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mainManageButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mainFooter = new System.Windows.Forms.GroupBox();
            this.mainFooterUserLabel = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.memberIDNum = new System.Windows.Forms.Label();
            this.memberSSN = new System.Windows.Forms.Label();
            this.memberEmail = new System.Windows.Forms.Label();
            this.memberEmailLabel = new System.Windows.Forms.Label();
            this.memberHome = new System.Windows.Forms.Label();
            this.memberHomeLabel = new System.Windows.Forms.Label();
            this.memberCell = new System.Windows.Forms.Label();
            this.memberCellLabel = new System.Windows.Forms.Label();
            this.memberMailAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.memberMailCityStateZip = new System.Windows.Forms.Label();
            this.memberMailStreet = new System.Windows.Forms.Label();
            this.memberAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.memberCityStateZip = new System.Windows.Forms.Label();
            this.memberStreet = new System.Windows.Forms.Label();
            this.memberSSNLabel = new System.Windows.Forms.Label();
            this.memberDOB = new System.Windows.Forms.Label();
            this.memberIDNumLabel = new System.Windows.Forms.Label();
            this.memberDOBLabel = new System.Windows.Forms.Label();
            this.memberName = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.memberInfoLabel = new System.Windows.Forms.Label();
            this.memberAccountDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.memberAccountsButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openShareButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openLoanButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountButton = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAccountButton = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.memberButtons = new System.Windows.Forms.ToolStripDropDownButton();
            this.editMemberButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip.SuspendLayout();
            this.mainFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.memberMailAddressGroupBox.SuspendLayout();
            this.memberAddressGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.toolStripSeparator1,
            this.mainTransactionButton,
            this.toolStripSeparator2,
            this.mainAccountButton,
            this.toolStripSeparator3,
            this.mainReportButton,
            this.toolStripSeparator5,
            this.mainManageButton,
            this.toolStripSeparator4});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.mainToolStrip.Size = new System.Drawing.Size(796, 28);
            this.mainToolStrip.Stretch = true;
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "mainToolStrip";
            // 
            // mainLogoutButton
            // 
            this.mainLogoutButton.BackColor = System.Drawing.Color.LightGray;
            this.mainLogoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainLogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("mainLogoutButton.Image")));
            this.mainLogoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainLogoutButton.Name = "mainLogoutButton";
            this.mainLogoutButton.Size = new System.Drawing.Size(53, 21);
            this.mainLogoutButton.Text = "Logout";
            this.mainLogoutButton.Click += new System.EventHandler(this.mainLogoutButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // mainTransactionButton
            // 
            this.mainTransactionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainTransactionButton.Image = ((System.Drawing.Image)(resources.GetObject("mainTransactionButton.Image")));
            this.mainTransactionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainTransactionButton.Name = "mainTransactionButton";
            this.mainTransactionButton.Size = new System.Drawing.Size(129, 21);
            this.mainTransactionButton.Text = "Perform Transaction";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // mainAccountButton
            // 
            this.mainAccountButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainAccountButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAccounButton,
            this.AddMemberButton,
            this.openAccountButton});
            this.mainAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("mainAccountButton.Image")));
            this.mainAccountButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainAccountButton.Name = "mainAccountButton";
            this.mainAccountButton.Size = new System.Drawing.Size(124, 21);
            this.mainAccountButton.Text = "Account Manager";
            // 
            // viewAccounButton
            // 
            this.viewAccounButton.Name = "viewAccounButton";
            this.viewAccounButton.Size = new System.Drawing.Size(206, 22);
            this.viewAccounButton.Text = "View/Manage Account";
            this.viewAccounButton.Click += new System.EventHandler(this.ViewAccounButton_Click);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(206, 22);
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // openAccountButton
            // 
            this.openAccountButton.Name = "openAccountButton";
            this.openAccountButton.Size = new System.Drawing.Size(206, 22);
            this.openAccountButton.Text = "Open Account";
            this.openAccountButton.Click += new System.EventHandler(this.openShareToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 24);
            // 
            // mainReportButton
            // 
            this.mainReportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainReportButton.Image = ((System.Drawing.Image)(resources.GetObject("mainReportButton.Image")));
            this.mainReportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainReportButton.Name = "mainReportButton";
            this.mainReportButton.Size = new System.Drawing.Size(58, 21);
            this.mainReportButton.Text = "Reports";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 24);
            // 
            // mainManageButton
            // 
            this.mainManageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainManageButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.mainManageButton.Image = ((System.Drawing.Image)(resources.GetObject("mainManageButton.Image")));
            this.mainManageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainManageButton.Name = "mainManageButton";
            this.mainManageButton.Size = new System.Drawing.Size(129, 21);
            this.mainManageButton.Text = "User Management";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editUserToolStripMenuItem.Text = "Edit User";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 24);
            // 
            // mainFooter
            // 
            this.mainFooter.AutoSize = true;
            this.mainFooter.Controls.Add(this.mainFooterUserLabel);
            this.mainFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainFooter.Location = new System.Drawing.Point(0, 477);
            this.mainFooter.Name = "mainFooter";
            this.mainFooter.Size = new System.Drawing.Size(796, 32);
            this.mainFooter.TabIndex = 2;
            this.mainFooter.TabStop = false;
            // 
            // mainFooterUserLabel
            // 
            this.mainFooterUserLabel.AutoSize = true;
            this.mainFooterUserLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainFooterUserLabel.Location = new System.Drawing.Point(3, 16);
            this.mainFooterUserLabel.Name = "mainFooterUserLabel";
            this.mainFooterUserLabel.Size = new System.Drawing.Size(94, 13);
            this.mainFooterUserLabel.TabIndex = 0;
            this.mainFooterUserLabel.Text = "Current User: User";
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainContainer.Location = new System.Drawing.Point(12, 48);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.AutoScroll = true;
            this.mainContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.mainContainer.Panel1.Controls.Add(this.memberIDNum);
            this.mainContainer.Panel1.Controls.Add(this.memberSSN);
            this.mainContainer.Panel1.Controls.Add(this.memberEmail);
            this.mainContainer.Panel1.Controls.Add(this.memberEmailLabel);
            this.mainContainer.Panel1.Controls.Add(this.memberHome);
            this.mainContainer.Panel1.Controls.Add(this.memberHomeLabel);
            this.mainContainer.Panel1.Controls.Add(this.memberCell);
            this.mainContainer.Panel1.Controls.Add(this.memberCellLabel);
            this.mainContainer.Panel1.Controls.Add(this.memberMailAddressGroupBox);
            this.mainContainer.Panel1.Controls.Add(this.memberAddressGroupBox);
            this.mainContainer.Panel1.Controls.Add(this.memberSSNLabel);
            this.mainContainer.Panel1.Controls.Add(this.memberDOB);
            this.mainContainer.Panel1.Controls.Add(this.memberIDNumLabel);
            this.mainContainer.Panel1.Controls.Add(this.memberDOBLabel);
            this.mainContainer.Panel1.Controls.Add(this.memberName);
            this.mainContainer.Panel1.Controls.Add(this.memberNameLabel);
            this.mainContainer.Panel1.Controls.Add(this.memberInfoLabel);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.AutoScroll = true;
            this.mainContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.mainContainer.Panel2.Controls.Add(this.memberAccountDetails);
            this.mainContainer.Panel2.Controls.Add(this.dataGridView1);
            this.mainContainer.Panel2.Controls.Add(this.toolStrip1);
            this.mainContainer.Size = new System.Drawing.Size(772, 423);
            this.mainContainer.SplitterDistance = 257;
            this.mainContainer.TabIndex = 4;
            // 
            // memberIDNum
            // 
            this.memberIDNum.AutoSize = true;
            this.memberIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDNum.Location = new System.Drawing.Point(67, 107);
            this.memberIDNum.Name = "memberIDNum";
            this.memberIDNum.Size = new System.Drawing.Size(0, 16);
            this.memberIDNum.TabIndex = 16;
            // 
            // memberSSN
            // 
            this.memberSSN.AutoSize = true;
            this.memberSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSSN.Location = new System.Drawing.Point(186, 80);
            this.memberSSN.Name = "memberSSN";
            this.memberSSN.Size = new System.Drawing.Size(0, 16);
            this.memberSSN.TabIndex = 15;
            // 
            // memberEmail
            // 
            this.memberEmail.AutoSize = true;
            this.memberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberEmail.Location = new System.Drawing.Point(67, 188);
            this.memberEmail.Name = "memberEmail";
            this.memberEmail.Size = new System.Drawing.Size(0, 16);
            this.memberEmail.TabIndex = 14;
            // 
            // memberEmailLabel
            // 
            this.memberEmailLabel.AutoSize = true;
            this.memberEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberEmailLabel.Location = new System.Drawing.Point(13, 188);
            this.memberEmailLabel.Name = "memberEmailLabel";
            this.memberEmailLabel.Size = new System.Drawing.Size(45, 16);
            this.memberEmailLabel.TabIndex = 13;
            this.memberEmailLabel.Text = "Email:";
            // 
            // memberHome
            // 
            this.memberHome.AutoSize = true;
            this.memberHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberHome.Location = new System.Drawing.Point(67, 162);
            this.memberHome.Name = "memberHome";
            this.memberHome.Size = new System.Drawing.Size(0, 16);
            this.memberHome.TabIndex = 12;
            // 
            // memberHomeLabel
            // 
            this.memberHomeLabel.AutoSize = true;
            this.memberHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberHomeLabel.Location = new System.Drawing.Point(13, 162);
            this.memberHomeLabel.Name = "memberHomeLabel";
            this.memberHomeLabel.Size = new System.Drawing.Size(48, 16);
            this.memberHomeLabel.TabIndex = 11;
            this.memberHomeLabel.Text = "Home:";
            // 
            // memberCell
            // 
            this.memberCell.AutoSize = true;
            this.memberCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberCell.Location = new System.Drawing.Point(67, 134);
            this.memberCell.Name = "memberCell";
            this.memberCell.Size = new System.Drawing.Size(0, 16);
            this.memberCell.TabIndex = 10;
            // 
            // memberCellLabel
            // 
            this.memberCellLabel.AutoSize = true;
            this.memberCellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberCellLabel.Location = new System.Drawing.Point(13, 134);
            this.memberCellLabel.Name = "memberCellLabel";
            this.memberCellLabel.Size = new System.Drawing.Size(34, 16);
            this.memberCellLabel.TabIndex = 9;
            this.memberCellLabel.Text = "Cell:";
            // 
            // memberMailAddressGroupBox
            // 
            this.memberMailAddressGroupBox.Controls.Add(this.memberMailCityStateZip);
            this.memberMailAddressGroupBox.Controls.Add(this.memberMailStreet);
            this.memberMailAddressGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberMailAddressGroupBox.Location = new System.Drawing.Point(16, 317);
            this.memberMailAddressGroupBox.Name = "memberMailAddressGroupBox";
            this.memberMailAddressGroupBox.Size = new System.Drawing.Size(224, 82);
            this.memberMailAddressGroupBox.TabIndex = 8;
            this.memberMailAddressGroupBox.TabStop = false;
            this.memberMailAddressGroupBox.Text = "Mailing Address";
            // 
            // memberMailCityStateZip
            // 
            this.memberMailCityStateZip.AutoSize = true;
            this.memberMailCityStateZip.Location = new System.Drawing.Point(7, 55);
            this.memberMailCityStateZip.Name = "memberMailCityStateZip";
            this.memberMailCityStateZip.Size = new System.Drawing.Size(0, 16);
            this.memberMailCityStateZip.TabIndex = 1;
            // 
            // memberMailStreet
            // 
            this.memberMailStreet.AutoSize = true;
            this.memberMailStreet.Location = new System.Drawing.Point(7, 28);
            this.memberMailStreet.Name = "memberMailStreet";
            this.memberMailStreet.Size = new System.Drawing.Size(0, 16);
            this.memberMailStreet.TabIndex = 0;
            // 
            // memberAddressGroupBox
            // 
            this.memberAddressGroupBox.Controls.Add(this.memberCityStateZip);
            this.memberAddressGroupBox.Controls.Add(this.memberStreet);
            this.memberAddressGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberAddressGroupBox.Location = new System.Drawing.Point(16, 221);
            this.memberAddressGroupBox.Name = "memberAddressGroupBox";
            this.memberAddressGroupBox.Size = new System.Drawing.Size(224, 81);
            this.memberAddressGroupBox.TabIndex = 7;
            this.memberAddressGroupBox.TabStop = false;
            this.memberAddressGroupBox.Text = "Address";
            // 
            // memberCityStateZip
            // 
            this.memberCityStateZip.AutoSize = true;
            this.memberCityStateZip.Location = new System.Drawing.Point(7, 54);
            this.memberCityStateZip.Name = "memberCityStateZip";
            this.memberCityStateZip.Size = new System.Drawing.Size(0, 16);
            this.memberCityStateZip.TabIndex = 1;
            // 
            // memberStreet
            // 
            this.memberStreet.AutoSize = true;
            this.memberStreet.Location = new System.Drawing.Point(7, 28);
            this.memberStreet.Name = "memberStreet";
            this.memberStreet.Size = new System.Drawing.Size(0, 16);
            this.memberStreet.TabIndex = 0;
            // 
            // memberSSNLabel
            // 
            this.memberSSNLabel.AutoSize = true;
            this.memberSSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSSNLabel.Location = new System.Drawing.Point(141, 80);
            this.memberSSNLabel.Name = "memberSSNLabel";
            this.memberSSNLabel.Size = new System.Drawing.Size(39, 16);
            this.memberSSNLabel.TabIndex = 6;
            this.memberSSNLabel.Text = "SSN:";
            // 
            // memberDOB
            // 
            this.memberDOB.AutoSize = true;
            this.memberDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDOB.Location = new System.Drawing.Point(67, 80);
            this.memberDOB.Name = "memberDOB";
            this.memberDOB.Size = new System.Drawing.Size(0, 16);
            this.memberDOB.TabIndex = 5;
            // 
            // memberIDNumLabel
            // 
            this.memberIDNumLabel.AutoSize = true;
            this.memberIDNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDNumLabel.Location = new System.Drawing.Point(13, 107);
            this.memberIDNumLabel.Name = "memberIDNumLabel";
            this.memberIDNumLabel.Size = new System.Drawing.Size(34, 16);
            this.memberIDNumLabel.TabIndex = 4;
            this.memberIDNumLabel.Text = "ID #:";
            // 
            // memberDOBLabel
            // 
            this.memberDOBLabel.AutoSize = true;
            this.memberDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDOBLabel.Location = new System.Drawing.Point(13, 80);
            this.memberDOBLabel.Name = "memberDOBLabel";
            this.memberDOBLabel.Size = new System.Drawing.Size(40, 16);
            this.memberDOBLabel.TabIndex = 3;
            this.memberDOBLabel.Text = "DOB:";
            // 
            // memberName
            // 
            this.memberName.AutoSize = true;
            this.memberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberName.Location = new System.Drawing.Point(67, 53);
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(0, 16);
            this.memberName.TabIndex = 2;
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLabel.Location = new System.Drawing.Point(13, 53);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(48, 16);
            this.memberNameLabel.TabIndex = 1;
            this.memberNameLabel.Text = "Name:";
            // 
            // memberInfoLabel
            // 
            this.memberInfoLabel.AutoSize = true;
            this.memberInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInfoLabel.Location = new System.Drawing.Point(44, 10);
            this.memberInfoLabel.Name = "memberInfoLabel";
            this.memberInfoLabel.Size = new System.Drawing.Size(178, 24);
            this.memberInfoLabel.TabIndex = 0;
            this.memberInfoLabel.Text = "Member Information";
            // 
            // memberAccountDetails
            // 
            this.memberAccountDetails.Location = new System.Drawing.Point(17, 249);
            this.memberAccountDetails.Name = "memberAccountDetails";
            this.memberAccountDetails.Size = new System.Drawing.Size(475, 150);
            this.memberAccountDetails.TabIndex = 2;
            this.memberAccountDetails.TabStop = false;
            this.memberAccountDetails.Text = "Account Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 202);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberAccountsButton,
            this.memberButtons});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(509, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // memberAccountsButton
            // 
            this.memberAccountsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.memberAccountsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openShareButton,
            this.openLoanButton,
            this.editAccountButton,
            this.closeAccountButton,
            this.viewTransactionsButton});
            this.memberAccountsButton.Image = ((System.Drawing.Image)(resources.GetObject("memberAccountsButton.Image")));
            this.memberAccountsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.memberAccountsButton.Name = "memberAccountsButton";
            this.memberAccountsButton.Size = new System.Drawing.Size(70, 22);
            this.memberAccountsButton.Text = "Accounts";
            // 
            // openShareButton
            // 
            this.openShareButton.Name = "openShareButton";
            this.openShareButton.Size = new System.Drawing.Size(168, 22);
            this.openShareButton.Text = "Open Share";
            // 
            // openLoanButton
            // 
            this.openLoanButton.Name = "openLoanButton";
            this.openLoanButton.Size = new System.Drawing.Size(168, 22);
            this.openLoanButton.Text = "Open Loan";
            // 
            // editAccountButton
            // 
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(168, 22);
            this.editAccountButton.Text = "Edit  an Account";
            // 
            // closeAccountButton
            // 
            this.closeAccountButton.Name = "closeAccountButton";
            this.closeAccountButton.Size = new System.Drawing.Size(168, 22);
            this.closeAccountButton.Text = "Close an Account";
            // 
            // viewTransactionsButton
            // 
            this.viewTransactionsButton.Name = "viewTransactionsButton";
            this.viewTransactionsButton.Size = new System.Drawing.Size(168, 22);
            this.viewTransactionsButton.Text = "View Transactions";
            // 
            // memberButtons
            // 
            this.memberButtons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.memberButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMemberButton,
            this.deleteMemberButton});
            this.memberButtons.Image = ((System.Drawing.Image)(resources.GetObject("memberButtons.Image")));
            this.memberButtons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.memberButtons.Name = "memberButtons";
            this.memberButtons.Size = new System.Drawing.Size(65, 22);
            this.memberButtons.Text = "Member";
            // 
            // editMemberButton
            // 
            this.editMemberButton.Name = "editMemberButton";
            this.editMemberButton.Size = new System.Drawing.Size(155, 22);
            this.editMemberButton.Text = "Edit Member";
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(155, 22);
            this.deleteMemberButton.Text = "Delete Member";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(796, 509);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.mainFooter);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Banking App | Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainFooter.ResumeLayout(false);
            this.mainFooter.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            this.mainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.memberMailAddressGroupBox.ResumeLayout(false);
            this.memberMailAddressGroupBox.PerformLayout();
            this.memberAddressGroupBox.ResumeLayout(false);
            this.memberAddressGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton mainLogoutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mainTransactionButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton mainReportButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.GroupBox mainFooter;
        private System.Windows.Forms.Label mainFooterUserLabel;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.ToolStripDropDownButton mainAccountButton;
        private System.Windows.Forms.ToolStripMenuItem viewAccounButton;
        private System.Windows.Forms.ToolStripMenuItem openAccountButton;
        private System.Windows.Forms.ToolStripMenuItem AddMemberButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton mainManageButton;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton memberAccountsButton;
        private System.Windows.Forms.ToolStripMenuItem openShareButton;
        private System.Windows.Forms.ToolStripMenuItem openLoanButton;
        private System.Windows.Forms.ToolStripMenuItem editAccountButton;
        private System.Windows.Forms.ToolStripMenuItem closeAccountButton;
        private System.Windows.Forms.ToolStripDropDownButton memberButtons;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionsButton;
        private System.Windows.Forms.ToolStripMenuItem editMemberButton;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberButton;
        private System.Windows.Forms.Label memberInfoLabel;
        private System.Windows.Forms.Label memberIDNum;
        private System.Windows.Forms.Label memberSSN;
        private System.Windows.Forms.Label memberEmail;
        private System.Windows.Forms.Label memberEmailLabel;
        private System.Windows.Forms.Label memberHome;
        private System.Windows.Forms.Label memberHomeLabel;
        private System.Windows.Forms.Label memberCell;
        private System.Windows.Forms.Label memberCellLabel;
        private System.Windows.Forms.GroupBox memberMailAddressGroupBox;
        private System.Windows.Forms.Label memberMailCityStateZip;
        private System.Windows.Forms.Label memberMailStreet;
        private System.Windows.Forms.GroupBox memberAddressGroupBox;
        private System.Windows.Forms.Label memberCityStateZip;
        private System.Windows.Forms.Label memberStreet;
        private System.Windows.Forms.Label memberSSNLabel;
        private System.Windows.Forms.Label memberDOB;
        private System.Windows.Forms.Label memberIDNumLabel;
        private System.Windows.Forms.Label memberDOBLabel;
        private System.Windows.Forms.Label memberName;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.GroupBox memberAccountDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}