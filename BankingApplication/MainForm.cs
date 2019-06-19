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
        public EditMemberForm editMemberForm = null;
        public AddUserForm addUserForm = null;
        public User currentUser = null;
        public Member currentMember = null;
        public int enteredMemberID;

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
                mainManageButton.Available = false;
                toolStripSeparator4.Available = false;

                MessageBox.Show("You're account has no privileges. Please see your administrator.");
            }
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
            this.Enabled = false;
            addMemberForm.Show();
        }

        private void ViewAccounButton_Click(object sender, EventArgs e)
        {
            
            string response = ShowDialog("Enter Member ID: ", "View Member Information");
            if (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("No member ID entered");
                return;
            }
            else
            {
                enteredMemberID = Convert.ToInt32(response);
            }
            populateData();
        }

        public void populateData()
        {
            try
            {
                currentMember = DataHelper.getMember(enteredMemberID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to locate member", MessageBoxButtons.OK);
                return;
            }

            if (currentMember != null)
            {
                memberInfoPanel.Visible = true;
                memberName.Text = currentMember.firstName + " " + currentMember.middleName + " " + currentMember.lastName;
                memberDOB.Text = currentMember.Birthdate.ToString("MM/dd/yyyy");
                memberSSN.Text = currentMember.socialSecurityNumber.ToString().Substring(5, 4);
                memberIDNum.Text = currentMember.IDNumber;
                memberCell.Text = currentMember.cellPhone.ToString("#(###)###-####");
                memberEmail.Text = currentMember.email;
                memberStreet.Text = currentMember.street;
                memberCityStateZip.Text = currentMember.city + ", " + currentMember.state + " " + currentMember.zipCode.ToString();
                if (currentMember.homePhone == 0)
                {
                    memberHome.Text = "";
                }
                else
                {
                    memberHome.Text = currentMember.homePhone.ToString("#(###)###-####");
                }
                if (string.IsNullOrWhiteSpace(currentMember.mailStreet))
                {
                    memberMailStreet.Text = "";
                    memberMailCityStateZip.Text = "";
                } else
                {
                    memberMailStreet.Text = currentMember.mailStreet;
                    memberMailCityStateZip.Text = currentMember.mailCity + ", " + currentMember.mailState + " " + currentMember.mailZipCode;
                }
            }
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 150 };
            Button confirmation = new Button() { Text = "Ok", Left = 75, Width = 50, Top = 75, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void EditMemberButton_Click(object sender, EventArgs e)
        {
            editMemberForm = new EditMemberForm()
            {
                currentMember = currentMember
            };
            editMemberForm.mainForm = this;
            editMemberForm.Show();
            this.Enabled = false;
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete member, {currentMember.firstName} { currentMember.lastName}?", "Delete Member", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DataHelper.deleteMember(currentMember.memberID);
                Console.WriteLine($"Member, {currentMember.firstName} {currentMember.lastName}");
                currentMember = null;
                memberInfoPanel.Visible = false;
            }
            return;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            addUserForm = new AddUserForm()
            {
                currentUser = currentUser
            };
            addUserForm.mainform = this;
            addUserForm.Show();
            this.Enabled = false;
        }
    }
}
