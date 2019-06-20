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
        public List<string> existingUsers = new List<string>();
        public List<string> acceptedSymbols = new List<string>() { "!", "@", "_", "-", "$", "#", "&", "*", "+", "=" };

        public userBaseForm()
        {
            InitializeComponent();
        }

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

        protected bool validateInputs()
        {
            bool validPassword = false;
            bool valid = true;

            if (existingUsers.Contains(addUserUsernameTextBox.Text))
            {
                MessageBox.Show("Username already exists. Please try a different one.");
                addUserUsernameTextBox.BackColor = Color.Salmon;
                valid = false;
            }

            if (addUserPasswordTextBox.Text != addUserPasswordConfirmTextBox.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                addUserPasswordTextBox.Text = "";
                addUserPasswordTextBox.BackColor = Color.Salmon;
                addUserPasswordConfirmTextBox.Text = "";
                addUserPasswordConfirmTextBox.BackColor = Color.Salmon;
                valid = false;
            }

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

        protected bool validateInputsWOUserName()
        {
            bool validPassword = false;
            bool valid = true;

            if (addUserPasswordTextBox.Text != addUserPasswordConfirmTextBox.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                addUserPasswordTextBox.Text = "";
                addUserPasswordTextBox.BackColor = Color.Salmon;
                addUserPasswordConfirmTextBox.Text = "";
                addUserPasswordConfirmTextBox.BackColor = Color.Salmon;
                valid = false;
            }

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
