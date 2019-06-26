namespace BankingApplication
{
    partial class OpenLoanForm
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
            this.joinInfoGroupBox.SuspendLayout();
            this.loanPanel.SuspendLayout();
            this.loanInfoGroupBox.SuspendLayout();
            this.memberInfoGroupBox.SuspendLayout();
            this.loanSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shareSubmitButton
            // 
            this.shareSubmitButton.Click += new System.EventHandler(this.ShareSubmitButton_Click);
            // 
            // loanJointCheckBox
            // 
            this.loanJointCheckBox.CheckedChanged += new System.EventHandler(this.LoanJointCheckBox_CheckedChanged);
            // 
            // shareCancelButton
            // 
            this.shareCancelButton.Click += new System.EventHandler(this.ShareCancelButton_Click);
            // 
            // loanTitleLabel
            // 
            this.loanTitleLabel.Size = new System.Drawing.Size(118, 25);
            this.loanTitleLabel.Text = "Open Loan";
            // 
            // loanAmount
            // 
            this.loanAmount.TextChanged += new System.EventHandler(this.LoanAmount_TextChanged);
            // 
            // loanTermTextBox
            // 
            this.loanTermTextBox.TextChanged += new System.EventHandler(this.LoanTermTextBox_TextChanged);
            // 
            // loanAPR
            // 
            this.loanAPR.Leave += new System.EventHandler(this.LoanAPR_Leave);
            // 
            // loanDayDue
            // 
            this.loanDayDue.Leave += new System.EventHandler(this.LoanDayDue_Leave);
            // 
            // OpenLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 508);
            this.Name = "OpenLoanForm";
            this.Text = "AddLoanForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenLoanForm_FormClosed);
            this.Load += new System.EventHandler(this.OpenLoanForm_Load);
            this.joinInfoGroupBox.ResumeLayout(false);
            this.joinInfoGroupBox.PerformLayout();
            this.loanPanel.ResumeLayout(false);
            this.loanPanel.PerformLayout();
            this.loanInfoGroupBox.ResumeLayout(false);
            this.loanInfoGroupBox.PerformLayout();
            this.memberInfoGroupBox.ResumeLayout(false);
            this.memberInfoGroupBox.PerformLayout();
            this.loanSummaryGroupBox.ResumeLayout(false);
            this.loanSummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}