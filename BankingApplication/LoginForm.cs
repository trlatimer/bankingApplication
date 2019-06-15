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
    public partial class LoginForm : Form
    {
        public User currentUser = null;

        public LoginForm()
        {
            InitializeComponent();

           //DataHelper.createUser("Admin", "admin", 3);
        }

        private void loginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginSignInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginUserNameTextBox.Text) || string.IsNullOrWhiteSpace(loginPasswordTextBox.Text))
            {
                MessageBox.Show("Both username and password are required. Please try again.");
                loginUserNameTextBox.Text = "";
                loginPasswordTextBox.Text = "";
                loginPasswordTextBox.BackColor = Color.Salmon;
                loginUserNameTextBox.BackColor = Color.Salmon;
                return;
            }

            try
            {
                currentUser = DataHelper.getUser(loginUserNameTextBox.Text);
            } catch
            {
                MessageBox.Show("Invalid login credentials");
                // MessageBox.Show("Unable to locate user");
                return;
            }

            if (DataHelper.ValidatePassword(currentUser, loginPasswordTextBox.Text))
            {
                Console.WriteLine($"Successful sign-in for: {currentUser.getUserName()}");
                MainForm mainForm = new MainForm();
                mainForm.currentUser = currentUser;
                MainForm.loginForm = this;
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid login. Please try again.");
                loginUserNameTextBox.Focus();
                currentUser = null;
            }
        }

        private void LoginPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginSignInButton_Click(sender, e);
            }
        }

        private void LoginPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginPasswordTextBox.Text))
            {
                loginPasswordTextBox.BackColor = Color.Salmon;
            }
            else
            {
                loginPasswordTextBox.BackColor = Color.White;
            }
        }

        private void loginUserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginUserNameTextBox.Text))
            {
                loginUserNameTextBox.BackColor = Color.Salmon;
            }
            else
            {
                loginUserNameTextBox.BackColor = Color.White;
            }
        }
    }
}
