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
    public partial class Login : Form
    {
        public User currentUser = null;

        public Login()
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
            try
            {
                currentUser = DataHelper.getUser(loginUserNameTextBox.Text);
            } catch
            {
                MessageBox.Show("Unable to locate user");
            }

            if (DataHelper.ValidatePassword(currentUser, loginPasswordTextBox.Text))
            {
                MessageBox.Show($"Succesfully signed in as: {currentUser.getUserName()}");
            }
            else
            {
                MessageBox.Show("Unable to sign in.");
            }
        }
    }
}
