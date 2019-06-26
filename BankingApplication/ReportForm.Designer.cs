namespace BankingApplication
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.reportsBackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.generateReportButton = new System.Windows.Forms.ToolStripSplitButton();
            this.allMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allMembersReportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.allAccountsReportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.allSharesReportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.allLoansReportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.allAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closedSharesReportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.closedLoansReportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTextBox = new System.Windows.Forms.RichTextBox();
            this.currentReportTitle = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsBackButton,
            this.toolStripSeparator1,
            this.generateReportButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(733, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // reportsBackButton
            // 
            this.reportsBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reportsBackButton.Image = ((System.Drawing.Image)(resources.GetObject("reportsBackButton.Image")));
            this.reportsBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportsBackButton.Name = "reportsBackButton";
            this.reportsBackButton.Size = new System.Drawing.Size(36, 22);
            this.reportsBackButton.Text = "Back";
            this.reportsBackButton.ToolTipText = "Return to Main";
            this.reportsBackButton.Click += new System.EventHandler(this.ReportsBackButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // generateReportButton
            // 
            this.generateReportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.generateReportButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allMembersToolStripMenuItem,
            this.allAccountsToolStripMenuItem});
            this.generateReportButton.Image = ((System.Drawing.Image)(resources.GetObject("generateReportButton.Image")));
            this.generateReportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(108, 22);
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.ToolTipText = "Generate  a report";
            // 
            // allMembersToolStripMenuItem
            // 
            this.allMembersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allMembersReportButton,
            this.allAccountsReportButton,
            this.allSharesReportButton,
            this.allLoansReportButton});
            this.allMembersToolStripMenuItem.Name = "allMembersToolStripMenuItem";
            this.allMembersToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.allMembersToolStripMenuItem.Text = "All Type Reports";
            // 
            // allMembersReportButton
            // 
            this.allMembersReportButton.Name = "allMembersReportButton";
            this.allMembersReportButton.Size = new System.Drawing.Size(141, 22);
            this.allMembersReportButton.Text = "All Members";
            this.allMembersReportButton.Click += new System.EventHandler(this.AllMembersReportButton_Click);
            // 
            // allAccountsReportButton
            // 
            this.allAccountsReportButton.Name = "allAccountsReportButton";
            this.allAccountsReportButton.Size = new System.Drawing.Size(141, 22);
            this.allAccountsReportButton.Text = "All Accounts";
            this.allAccountsReportButton.Click += new System.EventHandler(this.AllAccountsReportButton_Click);
            // 
            // allSharesReportButton
            // 
            this.allSharesReportButton.Name = "allSharesReportButton";
            this.allSharesReportButton.Size = new System.Drawing.Size(141, 22);
            this.allSharesReportButton.Text = "All Shares";
            this.allSharesReportButton.Click += new System.EventHandler(this.AllSharesReportButton_Click);
            // 
            // allLoansReportButton
            // 
            this.allLoansReportButton.Name = "allLoansReportButton";
            this.allLoansReportButton.Size = new System.Drawing.Size(141, 22);
            this.allLoansReportButton.Text = "All Loans";
            this.allLoansReportButton.Click += new System.EventHandler(this.AllLoansReportButton_Click);
            // 
            // allAccountsToolStripMenuItem
            // 
            this.allAccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closedSharesReportButton,
            this.closedLoansReportButton});
            this.allAccountsToolStripMenuItem.Name = "allAccountsToolStripMenuItem";
            this.allAccountsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.allAccountsToolStripMenuItem.Text = "Closed Reports";
            // 
            // closedSharesReportButton
            // 
            this.closedSharesReportButton.Name = "closedSharesReportButton";
            this.closedSharesReportButton.Size = new System.Drawing.Size(147, 22);
            this.closedSharesReportButton.Text = "Closed Shares";
            this.closedSharesReportButton.Click += new System.EventHandler(this.ClosedSharesReportButton_Click);
            // 
            // closedLoansReportButton
            // 
            this.closedLoansReportButton.Name = "closedLoansReportButton";
            this.closedLoansReportButton.Size = new System.Drawing.Size(147, 22);
            this.closedLoansReportButton.Text = "Closed Loans";
            this.closedLoansReportButton.Click += new System.EventHandler(this.ClosedLoansReportButton_Click);
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(0, 62);
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.ReadOnly = true;
            this.reportTextBox.Size = new System.Drawing.Size(733, 456);
            this.reportTextBox.TabIndex = 1;
            this.reportTextBox.Text = "";
            this.reportTextBox.Visible = false;
            // 
            // currentReportTitle
            // 
            this.currentReportTitle.AutoSize = true;
            this.currentReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentReportTitle.Location = new System.Drawing.Point(12, 36);
            this.currentReportTitle.Name = "currentReportTitle";
            this.currentReportTitle.Size = new System.Drawing.Size(91, 20);
            this.currentReportTitle.TabIndex = 2;
            this.currentReportTitle.Text = "Report Title";
            this.currentReportTitle.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(733, 520);
            this.Controls.Add(this.currentReportTitle);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ReportForm";
            this.Text = "Banking App | Reports";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportForm_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton reportsBackButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton generateReportButton;
        private System.Windows.Forms.ToolStripMenuItem allMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allMembersReportButton;
        private System.Windows.Forms.ToolStripMenuItem allAccountsReportButton;
        private System.Windows.Forms.ToolStripMenuItem allSharesReportButton;
        private System.Windows.Forms.ToolStripMenuItem allLoansReportButton;
        private System.Windows.Forms.ToolStripMenuItem allAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closedSharesReportButton;
        private System.Windows.Forms.ToolStripMenuItem closedLoansReportButton;
        private System.Windows.Forms.RichTextBox reportTextBox;
        private System.Windows.Forms.Label currentReportTitle;
    }
}