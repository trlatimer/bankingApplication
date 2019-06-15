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
    public partial class MainForm : Form
    {
        public LoginForm loginForm = null;

        public User currentUser = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }

        private void mainLogoutButton_Click(object sender, EventArgs e)
        {
            loginForm.currentUser = null;
            loginForm.mainForm = this;
            loginForm.Show();
            loginForm.mainForm.Close();
        }
    }
}
