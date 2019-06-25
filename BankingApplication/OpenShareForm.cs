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
        public Form originatingForm = null;
        public User currentUser = null;
        public Member currentMember = null;
        public Member jointMember = null;

        public OpenShareForm()
        {
            InitializeComponent();
        }

        private void OpenShareForm_Load(object sender, EventArgs e)
        {
            memberNameTextBox.Text = currentMember.FirstName + " " + currentMember.LastName;
            memberSSNTextBox.Text = currentMember.SocialSecurityNumber;
            memberDOBPicker.Value = currentMember.Birthdate;
            jointDOBPicker.Value = jointDOBPicker.MinDate;
        }

        private void ShareJointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (shareJointCheckBox.Checked == true)
            {
                string response = MainForm.ShowDialog("Enter joint ID:", "Add Joint");

                try
                {
                    jointMember = DataHelper.GetMember(Convert.ToInt32(response));
                } catch (Exception ex)
                {
                    MessageBox.Show("Unable to locate user with that UserID. Please try again. \n" + ex.Message, "Locate Error");
                    shareJointCheckBox.Checked = false;
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
            } else
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
                DataHelper.CreateShare(currentMember.MemberID, shareDescTextBox.Text, selectedType, currentUser.GetUserID());
            }
            else
            {
                DataHelper.CreateShare(currentMember.MemberID, shareDescTextBox.Text, selectedType, currentUser.GetUserID(), jointMember.MemberID);
            }  
            Console.WriteLine($"Account created for, {currentMember.FirstName} {currentMember.LastName}, by user {currentUser.GetUserID()}");
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }
    }
}
