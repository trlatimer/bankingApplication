namespace BankingApp_BaseForms
{
    partial class shareBaseForm
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
            this.memberInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.memberDOBPicker = new System.Windows.Forms.DateTimePicker();
            this.dobLabel = new System.Windows.Forms.Label();
            this.memberSSNTextBox = new System.Windows.Forms.TextBox();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sharePanel = new System.Windows.Forms.Panel();
            this.shareInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.shareTypeLabel = new System.Windows.Forms.Label();
            this.shareSavingsRadioButton = new System.Windows.Forms.RadioButton();
            this.shareCheckingRadioButton = new System.Windows.Forms.RadioButton();
            this.shareDescTextBox = new System.Windows.Forms.TextBox();
            this.shareDescLabel = new System.Windows.Forms.Label();
            this.shareJointCheckBox = new System.Windows.Forms.CheckBox();
            this.joinInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.jointDOBPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.jointSSNTextBox = new System.Windows.Forms.TextBox();
            this.jointNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shareCancelButton = new System.Windows.Forms.Button();
            this.shareSubmitButton = new System.Windows.Forms.Button();
            this.memberInfoGroupBox.SuspendLayout();
            this.sharePanel.SuspendLayout();
            this.shareInfoGroupBox.SuspendLayout();
            this.joinInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Share Title";
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
            // sharePanel
            // 
            this.sharePanel.BackColor = System.Drawing.Color.LightGray;
            this.sharePanel.Controls.Add(this.shareInfoGroupBox);
            this.sharePanel.Controls.Add(this.shareJointCheckBox);
            this.sharePanel.Controls.Add(this.joinInfoGroupBox);
            this.sharePanel.Controls.Add(this.memberInfoGroupBox);
            this.sharePanel.Location = new System.Drawing.Point(12, 46);
            this.sharePanel.Name = "sharePanel";
            this.sharePanel.Size = new System.Drawing.Size(392, 263);
            this.sharePanel.TabIndex = 2;
            // 
            // shareInfoGroupBox
            // 
            this.shareInfoGroupBox.Controls.Add(this.shareTypeLabel);
            this.shareInfoGroupBox.Controls.Add(this.shareSavingsRadioButton);
            this.shareInfoGroupBox.Controls.Add(this.shareCheckingRadioButton);
            this.shareInfoGroupBox.Controls.Add(this.shareDescTextBox);
            this.shareInfoGroupBox.Controls.Add(this.shareDescLabel);
            this.shareInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareInfoGroupBox.Location = new System.Drawing.Point(6, 168);
            this.shareInfoGroupBox.Name = "shareInfoGroupBox";
            this.shareInfoGroupBox.Size = new System.Drawing.Size(378, 85);
            this.shareInfoGroupBox.TabIndex = 4;
            this.shareInfoGroupBox.TabStop = false;
            this.shareInfoGroupBox.Text = "Share Details";
            // 
            // shareTypeLabel
            // 
            this.shareTypeLabel.AutoSize = true;
            this.shareTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareTypeLabel.Location = new System.Drawing.Point(43, 56);
            this.shareTypeLabel.Name = "shareTypeLabel";
            this.shareTypeLabel.Size = new System.Drawing.Size(43, 16);
            this.shareTypeLabel.TabIndex = 4;
            this.shareTypeLabel.Text = "Type:";
            // 
            // shareSavingsRadioButton
            // 
            this.shareSavingsRadioButton.AutoSize = true;
            this.shareSavingsRadioButton.Checked = true;
            this.shareSavingsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareSavingsRadioButton.Location = new System.Drawing.Point(117, 54);
            this.shareSavingsRadioButton.Name = "shareSavingsRadioButton";
            this.shareSavingsRadioButton.Size = new System.Drawing.Size(75, 20);
            this.shareSavingsRadioButton.TabIndex = 3;
            this.shareSavingsRadioButton.TabStop = true;
            this.shareSavingsRadioButton.Text = "Savings";
            this.shareSavingsRadioButton.UseVisualStyleBackColor = true;
            // 
            // shareCheckingRadioButton
            // 
            this.shareCheckingRadioButton.AutoSize = true;
            this.shareCheckingRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareCheckingRadioButton.Location = new System.Drawing.Point(222, 54);
            this.shareCheckingRadioButton.Name = "shareCheckingRadioButton";
            this.shareCheckingRadioButton.Size = new System.Drawing.Size(82, 20);
            this.shareCheckingRadioButton.TabIndex = 2;
            this.shareCheckingRadioButton.Text = "Checking";
            this.shareCheckingRadioButton.UseVisualStyleBackColor = true;
            // 
            // shareDescTextBox
            // 
            this.shareDescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareDescTextBox.Location = new System.Drawing.Point(92, 25);
            this.shareDescTextBox.Name = "shareDescTextBox";
            this.shareDescTextBox.Size = new System.Drawing.Size(234, 22);
            this.shareDescTextBox.TabIndex = 1;
            // 
            // shareDescLabel
            // 
            this.shareDescLabel.AutoSize = true;
            this.shareDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareDescLabel.Location = new System.Drawing.Point(7, 28);
            this.shareDescLabel.Name = "shareDescLabel";
            this.shareDescLabel.Size = new System.Drawing.Size(79, 16);
            this.shareDescLabel.TabIndex = 0;
            this.shareDescLabel.Text = "Description:";
            // 
            // shareJointCheckBox
            // 
            this.shareJointCheckBox.AutoSize = true;
            this.shareJointCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareJointCheckBox.Location = new System.Drawing.Point(16, 75);
            this.shareJointCheckBox.Name = "shareJointCheckBox";
            this.shareJointCheckBox.Size = new System.Drawing.Size(106, 20);
            this.shareJointCheckBox.TabIndex = 3;
            this.shareJointCheckBox.Text = "Joint Account";
            this.shareJointCheckBox.UseVisualStyleBackColor = true;
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
            // shareCancelButton
            // 
            this.shareCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareCancelButton.Location = new System.Drawing.Point(103, 315);
            this.shareCancelButton.Name = "shareCancelButton";
            this.shareCancelButton.Size = new System.Drawing.Size(82, 26);
            this.shareCancelButton.TabIndex = 3;
            this.shareCancelButton.Text = "Cancel";
            this.shareCancelButton.UseVisualStyleBackColor = true;
            // 
            // shareSubmitButton
            // 
            this.shareSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareSubmitButton.Location = new System.Drawing.Point(220, 315);
            this.shareSubmitButton.Name = "shareSubmitButton";
            this.shareSubmitButton.Size = new System.Drawing.Size(82, 26);
            this.shareSubmitButton.TabIndex = 4;
            this.shareSubmitButton.Text = "Submit";
            this.shareSubmitButton.UseVisualStyleBackColor = true;
            // 
            // shareBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(415, 353);
            this.Controls.Add(this.shareSubmitButton);
            this.Controls.Add(this.shareCancelButton);
            this.Controls.Add(this.sharePanel);
            this.Controls.Add(this.label1);
            this.Name = "shareBaseForm";
            this.Text = "shareBaseForm";
            this.memberInfoGroupBox.ResumeLayout(false);
            this.memberInfoGroupBox.PerformLayout();
            this.sharePanel.ResumeLayout(false);
            this.sharePanel.PerformLayout();
            this.shareInfoGroupBox.ResumeLayout(false);
            this.shareInfoGroupBox.PerformLayout();
            this.joinInfoGroupBox.ResumeLayout(false);
            this.joinInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox memberInfoGroupBox;
        protected System.Windows.Forms.DateTimePicker memberDOBPicker;
        protected System.Windows.Forms.Label dobLabel;
        protected System.Windows.Forms.TextBox memberSSNTextBox;
        protected System.Windows.Forms.TextBox memberNameTextBox;
        protected System.Windows.Forms.Label ssnLabel;
        protected System.Windows.Forms.Label nameLabel;
        protected System.Windows.Forms.Panel sharePanel;
        protected System.Windows.Forms.CheckBox shareJointCheckBox;
        protected System.Windows.Forms.GroupBox joinInfoGroupBox;
        protected System.Windows.Forms.DateTimePicker jointDOBPicker;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox jointSSNTextBox;
        protected System.Windows.Forms.TextBox jointNameTextBox;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.GroupBox shareInfoGroupBox;
        protected System.Windows.Forms.Label shareTypeLabel;
        protected System.Windows.Forms.RadioButton shareSavingsRadioButton;
        protected System.Windows.Forms.RadioButton shareCheckingRadioButton;
        protected System.Windows.Forms.TextBox shareDescTextBox;
        protected System.Windows.Forms.Label shareDescLabel;
        protected System.Windows.Forms.Button shareCancelButton;
        protected System.Windows.Forms.Button shareSubmitButton;
    }
}