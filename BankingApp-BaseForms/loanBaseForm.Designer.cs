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
            this.loanPanel = new System.Windows.Forms.Panel();
            this.loanSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.loanPayoffAmountTextBox = new System.Windows.Forms.TextBox();
            this.loanPayoffAmountLabel = new System.Windows.Forms.Label();
            this.loanPayoffDatePicker = new System.Windows.Forms.DateTimePicker();
            this.loanPayOffDate = new System.Windows.Forms.Label();
            this.loanTotalToPayTextBox = new System.Windows.Forms.TextBox();
            this.loanTotalPayLabel = new System.Windows.Forms.Label();
            this.loanPaymentTextBox = new System.Windows.Forms.TextBox();
            this.loanPayment = new System.Windows.Forms.Label();
            this.loanInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.loanAPR = new System.Windows.Forms.TextBox();
            this.loanAmount = new System.Windows.Forms.TextBox();
            this.loanAPRLabel = new System.Windows.Forms.Label();
            this.loanAmountLabel = new System.Windows.Forms.Label();
            this.loanDayDue = new System.Windows.Forms.TextBox();
            this.loanTermTextBox = new System.Windows.Forms.TextBox();
            this.loanTermLabel = new System.Windows.Forms.Label();
            this.loanTypeComboBox = new System.Windows.Forms.ComboBox();
            this.loanDayDueLabel = new System.Windows.Forms.Label();
            this.memberInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.memberDOBPicker = new System.Windows.Forms.DateTimePicker();
            this.dobLabel = new System.Windows.Forms.Label();
            this.memberSSNTextBox = new System.Windows.Forms.TextBox();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.loanTitleLabel = new System.Windows.Forms.Label();
            this.joinInfoGroupBox.SuspendLayout();
            this.loanPanel.SuspendLayout();
            this.loanSummaryGroupBox.SuspendLayout();
            this.loanInfoGroupBox.SuspendLayout();
            this.memberInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shareSubmitButton
            // 
            this.shareSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareSubmitButton.Location = new System.Drawing.Point(213, 476);
            this.shareSubmitButton.Name = "shareSubmitButton";
            this.shareSubmitButton.Size = new System.Drawing.Size(82, 26);
            this.shareSubmitButton.TabIndex = 1;
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
            this.jointDOBPicker.TabIndex = 2;
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
            this.jointSSNTextBox.TabIndex = 1;
            // 
            // jointNameTextBox
            // 
            this.jointNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jointNameTextBox.Location = new System.Drawing.Point(10, 37);
            this.jointNameTextBox.Name = "jointNameTextBox";
            this.jointNameTextBox.ReadOnly = true;
            this.jointNameTextBox.Size = new System.Drawing.Size(177, 22);
            this.jointNameTextBox.TabIndex = 0;
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
            this.shareCancelButton.Location = new System.Drawing.Point(112, 476);
            this.shareCancelButton.Name = "shareCancelButton";
            this.shareCancelButton.Size = new System.Drawing.Size(82, 26);
            this.shareCancelButton.TabIndex = 0;
            this.shareCancelButton.Text = "Cancel";
            this.shareCancelButton.UseVisualStyleBackColor = true;
            // 
            // loanTypeLabel
            // 
            this.loanTypeLabel.AutoSize = true;
            this.loanTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTypeLabel.Location = new System.Drawing.Point(84, 56);
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
            this.loanDescTextBox.TabIndex = 0;
            this.loanDescTextBox.TextChanged += new System.EventHandler(this.LoanDescTextBox_TextChanged);
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
            // loanPanel
            // 
            this.loanPanel.BackColor = System.Drawing.Color.LightGray;
            this.loanPanel.Controls.Add(this.loanSummaryGroupBox);
            this.loanPanel.Controls.Add(this.loanInfoGroupBox);
            this.loanPanel.Controls.Add(this.loanJointCheckBox);
            this.loanPanel.Controls.Add(this.joinInfoGroupBox);
            this.loanPanel.Controls.Add(this.memberInfoGroupBox);
            this.loanPanel.Location = new System.Drawing.Point(14, 46);
            this.loanPanel.Name = "loanPanel";
            this.loanPanel.Size = new System.Drawing.Size(392, 424);
            this.loanPanel.TabIndex = 6;
            // 
            // loanSummaryGroupBox
            // 
            this.loanSummaryGroupBox.Controls.Add(this.loanPayoffAmountTextBox);
            this.loanSummaryGroupBox.Controls.Add(this.loanPayoffAmountLabel);
            this.loanSummaryGroupBox.Controls.Add(this.loanPayoffDatePicker);
            this.loanSummaryGroupBox.Controls.Add(this.loanPayOffDate);
            this.loanSummaryGroupBox.Controls.Add(this.loanTotalToPayTextBox);
            this.loanSummaryGroupBox.Controls.Add(this.loanTotalPayLabel);
            this.loanSummaryGroupBox.Controls.Add(this.loanPaymentTextBox);
            this.loanSummaryGroupBox.Controls.Add(this.loanPayment);
            this.loanSummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanSummaryGroupBox.Location = new System.Drawing.Point(6, 326);
            this.loanSummaryGroupBox.Name = "loanSummaryGroupBox";
            this.loanSummaryGroupBox.Size = new System.Drawing.Size(378, 86);
            this.loanSummaryGroupBox.TabIndex = 5;
            this.loanSummaryGroupBox.TabStop = false;
            this.loanSummaryGroupBox.Text = "Loan Summary";
            // 
            // loanPayoffAmountTextBox
            // 
            this.loanPayoffAmountTextBox.Location = new System.Drawing.Point(100, 59);
            this.loanPayoffAmountTextBox.Name = "loanPayoffAmountTextBox";
            this.loanPayoffAmountTextBox.Size = new System.Drawing.Size(87, 22);
            this.loanPayoffAmountTextBox.TabIndex = 2;
            // 
            // loanPayoffAmountLabel
            // 
            this.loanPayoffAmountLabel.AutoSize = true;
            this.loanPayoffAmountLabel.Location = new System.Drawing.Point(2, 62);
            this.loanPayoffAmountLabel.Name = "loanPayoffAmountLabel";
            this.loanPayoffAmountLabel.Size = new System.Drawing.Size(97, 16);
            this.loanPayoffAmountLabel.TabIndex = 13;
            this.loanPayoffAmountLabel.Text = "Payoff Amount:";
            // 
            // loanPayoffDatePicker
            // 
            this.loanPayoffDatePicker.Enabled = false;
            this.loanPayoffDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanPayoffDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.loanPayoffDatePicker.Location = new System.Drawing.Point(277, 57);
            this.loanPayoffDatePicker.Name = "loanPayoffDatePicker";
            this.loanPayoffDatePicker.Size = new System.Drawing.Size(92, 22);
            this.loanPayoffDatePicker.TabIndex = 3;
            // 
            // loanPayOffDate
            // 
            this.loanPayOffDate.AutoSize = true;
            this.loanPayOffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanPayOffDate.Location = new System.Drawing.Point(190, 62);
            this.loanPayOffDate.Name = "loanPayOffDate";
            this.loanPayOffDate.Size = new System.Drawing.Size(81, 16);
            this.loanPayOffDate.TabIndex = 6;
            this.loanPayOffDate.Text = "Payoff Date:";
            // 
            // loanTotalToPayTextBox
            // 
            this.loanTotalToPayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTotalToPayTextBox.Location = new System.Drawing.Point(269, 29);
            this.loanTotalToPayTextBox.Name = "loanTotalToPayTextBox";
            this.loanTotalToPayTextBox.ReadOnly = true;
            this.loanTotalToPayTextBox.Size = new System.Drawing.Size(100, 22);
            this.loanTotalToPayTextBox.TabIndex = 1;
            // 
            // loanTotalPayLabel
            // 
            this.loanTotalPayLabel.AutoSize = true;
            this.loanTotalPayLabel.Location = new System.Drawing.Point(193, 32);
            this.loanTotalPayLabel.Name = "loanTotalPayLabel";
            this.loanTotalPayLabel.Size = new System.Drawing.Size(72, 16);
            this.loanTotalPayLabel.TabIndex = 4;
            this.loanTotalPayLabel.Text = "Total Cost:";
            // 
            // loanPaymentTextBox
            // 
            this.loanPaymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanPaymentTextBox.Location = new System.Drawing.Point(100, 29);
            this.loanPaymentTextBox.Name = "loanPaymentTextBox";
            this.loanPaymentTextBox.ReadOnly = true;
            this.loanPaymentTextBox.Size = new System.Drawing.Size(87, 22);
            this.loanPaymentTextBox.TabIndex = 0;
            // 
            // loanPayment
            // 
            this.loanPayment.AutoSize = true;
            this.loanPayment.Location = new System.Drawing.Point(22, 32);
            this.loanPayment.Name = "loanPayment";
            this.loanPayment.Size = new System.Drawing.Size(71, 16);
            this.loanPayment.TabIndex = 0;
            this.loanPayment.Text = "Payments:";
            // 
            // loanInfoGroupBox
            // 
            this.loanInfoGroupBox.Controls.Add(this.loanAPR);
            this.loanInfoGroupBox.Controls.Add(this.loanAmount);
            this.loanInfoGroupBox.Controls.Add(this.loanAPRLabel);
            this.loanInfoGroupBox.Controls.Add(this.loanAmountLabel);
            this.loanInfoGroupBox.Controls.Add(this.loanDayDue);
            this.loanInfoGroupBox.Controls.Add(this.loanTermTextBox);
            this.loanInfoGroupBox.Controls.Add(this.loanTermLabel);
            this.loanInfoGroupBox.Controls.Add(this.loanTypeComboBox);
            this.loanInfoGroupBox.Controls.Add(this.loanDayDueLabel);
            this.loanInfoGroupBox.Controls.Add(this.loanTypeLabel);
            this.loanInfoGroupBox.Controls.Add(this.loanDescTextBox);
            this.loanInfoGroupBox.Controls.Add(this.loanDescLabel);
            this.loanInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanInfoGroupBox.Location = new System.Drawing.Point(6, 168);
            this.loanInfoGroupBox.Name = "loanInfoGroupBox";
            this.loanInfoGroupBox.Size = new System.Drawing.Size(378, 152);
            this.loanInfoGroupBox.TabIndex = 4;
            this.loanInfoGroupBox.TabStop = false;
            this.loanInfoGroupBox.Text = "Loan Details";
            // 
            // loanAPR
            // 
            this.loanAPR.Location = new System.Drawing.Point(105, 120);
            this.loanAPR.Name = "loanAPR";
            this.loanAPR.Size = new System.Drawing.Size(50, 22);
            this.loanAPR.TabIndex = 4;
            this.loanAPR.TextChanged += new System.EventHandler(this.LoanAPR_TextChanged);
            // 
            // loanAmount
            // 
            this.loanAmount.Location = new System.Drawing.Point(69, 86);
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.Size = new System.Drawing.Size(86, 22);
            this.loanAmount.TabIndex = 2;
            this.loanAmount.TextChanged += new System.EventHandler(this.LoanAmount_TextChanged);
            this.loanAmount.Leave += new System.EventHandler(this.LoanAmount_Leave);
            // 
            // loanAPRLabel
            // 
            this.loanAPRLabel.AutoSize = true;
            this.loanAPRLabel.Location = new System.Drawing.Point(24, 123);
            this.loanAPRLabel.Name = "loanAPRLabel";
            this.loanAPRLabel.Size = new System.Drawing.Size(62, 16);
            this.loanAPRLabel.TabIndex = 9;
            this.loanAPRLabel.Text = "APR (%):";
            // 
            // loanAmountLabel
            // 
            this.loanAmountLabel.AutoSize = true;
            this.loanAmountLabel.Location = new System.Drawing.Point(7, 89);
            this.loanAmountLabel.Name = "loanAmountLabel";
            this.loanAmountLabel.Size = new System.Drawing.Size(56, 16);
            this.loanAmountLabel.TabIndex = 8;
            this.loanAmountLabel.Text = "Amount:";
            // 
            // loanDayDue
            // 
            this.loanDayDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanDayDue.Location = new System.Drawing.Point(289, 120);
            this.loanDayDue.Name = "loanDayDue";
            this.loanDayDue.Size = new System.Drawing.Size(37, 22);
            this.loanDayDue.TabIndex = 5;
            this.loanDayDue.TextChanged += new System.EventHandler(this.LoanDayDue_TextChanged);
            // 
            // loanTermTextBox
            // 
            this.loanTermTextBox.Location = new System.Drawing.Point(293, 86);
            this.loanTermTextBox.Name = "loanTermTextBox";
            this.loanTermTextBox.Size = new System.Drawing.Size(61, 22);
            this.loanTermTextBox.TabIndex = 3;
            this.loanTermTextBox.TextChanged += new System.EventHandler(this.LoanTermTextBox_TextChanged);
            // 
            // loanTermLabel
            // 
            this.loanTermLabel.AutoSize = true;
            this.loanTermLabel.Location = new System.Drawing.Point(190, 89);
            this.loanTermLabel.Name = "loanTermLabel";
            this.loanTermLabel.Size = new System.Drawing.Size(97, 16);
            this.loanTermLabel.TabIndex = 6;
            this.loanTermLabel.Text = "Term (Months):";
            // 
            // loanTypeComboBox
            // 
            this.loanTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.loanTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.loanTypeComboBox.FormattingEnabled = true;
            this.loanTypeComboBox.Items.AddRange(new object[] {
            "Business",
            "Construction",
            "Mortgage",
            "Recreational",
            "Signature",
            "Student",
            "Vehicle"});
            this.loanTypeComboBox.Location = new System.Drawing.Point(133, 53);
            this.loanTypeComboBox.Name = "loanTypeComboBox";
            this.loanTypeComboBox.Size = new System.Drawing.Size(143, 24);
            this.loanTypeComboBox.Sorted = true;
            this.loanTypeComboBox.TabIndex = 1;
            this.loanTypeComboBox.Text = "Loan Type";
            this.loanTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.LoanTypeComboBox_SelectedIndexChanged);
            // 
            // loanDayDueLabel
            // 
            this.loanDayDueLabel.AutoSize = true;
            this.loanDayDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanDayDueLabel.Location = new System.Drawing.Point(190, 123);
            this.loanDayDueLabel.Name = "loanDayDueLabel";
            this.loanDayDueLabel.Size = new System.Drawing.Size(72, 16);
            this.loanDayDueLabel.TabIndex = 2;
            this.loanDayDueLabel.Text = "Due (Day):";
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
            this.memberDOBPicker.TabIndex = 2;
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
            this.memberSSNTextBox.TabIndex = 1;
            // 
            // memberNameTextBox
            // 
            this.memberNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameTextBox.Location = new System.Drawing.Point(10, 36);
            this.memberNameTextBox.Name = "memberNameTextBox";
            this.memberNameTextBox.ReadOnly = true;
            this.memberNameTextBox.Size = new System.Drawing.Size(177, 22);
            this.memberNameTextBox.TabIndex = 0;
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
            // loanBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(422, 514);
            this.Controls.Add(this.shareSubmitButton);
            this.Controls.Add(this.shareCancelButton);
            this.Controls.Add(this.loanPanel);
            this.Controls.Add(this.loanTitleLabel);
            this.Name = "loanBaseForm";
            this.Text = "loanBaseForm";
            this.joinInfoGroupBox.ResumeLayout(false);
            this.joinInfoGroupBox.PerformLayout();
            this.loanPanel.ResumeLayout(false);
            this.loanPanel.PerformLayout();
            this.loanSummaryGroupBox.ResumeLayout(false);
            this.loanSummaryGroupBox.PerformLayout();
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
        protected System.Windows.Forms.Panel loanPanel;
        protected System.Windows.Forms.GroupBox loanInfoGroupBox;
        protected System.Windows.Forms.GroupBox memberInfoGroupBox;
        protected System.Windows.Forms.DateTimePicker memberDOBPicker;
        protected System.Windows.Forms.Label dobLabel;
        protected System.Windows.Forms.TextBox memberSSNTextBox;
        protected System.Windows.Forms.TextBox memberNameTextBox;
        protected System.Windows.Forms.Label ssnLabel;
        protected System.Windows.Forms.Label nameLabel;
        protected System.Windows.Forms.Label loanTitleLabel;
        protected System.Windows.Forms.DateTimePicker loanPayoffDatePicker;
        protected System.Windows.Forms.ComboBox loanTypeComboBox;
        protected System.Windows.Forms.TextBox loanAmount;
        protected System.Windows.Forms.Label loanAPRLabel;
        protected System.Windows.Forms.Label loanAmountLabel;
        protected System.Windows.Forms.TextBox loanTermTextBox;
        protected System.Windows.Forms.Label loanTermLabel;
        protected System.Windows.Forms.TextBox loanAPR;
        protected System.Windows.Forms.GroupBox loanSummaryGroupBox;
        protected System.Windows.Forms.TextBox loanPaymentTextBox;
        protected System.Windows.Forms.Label loanPayment;
        protected System.Windows.Forms.Label loanPayOffDate;
        protected System.Windows.Forms.TextBox loanTotalToPayTextBox;
        protected System.Windows.Forms.Label loanTotalPayLabel;
        protected System.Windows.Forms.TextBox loanDayDue;
        protected System.Windows.Forms.Label loanDayDueLabel;
        protected System.Windows.Forms.TextBox loanPayoffAmountTextBox;
        protected System.Windows.Forms.Label loanPayoffAmountLabel;
    }
}