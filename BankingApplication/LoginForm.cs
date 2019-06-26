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
        // Store current user and mainForm (for navigation)
        public User currentUser = null;
        public MainForm mainForm = null;

        // Constructor
        public LoginForm()
        {
            InitializeComponent();

           //Line for creating base Admin user in database. Required due to password hashing
           //DataHelper.createUser("Admin", "admin", 3);
        }

        // Exit button click
        private void loginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Sign In Button Click
        private async void loginSignInButton_Click(object sender, EventArgs e)
        {
            // Check if username or password are empty
            if (string.IsNullOrWhiteSpace(loginUserNameTextBox.Text) || string.IsNullOrWhiteSpace(loginPasswordTextBox.Text))
            {
                MessageBox.Show("Both username and password are required. Please try again.");
                loginUserNameTextBox.Text = "";
                loginPasswordTextBox.Text = "";
                loginPasswordTextBox.BackColor = Color.Salmon;
                loginUserNameTextBox.BackColor = Color.Salmon;
                return;
            }

            // Generate loading form and display
            LoadingForm loading = new LoadingForm();
            loading.StartPosition = FormStartPosition.CenterParent;
            loading.Show(this);
            this.Enabled = false;

            // Attempt to login asynchronously while Loading screen displays
            bool successfulLogin = await attemptLogin();
                       
            // If login is successful
            if (successfulLogin)
            {
                // Log login
                Console.WriteLine($"Successful sign-in for: {currentUser.GetUserName()}");
                // Call MainForm and navigate to it
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
                // If unsuccessful, re-enable this form, close loading screen and display error message
                this.Enabled = true;
                loading.Close();
                MessageBox.Show("Invalid login. Please try again.");
                loginUserNameTextBox.Focus();
                currentUser = null;
                return;
            }
        }

        // Attempt Login ASYNC task
        private async Task<bool> attemptLogin()
        {
            // Run asynchronous task to attempt login
            bool success = await Task.Run<bool>(() => {
                try
                {
                    // Attempt to obtain user by username
                    currentUser = DataHelper.GetUser(loginUserNameTextBox.Text);
                    // Return if password entered matches or not
                    return DataHelper.ValidatePassword(currentUser, loginPasswordTextBox.Text);
                }
                catch
                {
                    return false;
                }
            });
            // Return whether login was successful or not
            return success;
        }

        // Password KeyPress Event
        private void LoginPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If key is enter, trigger Sign In Click event
            if (e.KeyChar == (char)13)
            {
                loginSignInButton_Click(sender, e);
            }
        }

        // Password Text Change
        private void LoginPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Change BackColor if empty
            if (string.IsNullOrWhiteSpace(loginPasswordTextBox.Text))
            {
                loginPasswordTextBox.BackColor = Color.Salmon;
            }
            else
            {
                loginPasswordTextBox.BackColor = Color.White;
            }
        }

        // UserName Text Change
        private void loginUserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Change BackColor if empty
            if (string.IsNullOrWhiteSpace(loginUserNameTextBox.Text))
            {
                loginUserNameTextBox.BackColor = Color.Salmon;
            }
            else
            {
                loginUserNameTextBox.BackColor = Color.White;
            }
        }

        //Form Closing
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Form Activated
        private void LoginForm_Activated(object sender, EventArgs e)
        {
            // Clear any prior data
            loginUserNameTextBox.Text = "";
            loginPasswordTextBox.Text = "";
            loginUserNameTextBox.BackColor = Color.White;
            loginPasswordTextBox.BackColor = Color.White;
            loginUserNameTextBox.Focus();
        }
    }
}
