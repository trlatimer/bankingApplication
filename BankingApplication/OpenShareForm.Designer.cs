namespace BankingApplication
{
    partial class OpenShareForm
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
            this.memberInfoGroupBox.SuspendLayout();
            this.sharePanel.SuspendLayout();
            this.joinInfoGroupBox.SuspendLayout();
            this.shareInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.Text = "Open Share";
            // 
            // shareJointCheckBox
            // 
            this.shareJointCheckBox.CheckedChanged += new System.EventHandler(this.ShareJointCheckBox_CheckedChanged);
            // 
            // shareInfoGroupBox
            // 
            this.shareInfoGroupBox.TabIndex = 0;
            // 
            // shareSavingsRadioButton
            // 
            this.shareSavingsRadioButton.TabIndex = 1;
            // 
            // shareDescTextBox
            // 
            this.shareDescTextBox.TabIndex = 0;
            // 
            // shareCancelButton
            // 
            this.shareCancelButton.TabIndex = 0;
            this.shareCancelButton.Click += new System.EventHandler(this.ShareCancelButton_Click);
            // 
            // shareSubmitButton
            // 
            this.shareSubmitButton.TabIndex = 1;
            this.shareSubmitButton.Click += new System.EventHandler(this.ShareSubmitButton_Click);
            // 
            // OpenShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 353);
            this.Name = "OpenShareForm";
            this.Text = "OpenShareForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenShareForm_FormClosed);
            this.Load += new System.EventHandler(this.OpenShareForm_Load);
            this.memberInfoGroupBox.ResumeLayout(false);
            this.memberInfoGroupBox.PerformLayout();
            this.sharePanel.ResumeLayout(false);
            this.sharePanel.PerformLayout();
            this.joinInfoGroupBox.ResumeLayout(false);
            this.joinInfoGroupBox.PerformLayout();
            this.shareInfoGroupBox.ResumeLayout(false);
            this.shareInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}