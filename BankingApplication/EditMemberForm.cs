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
        public Form originatingForm = null;
        public Member currentMember = null;
        public User currentUser = null;

        public EditMemberForm()
        {
            InitializeComponent();
        }

        private void populateData()
        {
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

        private void MemberCancelButton_Click(object sender, EventArgs e)
        {
            
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void MemberSubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int parsedZip = Convert.ToInt32(memberZipTextBox.Text.Replace("-", string.Empty));
                string parsedMailZip = mailAddrZipTextBox.Text.Replace("-", string.Empty);
                DataHelper.UpdateMember(currentMember.MemberID, memberFNameTextBox.Text, memberLNameTextBox.Text, memberSSNTextBox.Text, memberIDNumTextBox.Text, memberDOBPicker.Value.ToString("yyyy-MM-dd"),
                    memberStreetTextBox.Text, memberCityTextBox.Text, memberStateTextBox.Text, parsedZip, memberCellTextBox.Text, memberEmailTextBox.Text,
                    currentUser.GetUserID(), memberMNameTextBox.Text, memberExtraAddrTextBox.Text, memberHomeTextBox.Text, mailAddrStreetTextBox.Text, mailAddrExtraTextBox.Text,
                    mailAddrCityTextBox.Text, mailAddrStateTextBox.Text, parsedMailZip);
                Console.WriteLine($"Member, {memberFNameTextBox.Text} {memberLNameTextBox.Text}, has been update by user {currentUser.GetUserID()}");
                originatingForm.Enabled = true;
                originatingForm.Show();
                this.Close();

            }
            return;
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            populateData();
        }
    }
}
