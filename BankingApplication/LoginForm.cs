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
        public MainForm mainForm = null;

        public LoginForm()
        {
            InitializeComponent();

           //DataHelper.createUser("Admin", "admin", 3);
        }

        private void loginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void loginSignInButton_Click(object sender, EventArgs e)
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

            LoadingForm loading = new LoadingForm();
            loading.StartPosition = FormStartPosition.CenterParent;
            loading.Show(this);
            this.Enabled = false;

            bool successfulLogin = await attemptLogin();
                       
            if (successfulLogin)
            {
                Console.WriteLine($"Successful sign-in for: {currentUser.getUserName()}");
                mainForm = new MainForm
                {
                    currentUser = currentUser,
                };
                this.Enabled = true;
                loading.Close();
                mainForm.loginForm = this;
                this.Hide();
                mainForm.Show();
            }
            else
            {
                this.Enabled = true;
                loading.Close();
                MessageBox.Show("Invalid login. Please try again.");
                loginUserNameTextBox.Focus();
                currentUser = null;
                return;
            }
        }

        private async Task<bool> attemptLogin()
        {
            bool success = await Task.Run<bool>(() => {
                try
                {
                    currentUser = DataHelper.getUser(loginUserNameTextBox.Text);
                    return DataHelper.ValidatePassword(currentUser, loginPasswordTextBox.Text);
                }
                catch
                {
                    return false;
                }
            });
            return success;
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

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            loginUserNameTextBox.Text = "";
            loginPasswordTextBox.Text = "";
            loginUserNameTextBox.BackColor = Color.White;
            loginPasswordTextBox.BackColor = Color.White;
            loginUserNameTextBox.Focus();
        }
    }
}
