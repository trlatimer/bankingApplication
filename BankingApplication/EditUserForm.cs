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
    public partial class EditUserForm : BankingApp_BaseForms.userBaseForm
    {
        public MainForm mainForm = null;
        public User selectedUser = null;
        public User currentUser = null;
        private string originalPassword;
        private string originalUsername;

        public EditUserForm()
        {
            InitializeComponent();
            existingUsers = DataHelper.GetUsers();
        }

        private void UserCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            mainForm.Show();
            this.Close();
        }

        private void UserCreateButton_Click(object sender, EventArgs e)
        {
            int selectedAuthLevel = 0;
            bool validInputs = true;

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

            if (originalUsername != addUserUsernameTextBox.Text)
            {
                validInputs = validateInputs();
            } else
            {
                validInputs = validateInputsWOUserName();
            }

            if (validInputs)
            {
                if (originalPassword != addUserPasswordTextBox.Text)
                {
                    DataHelper.UpdateUserWithPassword(selectedUser.GetUserID(), addUserUsernameTextBox.Text, addUserPasswordTextBox.Text, selectedAuthLevel);
                    Console.WriteLine($"User, {addUserUsernameTextBox.Text}, edited by {currentUser.GetUserID()}");
                    mainForm.Enabled = true;
                    mainForm.Show();
                    this.Close();
                } else
                {
                    DataHelper.UpdateUserWOPassword(selectedUser.GetUserID(), addUserUsernameTextBox.Text, selectedAuthLevel);
                    Console.WriteLine($"User, {addUserUsernameTextBox.Text}, edited by {currentUser.GetUserID()}");
                    mainForm.Enabled = true;
                    mainForm.Show();
                    this.Close();
                }
                
            }
            return;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            if (currentUser.GetUserName() == selectedUser.GetUserName())
            {
                userAuthLevelComboBox.Enabled = false;
            }

            addUserUsernameTextBox.Text = selectedUser.GetUserName();
            addUserPasswordTextBox.Text = selectedUser.GetPassword();
            addUserPasswordConfirmTextBox.Text = selectedUser.GetPassword();
            userAuthLevelComboBox.SelectedIndex = selectedUser.GetAuthLevel();
            originalUsername = selectedUser.GetUserName();
            originalPassword = selectedUser.GetPassword();
        }
    }
}
