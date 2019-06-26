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
        // Store calling form
        public Form originatingForm = null;
        // Store current user for change tracking
        public User currentUser = null;
        
        // Constructor
        public AddUserForm()
        {
            InitializeComponent();

            // Obtain existing usernames for comparison
            existingUsers = DataHelper.GetUsers();
            
        }

        // Cancel Button Click
        private void UserCancelButton_Click(object sender, EventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // Create Button Click
        private void UserCreateButton_Click(object sender, EventArgs e)
        {
            int selectedAuthLevel = 0;

            // Set selected authLevel
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

            // Validate inputs on form
            if (validateInputs())
            {
                // create a new user in the database with inputs provided
                DataHelper.CreateUser(addUserUsernameTextBox.Text, addUserPasswordTextBox.Text, selectedAuthLevel);
                // Log creation of user
                Console.WriteLine($"User, {addUserUsernameTextBox.Text}, created by {currentUser.GetUserID()}");
                // return to calling form
                originatingForm.Enabled = true;
                originatingForm.Show();
                this.Close();
            }
            // if not valide, cancel
            return;
        }
    }
}
