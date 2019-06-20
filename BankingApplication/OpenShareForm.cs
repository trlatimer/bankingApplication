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
        public MainForm mainForm = null;
        public User currentUser = null;
        public Member currentMember = null;
        public Member jointMember = null;

        public OpenShareForm()
        {
            InitializeComponent();
        }

        private void OpenShareForm_Load(object sender, EventArgs e)
        {
            memberNameTextBox.Text = currentMember.firstName + " " + currentMember.lastName;
            memberSSNTextBox.Text = currentMember.socialSecurityNumber.ToString("###-##-####");
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
                    jointMember = DataHelper.getMember(Convert.ToInt32(response));
                } catch (Exception ex)
                {
                    MessageBox.Show("Unable to locate user with that UserID. Please try again. \n" + ex.Message, "Locate Error");
                    return;
                }
                
                joinInfoGroupBox.Enabled = true;
                jointNameTextBox.Text = jointMember.firstName + " " + jointMember.lastName;
                jointSSNTextBox.Text = jointMember.socialSecurityNumber.ToString("###-##-####");
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
            mainForm.Enabled = true;
            mainForm.Show();
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

            DataHelper.createAccount(currentMember.memberID, shareDescTextBox.Text, selectedType, currentUser.getUserID(), jointMember.memberID);
            Console.WriteLine($"Account created for, {currentMember.firstName} {currentMember.lastName}, by user {currentUser.getUserID()}");
            mainForm.Enabled = true;
            mainForm.Show();
            mainForm.populateData();
            this.Close();
        }
    }
}
