namespace BankingApplication
{
    partial class Login
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
            this.loginTitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginSignInButton = new System.Windows.Forms.Button();
            this.loginExitButton = new System.Windows.Forms.Button();
            this.loginUserNameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginTitleLabel
            // 
            this.loginTitleLabel.AutoSize = true;
            this.loginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitleLabel.Location = new System.Drawing.Point(79, 20);
            this.loginTitleLabel.Name = "loginTitleLabel";
            this.loginTitleLabel.Size = new System.Drawing.Size(94, 29);
            this.loginTitleLabel.TabIndex = 0;
            this.loginTitleLabel.Text = "Sign In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // loginSignInButton
            // 
            this.loginSignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginSignInButton.Location = new System.Drawing.Point(145, 143);
            this.loginSignInButton.Name = "loginSignInButton";
            this.loginSignInButton.Size = new System.Drawing.Size(72, 23);
            this.loginSignInButton.TabIndex = 3;
            this.loginSignInButton.Text = "Sign In";
            this.loginSignInButton.UseVisualStyleBackColor = true;
            this.loginSignInButton.Click += new System.EventHandler(this.loginSignInButton_Click);
            // 
            // loginExitButton
            // 
            this.loginExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginExitButton.Location = new System.Drawing.Point(35, 142);
            this.loginExitButton.Name = "loginExitButton";
            this.loginExitButton.Size = new System.Drawing.Size(78, 24);
            this.loginExitButton.TabIndex = 4;
            this.loginExitButton.Text = "Exit";
            this.loginExitButton.UseVisualStyleBackColor = true;
            this.loginExitButton.Click += new System.EventHandler(this.loginExitButton_Click);
            // 
            // loginUserNameTextBox
            // 
            this.loginUserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserNameTextBox.Location = new System.Drawing.Point(127, 67);
            this.loginUserNameTextBox.MaxLength = 30;
            this.loginUserNameTextBox.Name = "loginUserNameTextBox";
            this.loginUserNameTextBox.Size = new System.Drawing.Size(125, 22);
            this.loginUserNameTextBox.TabIndex = 5;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordTextBox.Location = new System.Drawing.Point(127, 103);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.Size = new System.Drawing.Size(125, 22);
            this.loginPasswordTextBox.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(268, 189);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginUserNameTextBox);
            this.Controls.Add(this.loginExitButton);
            this.Controls.Add(this.loginSignInButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "Banking App | Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginTitleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginSignInButton;
        private System.Windows.Forms.Button loginExitButton;
        private System.Windows.Forms.TextBox loginUserNameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
    }
}

