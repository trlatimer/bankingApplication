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
            this.addMemberLabel = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.memberAddress = new System.Windows.Forms.GroupBox();
            this.memberStreetLabel = new System.Windows.Forms.Label();
            this.memberExtraAddrLabel = new System.Windows.Forms.Label();
            this.memberStreetTextBox = new System.Windows.Forms.TextBox();
            this.memberExtraAddrTextBox = new System.Windows.Forms.TextBox();
            this.memberCityLabel = new System.Windows.Forms.Label();
            this.memberCityTextBox = new System.Windows.Forms.TextBox();
            this.memberZipLabel = new System.Windows.Forms.Label();
            this.memberZipTextBox = new System.Windows.Forms.TextBox();
            this.memberStateTextBox = new System.Windows.Forms.TextBox();
            this.memberStateLabel = new System.Windows.Forms.Label();
            this.memberIdentificationGroupBox = new System.Windows.Forms.GroupBox();
            this.memberSSNTextBox = new System.Windows.Forms.TextBox();
            this.memberIDNumTextBox = new System.Windows.Forms.TextBox();
            this.memberSSNLabel = new System.Windows.Forms.Label();
            this.memberDLLabel = new System.Windows.Forms.Label();
            this.memberDOBLabel = new System.Windows.Forms.Label();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.memberFNameTextBox = new System.Windows.Forms.TextBox();
            this.memberMNameTextBox = new System.Windows.Forms.TextBox();
            this.memberLNameTextBox = new System.Windows.Forms.TextBox();
            this.nameFirstLabel = new System.Windows.Forms.Label();
            this.nameMiddleLabel = new System.Windows.Forms.Label();
            this.nameLastLabel = new System.Windows.Forms.Label();
            this.memberSubmitButton = new System.Windows.Forms.Button();
            this.memberCancelButton = new System.Windows.Forms.Button();
            this.memberDOBPicker = new System.Windows.Forms.DateTimePicker();
            this.addMemberPanel.SuspendLayout();
            this.memberContactInfoGroupBox.SuspendLayout();
            this.memberMailAddrGroupBox.SuspendLayout();
            this.memberAddress.SuspendLayout();
            this.memberIdentificationGroupBox.SuspendLayout();
            this.nameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addMemberLabel
            // 
            this.addMemberLabel.AutoSize = true;
            this.addMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberLabel.Location = new System.Drawing.Point(172, 9);
            this.addMemberLabel.Name = "addMemberLabel";
            this.addMemberLabel.Size = new System.Drawing.Size(134, 25);
            this.addMemberLabel.TabIndex = 0;
            this.addMemberLabel.Text = "Add Member";
            // 
            // addMemberPanel
            // 
            this.addMemberPanel.AutoScroll = true;
            this.addMemberPanel.BackColor = System.Drawing.Color.LightGray;
            this.addMemberPanel.Controls.Add(this.memberContactInfoGroupBox);
            this.addMemberPanel.Controls.Add(this.mailingSameCheckBox);
            this.addMemberPanel.Controls.Add(this.memberMailAddrGroupBox);
            this.addMemberPanel.Controls.Add(this.memberAddress);
            this.addMemberPanel.Controls.Add(this.memberIdentificationGroupBox);
            this.addMemberPanel.Controls.Add(this.nameGroupBox);
            this.addMemberPanel.Location = new System.Drawing.Point(12, 37);
            this.addMemberPanel.Name = "addMemberPanel";
            this.addMemberPanel.Size = new System.Drawing.Size(451, 502);
            this.addMemberPanel.TabIndex = 1;
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
            this.memberContactInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberContactInfoGroupBox.Location = new System.Drawing.Point(12, 427);
            this.memberContactInfoGroupBox.Name = "memberContactInfoGroupBox";
            this.memberContactInfoGroupBox.Size = new System.Drawing.Size(426, 63);
            this.memberContactInfoGroupBox.TabIndex = 32;
            this.memberContactInfoGroupBox.TabStop = false;
            this.memberContactInfoGroupBox.Text = "Contact Information";
            // 
            // memberEmailLabel
            // 
            this.memberEmailLabel.AutoSize = true;
            this.memberEmailLabel.Location = new System.Drawing.Point(256, 16);
            this.memberEmailLabel.Name = "memberEmailLabel";
            this.memberEmailLabel.Size = new System.Drawing.Size(96, 16);
            this.memberEmailLabel.TabIndex = 28;
            this.memberEmailLabel.Text = "Email Address";
            // 
            // memberHomeLabel
            // 
            this.memberHomeLabel.AutoSize = true;
            this.memberHomeLabel.Location = new System.Drawing.Point(132, 16);
            this.memberHomeLabel.Name = "memberHomeLabel";
            this.memberHomeLabel.Size = new System.Drawing.Size(87, 16);
            this.memberHomeLabel.TabIndex = 27;
            this.memberHomeLabel.Text = "Home Phone";
            // 
            // memberCellLabel
            // 
            this.memberCellLabel.AutoSize = true;
            this.memberCellLabel.Location = new System.Drawing.Point(6, 16);
            this.memberCellLabel.Name = "memberCellLabel";
            this.memberCellLabel.Size = new System.Drawing.Size(73, 16);
            this.memberCellLabel.TabIndex = 26;
            this.memberCellLabel.Text = "Cell Phone";
            // 
            // memberCellTextBox
            // 
            this.memberCellTextBox.Location = new System.Drawing.Point(9, 32);
            this.memberCellTextBox.Name = "memberCellTextBox";
            this.memberCellTextBox.Size = new System.Drawing.Size(100, 22);
            this.memberCellTextBox.TabIndex = 0;
            // 
            // memberHomeTextBox
            // 
            this.memberHomeTextBox.Location = new System.Drawing.Point(135, 32);
            this.memberHomeTextBox.Name = "memberHomeTextBox";
            this.memberHomeTextBox.Size = new System.Drawing.Size(100, 22);
            this.memberHomeTextBox.TabIndex = 1;
            // 
            // memberEmailTextBox
            // 
            this.memberEmailTextBox.Location = new System.Drawing.Point(259, 32);
            this.memberEmailTextBox.Name = "memberEmailTextBox";
            this.memberEmailTextBox.Size = new System.Drawing.Size(161, 22);
            this.memberEmailTextBox.TabIndex = 2;
            // 
            // mailingSameCheckBox
            // 
            this.mailingSameCheckBox.AutoSize = true;
            this.mailingSameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailingSameCheckBox.Location = new System.Drawing.Point(21, 279);
            this.mailingSameCheckBox.Name = "mailingSameCheckBox";
            this.mailingSameCheckBox.Size = new System.Drawing.Size(220, 20);
            this.mailingSameCheckBox.TabIndex = 31;
            this.mailingSameCheckBox.Text = "Mailing address same as above";
            this.mailingSameCheckBox.UseVisualStyleBackColor = true;
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
            this.memberMailAddrGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberMailAddrGroupBox.Location = new System.Drawing.Point(12, 305);
            this.memberMailAddrGroupBox.Name = "memberMailAddrGroupBox";
            this.memberMailAddrGroupBox.Size = new System.Drawing.Size(426, 116);
            this.memberMailAddrGroupBox.TabIndex = 30;
            this.memberMailAddrGroupBox.TabStop = false;
            this.memberMailAddrGroupBox.Text = "Mailing Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Street Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Extra Address";
            // 
            // mailAddrStreetTextBox
            // 
            this.mailAddrStreetTextBox.Location = new System.Drawing.Point(9, 37);
            this.mailAddrStreetTextBox.Name = "mailAddrStreetTextBox";
            this.mailAddrStreetTextBox.Size = new System.Drawing.Size(226, 22);
            this.mailAddrStreetTextBox.TabIndex = 0;
            // 
            // mailAddrExtraTextBox
            // 
            this.mailAddrExtraTextBox.Location = new System.Drawing.Point(259, 37);
            this.mailAddrExtraTextBox.Name = "mailAddrExtraTextBox";
            this.mailAddrExtraTextBox.Size = new System.Drawing.Size(140, 22);
            this.mailAddrExtraTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "City";
            // 
            // mailAddrCityTextBox
            // 
            this.mailAddrCityTextBox.Location = new System.Drawing.Point(9, 79);
            this.mailAddrCityTextBox.Name = "mailAddrCityTextBox";
            this.mailAddrCityTextBox.Size = new System.Drawing.Size(140, 22);
            this.mailAddrCityTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Zip Code";
            // 
            // mailAddrZipTextBox
            // 
            this.mailAddrZipTextBox.Location = new System.Drawing.Point(309, 79);
            this.mailAddrZipTextBox.Name = "mailAddrZipTextBox";
            this.mailAddrZipTextBox.Size = new System.Drawing.Size(100, 22);
            this.mailAddrZipTextBox.TabIndex = 4;
            // 
            // mailAddrStateTextBox
            // 
            this.mailAddrStateTextBox.Location = new System.Drawing.Point(171, 79);
            this.mailAddrStateTextBox.Name = "mailAddrStateTextBox";
            this.mailAddrStateTextBox.Size = new System.Drawing.Size(116, 22);
            this.mailAddrStateTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "State";
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
            this.memberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberAddress.Location = new System.Drawing.Point(12, 157);
            this.memberAddress.Name = "memberAddress";
            this.memberAddress.Size = new System.Drawing.Size(426, 116);
            this.memberAddress.TabIndex = 29;
            this.memberAddress.TabStop = false;
            this.memberAddress.Text = "Address";
            // 
            // memberStreetLabel
            // 
            this.memberStreetLabel.AutoSize = true;
            this.memberStreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberStreetLabel.Location = new System.Drawing.Point(6, 18);
            this.memberStreetLabel.Name = "memberStreetLabel";
            this.memberStreetLabel.Size = new System.Drawing.Size(97, 16);
            this.memberStreetLabel.TabIndex = 5;
            this.memberStreetLabel.Text = "Street Address";
            // 
            // memberExtraAddrLabel
            // 
            this.memberExtraAddrLabel.AutoSize = true;
            this.memberExtraAddrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberExtraAddrLabel.Location = new System.Drawing.Point(256, 18);
            this.memberExtraAddrLabel.Name = "memberExtraAddrLabel";
            this.memberExtraAddrLabel.Size = new System.Drawing.Size(92, 16);
            this.memberExtraAddrLabel.TabIndex = 9;
            this.memberExtraAddrLabel.Text = "Extra Address";
            // 
            // memberStreetTextBox
            // 
            this.memberStreetTextBox.Location = new System.Drawing.Point(9, 37);
            this.memberStreetTextBox.Name = "memberStreetTextBox";
            this.memberStreetTextBox.Size = new System.Drawing.Size(226, 22);
            this.memberStreetTextBox.TabIndex = 0;
            // 
            // memberExtraAddrTextBox
            // 
            this.memberExtraAddrTextBox.Location = new System.Drawing.Point(259, 37);
            this.memberExtraAddrTextBox.Name = "memberExtraAddrTextBox";
            this.memberExtraAddrTextBox.Size = new System.Drawing.Size(140, 22);
            this.memberExtraAddrTextBox.TabIndex = 1;
            // 
            // memberCityLabel
            // 
            this.memberCityLabel.AutoSize = true;
            this.memberCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberCityLabel.Location = new System.Drawing.Point(6, 60);
            this.memberCityLabel.Name = "memberCityLabel";
            this.memberCityLabel.Size = new System.Drawing.Size(30, 16);
            this.memberCityLabel.TabIndex = 11;
            this.memberCityLabel.Text = "City";
            // 
            // memberCityTextBox
            // 
            this.memberCityTextBox.Location = new System.Drawing.Point(9, 79);
            this.memberCityTextBox.Name = "memberCityTextBox";
            this.memberCityTextBox.Size = new System.Drawing.Size(140, 22);
            this.memberCityTextBox.TabIndex = 2;
            // 
            // memberZipLabel
            // 
            this.memberZipLabel.AutoSize = true;
            this.memberZipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberZipLabel.Location = new System.Drawing.Point(306, 60);
            this.memberZipLabel.Name = "memberZipLabel";
            this.memberZipLabel.Size = new System.Drawing.Size(63, 16);
            this.memberZipLabel.TabIndex = 12;
            this.memberZipLabel.Text = "Zip Code";
            // 
            // memberZipTextBox
            // 
            this.memberZipTextBox.Location = new System.Drawing.Point(309, 79);
            this.memberZipTextBox.Name = "memberZipTextBox";
            this.memberZipTextBox.Size = new System.Drawing.Size(100, 22);
            this.memberZipTextBox.TabIndex = 4;
            // 
            // memberStateTextBox
            // 
            this.memberStateTextBox.Location = new System.Drawing.Point(171, 79);
            this.memberStateTextBox.Name = "memberStateTextBox";
            this.memberStateTextBox.Size = new System.Drawing.Size(116, 22);
            this.memberStateTextBox.TabIndex = 3;
            // 
            // memberStateLabel
            // 
            this.memberStateLabel.AutoSize = true;
            this.memberStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberStateLabel.Location = new System.Drawing.Point(168, 60);
            this.memberStateLabel.Name = "memberStateLabel";
            this.memberStateLabel.Size = new System.Drawing.Size(39, 16);
            this.memberStateLabel.TabIndex = 8;
            this.memberStateLabel.Text = "State";
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
            this.memberIdentificationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIdentificationGroupBox.Location = new System.Drawing.Point(12, 86);
            this.memberIdentificationGroupBox.Name = "memberIdentificationGroupBox";
            this.memberIdentificationGroupBox.Size = new System.Drawing.Size(426, 65);
            this.memberIdentificationGroupBox.TabIndex = 28;
            this.memberIdentificationGroupBox.TabStop = false;
            this.memberIdentificationGroupBox.Text = "Identification";
            // 
            // memberSSNTextBox
            // 
            this.memberSSNTextBox.Location = new System.Drawing.Point(9, 39);
            this.memberSSNTextBox.Name = "memberSSNTextBox";
            this.memberSSNTextBox.Size = new System.Drawing.Size(115, 22);
            this.memberSSNTextBox.TabIndex = 0;
            // 
            // memberIDNumTextBox
            // 
            this.memberIDNumTextBox.Location = new System.Drawing.Point(153, 39);
            this.memberIDNumTextBox.Name = "memberIDNumTextBox";
            this.memberIDNumTextBox.Size = new System.Drawing.Size(134, 22);
            this.memberIDNumTextBox.TabIndex = 1;
            // 
            // memberSSNLabel
            // 
            this.memberSSNLabel.AutoSize = true;
            this.memberSSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSSNLabel.Location = new System.Drawing.Point(6, 20);
            this.memberSSNLabel.Name = "memberSSNLabel";
            this.memberSSNLabel.Size = new System.Drawing.Size(110, 16);
            this.memberSSNLabel.TabIndex = 4;
            this.memberSSNLabel.Text = "Social Security #:";
            // 
            // memberDLLabel
            // 
            this.memberDLLabel.AutoSize = true;
            this.memberDLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDLLabel.Location = new System.Drawing.Point(150, 20);
            this.memberDLLabel.Name = "memberDLLabel";
            this.memberDLLabel.Size = new System.Drawing.Size(137, 16);
            this.memberDLLabel.TabIndex = 7;
            this.memberDLLabel.Text = "Driver\'s License/ ID #:";
            // 
            // memberDOBLabel
            // 
            this.memberDOBLabel.AutoSize = true;
            this.memberDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDOBLabel.Location = new System.Drawing.Point(306, 20);
            this.memberDOBLabel.Name = "memberDOBLabel";
            this.memberDOBLabel.Size = new System.Drawing.Size(64, 16);
            this.memberDOBLabel.TabIndex = 6;
            this.memberDOBLabel.Text = "Birthdate:";
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
            this.nameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameGroupBox.Location = new System.Drawing.Point(12, 14);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(426, 65);
            this.nameGroupBox.TabIndex = 26;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Member Name";
            // 
            // memberFNameTextBox
            // 
            this.memberFNameTextBox.Location = new System.Drawing.Point(8, 39);
            this.memberFNameTextBox.Name = "memberFNameTextBox";
            this.memberFNameTextBox.Size = new System.Drawing.Size(141, 22);
            this.memberFNameTextBox.TabIndex = 0;
            // 
            // memberMNameTextBox
            // 
            this.memberMNameTextBox.Location = new System.Drawing.Point(155, 39);
            this.memberMNameTextBox.Name = "memberMNameTextBox";
            this.memberMNameTextBox.Size = new System.Drawing.Size(77, 22);
            this.memberMNameTextBox.TabIndex = 1;
            // 
            // memberLNameTextBox
            // 
            this.memberLNameTextBox.Location = new System.Drawing.Point(238, 39);
            this.memberLNameTextBox.Name = "memberLNameTextBox";
            this.memberLNameTextBox.Size = new System.Drawing.Size(182, 22);
            this.memberLNameTextBox.TabIndex = 2;
            // 
            // nameFirstLabel
            // 
            this.nameFirstLabel.AutoSize = true;
            this.nameFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFirstLabel.Location = new System.Drawing.Point(6, 20);
            this.nameFirstLabel.Name = "nameFirstLabel";
            this.nameFirstLabel.Size = new System.Drawing.Size(36, 16);
            this.nameFirstLabel.TabIndex = 3;
            this.nameFirstLabel.Text = "First:";
            // 
            // nameMiddleLabel
            // 
            this.nameMiddleLabel.AutoSize = true;
            this.nameMiddleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameMiddleLabel.Location = new System.Drawing.Point(152, 20);
            this.nameMiddleLabel.Name = "nameMiddleLabel";
            this.nameMiddleLabel.Size = new System.Drawing.Size(52, 16);
            this.nameMiddleLabel.TabIndex = 10;
            this.nameMiddleLabel.Text = "Middle:";
            // 
            // nameLastLabel
            // 
            this.nameLastLabel.AutoSize = true;
            this.nameLastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLastLabel.Location = new System.Drawing.Point(235, 18);
            this.nameLastLabel.Name = "nameLastLabel";
            this.nameLastLabel.Size = new System.Drawing.Size(36, 16);
            this.nameLastLabel.TabIndex = 2;
            this.nameLastLabel.Text = "Last:";
            // 
            // memberSubmitButton
            // 
            this.memberSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSubmitButton.Location = new System.Drawing.Point(279, 545);
            this.memberSubmitButton.Name = "memberSubmitButton";
            this.memberSubmitButton.Size = new System.Drawing.Size(93, 31);
            this.memberSubmitButton.TabIndex = 0;
            this.memberSubmitButton.Text = "Submit";
            this.memberSubmitButton.UseVisualStyleBackColor = true;
            this.memberSubmitButton.Click += new System.EventHandler(this.memberSubmitButton_Click);
            // 
            // memberCancelButton
            // 
            this.memberCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberCancelButton.Location = new System.Drawing.Point(115, 545);
            this.memberCancelButton.Name = "memberCancelButton";
            this.memberCancelButton.Size = new System.Drawing.Size(88, 31);
            this.memberCancelButton.TabIndex = 1;
            this.memberCancelButton.Text = "Cancel";
            this.memberCancelButton.UseVisualStyleBackColor = true;
            this.memberCancelButton.Click += new System.EventHandler(this.memberCancelButton_Click);
            // 
            // memberDOBPicker
            // 
            this.memberDOBPicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.memberDOBPicker.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.memberDOBPicker.Location = new System.Drawing.Point(309, 39);
            this.memberDOBPicker.Name = "memberDOBPicker";
            this.memberDOBPicker.Size = new System.Drawing.Size(111, 22);
            this.memberDOBPicker.TabIndex = 8;
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(476, 584);
            this.Controls.Add(this.memberCancelButton);
            this.Controls.Add(this.memberSubmitButton);
            this.Controls.Add(this.addMemberPanel);
            this.Controls.Add(this.addMemberLabel);
            this.Name = "AddMemberForm";
            this.Text = "AddMemberForm";
            this.addMemberPanel.ResumeLayout(false);
            this.addMemberPanel.PerformLayout();
            this.memberContactInfoGroupBox.ResumeLayout(false);
            this.memberContactInfoGroupBox.PerformLayout();
            this.memberMailAddrGroupBox.ResumeLayout(false);
            this.memberMailAddrGroupBox.PerformLayout();
            this.memberAddress.ResumeLayout(false);
            this.memberAddress.PerformLayout();
            this.memberIdentificationGroupBox.ResumeLayout(false);
            this.memberIdentificationGroupBox.PerformLayout();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addMemberLabel;
        private System.Windows.Forms.Panel addMemberPanel;
        private System.Windows.Forms.Label memberZipLabel;
        private System.Windows.Forms.Label memberCityLabel;
        private System.Windows.Forms.Label nameMiddleLabel;
        private System.Windows.Forms.Label memberExtraAddrLabel;
        private System.Windows.Forms.Label memberStateLabel;
        private System.Windows.Forms.Label memberDLLabel;
        private System.Windows.Forms.Label memberDOBLabel;
        private System.Windows.Forms.Label memberStreetLabel;
        private System.Windows.Forms.Label memberSSNLabel;
        private System.Windows.Forms.Label nameFirstLabel;
        private System.Windows.Forms.Label nameLastLabel;
        private System.Windows.Forms.TextBox memberEmailTextBox;
        private System.Windows.Forms.TextBox memberHomeTextBox;
        private System.Windows.Forms.TextBox memberCellTextBox;
        private System.Windows.Forms.TextBox memberZipTextBox;
        private System.Windows.Forms.TextBox memberStateTextBox;
        private System.Windows.Forms.TextBox memberCityTextBox;
        private System.Windows.Forms.TextBox memberIDNumTextBox;
        private System.Windows.Forms.TextBox memberStreetTextBox;
        private System.Windows.Forms.TextBox memberExtraAddrTextBox;
        private System.Windows.Forms.TextBox memberLNameTextBox;
        private System.Windows.Forms.TextBox memberFNameTextBox;
        private System.Windows.Forms.TextBox memberMNameTextBox;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.TextBox memberSSNTextBox;
        private System.Windows.Forms.GroupBox memberIdentificationGroupBox;
        private System.Windows.Forms.GroupBox memberAddress;
        private System.Windows.Forms.GroupBox memberContactInfoGroupBox;
        private System.Windows.Forms.CheckBox mailingSameCheckBox;
        private System.Windows.Forms.GroupBox memberMailAddrGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailAddrStreetTextBox;
        private System.Windows.Forms.TextBox mailAddrExtraTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailAddrCityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailAddrZipTextBox;
        private System.Windows.Forms.TextBox mailAddrStateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label memberEmailLabel;
        private System.Windows.Forms.Label memberHomeLabel;
        private System.Windows.Forms.Label memberCellLabel;
        private System.Windows.Forms.Button memberSubmitButton;
        private System.Windows.Forms.Button memberCancelButton;
        private System.Windows.Forms.DateTimePicker memberDOBPicker;
    }
}