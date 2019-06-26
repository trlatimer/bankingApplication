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
        // Store current childForm and loginForm for navigation
        public Form childForm = null;
        public LoginForm loginForm = null;

        // Store user currently logged in
        public User currentUser = null;
        // Store current Member if in Account Manager
        public Member currentMember = null;
        // Store MemberID when entered in prompt
        public int enteredMemberID;
        // Store selected share or loan for editing, deletion, or viewing
        public Share selectedShare = null;
        public Loan selectedLoan = null;

        // Store shares and loans for current member when in Account Manager
        public DataTable sharesDT = new DataTable();
        public DataTable loansDT = new DataTable();

        // Constructor
        public MainForm()
        {
            InitializeComponent();
        }

        // Form Closed
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Return to login screen
            loginForm.Show();
        }

        // Logout Click
        private void MainLogoutButton_Click(object sender, EventArgs e)
        {
            // Remove informatoin for current user
            loginForm.currentUser = null;
            // Return to login form
            loginForm.mainForm = this;
            loginForm.Show();
            loginForm.mainForm.Close();
        }

        // Form Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set footer text, default DGV styles
            mainFooterUserLabel.Text = $"Current User: {currentUser.GetUserName()}";
            sharesDGV.DefaultCellStyle.SelectionBackColor = Color.White;
            sharesDGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            loansDGV.DefaultCellStyle.SelectionBackColor = Color.White;
            loansDGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            // Determine what user has available and hide what they do not have permission for
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

        // Add Member Button Click
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            // Create and display Add Member Form
            childForm = new AddMemberForm() {
                originatingForm = this,
                currentUser = currentUser
            };
            this.Enabled = false;
            childForm.Show();
        }

        // View Account Button Click
        private void ViewAccountButton_Click(object sender, EventArgs e)
        {
            // Prompt for Member ID
            string response = ShowDialog("Enter Member ID: ", "View Member Information");
            // If input is valid, store enteredMemberID
            if (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("No member ID entered");
                return;
            }
            else
            {
                enteredMemberID = Convert.ToInt32(response);
            }
            // Populate form data using Member ID entered
            PopulateData();
        }

        // Populate data on form
        public void PopulateData()
        {
            try
            {
                // Attempt to obtain currentMember information based on enteredMemberID
                currentMember = DataHelper.GetMember(enteredMemberID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Member Not Found");
                return;
            }

            // If current member exists, populate form data
            if (currentMember != null)
            {
                memberInfoPanel.Visible = true;
                memberName.Text = currentMember.FirstName + " " + currentMember.MiddleName + " " + currentMember.LastName;
                memberDOB.Text = currentMember.Birthdate.ToString("MM/dd/yyyy");
                memberSSN.Text = currentMember.SocialSecurityNumber.ToString().Substring(7, 4);
                memberIDNum.Text = currentMember.IDNumber;
                memberCell.Text = currentMember.CellPhone;
                memberEmail.Text = currentMember.Email;
                memberStreet.Text = currentMember.Street;
                memberCityStateZip.Text = currentMember.City + ", " + currentMember.State + " " + currentMember.ZipCode.ToString();
                if (string.IsNullOrWhiteSpace(currentMember.HomePhone))
                {
                    memberHome.Text = "";
                }
                else
                {
                    memberHome.Text = currentMember.HomePhone;
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

                // Obtain shares for member and populate DGV
                sharesDT = DataHelper.GetShares(currentMember.MemberID);
                sharesDGV.DataSource = sharesDT;
                sharesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Obtain loans for member and populate DGV
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

        // Display a prompt for the user to enter information
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

        // Edit Member Click
        private void EditMemberButton_Click(object sender, EventArgs e)
        {
            // Create and display EditMemberForm
            childForm = new EditMemberForm()
            {
                currentMember = currentMember,
                currentUser = currentUser,
                originatingForm = this
            };
            childForm.Show();
            this.Enabled = false;
        }

        // Delete Member Click
        private void DeleteMemberButton_Click(object sender, EventArgs e)
        {
            // Display prompt to verify they want to delete member
            DialogResult result = MessageBox.Show($"Are you sure you want to delete member, {currentMember.FirstName} { currentMember.LastName}?", "Delete Member", MessageBoxButtons.YesNo);

            // If yes, attempt to delete member
            if (result == DialogResult.Yes)
            {
                DataHelper.DeleteMember(currentMember.MemberID);
                Console.WriteLine($"Member, {currentMember.FirstName} {currentMember.LastName}");
                currentMember = null;
                memberInfoPanel.Visible = false;
            }
            return;
        }

        // Add User Click
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            // Create and show AddUserForm
            childForm = new AddUserForm()
            {
                currentUser = currentUser,
                originatingForm = this
            };
            childForm.Show();
            this.Enabled = false;
        }

        // Edit User Click
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            // Prompt for Username to edit
            string response = ShowDialog("Enter A Username: ", "Edit User");
            // Store located user to edit
            User foundUser = null;

            try
            {
                // Attempt to find user based off username entered
                foundUser = DataHelper.GetUser(response);
                // If user doesn't have perimssion or is deleting their o
                if (currentUser.GetAuthLevel() != 3 && (currentUser.GetUserID() != foundUser.GetUserID()))
                {
                    MessageBox.Show("You do not have permissions to edit this user. Please contact your administrator.");
                    return;
                }

                // Create and show EditUserForm
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

        // Delet User Click
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            // Prompt for username to delete and confirmation
            string response = ShowDialog("Enter A Username: ", "Delete User");
            string response2 = ShowDialog("Confrim Username: ", "Delete User");
            // Store user to delete
            User foundUser = null;

            // If username and confirmation don't match, display error and cancel
            if (response != response2)
            {
                MessageBox.Show("Usernames did not match. Please try again.");
                return;
            }

            try
            {
                // Attempt to retrieve user with username entered
                foundUser = DataHelper.GetUser(response);
                // Verify user has correct permissions
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

            // Attempt to delete user
            DataHelper.DeleteUser(foundUser.GetUserID());
            // Log user deletion
            MessageBox.Show("Successfully deleted user.");
            // Remove user instance from memory
            foundUser = null;
        }

        // Open Share Click
        private void OpenShareButton_Click(object sender, EventArgs e)
        {
            // Create and show OpenShareForm
            childForm = new OpenShareForm
            {
                currentUser = currentUser,
                currentMember = currentMember,
                originatingForm = this
            };
            this.Enabled = false;
            childForm.Show();
        }

        // SharesDGV Cell CLick
        private void SharesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtain selected share information and store locally
            selectedShare = DataHelper.GetShare(Convert.ToInt32(sharesDGV.SelectedRows[0].Cells[0].Value));
            selectedLoan = null;
            // Change default styles
            sharesDGV.DefaultCellStyle.SelectionBackColor = Color.Blue;
            sharesDGV.DefaultCellStyle.SelectionForeColor = Color.White;
            // Populate account information on form
            accountID.Text = selectedShare.ShareID.ToString();
            accountDesc.Text = selectedShare.Description;
            accountBalance.Text = selectedShare.Balance.ToString("$###,###,##0.00");
            if (selectedShare.JointMemberID == 0)
            {
                accountJointID.Text = "";
                accountJointSSN.Text = "";
            } else
            {
                accountJointID.Text = selectedShare.JointMemberID.ToString();
                accountJointSSN.Text = selectedShare.JointMemberSSN.Substring(7, 4);
            }           
            accountJointName.Text = selectedShare.JointMemberName;
            accountOpenDate.Text = selectedShare.DateOpened.Date.ToString("MM/dd/yyyy");
            if (selectedShare.DateClosed.Date == Convert.ToDateTime("11/11/1111"))
            {
                accountClosedDate.Text = "--/--/----";
            } else
            {
                accountClosedDate.Text = selectedShare.DateClosed.Date.ToString("MM/dd/yyyy");
            }
        }

        // Open Loan Click
        private void OpenLoanButton_Click(object sender, EventArgs e)
        {
            // Create and show OpenLoanForm
            childForm = new OpenLoanForm
            {
                currentUser = currentUser,
                currentMember = currentMember,
                originatingForm = this
            };
            this.Enabled = false;
            childForm.Show();
        }

        // LoansDGV Cell Click
        private void LoansDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Change default styles
            loansDGV.DefaultCellStyle.SelectionBackColor = Color.Blue;
            loansDGV.DefaultCellStyle.SelectionForeColor = Color.White;
            selectedShare = null;
            // Obtain and store loan information
            selectedLoan = DataHelper.GetLoan(Convert.ToInt32(loansDGV.SelectedRows[0].Cells[0].Value));
            // Populate data on form
            accountID.Text = selectedLoan.LoanID.ToString();
            accountDesc.Text = selectedLoan.Description;
            accountBalance.Text = selectedLoan.CurrentBalance.ToString("$###,###,##0.00");
            if (selectedLoan.JointMemberID == 0)
            {
                accountJointID.Text = "";
                accountJointSSN.Text = "";
            }
            else
            {
                accountJointID.Text = selectedLoan.JointMemberID.ToString();
                accountJointSSN.Text = selectedLoan.JointMemberSSN.Substring(7, 4);
            }
            accountJointName.Text = selectedLoan.JointMemberName;
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

        // SharesDGV Leave
        private void SharesDGV_Leave(object sender, EventArgs e)
        {
            // Change default styles to remove trailing blue selection
            sharesDGV.DefaultCellStyle.SelectionBackColor = Color.White;
            sharesDGV.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void LoansDGV_Leave(object sender, EventArgs e)
        {
            // Change default style to remove trailing blue selection
            loansDGV.DefaultCellStyle.SelectionBackColor = Color.White;
            loansDGV.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        // Edit Account Click
        private void EditAccountButton_Click(object sender, EventArgs e)
        {
            // Check whether a share or a loan is selected
            // Ensure a share is selected
            if (selectedShare != null)
            {
                // Create and show EditShareForm
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
            // Ensure a loan is selected
            if (selectedLoan != null)
            {
                // Create and show EditLoanForm
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

        // Close Account Click
        private void CloseAccountButton_Click(object sender, EventArgs e)
        {
            // Prompt for confirmation on account number
            string response = ShowDialog("Confirm account #:", "Close Account");
            // Check if a loan or share is selected
            // Ensure a share is selected
            if (selectedShare != null)
            {
                // If response is valid and matches selected ID
                if (Convert.ToInt32(response) == selectedShare.ShareID)
                {
                    // Prompt user for reason for closing
                    response = ShowDialog("Reason:", "Close Account");
                    try
                    {
                        // Attempt to close share
                        DataHelper.CloseShare(selectedShare.ShareID, response, currentUser.GetUserID());
                    } catch (Exception)
                    {
                        return;
                    }
                    // Log account closure
                    MessageBox.Show("Account successfully closed.");
                    // Repopulate data to show that account has been removed
                    PopulateData();
                } else
                {
                    // If confirmation did not match, display message and cancel
                    MessageBox.Show("Account ID's did not match. Please try again.");
                    return;
                }
            }
            // Ensure a loan is selected
            if (selectedLoan != null)
            {
                // If confirmation matches ID
                if (Convert.ToInt32(response) == selectedLoan.LoanID)
                {
                    try
                    {
                        // Attempt to delete loan
                        DataHelper.CloseLoan(selectedLoan.LoanID, currentUser.GetUserID());
                    } catch (Exception)
                    {
                        return;
                    }
                    // Log account closure
                    MessageBox.Show("Account successfully closed.");
                    PopulateData();
                } else
                {
                    MessageBox.Show("Account ID's did not match. Please try again.");
                    return;
                }
            }
        }

        // Transaction Click
        private void MainTransactionButton_Click(object sender, EventArgs e)
        {
            // Prompt for member ID to perform transactions within
            string response = ShowDialog("Enter Member #: ", "Perform Transaction");

            try
            {
                // Attempt to retrieve member and store locally
                currentMember = DataHelper.GetMember(Convert.ToInt32(response));
            } catch (Exception ex)
            {
                MessageBox.Show("Invalid member number. Please try again. \n" + ex.Message, "Retrieval Error");
                return;
            }
            
            // Create and show TransactionForm
            childForm = new TransactionForm()
            {
                currentMember = currentMember,
                currentUser = currentUser,
                originatingForm = this
            };
            childForm.Show();
            currentMember = null;
            memberInfoPanel.Visible = false;
            this.Enabled = false;
        }

        // Report Click
        private void MainReportButton_Click(object sender, EventArgs e)
        {
            // Create and show ReportForm
            childForm = new ReportForm()
            {
                currentUser = currentUser,
                originatingForm = this
            };
            childForm.Show();
            currentMember = null;
            memberInfoPanel.Visible = false;
            this.Enabled = false;
        }

        // Search Click
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Create and show SearchForm
            childForm = new SearchForm()
            {
                originatingForm = this
            };
            childForm.Show();
            this.Enabled = false;
        }

        // Form Enabled Changed
        private void MainForm_EnabledChanged(object sender, EventArgs e)
        {
            // If changed to enabled
            if (this.Enabled == true)
            {
                // If form returning from is any of the listed forms, do not populate data
                if (childForm.GetType() == typeof(TransactionForm) ||
                    childForm.GetType() == typeof(ReportForm) ||
                    childForm.GetType() == typeof(SearchForm) ||
                    childForm.GetType() == typeof(AddMemberForm) ||
                    childForm.GetType() == typeof(AddUserForm) ||
                    childForm.GetType() == typeof(EditUserForm) ||
                    childForm.GetType() == typeof(ViewTransactionsForm))
                {
                    return;
                }
                // Else, populate data for current member
                PopulateData();
            }
        }

        // View Transaction Click
        private void ViewTranscationsButton_Click(object sender, EventArgs e)
        {
            // Create and show ViewTransactionForm
            childForm = new ViewTransactionsForm()
            {
                originatingForm = this,
                currentMember = currentMember,
                selectedShare = selectedShare,
                selectedLoan = selectedLoan
            };
            childForm.Show();
            this.Enabled = false;
        }
    }
}
