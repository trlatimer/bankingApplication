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
    public partial class OpenShareForm : BankingApp_BaseForms.shareBaseForm
    {
        // Store calling form, current user, and current member
        public Form originatingForm = null;
        public User currentUser = null;
        public Member currentMember = null;
        public Member jointMember = null;

        // Constructor
        public OpenShareForm()
        {
            InitializeComponent();
        }

        // Form Load
        private void OpenShareForm_Load(object sender, EventArgs e)
        {
            // Populate form data
            memberNameTextBox.Text = currentMember.FirstName + " " + currentMember.LastName;
            memberSSNTextBox.Text = currentMember.SocialSecurityNumber;
            memberDOBPicker.Value = currentMember.Birthdate;
            jointDOBPicker.Value = jointDOBPicker.MinDate;
        }

        // Joint CheckBox CheckedChanged
        private void ShareJointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If joint, prompt for joint ID
            if (shareJointCheckBox.Checked == true)
            {
                string response = MainForm.ShowDialog("Enter joint ID:", "Add Joint");

                try
                {
                    // Attempt to obtain joint information
                    jointMember = DataHelper.GetMember(Convert.ToInt32(response));
                } catch (Exception ex)
                {
                    MessageBox.Show("Unable to locate user with that UserID. Please try again. \n" + ex.Message, "Locate Error");
                    shareJointCheckBox.Checked = false;
                    return;
                }
                // Populate joint details
                joinInfoGroupBox.Enabled = true;
                jointNameTextBox.Text = jointMember.FirstName + " " + jointMember.LastName;
                jointSSNTextBox.Text = jointMember.SocialSecurityNumber;
                jointDOBPicker.Value = jointMember.Birthdate;
            }
            else
            {
                // Set joint details to empty
                joinInfoGroupBox.Enabled = false;
                jointNameTextBox.Text = "";
                jointSSNTextBox.Text = "";
                jointDOBPicker.Value = jointDOBPicker.MinDate;
            }
        }

        // Cancel Click
        private void ShareCancelButton_Click(object sender, EventArgs e)
        {
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // Submit Click
        private void ShareSubmitButton_Click(object sender, EventArgs e)
        {
            // Set selected account type
            string selectedType;
            if (shareCheckingRadioButton.Checked)
            {
                selectedType = "Checking";
            } else
            {
                selectedType = "Savings";
            }

            // Check if description is null
            if (string.IsNullOrWhiteSpace(shareDescTextBox.Text))
            {
                MessageBox.Show("Share must have a description/name. Please enter one and try again.");
                shareDescTextBox.BackColor = Color.Salmon;
                return;
            }

            // If no joint, create share without joint parameters
            if (shareJointCheckBox.Checked == false)
            {
                DataHelper.CreateShare(currentMember.MemberID, shareDescTextBox.Text, selectedType, currentUser.GetUserID());
            }
            // If joint, create share with joint parameters
            else
            {
                DataHelper.CreateShare(currentMember.MemberID, shareDescTextBox.Text, selectedType, currentUser.GetUserID(), jointMember.MemberID);
            }  
            // Log share creation
            Console.WriteLine($"Account created for, {currentMember.FirstName} {currentMember.LastName}, by user {currentUser.GetUserID()}");
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }
    }
}
