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
        public AddMemberForm addMemberForm = null;
        public EditMemberForm editMemberForm = null;
        public AddUserForm addUserForm = null;
        public EditUserForm editUserForm = null;
        public OpenShareForm openShareForm = null;

        public User currentUser = null;
        public Member currentMember = null;
        public int enteredMemberID;
        public Share selectedShare = null;

        public DataTable sharesDT = new DataTable();
        public DataTable loansDT = new DataTable();

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
                toolStripSeparator4.Available = false;
                addUserButton.Available = false;
                deleteUserButton.Available = false;
                memberButtons.Available = false;
                openShareButton.Available = false;
                openLoanButton.Available = false;
                editAccountButton.Available = false;
                closeAccountButton.Available = false;
            }
            else if (currentUser.getAuthLevel() == 2)
            {
                toolStripSeparator4.Available = false;
                addUserButton.Available = false;
                deleteUserButton.Available = false;
                deleteMemberButton.Available = false;
                closeAccountButton.Available = false;
            }
            else if (currentUser.getAuthLevel() < 1 || currentUser.getAuthLevel() > 3)
            {
                mainTransactionButton.Available = false;
                mainReportButton.Available = false;
                AddMemberButton.Available = false;
                mainManageButton.Available = false;
                toolStripSeparator4.Available = false;
                addUserButton.Available = false;
                deleteUserButton.Available = false;
                memberButtons.Available = false;
                openShareButton.Available = false;
                openLoanButton.Available = false;
                editAccountButton.Available = false;
                closeAccountButton.Available = false;
                viewTranscationsButton.Enabled = false;

                MessageBox.Show("You're account has no privileges. Please see your administrator.");
            }
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

                sharesDT = DataHelper.getShares(currentMember.memberID);
                sharesDGV.DataSource = sharesDT;
                sharesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            string response = ShowDialog("Enter A Username: ", "Edit User");
            User foundUser = null;

            try
            {
                foundUser = DataHelper.getUser(response);
                if (currentUser.getAuthLevel() != 3 && (currentUser.getUserID() != foundUser.getUserID()))
                {
                    MessageBox.Show("You do not have permissions to edit this user. Please contact your administrator.");
                    return;
                }

                editUserForm = new EditUserForm()
                {
                    currentUser = currentUser
                };
                editUserForm.mainForm = this;
                editUserForm.selectedUser = foundUser;
                editUserForm.Show();
                this.Enabled = false;
            } catch (Exception ex)
            {
                MessageBox.Show("Unable to find User. \n" + ex.Message);
                return;
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            string response = ShowDialog("Enter A Username: ", "Delete User");
            string response2 = ShowDialog("Confrim Username: ", "Delete User");
            User foundUser = null;

            if (response != response2)
            {
                MessageBox.Show("Usernames did not match. Please try again.");
                return;
            }

            try
            {
                foundUser = DataHelper.getUser(response);
                if (currentUser.getAuthLevel() != 3 && (currentUser.getUserID() != foundUser.getUserID()))
                {
                    MessageBox.Show("You do not have permissions to delete this user. Please contact your administrator.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to find User. \n" + ex.Message);
                return;
            }

            DataHelper.deleteUser(foundUser.getUserID());
            MessageBox.Show("Successfully deleted user.");
            foundUser = null;
        }

        private void OpenShareButton_Click(object sender, EventArgs e)
        {
            openShareForm = new OpenShareForm
            {
                currentUser = currentUser,
                currentMember = currentMember
            };
            openShareForm.mainForm = this;
            this.Enabled = false;
            openShareForm.Show();
        }

        private void SharesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedShare = DataHelper.getShare(Convert.ToInt32(sharesDGV.SelectedRows[0].Cells[0].Value));

            accountID.Text = selectedShare.shareID.ToString();
            accountDesc.Text = selectedShare.description;
            accountBalance.Text = selectedShare.balance.ToString("$###,###,###.##");
            accountJointID.Text = selectedShare.jointMemberID.ToString();
            accountJointName.Text = selectedShare.jointMemberName;
            accountJointSSN.Text = selectedShare.jointMemberSSN.ToString().Substring(5, 4);
            accountOpenDate.Text = selectedShare.dateOpened.Date.ToString("MM/dd/yyyy");
            accountClosedDate.Text = selectedShare.dateOpened.Date.ToString("MM/dd/yyyy");
        }

    }
}
