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
        public OpenAccountForm openAccountForm = null;
        public AddMemberForm addMemberForm = null;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainFooterUserLabel.Text = $"Current User: {currentUser.getUserName()}";
            if (currentUser.getAuthLevel() == 1)
            {
                AddMemberButton.Available = false;
                openAccountButton.Available = false;
                mainManageButton.Available = false;
                toolStripSeparator4.Available = false;
            }
            else if (currentUser.getAuthLevel() == 2)
            {
                mainManageButton.Available = false;
                toolStripSeparator4.Available = false;
            }
            else if (currentUser.getAuthLevel() < 1 || currentUser.getAuthLevel() > 3)
            {
                mainTransactionButton.Available = false;
                mainReportButton.Available = false;
                AddMemberButton.Available = false;
                openAccountButton.Available = false;
                mainManageButton.Available = false;
                toolStripSeparator4.Available = false;

                MessageBox.Show("You're account has no privileges. Please see your administrator.");
            }
        }

        private void mainTransactionButton_Click(object sender, EventArgs e)
        {

        }

        private void openShareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAccountForm = new OpenAccountForm
            {
                currentUser = currentUser
            };
            openAccountForm.mainForm = this;
            openAccountForm.Show();
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            addMemberForm = new AddMemberForm();
            addMemberForm.mainForm = this;
            addMemberForm.Show();
        }
    }
}
