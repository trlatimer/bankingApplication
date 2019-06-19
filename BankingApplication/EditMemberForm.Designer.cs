namespace BankingApplication
{
    partial class EditMemberForm
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
            this.addMemberPanel.SuspendLayout();
            this.memberIdentificationGroupBox.SuspendLayout();
            this.memberAddress.SuspendLayout();
            this.nameGroupBox.SuspendLayout();
            this.memberContactInfoGroupBox.SuspendLayout();
            this.memberMailAddrGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberSubmitButton
            // 
            this.memberSubmitButton.Click += new System.EventHandler(this.MemberSubmitButton_Click);
            // 
            // memberCancelButton
            // 
            this.memberCancelButton.Click += new System.EventHandler(this.MemberCancelButton_Click);
            // 
            // MemberTitle
            // 
            this.MemberTitle.Size = new System.Drawing.Size(133, 25);
            this.MemberTitle.Text = "Edit Member";
            // 
            // EditMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 589);
            this.Name = "EditMemberForm";
            this.Text = "EditMemberForm";
            this.Load += new System.EventHandler(this.EditMemberForm_Load);
            this.addMemberPanel.ResumeLayout(false);
            this.addMemberPanel.PerformLayout();
            this.memberIdentificationGroupBox.ResumeLayout(false);
            this.memberIdentificationGroupBox.PerformLayout();
            this.memberAddress.ResumeLayout(false);
            this.memberAddress.PerformLayout();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.memberContactInfoGroupBox.ResumeLayout(false);
            this.memberContactInfoGroupBox.PerformLayout();
            this.memberMailAddrGroupBox.ResumeLayout(false);
            this.memberMailAddrGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}