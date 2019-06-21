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
        public Form originatingForm = null;
        public User currentUser = null;
        
        public AddUserForm()
        {
            InitializeComponent();

            existingUsers = DataHelper.GetUsers();
            
        }

        private void UserCancelButton_Click(object sender, EventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void UserCreateButton_Click(object sender, EventArgs e)
        {
            int selectedAuthLevel = 0;

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

            if (validateInputs())
            {
                DataHelper.CreateUser(addUserUsernameTextBox.Text, addUserPasswordTextBox.Text, selectedAuthLevel);
                Console.WriteLine($"User, {addUserUsernameTextBox.Text}, created by {currentUser.GetUserID()}");
                originatingForm.Enabled = true;
                originatingForm.Show();
                this.Close();
            }
            return;
        }
    }
}
