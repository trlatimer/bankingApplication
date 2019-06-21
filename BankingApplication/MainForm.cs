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
        // TODO Test using generic Form for storing child and parent forms
        public Form childForm = null;
        public LoginForm loginForm = null;

        public User currentUser = null;
        public Member currentMember = null;
        public int enteredMemberID;
        public Share selectedShare = null;
        public Loan selectedLoan = null;

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

        private void MainLogoutButton_Click(object sender, EventArgs e)
        {
            loginForm.currentUser = null;
            loginForm.mainForm = this;
            loginForm.Show();
            loginForm.mainForm.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainFooterUserLabel.Text = $"Current User: {currentUser.GetUserName()}";
            sharesDGV.DefaultCellStyle.SelectionBackColor = Color.White;
            sharesDGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            loansDGV.DefaultCellStyle.SelectionBackColor = Color.White;
            loansDGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            if (currentUser.GetAuthLevel() == 1)
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
            else if (currentUser.GetAuthLevel() == 2)
            {
                toolStripSeparator4.Available = false;
                addUserButton.Available = false;
                deleteUserButton.Available = false;
                deleteMemberButton.Available = false;
                closeAccountButton.Available = false;
            }
            else if (currentUser.GetAuthLevel() < 1 || currentUser.GetAuthLevel() > 3)
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
            childForm = new AddMemberForm() {
                originatingForm = this,
                currentUser = currentUser
            };
            this.Enabled = false;
            childForm.Show();
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
            PopulateData();
        }

        public void PopulateData()
        {
            try
            {
                currentMember = DataHelper.GetMember(enteredMemberID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to locate member", MessageBoxButtons.OK);
                return;
            }

            if (currentMember != null)
            {
                memberInfoPanel.Visible = true;
                memberName.Text = currentMember.FirstName + " " + currentMember.MiddleName + " " + currentMember.LastName;
                memberDOB.Text = currentMember.Birthdate.ToString("MM/dd/yyyy");
                memberSSN.Text = currentMember.SocialSecurityNumber.ToString().Substring(5, 4);
                memberIDNum.Text = currentMember.IDNumber;
                memberCell.Text = currentMember.CellPhone.ToString("#(###)###-####");
                memberEmail.Text = currentMember.Email;
                memberStreet.Text = currentMember.Street;
                memberCityStateZip.Text = currentMember.City + ", " + currentMember.State + " " + currentMember.ZipCode.ToString();
                if (currentMember.HomePhone == 0)
                {
                    memberHome.Text = "";
                }
                else
                {
                    memberHome.Text = currentMember.HomePhone.ToString("#(###)###-####");
                }
                if (string.IsNullOrWhiteSpace(currentMember.MailStreet))
                {
                    memberMailStreet.Text = "";
                    memberMailCityStateZip.Text = "";
                } else
                {
                    memberMailStreet.Text = currentMember.MailStreet;
                    memberMailCityStateZip.Text = currentMember.MailCity + ", " + currentMember.MailState + " " + currentMember.MailZipCode;
                }

                sharesDT = DataHelper.GetShares(currentMember.MemberID);
                sharesDGV.DataSource = sharesDT;
                sharesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                loansDT = DataHelper.GetLoans(currentMember.MemberID);
                loansDGV.DataSource = loansDT;
                loansDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                accountID.Text = "";
                accountDesc.Text = "";
                accountBalance.Text = "";
                accountJointID.Text = "";
                accountJointName.Text = "";
                accountJointSSN.Text = "";
                accountOpenDate.Text = "";
                accountClosedDate.Text = "";
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
            childForm = new EditMemberForm()
            {
                currentMember = currentMember,
                currentUser = currentUser,
                originatingForm = this
            };
            childForm.Show();
            this.Enabled = false;
        }

        private void DeleteMemberButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete member, {currentMember.FirstName} { currentMember.LastName}?", "Delete Member", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DataHelper.DeleteMember(currentMember.MemberID);
                Console.WriteLine($"Member, {currentMember.FirstName} {currentMember.LastName}");
                currentMember = null;
                memberInfoPanel.Visible = false;
            }
            return;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            childForm = new AddUserForm()
            {
                currentUser = currentUser,
                originatingForm = this
            };
            childForm.Show();
            this.Enabled = false;
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            string response = ShowDialog("Enter A Username: ", "Edit User");
            User foundUser = null;

            try
            {
                foundUser = DataHelper.GetUser(response);
                if (currentUser.GetAuthLevel() != 3 && (currentUser.GetUserID() != foundUser.GetUserID()))
                {
                    MessageBox.Show("You do not have permissions to edit this user. Please contact your administrator.");
                    return;
                }

                childForm = new EditUserForm()
                {
                    currentUser = currentUser,
                    originatingForm = this,
                    selectedUser = foundUser
                };
                childForm.Show();
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
                foundUser = DataHelper.GetUser(response);
                if (currentUser.GetAuthLevel() != 3 && (currentUser.GetUserID() != foundUser.GetUserID()))
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

            DataHelper.DeleteUser(foundUser.GetUserID());
            MessageBox.Show("Successfully deleted user.");
            foundUser = null;
        }

        private void OpenShareButton_Click(object sender, EventArgs e)
        {
            childForm = new OpenShareForm
            {
                currentUser = currentUser,
                currentMember = currentMember,
                originatingForm = this
            };
            this.Enabled = false;
            childForm.Show();
        }

        private void SharesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedShare = DataHelper.GetShare(Convert.ToInt32(sharesDGV.SelectedRows[0].Cells[0].Value));
            selectedLoan = null;
            sharesDGV.DefaultCellStyle.SelectionBackColor = Color.Blue;
            sharesDGV.DefaultCellStyle.SelectionForeColor = Color.White;
            accountID.Text = selectedShare.ShareID.ToString();
            accountDesc.Text = selectedShare.Description;
            accountBalance.Text = selectedShare.Balance.ToString("$###,###,##0.00");
            if (selectedShare.JointMemberID == 0)
            {
                accountJointID.Text = "";
            } else
            {
                accountJointID.Text = selectedShare.JointMemberID.ToString();
            }           
            accountJointName.Text = selectedShare.JointMemberName;
            if (selectedShare.JointMemberSSN == 0)
            {
                accountJointSSN.Text = "";
            } else
            {
                accountJointSSN.Text = selectedShare.JointMemberSSN.ToString().Substring(5, 4);
            }
            accountOpenDate.Text = selectedShare.DateOpened.Date.ToString("MM/dd/yyyy");
            if (selectedShare.DateClosed.Date == Convert.ToDateTime("11/11/1111"))
            {
                accountClosedDate.Text = "--/--/----";
            } else
            {
                accountClosedDate.Text = selectedShare.DateClosed.Date.ToString("MM/dd/yyyy");
            }
        }

        private void OpenLoanButton_Click(object sender, EventArgs e)
        {
            childForm = new OpenLoanForm
            {
                currentUser = currentUser,
                currentMember = currentMember,
                originatingForm = this
            };
            this.Enabled = false;
            childForm.Show();
        }

        private void LoansDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loansDGV.DefaultCellStyle.SelectionBackColor = Color.Blue;
            loansDGV.DefaultCellStyle.SelectionForeColor = Color.White;
            selectedShare = null;
            selectedLoan = DataHelper.GetLoan(Convert.ToInt32(loansDGV.SelectedRows[0].Cells[0].Value));

            accountID.Text = selectedLoan.LoanID.ToString();
            accountDesc.Text = selectedLoan.Description;
            accountBalance.Text = selectedLoan.CurrentBalance.ToString("$###,###,##0.00");
            if (selectedLoan.JointMemberID == 0)
            {
                accountJointID.Text = "";
            }
            else
            {
                accountJointID.Text = selectedLoan.JointMemberID.ToString();
            }
            accountJointName.Text = selectedLoan.JointMemberName;
            if (selectedLoan.JointMemberSSN == 0)
            {
                accountJointSSN.Text = "";
            }
            else
            {
                accountJointSSN.Text = selectedLoan.JointMemberSSN.ToString().Substring(5, 4);
            }
            accountOpenDate.Text = selectedLoan.DateOpened.Date.ToString("MM/dd/yyyy");
            if (selectedLoan.DateClosed.Date == Convert.ToDateTime("11/11/1111"))
            {
                accountClosedDate.Text = "--/--/----";
            }
            else
            {
                accountClosedDate.Text = selectedLoan.DateClosed.Date.ToString("MM/dd/yyyy");
            }
        }

        private void SharesDGV_Leave(object sender, EventArgs e)
        {
            sharesDGV.DefaultCellStyle.SelectionBackColor = Color.White;
            sharesDGV.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void LoansDGV_Leave(object sender, EventArgs e)
        {
            loansDGV.DefaultCellStyle.SelectionBackColor = Color.White;
            loansDGV.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void EditAccountButton_Click(object sender, EventArgs e)
        {
            if (selectedShare != null)
            {
                childForm = new EditShareForm
                {
                    currentUser = currentUser,
                    currentMember = currentMember,
                    currentShare = selectedShare,
                    originatingForm = this
                };
                this.Enabled = false;
                childForm.Show();
            }
            if (selectedLoan != null)
            {
                childForm = new EditLoanForm()
                {
                    currentMember = currentMember,
                    currentUser = currentUser,
                    currentLoan = selectedLoan,
                    originatingForm = this
                };
                childForm.Show();
                this.Enabled = false;
            }
        }

        private void MainForm_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled == true)
            {
                PopulateData();
            }
        }

        private void closeAccountButton_Click(object sender, EventArgs e)
        {
            string response = ShowDialog("Confirm account #:", "Close Account");
            if (selectedShare != null)
            {
                if (Convert.ToInt32(response) == selectedShare.ShareID)
                {
                    response = ShowDialog("Reason:", "Close Account");
                    try
                    {
                        DataHelper.CloseShare(selectedShare.ShareID, response, currentUser.GetUserID());
                    } catch (Exception)
                    {
                        return;
                    }
                    MessageBox.Show("Account successfully closed.");
                    PopulateData();
                } else
                {
                    MessageBox.Show("Account ID's did not match. Please try again.");
                    return;
                }
            }
            if (selectedLoan != null)
            {
                if (Convert.ToInt32(response) == selectedLoan.LoanID)
                {
                    try
                    {
                        DataHelper.CloseLoan(selectedLoan.LoanID, currentUser.GetUserID());
                    } catch (Exception)
                    {
                        return;
                    }
                    MessageBox.Show("Account successfully closed.");
                    PopulateData();
                } else
                {
                    MessageBox.Show("Account ID's did not match. Please try again.");
                    return;
                }
            }
        }
    }
}
