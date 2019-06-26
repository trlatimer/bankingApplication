using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp_BaseForms
{
    public partial class userBaseForm : Form
    {
        // List of existing users to compare new usernames against
        public List<string> existingUsers = new List<string>();
        // List of accepted special characters in passwords
        public List<string> acceptedSymbols = new List<string>() { "!", "@", "_", "-", "$", "#", "&", "*", "+", "=" };

        // Constructor
        public userBaseForm()
        {
            InitializeComponent();
        }

        // If Username changed, verify it is not empty
        protected void AddUserUsernameTextBox_TextChanged(object sender, EventArgs e)
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

        // Verify input is not empty
        protected void AddUserPasswordTextBox_TextChanged(object sender, EventArgs e)
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

        // Verify input is not empty
        protected void AddUserPasswordConfirmTextBox_TextChanged(object sender, EventArgs e)
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

        // Validate inputs on form
        protected bool validateInputs()
        {
            bool validPassword = false;
            bool valid = true;

            // If the username entered exists in the list of existing users, error
            if (existingUsers.Contains(addUserUsernameTextBox.Text))
            {
                MessageBox.Show("Username already exists. Please try a different one.");
                addUserUsernameTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            // Check that password and password confirmation match
            if (addUserPasswordTextBox.Text != addUserPasswordConfirmTextBox.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                addUserPasswordTextBox.Text = "";
                addUserPasswordTextBox.BackColor = Color.Salmon;
                addUserPasswordConfirmTextBox.Text = "";
                addUserPasswordConfirmTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            // Ensure that password contains at least one accepted symbol, 6 characters, and a number
            if (acceptedSymbols.Any(addUserPasswordTextBox.Text.Contains) &&
                addUserPasswordTextBox.Text.Length > 6 &&
                addUserPasswordTextBox.Text.Any(char.IsDigit))
            {
                validPassword = true;
            }
            else
            {
                // If not, inform user of requirements
                MessageBox.Show("Password must be at least six (6) characters long, contain a special character, and have at least one number.");
                addUserPasswordTextBox.BackColor = Color.Salmon;
                addUserPasswordConfirmTextBox.BackColor = Color.Salmon;
                valid = false;
            }
            // return whether form inputs and password are valid
            return (valid && validPassword);
        }

        // Validate inputs without checking the username
        protected bool validateInputsWOUserName()
        {
            bool validPassword = false;
            bool valid = true;

            // Verify password and password confirmation match
            if (addUserPasswordTextBox.Text != addUserPasswordConfirmTextBox.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                addUserPasswordTextBox.Text = "";
                addUserPasswordTextBox.BackColor = Color.Salmon;
                addUserPasswordConfirmTextBox.Text = "";
                addUserPasswordConfirmTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            // Verify password meets requirements
            if (acceptedSymbols.Any(addUserPasswordTextBox.Text.Contains) &&
                addUserPasswordTextBox.Text.Length > 6 &&
                addUserPasswordTextBox.Text.Any(char.IsDigit))
            {
                validPassword = true;
            }
            else
            {
                MessageBox.Show("Password must be at least six (6) characters long, contain a special character, and have at least one number.");
                addUserPasswordTextBox.BackColor = Color.Salmon;
                addUserPasswordConfirmTextBox.BackColor = Color.Salmon;
                valid = false;
            }
            return (valid && validPassword);
        }

    }
}
