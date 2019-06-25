using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BankingApp_BaseForms
{
    public partial class memberBaseForm : Form
    {
        public List<TextBox> requiredTextBoxes;
        public List<TextBox> numericalTextBoxes;

        public memberBaseForm()
        {
            InitializeComponent();

            memberDOBPicker.Format = DateTimePickerFormat.Custom;
            memberDOBPicker.CustomFormat = "MM/dd/yyyy";

            requiredTextBoxes = new List<TextBox>
            {
                memberFNameTextBox, memberLNameTextBox, memberSSNTextBox, memberIDNumTextBox,
                memberStreetTextBox, memberCityTextBox, memberStateTextBox,
                memberZipTextBox, memberCellTextBox
            };

            numericalTextBoxes = new List<TextBox>
            {
                memberSSNTextBox, memberZipTextBox
            };
        }

        protected void MailingSameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mailingSameCheckBox.Checked == true)
            {
                memberMailAddrGroupBox.Enabled = false;
                requiredTextBoxes.Remove(mailAddrStreetTextBox);
                requiredTextBoxes.Remove(mailAddrCityTextBox);
                requiredTextBoxes.Remove(mailAddrStateTextBox);
                requiredTextBoxes.Remove(mailAddrZipTextBox);
                mailAddrStreetTextBox.BackColor = Color.White;
                mailAddrCityTextBox.BackColor = Color.White;
                mailAddrStateTextBox.BackColor = Color.White;
                mailAddrZipTextBox.BackColor = Color.White;
            }
            else
            {
                memberMailAddrGroupBox.Enabled = true;
            }
        }

        protected void textChanged(Control control)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                control.BackColor = Color.Salmon;
            }
            else
            {
                control.BackColor = Color.White;
            }
        }

        protected bool ValidateInputs()
        {
            bool valid = true;
            int value;
            string parsedSSN;
            string parsedZip;
            string parsedPhone;

            List<string> messages = new List<string>();

            if (!mailingSameCheckBox.Checked)
            {
                requiredTextBoxes.Add(mailAddrStreetTextBox);
                requiredTextBoxes.Add(mailAddrCityTextBox);
                requiredTextBoxes.Add(mailAddrStateTextBox);
                requiredTextBoxes.Add(mailAddrZipTextBox);
            }

            foreach (TextBox textbox in requiredTextBoxes)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    switch (textbox.Name)
                    {
                        case "memberFNameTextBox":
                            messages.Add("Member's first name is required.");
                            memberFNameTextBox.BackColor = Color.Salmon;
                            break;
                        case "memberLNameTextBox":
                            messages.Add("Member's last name is required.");
                            memberLNameTextBox.BackColor = Color.Salmon;
                            break;
                        case "memberSSNTextBox":
                            messages.Add("Member's social security number is required.");
                            memberSSNTextBox.BackColor = Color.Salmon;
                            break;
                        case "memberIDNumTextBox":
                            messages.Add("Member's ID number is required.");
                            memberIDNumTextBox.BackColor = Color.Salmon;
                            break;
                        case "memberStreetTextBox":
                            messages.Add("Member's address is required.");
                            memberStreetTextBox.BackColor = Color.Salmon;
                            break;
                        case "memberCityTextBox":
                            messages.Add("Member's address is required.");
                            memberCityTextBox.BackColor = Color.Salmon;
                            break;
                        case "memberStateTextBox":
                            messages.Add("Member's address is required.");
                            memberStateTextBox.BackColor = Color.Salmon;
                            break;
                        case "memberZipTextBox":
                            messages.Add("Member's address is required.");
                            memberZipTextBox.BackColor = Color.Salmon;
                            break;
                        case "memberCellTextBox":
                            messages.Add("Member's cell phone is required.");
                            memberCellTextBox.BackColor = Color.Salmon;
                            break;
                        case "mailAddrStreetTextBox":
                            messages.Add("Member's mailing address is required if different.");
                            mailAddrStreetTextBox.BackColor = Color.Salmon;
                            break;
                        case "mailAddrCityTextBox":
                            messages.Add("Member's mailing address is required if different.");
                            mailAddrCityTextBox.BackColor = Color.Salmon;
                            break;
                        case "mailAddrStateTextBox":
                            messages.Add("Member's mailing address is required if different.");
                            mailAddrStateTextBox.BackColor = Color.Salmon;
                            break;
                        case "mailAddrZipTextBox":
                            messages.Add("Member's mailing address is required if different.");
                            mailAddrZipTextBox.BackColor = Color.Salmon;
                            break;
                    }
                    valid = false;
                }
            }

            foreach (TextBox textbox in numericalTextBoxes)
            {
                if (!string.IsNullOrWhiteSpace(textbox.Text) && !int.TryParse(textbox.Text.Replace("-", ""), out value))
                {
                    switch (textbox.Name)
                    {
                        case "memberSSNTextBox":
                            messages.Add("Social security must contain only numbers with two optional dashes");
                            memberSSNTextBox.BackColor = Color.Salmon;
                            break;
                        case "memberZipTextBox":
                            messages.Add("Zip code must contain only numbers with an optional dash");
                            memberZipTextBox.BackColor = Color.Salmon;
                            break;
                    }

                    valid = false;
                }
            }

            parsedSSN = memberSSNTextBox.Text.Replace("-", string.Empty);
            if (parsedSSN.Length != 9)
            {
                messages.Add("Social is not the correct length. It should be nine (9) characters long.");
                memberSSNTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            parsedZip = memberZipTextBox.Text.Replace("-", string.Empty);
            if (parsedZip.Length != 5 && parsedZip.Length != 9)
            {
                messages.Add("Physical zip code is not a valid length. Please enter valid five or nine digit zip code.");
                memberZipTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            parsedZip = mailAddrZipTextBox.Text.Replace("-", string.Empty);
            if (!string.IsNullOrWhiteSpace(mailAddrZipTextBox.Text) && parsedZip.Length != 5 && parsedZip.Length != 9)
            {
                messages.Add("Mailing zip code is not a valid length. Please enter valid five or nine digit zip code.");
                mailAddrZipTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            if (memberDOBPicker.Value > DateTime.Now)
            {
                messages.Add("Member's date of birth cannot be after today's date. Please enter a valid date.");
                valid = false;
            }

            if (!(new EmailAddressAttribute().IsValid(memberEmailTextBox.Text)))
            {
                messages.Add("Email address is not valid. Please enter a valid email.");
                memberEmailTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            parsedPhone = memberCellTextBox.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty);
            Console.WriteLine(parsedPhone);
            if (Regex.Matches(parsedPhone, @"[a-zA-Z]").Count > 0)
            {
                messages.Add("Invalid cell phone number. Phone numbers can only contain numbers, (, ), and -.");
                memberCellTextBox.BackColor = Color.Salmon;
                valid = false;
            }
            if (parsedPhone.Length != 10 && parsedPhone.Length != 11)
            {
                messages.Add("Invalid cell phone number.  Please enter a valid number with 10 or 11 digits");
                memberCellTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            parsedPhone = memberHomeTextBox.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty);
            if (Regex.Matches(parsedPhone, @"[a-zA-Z]").Count > 0)
            {
                messages.Add("Invalid home phone number. Phone numbers can only contain numbers, (, ), and -.");
                memberHomeTextBox.BackColor = Color.Salmon;
                valid = false;
            }
            if (!string.IsNullOrWhiteSpace(parsedPhone) && parsedPhone.Length != 10 && parsedPhone.Length != 11)
            {
                messages.Add("Invalid cell phone number.  Please enter a valid number with 10 or 11 digits");
                memberCellTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            if (messages.Count > 0)
            {
                string dialog = "";
                foreach (string message in messages)
                {
                    dialog = dialog + message + "\n";
                }

                MessageBox.Show(dialog);
            }

            return valid;
        }

        // Text Changed Events for required fields
        protected void MemberFNameTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(memberFNameTextBox);
        }

        protected void MemberLNameTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(memberLNameTextBox);
        }

        protected void MemberSSNTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(memberSSNTextBox);
        }

        protected void MemberIDNumTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(memberIDNumTextBox);
        }

        protected void MemberStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(memberStreetTextBox);
        }

        protected void MemberCityTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(memberCityTextBox);
        }

        protected void MemberStateTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(memberStateTextBox);
        }

        protected void MemberZipTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(memberZipTextBox);
        }

        protected void MemberCellTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(memberCellTextBox);
        }

        protected void MemberEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(memberEmailTextBox);
        }

        protected void MailAddrStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(mailAddrStreetTextBox);
        }

        protected void MailAddrCityTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(mailAddrCityTextBox);
        }

        protected void MailAddrStateTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(mailAddrStateTextBox);
        }

        protected void MailAddrZipTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged(mailAddrZipTextBox);
        }

        protected void MemberHomeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MemberCellTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back)
            {
                if (memberCellTextBox.Text.Length == 1)
                {
                    memberCellTextBox.Text = "(" + memberCellTextBox.Text;
                    memberCellTextBox.SelectionStart = 2;
                }
                if (memberCellTextBox.Text.Length == 4)
                {
                    memberCellTextBox.Text += ')';
                    memberCellTextBox.SelectionStart = 6;
                }
                if (memberCellTextBox.Text.Length == 8)
                {
                    memberCellTextBox.Text += '-';
                    memberCellTextBox.SelectionStart = 10;
                }
            }
        }

        private void MemberHomeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back)
            {
                if (memberHomeTextBox.Text.Length == 1)
                {
                    memberHomeTextBox.Text = "(" + memberHomeTextBox.Text;
                    memberHomeTextBox.SelectionStart = 2;
                }
                if (memberHomeTextBox.Text.Length == 4)
                {
                    memberHomeTextBox.Text += ')';
                    memberHomeTextBox.SelectionStart = 6;
                }
                if (memberHomeTextBox.Text.Length == 8)
                {
                    memberHomeTextBox.Text += '-';
                    memberHomeTextBox.SelectionStart = 10;
                }
            }
        }

        private void MemberSSNTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back)
            {
                if (memberSSNTextBox.Text.Length == 3)
                {
                    memberSSNTextBox.Text += '-';
                    memberSSNTextBox.SelectionStart = 5;
                }
                if (memberSSNTextBox.Text.Length == 6)
                {
                    memberSSNTextBox.Text += '-';
                    memberSSNTextBox.SelectionStart = 8;
                }
            }
        }
    }
}
