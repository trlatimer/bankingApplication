namespace BankingApp_BaseForms
{
    partial class memberBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memberBaseForm));
            this.label5 = new System.Windows.Forms.Label();
            this.memberStreetLabel = new System.Windows.Forms.Label();
            this.memberSubmitButton = new System.Windows.Forms.Button();
            this.memberIdentificationGroupBox = new System.Windows.Forms.GroupBox();
            this.memberDOBPicker = new System.Windows.Forms.DateTimePicker();
            this.memberSSNTextBox = new System.Windows.Forms.TextBox();
            this.memberIDNumTextBox = new System.Windows.Forms.TextBox();
            this.memberSSNLabel = new System.Windows.Forms.Label();
            this.memberDLLabel = new System.Windows.Forms.Label();
            this.memberDOBLabel = new System.Windows.Forms.Label();
            this.memberAddress = new System.Windows.Forms.GroupBox();
            this.memberExtraAddrLabel = new System.Windows.Forms.Label();
            this.memberStreetTextBox = new System.Windows.Forms.TextBox();
            this.memberExtraAddrTextBox = new System.Windows.Forms.TextBox();
            this.memberCityLabel = new System.Windows.Forms.Label();
            this.memberCityTextBox = new System.Windows.Forms.TextBox();
            this.memberZipLabel = new System.Windows.Forms.Label();
            this.memberZipTextBox = new System.Windows.Forms.TextBox();
            this.memberStateTextBox = new System.Windows.Forms.TextBox();
            this.memberStateLabel = new System.Windows.Forms.Label();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.memberFNameTextBox = new System.Windows.Forms.TextBox();
            this.memberMNameTextBox = new System.Windows.Forms.TextBox();
            this.memberLNameTextBox = new System.Windows.Forms.TextBox();
            this.nameFirstLabel = new System.Windows.Forms.Label();
            this.nameMiddleLabel = new System.Windows.Forms.Label();
            this.nameLastLabel = new System.Windows.Forms.Label();
            this.memberCancelButton = new System.Windows.Forms.Button();
            this.addMemberPanel = new System.Windows.Forms.Panel();
            this.memberContactInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.memberEmailLabel = new System.Windows.Forms.Label();
            this.memberHomeLabel = new System.Windows.Forms.Label();
            this.memberCellLabel = new System.Windows.Forms.Label();
            this.memberCellTextBox = new System.Windows.Forms.TextBox();
            this.memberHomeTextBox = new System.Windows.Forms.TextBox();
            this.memberEmailTextBox = new System.Windows.Forms.TextBox();
            this.mailingSameCheckBox = new System.Windows.Forms.CheckBox();
            this.memberMailAddrGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mailAddrStreetTextBox = new System.Windows.Forms.TextBox();
            this.mailAddrExtraTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mailAddrCityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mailAddrZipTextBox = new System.Windows.Forms.TextBox();
            this.mailAddrStateTextBox = new System.Windows.Forms.TextBox();
            this.MemberTitle = new System.Windows.Forms.Label();
            this.memberIdentificationGroupBox.SuspendLayout();
            this.memberAddress.SuspendLayout();
            this.nameGroupBox.SuspendLayout();
            this.addMemberPanel.SuspendLayout();
            this.memberContactInfoGroupBox.SuspendLayout();
            this.memberMailAddrGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // memberStreetLabel
            // 
            resources.ApplyResources(this.memberStreetLabel, "memberStreetLabel");
            this.memberStreetLabel.Name = "memberStreetLabel";
            // 
            // memberSubmitButton
            // 
            resources.ApplyResources(this.memberSubmitButton, "memberSubmitButton");
            this.memberSubmitButton.Name = "memberSubmitButton";
            this.memberSubmitButton.UseVisualStyleBackColor = true;
            // 
            // memberIdentificationGroupBox
            // 
            this.memberIdentificationGroupBox.BackColor = System.Drawing.Color.White;
            this.memberIdentificationGroupBox.Controls.Add(this.memberDOBPicker);
            this.memberIdentificationGroupBox.Controls.Add(this.memberSSNTextBox);
            this.memberIdentificationGroupBox.Controls.Add(this.memberIDNumTextBox);
            this.memberIdentificationGroupBox.Controls.Add(this.memberSSNLabel);
            this.memberIdentificationGroupBox.Controls.Add(this.memberDLLabel);
            this.memberIdentificationGroupBox.Controls.Add(this.memberDOBLabel);
            resources.ApplyResources(this.memberIdentificationGroupBox, "memberIdentificationGroupBox");
            this.memberIdentificationGroupBox.Name = "memberIdentificationGroupBox";
            this.memberIdentificationGroupBox.TabStop = false;
            // 
            // memberDOBPicker
            // 
            this.memberDOBPicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.memberDOBPicker.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.memberDOBPicker, "memberDOBPicker");
            this.memberDOBPicker.Name = "memberDOBPicker";
            // 
            // memberSSNTextBox
            // 
            resources.ApplyResources(this.memberSSNTextBox, "memberSSNTextBox");
            this.memberSSNTextBox.Name = "memberSSNTextBox";
            this.memberSSNTextBox.TextChanged += new System.EventHandler(this.MemberSSNTextBox_TextChanged);
            this.memberSSNTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemberSSNTextBox_KeyDown);
            // 
            // memberIDNumTextBox
            // 
            resources.ApplyResources(this.memberIDNumTextBox, "memberIDNumTextBox");
            this.memberIDNumTextBox.Name = "memberIDNumTextBox";
            this.memberIDNumTextBox.TextChanged += new System.EventHandler(this.MemberIDNumTextBox_TextChanged);
            // 
            // memberSSNLabel
            // 
            resources.ApplyResources(this.memberSSNLabel, "memberSSNLabel");
            this.memberSSNLabel.Name = "memberSSNLabel";
            // 
            // memberDLLabel
            // 
            resources.ApplyResources(this.memberDLLabel, "memberDLLabel");
            this.memberDLLabel.Name = "memberDLLabel";
            // 
            // memberDOBLabel
            // 
            resources.ApplyResources(this.memberDOBLabel, "memberDOBLabel");
            this.memberDOBLabel.Name = "memberDOBLabel";
            // 
            // memberAddress
            // 
            this.memberAddress.BackColor = System.Drawing.Color.White;
            this.memberAddress.Controls.Add(this.memberStreetLabel);
            this.memberAddress.Controls.Add(this.memberExtraAddrLabel);
            this.memberAddress.Controls.Add(this.memberStreetTextBox);
            this.memberAddress.Controls.Add(this.memberExtraAddrTextBox);
            this.memberAddress.Controls.Add(this.memberCityLabel);
            this.memberAddress.Controls.Add(this.memberCityTextBox);
            this.memberAddress.Controls.Add(this.memberZipLabel);
            this.memberAddress.Controls.Add(this.memberZipTextBox);
            this.memberAddress.Controls.Add(this.memberStateTextBox);
            this.memberAddress.Controls.Add(this.memberStateLabel);
            resources.ApplyResources(this.memberAddress, "memberAddress");
            this.memberAddress.Name = "memberAddress";
            this.memberAddress.TabStop = false;
            // 
            // memberExtraAddrLabel
            // 
            resources.ApplyResources(this.memberExtraAddrLabel, "memberExtraAddrLabel");
            this.memberExtraAddrLabel.Name = "memberExtraAddrLabel";
            // 
            // memberStreetTextBox
            // 
            resources.ApplyResources(this.memberStreetTextBox, "memberStreetTextBox");
            this.memberStreetTextBox.Name = "memberStreetTextBox";
            this.memberStreetTextBox.TextChanged += new System.EventHandler(this.MemberStreetTextBox_TextChanged);
            // 
            // memberExtraAddrTextBox
            // 
            resources.ApplyResources(this.memberExtraAddrTextBox, "memberExtraAddrTextBox");
            this.memberExtraAddrTextBox.Name = "memberExtraAddrTextBox";
            // 
            // memberCityLabel
            // 
            resources.ApplyResources(this.memberCityLabel, "memberCityLabel");
            this.memberCityLabel.Name = "memberCityLabel";
            // 
            // memberCityTextBox
            // 
            resources.ApplyResources(this.memberCityTextBox, "memberCityTextBox");
            this.memberCityTextBox.Name = "memberCityTextBox";
            this.memberCityTextBox.TextChanged += new System.EventHandler(this.MemberCityTextBox_TextChanged);
            // 
            // memberZipLabel
            // 
            resources.ApplyResources(this.memberZipLabel, "memberZipLabel");
            this.memberZipLabel.Name = "memberZipLabel";
            // 
            // memberZipTextBox
            // 
            resources.ApplyResources(this.memberZipTextBox, "memberZipTextBox");
            this.memberZipTextBox.Name = "memberZipTextBox";
            this.memberZipTextBox.TextChanged += new System.EventHandler(this.MemberZipTextBox_TextChanged);
            // 
            // memberStateTextBox
            // 
            resources.ApplyResources(this.memberStateTextBox, "memberStateTextBox");
            this.memberStateTextBox.Name = "memberStateTextBox";
            this.memberStateTextBox.TextChanged += new System.EventHandler(this.MemberStateTextBox_TextChanged);
            // 
            // memberStateLabel
            // 
            resources.ApplyResources(this.memberStateLabel, "memberStateLabel");
            this.memberStateLabel.Name = "memberStateLabel";
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.BackColor = System.Drawing.Color.White;
            this.nameGroupBox.Controls.Add(this.memberFNameTextBox);
            this.nameGroupBox.Controls.Add(this.memberMNameTextBox);
            this.nameGroupBox.Controls.Add(this.memberLNameTextBox);
            this.nameGroupBox.Controls.Add(this.nameFirstLabel);
            this.nameGroupBox.Controls.Add(this.nameMiddleLabel);
            this.nameGroupBox.Controls.Add(this.nameLastLabel);
            resources.ApplyResources(this.nameGroupBox, "nameGroupBox");
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.TabStop = false;
            // 
            // memberFNameTextBox
            // 
            resources.ApplyResources(this.memberFNameTextBox, "memberFNameTextBox");
            this.memberFNameTextBox.Name = "memberFNameTextBox";
            this.memberFNameTextBox.TextChanged += new System.EventHandler(this.MemberFNameTextBox_TextChanged);
            // 
            // memberMNameTextBox
            // 
            resources.ApplyResources(this.memberMNameTextBox, "memberMNameTextBox");
            this.memberMNameTextBox.Name = "memberMNameTextBox";
            // 
            // memberLNameTextBox
            // 
            resources.ApplyResources(this.memberLNameTextBox, "memberLNameTextBox");
            this.memberLNameTextBox.Name = "memberLNameTextBox";
            this.memberLNameTextBox.TextChanged += new System.EventHandler(this.MemberLNameTextBox_TextChanged);
            // 
            // nameFirstLabel
            // 
            resources.ApplyResources(this.nameFirstLabel, "nameFirstLabel");
            this.nameFirstLabel.Name = "nameFirstLabel";
            // 
            // nameMiddleLabel
            // 
            resources.ApplyResources(this.nameMiddleLabel, "nameMiddleLabel");
            this.nameMiddleLabel.Name = "nameMiddleLabel";
            // 
            // nameLastLabel
            // 
            resources.ApplyResources(this.nameLastLabel, "nameLastLabel");
            this.nameLastLabel.Name = "nameLastLabel";
            // 
            // memberCancelButton
            // 
            resources.ApplyResources(this.memberCancelButton, "memberCancelButton");
            this.memberCancelButton.Name = "memberCancelButton";
            this.memberCancelButton.UseVisualStyleBackColor = true;
            // 
            // addMemberPanel
            // 
            resources.ApplyResources(this.addMemberPanel, "addMemberPanel");
            this.addMemberPanel.BackColor = System.Drawing.Color.LightGray;
            this.addMemberPanel.Controls.Add(this.memberContactInfoGroupBox);
            this.addMemberPanel.Controls.Add(this.mailingSameCheckBox);
            this.addMemberPanel.Controls.Add(this.memberMailAddrGroupBox);
            this.addMemberPanel.Controls.Add(this.memberAddress);
            this.addMemberPanel.Controls.Add(this.memberIdentificationGroupBox);
            this.addMemberPanel.Controls.Add(this.nameGroupBox);
            this.addMemberPanel.Name = "addMemberPanel";
            // 
            // memberContactInfoGroupBox
            // 
            this.memberContactInfoGroupBox.BackColor = System.Drawing.Color.White;
            this.memberContactInfoGroupBox.Controls.Add(this.memberEmailLabel);
            this.memberContactInfoGroupBox.Controls.Add(this.memberHomeLabel);
            this.memberContactInfoGroupBox.Controls.Add(this.memberCellLabel);
            this.memberContactInfoGroupBox.Controls.Add(this.memberCellTextBox);
            this.memberContactInfoGroupBox.Controls.Add(this.memberHomeTextBox);
            this.memberContactInfoGroupBox.Controls.Add(this.memberEmailTextBox);
            resources.ApplyResources(this.memberContactInfoGroupBox, "memberContactInfoGroupBox");
            this.memberContactInfoGroupBox.Name = "memberContactInfoGroupBox";
            this.memberContactInfoGroupBox.TabStop = false;
            // 
            // memberEmailLabel
            // 
            resources.ApplyResources(this.memberEmailLabel, "memberEmailLabel");
            this.memberEmailLabel.Name = "memberEmailLabel";
            // 
            // memberHomeLabel
            // 
            resources.ApplyResources(this.memberHomeLabel, "memberHomeLabel");
            this.memberHomeLabel.Name = "memberHomeLabel";
            // 
            // memberCellLabel
            // 
            resources.ApplyResources(this.memberCellLabel, "memberCellLabel");
            this.memberCellLabel.Name = "memberCellLabel";
            // 
            // memberCellTextBox
            // 
            resources.ApplyResources(this.memberCellTextBox, "memberCellTextBox");
            this.memberCellTextBox.Name = "memberCellTextBox";
            this.memberCellTextBox.TextChanged += new System.EventHandler(this.MemberCellTextBox_TextChanged);
            this.memberCellTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemberCellTextBox_KeyDown);
            // 
            // memberHomeTextBox
            // 
            resources.ApplyResources(this.memberHomeTextBox, "memberHomeTextBox");
            this.memberHomeTextBox.Name = "memberHomeTextBox";
            this.memberHomeTextBox.TextChanged += new System.EventHandler(this.MemberHomeTextBox_TextChanged);
            this.memberHomeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemberHomeTextBox_KeyDown);
            // 
            // memberEmailTextBox
            // 
            resources.ApplyResources(this.memberEmailTextBox, "memberEmailTextBox");
            this.memberEmailTextBox.Name = "memberEmailTextBox";
            this.memberEmailTextBox.TextChanged += new System.EventHandler(this.MemberEmailTextBox_TextChanged);
            // 
            // mailingSameCheckBox
            // 
            resources.ApplyResources(this.mailingSameCheckBox, "mailingSameCheckBox");
            this.mailingSameCheckBox.Name = "mailingSameCheckBox";
            this.mailingSameCheckBox.UseVisualStyleBackColor = true;
            this.mailingSameCheckBox.CheckedChanged += new System.EventHandler(this.MailingSameCheckBox_CheckedChanged);
            // 
            // memberMailAddrGroupBox
            // 
            this.memberMailAddrGroupBox.BackColor = System.Drawing.Color.White;
            this.memberMailAddrGroupBox.Controls.Add(this.label1);
            this.memberMailAddrGroupBox.Controls.Add(this.label2);
            this.memberMailAddrGroupBox.Controls.Add(this.mailAddrStreetTextBox);
            this.memberMailAddrGroupBox.Controls.Add(this.mailAddrExtraTextBox);
            this.memberMailAddrGroupBox.Controls.Add(this.label3);
            this.memberMailAddrGroupBox.Controls.Add(this.mailAddrCityTextBox);
            this.memberMailAddrGroupBox.Controls.Add(this.label4);
            this.memberMailAddrGroupBox.Controls.Add(this.mailAddrZipTextBox);
            this.memberMailAddrGroupBox.Controls.Add(this.mailAddrStateTextBox);
            this.memberMailAddrGroupBox.Controls.Add(this.label5);
            resources.ApplyResources(this.memberMailAddrGroupBox, "memberMailAddrGroupBox");
            this.memberMailAddrGroupBox.Name = "memberMailAddrGroupBox";
            this.memberMailAddrGroupBox.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // mailAddrStreetTextBox
            // 
            resources.ApplyResources(this.mailAddrStreetTextBox, "mailAddrStreetTextBox");
            this.mailAddrStreetTextBox.Name = "mailAddrStreetTextBox";
            this.mailAddrStreetTextBox.TextChanged += new System.EventHandler(this.MailAddrStreetTextBox_TextChanged);
            // 
            // mailAddrExtraTextBox
            // 
            resources.ApplyResources(this.mailAddrExtraTextBox, "mailAddrExtraTextBox");
            this.mailAddrExtraTextBox.Name = "mailAddrExtraTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // mailAddrCityTextBox
            // 
            resources.ApplyResources(this.mailAddrCityTextBox, "mailAddrCityTextBox");
            this.mailAddrCityTextBox.Name = "mailAddrCityTextBox";
            this.mailAddrCityTextBox.TextChanged += new System.EventHandler(this.MailAddrCityTextBox_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // mailAddrZipTextBox
            // 
            resources.ApplyResources(this.mailAddrZipTextBox, "mailAddrZipTextBox");
            this.mailAddrZipTextBox.Name = "mailAddrZipTextBox";
            this.mailAddrZipTextBox.TextChanged += new System.EventHandler(this.MailAddrZipTextBox_TextChanged);
            // 
            // mailAddrStateTextBox
            // 
            resources.ApplyResources(this.mailAddrStateTextBox, "mailAddrStateTextBox");
            this.mailAddrStateTextBox.Name = "mailAddrStateTextBox";
            this.mailAddrStateTextBox.TextChanged += new System.EventHandler(this.MailAddrStateTextBox_TextChanged);
            // 
            // MemberTitle
            // 
            resources.ApplyResources(this.MemberTitle, "MemberTitle");
            this.MemberTitle.Name = "MemberTitle";
            // 
            // memberBaseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.memberSubmitButton);
            this.Controls.Add(this.memberCancelButton);
            this.Controls.Add(this.addMemberPanel);
            this.Controls.Add(this.MemberTitle);
            this.Name = "memberBaseForm";
            this.memberIdentificationGroupBox.ResumeLayout(false);
            this.memberIdentificationGroupBox.PerformLayout();
            this.memberAddress.ResumeLayout(false);
            this.memberAddress.PerformLayout();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.addMemberPanel.ResumeLayout(false);
            this.addMemberPanel.PerformLayout();
            this.memberContactInfoGroupBox.ResumeLayout(false);
            this.memberContactInfoGroupBox.PerformLayout();
            this.memberMailAddrGroupBox.ResumeLayout(false);
            this.memberMailAddrGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button memberSubmitButton;
        protected System.Windows.Forms.Button memberCancelButton;
        protected System.Windows.Forms.Panel addMemberPanel;
        protected System.Windows.Forms.Label MemberTitle;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label memberStreetLabel;
        protected System.Windows.Forms.GroupBox memberIdentificationGroupBox;
        protected System.Windows.Forms.DateTimePicker memberDOBPicker;
        protected System.Windows.Forms.TextBox memberSSNTextBox;
        protected System.Windows.Forms.TextBox memberIDNumTextBox;
        protected System.Windows.Forms.Label memberSSNLabel;
        protected System.Windows.Forms.Label memberDLLabel;
        protected System.Windows.Forms.Label memberDOBLabel;
        protected System.Windows.Forms.GroupBox memberAddress;
        protected System.Windows.Forms.Label memberExtraAddrLabel;
        protected System.Windows.Forms.TextBox memberStreetTextBox;
        protected System.Windows.Forms.TextBox memberExtraAddrTextBox;
        protected System.Windows.Forms.Label memberCityLabel;
        protected System.Windows.Forms.TextBox memberCityTextBox;
        protected System.Windows.Forms.Label memberZipLabel;
        protected System.Windows.Forms.TextBox memberZipTextBox;
        protected System.Windows.Forms.TextBox memberStateTextBox;
        protected System.Windows.Forms.Label memberStateLabel;
        protected System.Windows.Forms.GroupBox nameGroupBox;
        protected System.Windows.Forms.TextBox memberFNameTextBox;
        protected System.Windows.Forms.TextBox memberMNameTextBox;
        protected System.Windows.Forms.TextBox memberLNameTextBox;
        protected System.Windows.Forms.Label nameFirstLabel;
        protected System.Windows.Forms.Label nameMiddleLabel;
        protected System.Windows.Forms.Label nameLastLabel;
        protected System.Windows.Forms.GroupBox memberContactInfoGroupBox;
        protected System.Windows.Forms.Label memberEmailLabel;
        protected System.Windows.Forms.Label memberHomeLabel;
        protected System.Windows.Forms.Label memberCellLabel;
        protected System.Windows.Forms.TextBox memberCellTextBox;
        protected System.Windows.Forms.TextBox memberHomeTextBox;
        protected System.Windows.Forms.TextBox memberEmailTextBox;
        protected System.Windows.Forms.CheckBox mailingSameCheckBox;
        protected System.Windows.Forms.GroupBox memberMailAddrGroupBox;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox mailAddrStreetTextBox;
        protected System.Windows.Forms.TextBox mailAddrExtraTextBox;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox mailAddrCityTextBox;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox mailAddrZipTextBox;
        protected System.Windows.Forms.TextBox mailAddrStateTextBox;
    }
}

