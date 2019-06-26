namespace BankingApplication
{
    partial class AddMemberForm
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
            this.memberSubmitButton.TabIndex = 1;
            this.memberSubmitButton.Click += new System.EventHandler(this.MemberSubmitButton_Click);
            // 
            // memberCancelButton
            // 
            this.memberCancelButton.TabIndex = 0;
            this.memberCancelButton.Click += new System.EventHandler(this.MemberCancelButton_Click);
            // 
            // MemberTitle
            // 
            this.MemberTitle.Location = new System.Drawing.Point(141, 7);
            this.MemberTitle.Size = new System.Drawing.Size(208, 25);
            this.MemberTitle.Text = "Create New Member";
            // 
            // memberDOBPicker
            // 
            this.memberDOBPicker.TabIndex = 2;
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 585);
            this.Name = "AddMemberForm";
            this.Text = "AddMemberForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddMemberForm_FormClosed);
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