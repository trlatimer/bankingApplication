using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class EditMemberForm : BankingApp_BaseForms.memberBaseForm
    {
        // Store calling form, current member, and current user
        public Form originatingForm = null;
        public Member currentMember = null;
        public User currentUser = null;

        // Constructor
        public EditMemberForm()
        {
            InitializeComponent();
        }

        // Populate form data with existing data
        private void populateData()
        {
            // Set Member information
            memberFNameTextBox.Text = currentMember.FirstName;
            memberMNameTextBox.Text = currentMember.MiddleName;
            memberLNameTextBox.Text = currentMember.LastName;
            memberSSNTextBox.Text = currentMember.SocialSecurityNumber;
            memberIDNumTextBox.Text = currentMember.IDNumber;
            memberDOBPicker.Value = currentMember.Birthdate;
            memberStreetTextBox.Text = currentMember.Street;
            memberExtraAddrTextBox.Text = currentMember.ExtraAddress;
            memberCityTextBox.Text = currentMember.City;
            memberStateTextBox.Text = currentMember.State;
            memberZipTextBox.Text = currentMember.ZipCode.ToString();
            mailAddrStreetTextBox.Text = currentMember.MailStreet;
            // If member currently has no mailing info, Check mailingSameCheckBox
            if (string.IsNullOrWhiteSpace(mailAddrStreetTextBox.Text))
            {
                mailingSameCheckBox.Checked = true;
            }
            mailAddrExtraTextBox.Text = currentMember.MailExtraAddress;
            mailAddrCityTextBox.Text = currentMember.MailCity;
            mailAddrStateTextBox.Text = currentMember.MailState;
            mailAddrZipTextBox.Text = currentMember.MailZipCode;
            memberCellTextBox.Text = currentMember.CellPhone;
            memberHomeTextBox.Text = currentMember.HomePhone;
            memberEmailTextBox.Text = currentMember.Email;
        }

        // Cancel Click
        private void MemberCancelButton_Click(object sender, EventArgs e)
        {
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // Submit Click
        private void MemberSubmitButton_Click(object sender, EventArgs e)
        {
            // Check that inputs are valid
            if (ValidateInputs())
            {
                // remove dashes from zip codes
                int parsedZip = Convert.ToInt32(memberZipTextBox.Text.Replace("-", string.Empty));
                string parsedMailZip = mailAddrZipTextBox.Text.Replace("-", string.Empty);
                // Update member with new or existing information on form
                DataHelper.UpdateMember(currentMember.MemberID, memberFNameTextBox.Text, memberLNameTextBox.Text, memberSSNTextBox.Text, memberIDNumTextBox.Text, memberDOBPicker.Value.ToString("yyyy-MM-dd"),
                    memberStreetTextBox.Text, memberCityTextBox.Text, memberStateTextBox.Text, parsedZip, memberCellTextBox.Text, memberEmailTextBox.Text,
                    currentUser.GetUserID(), memberMNameTextBox.Text, memberExtraAddrTextBox.Text, memberHomeTextBox.Text, mailAddrStreetTextBox.Text, mailAddrExtraTextBox.Text,
                    mailAddrCityTextBox.Text, mailAddrStateTextBox.Text, parsedMailZip);
                // Log member update
                Console.WriteLine($"Member, {memberFNameTextBox.Text} {memberLNameTextBox.Text}, has been update by user {currentUser.GetUserID()}");
                // Return to calling form
                originatingForm.Enabled = true;
                originatingForm.Show();
                this.Close();

            }
            return;
        }

        // Form Load
        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            populateData();
        }

        private void EditMemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
        }
    }
}
