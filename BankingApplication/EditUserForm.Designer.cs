namespace BankingApplication
{
    partial class EditUserForm
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.Text = "Edit User";
            // 
            // addUserPasswordConfirmTextBox
            // 
            this.addUserPasswordConfirmTextBox.PasswordChar = '*';
            // 
            // addUserPasswordTextBox
            // 
            this.addUserPasswordTextBox.PasswordChar = '*';
            // 
            // userCancelButton
            // 
            this.userCancelButton.Click += new System.EventHandler(this.UserCancelButton_Click);
            // 
            // userCreateButton
            // 
            this.userCreateButton.Text = "Submit";
            this.userCreateButton.Click += new System.EventHandler(this.UserCreateButton_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}