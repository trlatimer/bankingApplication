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
        public Form originatingForm = null;
        public User currentUser = null;
        public Member currentMember = null;
        public Member jointMember = null;
        public Share currentShare = null;

        public EditShareForm()
        {
            InitializeComponent();
        }

        private void EditShareForm_Load(object sender, EventArgs e)
        {
            memberNameTextBox.Text = currentMember.FirstName + " " + currentMember.LastName;
            memberSSNTextBox.Text = currentMember.SocialSecurityNumber.ToString("###-##-####");
            memberDOBPicker.Value = currentMember.Birthdate;
            shareDescTextBox.Text = currentShare.Description;
            if (currentShare.Type == "Checking")
            {
                shareCheckingRadioButton.Checked = true;
            } else if (currentShare.Type == "Savings")
            {
                shareSavingsRadioButton.Checked = true;
            }

            if (currentShare.JointMemberID != 0)
            {
                joinInfoGroupBox.Enabled = true;
                shareJointCheckBox.CheckedChanged -= ShareJointCheckBox_CheckedChanged;
                shareJointCheckBox.Checked = true;
                shareJointCheckBox.CheckedChanged += ShareJointCheckBox_CheckedChanged;
                jointMember = DataHelper.GetMember(Convert.ToInt32(currentShare.JointMemberID));
                jointDOBPicker.Value = jointMember.Birthdate;
                jointNameTextBox.Text = currentShare.JointMemberName;
                jointSSNTextBox.Text = currentShare.JointMemberSSN.ToString("###-##-####");
            } else
            {
                jointDOBPicker.Value = jointDOBPicker.MinDate;
            }
            
        }

        private void ShareJointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
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
                jointSSNTextBox.Text = jointMember.SocialSecurityNumber.ToString("###-##-####");
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

        private void ShareCancelButton_Click(object sender, EventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void ShareSubmitButton_Click(object sender, EventArgs e)
        {
            string selectedType;
            if (shareCheckingRadioButton.Checked)
            {
                selectedType = "Checking";
            }
            else
            {
                selectedType = "Savings";
            }

            if (string.IsNullOrWhiteSpace(shareDescTextBox.Text))
            {
                MessageBox.Show("Share must have a description/name. Please enter one and try again.");
                shareDescTextBox.BackColor = Color.Salmon;
                return;
            }

            if (shareJointCheckBox.Checked == false)
            {
                DataHelper.UpdateShare(currentShare.ShareID, shareDescTextBox.Text, selectedType, currentUser.GetUserID());
            }
            else
            {
                DataHelper.UpdateShare(currentShare.ShareID, shareDescTextBox.Text, selectedType, currentUser.GetUserID(), jointMember.MemberID);
            }
            Console.WriteLine($"Account updated for, {currentMember.FirstName} {currentMember.LastName}, by user {currentUser.GetUserID()}");
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }
    }
}
