namespace BankingApp_BaseForms
{
    partial class loanBaseForm
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
            this.shareSubmitButton = new System.Windows.Forms.Button();
            this.jointDOBPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.jointSSNTextBox = new System.Windows.Forms.TextBox();
            this.jointNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loanJointCheckBox = new System.Windows.Forms.CheckBox();
            this.joinInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.shareCancelButton = new System.Windows.Forms.Button();
            this.loanTypeLabel = new System.Windows.Forms.Label();
            this.loanDescTextBox = new System.Windows.Forms.TextBox();
            this.loanDescLabel = new System.Windows.Forms.Label();
            this.sharePanel = new System.Windows.Forms.Panel();
            this.loanInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.memberInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.memberDOBPicker = new System.Windows.Forms.DateTimePicker();
            this.dobLabel = new System.Windows.Forms.Label();
            this.memberSSNTextBox = new System.Windows.Forms.TextBox();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.loanTitleLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.joinInfoGroupBox.SuspendLayout();
            this.sharePanel.SuspendLayout();
            this.loanInfoGroupBox.SuspendLayout();
            this.memberInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shareSubmitButton
            // 
            this.shareSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareSubmitButton.Location = new System.Drawing.Point(213, 376);
            this.shareSubmitButton.Name = "shareSubmitButton";
            this.shareSubmitButton.Size = new System.Drawing.Size(82, 26);
            this.shareSubmitButton.TabIndex = 8;
            this.shareSubmitButton.Text = "Submit";
            this.shareSubmitButton.UseVisualStyleBackColor = true;
            // 
            // jointDOBPicker
            // 
            this.jointDOBPicker.Enabled = false;
            this.jointDOBPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jointDOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jointDOBPicker.Location = new System.Drawing.Point(277, 37);
            this.jointDOBPicker.Name = "jointDOBPicker";
            this.jointDOBPicker.Size = new System.Drawing.Size(92, 22);
            this.jointDOBPicker.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "DOB:";
            // 
            // jointSSNTextBox
            // 
            this.jointSSNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jointSSNTextBox.Location = new System.Drawing.Point(193, 37);
            this.jointSSNTextBox.Name = "jointSSNTextBox";
            this.jointSSNTextBox.ReadOnly = true;
            this.jointSSNTextBox.Size = new System.Drawing.Size(78, 22);
            this.jointSSNTextBox.TabIndex = 9;
            // 
            // jointNameTextBox
            // 
            this.jointNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jointNameTextBox.Location = new System.Drawing.Point(10, 37);
            this.jointNameTextBox.Name = "jointNameTextBox";
            this.jointNameTextBox.ReadOnly = true;
            this.jointNameTextBox.Size = new System.Drawing.Size(177, 22);
            this.jointNameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "SSN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name:";
            // 
            // loanJointCheckBox
            // 
            this.loanJointCheckBox.AutoSize = true;
            this.loanJointCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanJointCheckBox.Location = new System.Drawing.Point(16, 75);
            this.loanJointCheckBox.Name = "loanJointCheckBox";
            this.loanJointCheckBox.Size = new System.Drawing.Size(106, 20);
            this.loanJointCheckBox.TabIndex = 3;
            this.loanJointCheckBox.Text = "Joint Account";
            this.loanJointCheckBox.UseVisualStyleBackColor = true;
            // 
            // joinInfoGroupBox
            // 
            this.joinInfoGroupBox.Controls.Add(this.jointDOBPicker);
            this.joinInfoGroupBox.Controls.Add(this.label2);
            this.joinInfoGroupBox.Controls.Add(this.jointSSNTextBox);
            this.joinInfoGroupBox.Controls.Add(this.jointNameTextBox);
            this.joinInfoGroupBox.Controls.Add(this.label3);
            this.joinInfoGroupBox.Controls.Add(this.label4);
            this.joinInfoGroupBox.Enabled = false;
            this.joinInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinInfoGroupBox.Location = new System.Drawing.Point(6, 97);
            this.joinInfoGroupBox.Name = "joinInfoGroupBox";
            this.joinInfoGroupBox.Size = new System.Drawing.Size(378, 65);
            this.joinInfoGroupBox.TabIndex = 2;
            this.joinInfoGroupBox.TabStop = false;
            this.joinInfoGroupBox.Text = "Joint Information";
            // 
            // shareCancelButton
            // 
            this.shareCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareCancelButton.Location = new System.Drawing.Point(112, 376);
            this.shareCancelButton.Name = "shareCancelButton";
            this.shareCancelButton.Size = new System.Drawing.Size(82, 26);
            this.shareCancelButton.TabIndex = 7;
            this.shareCancelButton.Text = "Cancel";
            this.shareCancelButton.UseVisualStyleBackColor = true;
            // 
            // loanTypeLabel
            // 
            this.loanTypeLabel.AutoSize = true;
            this.loanTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTypeLabel.Location = new System.Drawing.Point(61, 56);
            this.loanTypeLabel.Name = "loanTypeLabel";
            this.loanTypeLabel.Size = new System.Drawing.Size(43, 16);
            this.loanTypeLabel.TabIndex = 4;
            this.loanTypeLabel.Text = "Type:";
            // 
            // loanDescTextBox
            // 
            this.loanDescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanDescTextBox.Location = new System.Drawing.Point(92, 25);
            this.loanDescTextBox.Name = "loanDescTextBox";
            this.loanDescTextBox.Size = new System.Drawing.Size(234, 22);
            this.loanDescTextBox.TabIndex = 1;
            // 
            // loanDescLabel
            // 
            this.loanDescLabel.AutoSize = true;
            this.loanDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanDescLabel.Location = new System.Drawing.Point(7, 28);
            this.loanDescLabel.Name = "loanDescLabel";
            this.loanDescLabel.Size = new System.Drawing.Size(79, 16);
            this.loanDescLabel.TabIndex = 0;
            this.loanDescLabel.Text = "Description:";
            // 
            // sharePanel
            // 
            this.sharePanel.BackColor = System.Drawing.Color.LightGray;
            this.sharePanel.Controls.Add(this.loanInfoGroupBox);
            this.sharePanel.Controls.Add(this.loanJointCheckBox);
            this.sharePanel.Controls.Add(this.joinInfoGroupBox);
            this.sharePanel.Controls.Add(this.memberInfoGroupBox);
            this.sharePanel.Location = new System.Drawing.Point(14, 46);
            this.sharePanel.Name = "sharePanel";
            this.sharePanel.Size = new System.Drawing.Size(392, 324);
            this.sharePanel.TabIndex = 6;
            // 
            // loanInfoGroupBox
            // 
            this.loanInfoGroupBox.Controls.Add(this.comboBox1);
            this.loanInfoGroupBox.Controls.Add(this.loanTypeLabel);
            this.loanInfoGroupBox.Controls.Add(this.loanDescTextBox);
            this.loanInfoGroupBox.Controls.Add(this.loanDescLabel);
            this.loanInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanInfoGroupBox.Location = new System.Drawing.Point(6, 168);
            this.loanInfoGroupBox.Name = "loanInfoGroupBox";
            this.loanInfoGroupBox.Size = new System.Drawing.Size(378, 139);
            this.loanInfoGroupBox.TabIndex = 4;
            this.loanInfoGroupBox.TabStop = false;
            this.loanInfoGroupBox.Text = "Loan Details";
            // 
            // memberInfoGroupBox
            // 
            this.memberInfoGroupBox.Controls.Add(this.memberDOBPicker);
            this.memberInfoGroupBox.Controls.Add(this.dobLabel);
            this.memberInfoGroupBox.Controls.Add(this.memberSSNTextBox);
            this.memberInfoGroupBox.Controls.Add(this.memberNameTextBox);
            this.memberInfoGroupBox.Controls.Add(this.ssnLabel);
            this.memberInfoGroupBox.Controls.Add(this.nameLabel);
            this.memberInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInfoGroupBox.Location = new System.Drawing.Point(6, 4);
            this.memberInfoGroupBox.Name = "memberInfoGroupBox";
            this.memberInfoGroupBox.Size = new System.Drawing.Size(378, 65);
            this.memberInfoGroupBox.TabIndex = 1;
            this.memberInfoGroupBox.TabStop = false;
            this.memberInfoGroupBox.Text = "Member Information";
            // 
            // memberDOBPicker
            // 
            this.memberDOBPicker.Enabled = false;
            this.memberDOBPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.memberDOBPicker.Location = new System.Drawing.Point(277, 36);
            this.memberDOBPicker.Name = "memberDOBPicker";
            this.memberDOBPicker.Size = new System.Drawing.Size(92, 22);
            this.memberDOBPicker.TabIndex = 5;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(274, 17);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(40, 16);
            this.dobLabel.TabIndex = 4;
            this.dobLabel.Text = "DOB:";
            // 
            // memberSSNTextBox
            // 
            this.memberSSNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSSNTextBox.Location = new System.Drawing.Point(193, 36);
            this.memberSSNTextBox.Name = "memberSSNTextBox";
            this.memberSSNTextBox.ReadOnly = true;
            this.memberSSNTextBox.Size = new System.Drawing.Size(78, 22);
            this.memberSSNTextBox.TabIndex = 3;
            // 
            // memberNameTextBox
            // 
            this.memberNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameTextBox.Location = new System.Drawing.Point(10, 36);
            this.memberNameTextBox.Name = "memberNameTextBox";
            this.memberNameTextBox.ReadOnly = true;
            this.memberNameTextBox.Size = new System.Drawing.Size(177, 22);
            this.memberNameTextBox.TabIndex = 2;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLabel.Location = new System.Drawing.Point(190, 17);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(39, 16);
            this.ssnLabel.TabIndex = 1;
            this.ssnLabel.Text = "SSN:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(7, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // loanTitleLabel
            // 
            this.loanTitleLabel.AutoSize = true;
            this.loanTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTitleLabel.Location = new System.Drawing.Point(148, 9);
            this.loanTitleLabel.Name = "loanTitleLabel";
            this.loanTitleLabel.Size = new System.Drawing.Size(107, 25);
            this.loanTitleLabel.TabIndex = 5;
            this.loanTitleLabel.Text = "Loan Title";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Business",
            "Construction",
            "Mortgage",
            "Recreational",
            "Signature",
            "Student",
            "Vehicle"});
            this.comboBox1.Location = new System.Drawing.Point(133, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Loan Type";
            // 
            // loanBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(422, 409);
            this.Controls.Add(this.shareSubmitButton);
            this.Controls.Add(this.shareCancelButton);
            this.Controls.Add(this.sharePanel);
            this.Controls.Add(this.loanTitleLabel);
            this.Name = "loanBaseForm";
            this.Text = "loanBaseForm";
            this.joinInfoGroupBox.ResumeLayout(false);
            this.joinInfoGroupBox.PerformLayout();
            this.sharePanel.ResumeLayout(false);
            this.sharePanel.PerformLayout();
            this.loanInfoGroupBox.ResumeLayout(false);
            this.loanInfoGroupBox.PerformLayout();
            this.memberInfoGroupBox.ResumeLayout(false);
            this.memberInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button shareSubmitButton;
        protected System.Windows.Forms.DateTimePicker jointDOBPicker;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox jointSSNTextBox;
        protected System.Windows.Forms.TextBox jointNameTextBox;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.CheckBox loanJointCheckBox;
        protected System.Windows.Forms.GroupBox joinInfoGroupBox;
        protected System.Windows.Forms.Button shareCancelButton;
        protected System.Windows.Forms.Label loanTypeLabel;
        protected System.Windows.Forms.TextBox loanDescTextBox;
        protected System.Windows.Forms.Label loanDescLabel;
        protected System.Windows.Forms.Panel sharePanel;
        protected System.Windows.Forms.GroupBox loanInfoGroupBox;
        protected System.Windows.Forms.GroupBox memberInfoGroupBox;
        protected System.Windows.Forms.DateTimePicker memberDOBPicker;
        protected System.Windows.Forms.Label dobLabel;
        protected System.Windows.Forms.TextBox memberSSNTextBox;
        protected System.Windows.Forms.TextBox memberNameTextBox;
        protected System.Windows.Forms.Label ssnLabel;
        protected System.Windows.Forms.Label nameLabel;
        protected System.Windows.Forms.Label loanTitleLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}