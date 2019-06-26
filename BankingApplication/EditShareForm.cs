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
    public partial class EditShareForm : BankingApp_BaseForms.shareBaseForm
    {
        // Store calling form and curremt member and account information
        public Form originatingForm = null;
        public User currentUser = null;
        public Member currentMember = null;
        public Member jointMember = null;
        public Share currentShare = null;

        // Constructor
        public EditShareForm()
        {
            InitializeComponent();
        }

        // Form Load
        private void EditShareForm_Load(object sender, EventArgs e)
        {
            // Set form fields to existing values
            memberNameTextBox.Text = currentMember.FirstName + " " + currentMember.LastName;
            memberSSNTextBox.Text = currentMember.SocialSecurityNumber;
            memberDOBPicker.Value = currentMember.Birthdate;
            shareDescTextBox.Text = currentShare.Description;
            if (currentShare.Type == "Checking")
            {
                shareCheckingRadioButton.Checked = true;
            } else if (currentShare.Type == "Savings")
            {
                shareSavingsRadioButton.Checked = true;
            }

            // If a joint member exists, populate joint information
            if (currentShare.JointMemberID != 0)
            {
                joinInfoGroupBox.Enabled = true;
                shareJointCheckBox.CheckedChanged -= ShareJointCheckBox_CheckedChanged;
                shareJointCheckBox.Checked = true;
                shareJointCheckBox.CheckedChanged += ShareJointCheckBox_CheckedChanged;
                jointMember = DataHelper.GetMember(Convert.ToInt32(currentShare.JointMemberID));
                jointDOBPicker.Value = jointMember.Birthdate;
                jointNameTextBox.Text = currentShare.JointMemberName;
                jointSSNTextBox.Text = currentShare.JointMemberSSN;
            } else
            {
                jointDOBPicker.Value = jointDOBPicker.MinDate;
            }
            
        }

        // Joint CheckBox CheckedChanged
        private void ShareJointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If set to true, prompt for joint ID, obtain joint info, and populate fields
            if (shareJointCheckBox.Checked == true)
            {
                string response = MainForm.ShowDialog("Enter joint ID:", "Add Joint");

                try
                {
                    jointMember = DataHelper.GetMember(Convert.ToInt32(response));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to locate user with that UserID. Please try again. \n" + ex.Message, "Locate Error");
                    return;
                }

                joinInfoGroupBox.Enabled = true;
                jointNameTextBox.Text = jointMember.FirstName + " " + jointMember.LastName;
                jointSSNTextBox.Text = jointMember.SocialSecurityNumber;
                jointDOBPicker.Value = jointMember.Birthdate;
            }
            else
            {
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
            string selectedType;
            // Set selectedType based on radio button is checked
            if (shareCheckingRadioButton.Checked)
            {
                selectedType = "Checking";
            }
            else
            {
                selectedType = "Savings";
            }

            // Ensure that the description has values
            if (string.IsNullOrWhiteSpace(shareDescTextBox.Text))
            {
                MessageBox.Show("Share must have a description/name. Please enter one and try again.");
                shareDescTextBox.BackColor = Color.Salmon;
                return;
            }

            // If no joint, update without joint info
            if (shareJointCheckBox.Checked == false)
            {
                DataHelper.UpdateShare(currentShare.ShareID, shareDescTextBox.Text, selectedType, currentUser.GetUserID());
            }
            // If joint checked, update with joint info
            else
            {
                DataHelper.UpdateShare(currentShare.ShareID, shareDescTextBox.Text, selectedType, currentUser.GetUserID(), jointMember.MemberID);
            }
            // Log Share update
            Console.WriteLine($"Account updated for, {currentMember.FirstName} {currentMember.LastName}, by user {currentUser.GetUserID()}");
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void EditShareForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
        }
    }
}
