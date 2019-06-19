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
    public partial class AddUserForm : BankingApp_BaseForms.userBaseForm
    {
        public MainForm mainform = null;
        public User currentUser = null;
        public List<string> existingUsers = new List<string>();
        public List<string> acceptedSymbols = new List<string>() { "!", "@", "_", "-", "$", "#", "&", "*", "+", "=" };

        public AddUserForm()
        {
            InitializeComponent();

            existingUsers = DataHelper.getUsers();
            
        }

        private void UserCancelButton_Click(object sender, EventArgs e)
        {
            mainform.Enabled = true;
            mainform.Show();
            this.Close();
        }

        private void UserCreateButton_Click(object sender, EventArgs e)
        {
            int selectedAuthLevel = 0;

            if (existingUsers.Contains(addUserUsernameTextBox.Text))
            {
                MessageBox.Show("Username already exists. Please try a different one.");
                addUserUsernameTextBox.BackColor = Color.Salmon;
                return;
            }

            if (addUserPasswordTextBox.Text != addUserPasswordConfirmTextBox.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                addUserPasswordTextBox.Text = "";
                addUserPasswordTextBox.BackColor = Color.Salmon;
                addUserPasswordConfirmTextBox.Text = "";
                addUserPasswordConfirmTextBox.BackColor = Color.Salmon;
                return;
            }

            switch (userAuthLevelComboBox.SelectedItem)
            {
                case "Guest":
                    selectedAuthLevel = 0;
                    break;
                case "User":
                    selectedAuthLevel = 1;
                    break;
                case "Moderator":
                    selectedAuthLevel = 2;
                    break;
                case "Manager":
                    selectedAuthLevel = 3;
                    break;
                default:
                    selectedAuthLevel = 0;
                    break;
            }

            if (acceptedSymbols.Any(addUserPasswordTextBox.Text.Contains) && 
                addUserPasswordTextBox.Text.Length > 6 && 
                addUserPasswordTextBox.Text.Any(char.IsDigit))
            {
                DataHelper.createUser(addUserUsernameTextBox.Text, addUserPasswordTextBox.Text, selectedAuthLevel);
                Console.WriteLine($"User, {addUserUsernameTextBox.Text}, created by {currentUser.getUserID()}");
                mainform.Enabled = true;
                mainform.Show();
                this.Close();

            } else
            {
                MessageBox.Show("Password must be at least six (6) characters long, contain a special character, and have at least one number.");
                addUserPasswordTextBox.BackColor = Color.Salmon;
                addUserPasswordConfirmTextBox.BackColor = Color.Salmon;
                return;
            }
        }

        private void AddUserUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addUserUsernameTextBox.Text))
            {
                addUserUsernameTextBox.BackColor = Color.Salmon;
            }
            else
            {
                addUserUsernameTextBox.BackColor = Color.White;
            }
        }

        private void AddUserPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addUserPasswordTextBox.Text))
            {
                addUserPasswordTextBox.BackColor = Color.Salmon;
            }
            else
            {
                addUserPasswordTextBox.BackColor = Color.White;
            }
        }

        private void AddUserPasswordConfirmTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addUserPasswordConfirmTextBox.Text))
            {
                addUserPasswordConfirmTextBox.BackColor = Color.Salmon;
            }
            else
            {
                addUserPasswordConfirmTextBox.BackColor = Color.White;
            }
        }
    }
}
