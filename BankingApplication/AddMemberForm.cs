using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace BankingApplication
{
    public partial class AddMemberForm : Form
    {
        public MainForm mainForm = null;

        public List<TextBox> requiredTextBoxes;
        public List<TextBox> numericalTextBoxes;

        public AddMemberForm()
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
        


        private bool ValidateInputs()
        {
            bool valid = true;
            int value;
            string parsedSSN;
            string parsedZip;
            string parsedPhone;

            List<string> messages = new List<string>();

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
                    }
                    valid = false;
                }
            }

            foreach (TextBox textbox in numericalTextBoxes)
            {
                if (!string.IsNullOrWhiteSpace(textbox.Text) && !int.TryParse(textbox.Text, out value))
                {
                    switch (textbox.Name)
                    {
                        case "memberSSNTextBox":
                            messages.Add("Social security must contain only numbers");
                            memberSSNTextBox.BackColor = Color.Salmon;
                            break;
                        case "memberZipTextBox":
                            messages.Add("Zip code must contain only numbers");
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

            parsedPhone = memberCellTextBox.Text.Replace("(", string.Empty).Replace("-", string.Empty);
            if (!int.TryParse(parsedPhone, out value) || (parsedPhone.Length != 10 && parsedPhone.Length != 11)){
                messages.Add("Invalid cell phone number. Please enter a valid number with 10 or 11 digits");
                memberCellTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            parsedPhone = memberHomeTextBox.Text.Replace("(", string.Empty).Replace("-", string.Empty);
            if (!string.IsNullOrWhiteSpace(memberHomeTextBox.Text) && 
                (!int.TryParse(parsedPhone, out value) || 
                (parsedPhone.Length != 10 && parsedPhone.Length != 11))){
                messages.Add("Invalid home phone number. Please enter a valid number with 10 or 11 digits");
                memberCellTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            return valid;
        }

        private void memberCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void memberSubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                MessageBox.Show("Successful submit");
                this.Close();
                mainForm.Show();
            }
        }
    }
}
