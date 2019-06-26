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
        // Store calling form
        public Form originatingForm = null;
        // Store selected user and current user
        public User selectedUser = null;
        public User currentUser = null;
        // Store original username and password for comparing changes
        private string originalPassword;
        private string originalUsername;

        // Constructor
        public EditUserForm()
        {
            InitializeComponent();
            existingUsers = DataHelper.GetUsers();
        }

        // Cancel Click
        private void UserCancelButton_Click(object sender, EventArgs e)
        {
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // Create Click
        private void UserCreateButton_Click(object sender, EventArgs e)
        {
            int selectedAuthLevel = 0;
            bool validInputs = true;

            // Set AuthLevel based on selection
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

            // Check if username has changed and call appropriate validation
            if (originalUsername != addUserUsernameTextBox.Text)
            {
                validInputs = validateInputs();
            } else
            {
                validInputs = validateInputsWOUserName();
            }

            // Check if inputs are valid
            if (validInputs)
            {
                // Check if password has changed
                if (originalPassword != addUserPasswordTextBox.Text)
                {
                    // If changed, update with new password
                    DataHelper.UpdateUserWithPassword(selectedUser.GetUserID(), addUserUsernameTextBox.Text, addUserPasswordTextBox.Text, selectedAuthLevel);
                    // Log update
                    Console.WriteLine($"User, {addUserUsernameTextBox.Text}, edited by {currentUser.GetUserID()}");
                } else
                {
                    // If not changed, update without new password
                    DataHelper.UpdateUserWOPassword(selectedUser.GetUserID(), addUserUsernameTextBox.Text, selectedAuthLevel);
                    // Log update
                    Console.WriteLine($"User, {addUserUsernameTextBox.Text}, edited by {currentUser.GetUserID()}");
                }
                // Return to calling form
                originatingForm.Enabled = true;
                originatingForm.Show();
                this.Close();
            }
            // If inputs are invalid, cancel creation
            return;
        }

        // Form Load
        private void EditUserForm_Load(object sender, EventArgs e)
        {
            // If user is editing themselves, don't allow changes to authority level
            if (currentUser.GetUserName() == selectedUser.GetUserName())
            {
                userAuthLevelComboBox.Enabled = false;
            }

            // Populate form with existing information
            addUserUsernameTextBox.Text = selectedUser.GetUserName();
            addUserPasswordTextBox.Text = selectedUser.GetPassword();
            addUserPasswordConfirmTextBox.Text = selectedUser.GetPassword();
            userAuthLevelComboBox.SelectedIndex = selectedUser.GetAuthLevel();
            originalUsername = selectedUser.GetUserName();
            originalPassword = selectedUser.GetPassword();
        }

        private void EditUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
        }
    }
}
