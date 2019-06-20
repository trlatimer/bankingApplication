namespace BankingApp_BaseForms
{
    partial class userBaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addUserPasswordConfirmTextBox = new System.Windows.Forms.TextBox();
            this.addUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.addUserUsernameTextBox = new System.Windows.Forms.TextBox();
            this.userAuthLevelComboBox = new System.Windows.Forms.ComboBox();
            this.userPasswordConfirmLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userUsernameLabel = new System.Windows.Forms.Label();
            this.userCancelButton = new System.Windows.Forms.Button();
            this.userCreateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Title";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.addUserPasswordConfirmTextBox);
            this.panel1.Controls.Add(this.addUserPasswordTextBox);
            this.panel1.Controls.Add(this.addUserUsernameTextBox);
            this.panel1.Controls.Add(this.userAuthLevelComboBox);
            this.panel1.Controls.Add(this.userPasswordConfirmLabel);
            this.panel1.Controls.Add(this.userPasswordLabel);
            this.panel1.Controls.Add(this.userUsernameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 149);
            this.panel1.TabIndex = 1;
            // 
            // addUserPasswordConfirmTextBox
            // 
            this.addUserPasswordConfirmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserPasswordConfirmTextBox.Location = new System.Drawing.Point(146, 70);
            this.addUserPasswordConfirmTextBox.Name = "addUserPasswordConfirmTextBox";
            this.addUserPasswordConfirmTextBox.Size = new System.Drawing.Size(118, 22);
            this.addUserPasswordConfirmTextBox.TabIndex = 6;
            this.addUserPasswordConfirmTextBox.TextChanged += new System.EventHandler(this.AddUserPasswordConfirmTextBox_TextChanged);
            // 
            // addUserPasswordTextBox
            // 
            this.addUserPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserPasswordTextBox.Location = new System.Drawing.Point(146, 42);
            this.addUserPasswordTextBox.Name = "addUserPasswordTextBox";
            this.addUserPasswordTextBox.Size = new System.Drawing.Size(118, 22);
            this.addUserPasswordTextBox.TabIndex = 5;
            this.addUserPasswordTextBox.TextChanged += new System.EventHandler(this.AddUserPasswordTextBox_TextChanged);
            // 
            // addUserUsernameTextBox
            // 
            this.addUserUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserUsernameTextBox.Location = new System.Drawing.Point(146, 14);
            this.addUserUsernameTextBox.Name = "addUserUsernameTextBox";
            this.addUserUsernameTextBox.Size = new System.Drawing.Size(118, 22);
            this.addUserUsernameTextBox.TabIndex = 4;
            this.addUserUsernameTextBox.TextChanged += new System.EventHandler(this.AddUserUsernameTextBox_TextChanged);
            // 
            // userAuthLevelComboBox
            // 
            this.userAuthLevelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAuthLevelComboBox.FormattingEnabled = true;
            this.userAuthLevelComboBox.Items.AddRange(new object[] {
            "Guest",
            "User",
            "Moderator",
            "Manager"});
            this.userAuthLevelComboBox.Location = new System.Drawing.Point(91, 111);
            this.userAuthLevelComboBox.Name = "userAuthLevelComboBox";
            this.userAuthLevelComboBox.Size = new System.Drawing.Size(121, 24);
            this.userAuthLevelComboBox.TabIndex = 3;
            this.userAuthLevelComboBox.Text = "Authority Level";
            // 
            // userPasswordConfirmLabel
            // 
            this.userPasswordConfirmLabel.AutoSize = true;
            this.userPasswordConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordConfirmLabel.Location = new System.Drawing.Point(13, 73);
            this.userPasswordConfirmLabel.Name = "userPasswordConfirmLabel";
            this.userPasswordConfirmLabel.Size = new System.Drawing.Size(119, 16);
            this.userPasswordConfirmLabel.TabIndex = 2;
            this.userPasswordConfirmLabel.Text = "Confirm Password:";
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordLabel.Location = new System.Drawing.Point(61, 45);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(71, 16);
            this.userPasswordLabel.TabIndex = 1;
            this.userPasswordLabel.Text = "Password:";
            // 
            // userUsernameLabel
            // 
            this.userUsernameLabel.AutoSize = true;
            this.userUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userUsernameLabel.Location = new System.Drawing.Point(58, 17);
            this.userUsernameLabel.Name = "userUsernameLabel";
            this.userUsernameLabel.Size = new System.Drawing.Size(74, 16);
            this.userUsernameLabel.TabIndex = 0;
            this.userUsernameLabel.Text = "Username:";
            // 
            // userCancelButton
            // 
            this.userCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCancelButton.Location = new System.Drawing.Point(61, 202);
            this.userCancelButton.Name = "userCancelButton";
            this.userCancelButton.Size = new System.Drawing.Size(70, 23);
            this.userCancelButton.TabIndex = 2;
            this.userCancelButton.Text = "Cancel";
            this.userCancelButton.UseVisualStyleBackColor = true;
            // 
            // userCreateButton
            // 
            this.userCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCreateButton.Location = new System.Drawing.Point(173, 202);
            this.userCreateButton.Name = "userCreateButton";
            this.userCreateButton.Size = new System.Drawing.Size(75, 23);
            this.userCreateButton.TabIndex = 3;
            this.userCreateButton.Text = "Create";
            this.userCreateButton.UseVisualStyleBackColor = true;
            // 
            // userBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(315, 237);
            this.Controls.Add(this.userCreateButton);
            this.Controls.Add(this.userCancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "userBaseForm";
            this.Text = "userBaseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label userPasswordConfirmLabel;
        protected System.Windows.Forms.Label userPasswordLabel;
        protected System.Windows.Forms.Label userUsernameLabel;
        protected System.Windows.Forms.ComboBox userAuthLevelComboBox;
        protected System.Windows.Forms.TextBox addUserPasswordConfirmTextBox;
        protected System.Windows.Forms.TextBox addUserPasswordTextBox;
        protected System.Windows.Forms.TextBox addUserUsernameTextBox;
        protected System.Windows.Forms.Button userCancelButton;
        protected System.Windows.Forms.Button userCreateButton;
    }
}