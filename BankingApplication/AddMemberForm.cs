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
    public partial class AddMemberForm : BankingApp_BaseForms.memberBaseForm
    {
        // Instance variables
        // Store form that launched this form for returning
        public Form originatingForm = null;
        // Store current user for change tracking
        public User currentUser = null;

        // Constructor
        public AddMemberForm()
        {
            InitializeComponent();
        }

        // Cancel Click Event
        private void MemberCancelButton_Click(object sender, EventArgs e)
        {
            
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // Submit Click Event
        private void MemberSubmitButton_Click(object sender, EventArgs e)
        {
            // Check that inputs are valid
            if (ValidateInputs())
            {
                // Remove dashes from zip codes
                int parsedZip = Convert.ToInt32(memberZipTextBox.Text.Replace("-", string.Empty));
                string parsedMailZip = mailAddrZipTextBox.Text.Replace("-", string.Empty);
                // Pass inputs to CreateMember function to create a new member in the database
                DataHelper.CreateMember(memberFNameTextBox.Text, memberLNameTextBox.Text, memberSSNTextBox.Text, memberIDNumTextBox.Text, memberDOBPicker.Value.ToString("yyyy-MM-dd"),
                    memberStreetTextBox.Text, memberCityTextBox.Text, memberStateTextBox.Text, parsedZip, memberCellTextBox.Text, memberEmailTextBox.Text,
                    currentUser.GetUserID(), memberMNameTextBox.Text, memberExtraAddrTextBox.Text, memberHomeTextBox.Text, mailAddrStreetTextBox.Text, mailAddrExtraTextBox.Text,
                    mailAddrCityTextBox.Text, mailAddrStateTextBox.Text, parsedMailZip);
                // Log the creation of the member
                Console.WriteLine($"Member, {memberFNameTextBox.Text} {memberLNameTextBox.Text}, has been created by user {currentUser.GetUserID()}");
                // Close this window, return to originatingForm
                originatingForm.Enabled = true;
                originatingForm.Show();
                this.Close();

            }
            // If inputs are not valid, return
            return;
        }
    }
}
