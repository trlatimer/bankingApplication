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
            this.mainAccountButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mainReportButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.mainLookupTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mainSearchCriteria = new System.Windows.Forms.ToolStripDropDownButton();
            this.accountNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socialSecurityNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AllowMerge = false;
            this.mainToolStrip.BackColor = System.Drawing.Color.PeachPuff;
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
            this.toolStripButton4,
            this.mainLookupTextBox,
            this.mainSearchCriteria,
            this.toolStripSeparator4});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.mainToolStrip.Size = new System.Drawing.Size(739, 28);
            this.mainToolStrip.Stretch = true;
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "mainToolStrip";
            // 
            // mainLogoutButton
            // 
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
            this.mainAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("mainAccountButton.Image")));
            this.mainAccountButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainAccountButton.Name = "mainAccountButton";
            this.mainAccountButton.Size = new System.Drawing.Size(115, 21);
            this.mainAccountButton.Text = "Account Manager";
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
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(112, 21);
            this.toolStripButton4.Text = "Lookup Member:";
            // 
            // mainLookupTextBox
            // 
            this.mainLookupTextBox.Name = "mainLookupTextBox";
            this.mainLookupTextBox.Size = new System.Drawing.Size(100, 24);
            this.mainLookupTextBox.ToolTipText = "Enter ";
            // 
            // mainSearchCriteria
            // 
            this.mainSearchCriteria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainSearchCriteria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountNumberToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.socialSecurityNumberToolStripMenuItem});
            this.mainSearchCriteria.Image = ((System.Drawing.Image)(resources.GetObject("mainSearchCriteria.Image")));
            this.mainSearchCriteria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainSearchCriteria.Name = "mainSearchCriteria";
            this.mainSearchCriteria.Size = new System.Drawing.Size(80, 21);
            this.mainSearchCriteria.Text = "Search By:";
            // 
            // accountNumberToolStripMenuItem
            // 
            this.accountNumberToolStripMenuItem.Name = "accountNumberToolStripMenuItem";
            this.accountNumberToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.accountNumberToolStripMenuItem.Text = "Account Number";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // socialSecurityNumberToolStripMenuItem
            // 
            this.socialSecurityNumberToolStripMenuItem.Name = "socialSecurityNumberToolStripMenuItem";
            this.socialSecurityNumberToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.socialSecurityNumberToolStripMenuItem.Text = "Social Security Number";
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
            this.ClientSize = new System.Drawing.Size(739, 484);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Banking App | Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton mainLogoutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mainTransactionButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mainAccountButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton mainReportButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripTextBox mainLookupTextBox;
        private System.Windows.Forms.ToolStripDropDownButton mainSearchCriteria;
        private System.Windows.Forms.ToolStripMenuItem accountNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socialSecurityNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}