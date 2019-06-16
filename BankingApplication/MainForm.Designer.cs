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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mainReportButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mainFooter = new System.Windows.Forms.GroupBox();
            this.mainFooterUserLabel = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.mainAccountButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewAccounButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openAccountButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMemberButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainManageButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mainToolStrip.SuspendLayout();
            this.mainFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.SuspendLayout();
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
            this.mainTransactionButton.Click += new System.EventHandler(this.mainTransactionButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
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
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.mainContainer.Size = new System.Drawing.Size(772, 423);
            this.mainContainer.SplitterDistance = 257;
            this.mainContainer.TabIndex = 4;
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
            // 
            // openAccountButton
            // 
            this.openAccountButton.Name = "openAccountButton";
            this.openAccountButton.Size = new System.Drawing.Size(206, 22);
            this.openAccountButton.Text = "Open Account";
            this.openAccountButton.Click += new System.EventHandler(this.openShareToolStripMenuItem_Click);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(206, 22);
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // mainManageButton
            // 
            this.mainManageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainManageButton.Image = ((System.Drawing.Image)(resources.GetObject("mainManageButton.Image")));
            this.mainManageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainManageButton.Name = "mainManageButton";
            this.mainManageButton.Size = new System.Drawing.Size(120, 21);
            this.mainManageButton.Text = "User Management";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 24);
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
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton mainManageButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}