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
    public partial class TransactionForm : Form
    {
        // Store calling form
        public Form originatingForm;
        // Store current user and member
        public User currentUser;
        public Member currentMember;
        // Store destination member if selected
        public Member destMember;
        // Store shares as they are selected
        public int selectedShareID;
        public int selectedDestShareID;
        public int selectedLoanID;

        // Store data to populate DGV's
        DataTable sharesDT = new DataTable();
        DataTable destSharesDT = new DataTable();
        DataTable loansDT = new DataTable();
        DataTable pendingTransactionsTable = new DataTable();
        
        // Constructor
        public TransactionForm()
        {
            InitializeComponent();

            // Add columns to pending DGV
            pendingTransactionsTable.Columns.Add("Share");
            pendingTransactionsTable.Columns.Add("Type");
            pendingTransactionsTable.Columns.Add("Exchange");
            pendingTransactionsTable.Columns.Add("Amount");
            pendingTransactionsTable.Columns.Add("ToMember");
            pendingTransactionsTable.Columns.Add("ToAccount");
        }

        // Logout Click
        private void MainLogoutButton_Click(object sender, EventArgs e)
        {
            // Check for pending transactions
            if (pendingDGV.Rows.Count > 0)
            {
                // If pending transctions, confirm closing
                DialogResult response = MessageBox.Show("There are pending transactions. Are you sure you want to cancel?", "Transactions Pending", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    originatingForm.Enabled = true;
                    originatingForm.Show();
                    this.Close();
                } else
                {
                    return;
                }
            }
            // return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // Deposit Amount Changed
        private void DepositAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            // Change BackColor if null
            if (string.IsNullOrWhiteSpace(depositAmountTextBox.Text))
            {
                depositAmountTextBox.BackColor = Color.Salmon;
            }
            else
            {
                depositAmountTextBox.BackColor = Color.White;
            }
        }

        // Deposit Amount Leave
        private void DepositAmountTextBox_Leave(object sender, EventArgs e)
        {
            // Format value to currency
            if (Double.TryParse(depositAmountTextBox.Text, System.Globalization.NumberStyles.Currency, null, out double amount))
            {
                depositAmountTextBox.Text = amount.ToString("C");
            }
        }

        // Deposit Click
        private void DepositButton_Click(object sender, EventArgs e)
        {
            // Show deposit panel
            depositPanel.Visible = true;
            // Obtain shares for member and populate DGV
            sharesDT = DataHelper.GetShares(currentMember.MemberID);
            depositSharesDGV.DataSource = sharesDT;
        }

        // DepositSharesDGV Cell Click
        private void DepositSharesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set selected share
            selectedShareID = Convert.ToInt32(depositSharesDGV.SelectedRows[0].Cells[0].Value);
            selectedLoanID = -1;
        }

        // Deposit Add Click
        private void DepositAddButton_Click(object sender, EventArgs e)
        {
            // Verify amount has values
            if (string.IsNullOrWhiteSpace(depositAmountTextBox.Text))
            {
                MessageBox.Show("Must provide an amount. Please try again.");
                depositAmountTextBox.BackColor = Color.Salmon;
                return;
            }
            // Verify a share is selected and an exchange type is specified
            if (selectedShareID < 1 || depositExchangeTypeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("You must selected a share to deposit to and specify an exchange type.");
                return;
            }
            // Convert amount input
            double amount = Convert.ToDouble(depositAmountTextBox.Text.Replace("$", string.Empty).Replace(",", string.Empty));
            // Create new row
            DataRow depositRow = pendingTransactionsTable.NewRow();
            // Set values for row
            depositRow["Share"] = selectedShareID;
            depositRow["Type"] = "Deposit";
            depositRow["Exchange"] = depositExchangeTypeComboBox.SelectedItem.ToString();
            depositRow["Amount"] = amount;
            // Add row to pending table
            pendingTransactionsTable.Rows.Add(depositRow);

            // Clear shares data and inputs
            sharesDT.Clear();
            depositAmountTextBox.Text = "";
            depositExchangeTypeComboBox.SelectedIndex = -1;
            depositPanel.Visible = false;
        }

        // Form Load
        private void TransactionForm_Load(object sender, EventArgs e)
        {
            // Set pending table DataSource
            pendingDGV.DataSource = pendingTransactionsTable;
        }

        // Withdrawal Click
        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            // Show withdrawal panel
            withdrawalPanel.Visible = true;
            // Obtain shares for member and populate DGV
            sharesDT = DataHelper.GetShares(currentMember.MemberID);
            withdrawalSharesDGV.DataSource = sharesDT;
        }

        // Withdrawal Amount Text Changed
        private void WithdrawalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            // Change BackColor if null
            if (string.IsNullOrWhiteSpace(withdrawalAmountTextBox.Text))
            {
                withdrawalAmountTextBox.BackColor = Color.Salmon;
            }
            else
            {
                withdrawalAmountTextBox.BackColor = Color.White;
            }
        }

        // Amount Leave
        private void WithdrawalAmountTextBox_Leave(object sender, EventArgs e)
        {
            // Format value as currency
            if (Double.TryParse(withdrawalAmountTextBox.Text, System.Globalization.NumberStyles.Currency, null, out double amount))
            {
                withdrawalAmountTextBox.Text = amount.ToString("C");
            }
        }

        // WithdrawalSharesDGV Cell Click
        private void WithdrawalSharesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set selected share information
            selectedShareID = Convert.ToInt32(withdrawalSharesDGV.SelectedRows[0].Cells[0].Value);
            selectedLoanID = -1;
        }

        // Withdrawal Add Click
        private void WithdrawalAddButton_Click(object sender, EventArgs e)
        {
            // Verify amount has values
            if (string.IsNullOrWhiteSpace(withdrawalAmountTextBox.Text))
            {
                MessageBox.Show("Must provide an amount. Please try again.");
                withdrawalAmountTextBox.BackColor = Color.Salmon;
                return;
            }
            // verify a share is selected
            if (selectedShareID < 1)
            {
                MessageBox.Show("You must selected a share to withdraw from.");
                return;
            }

            // Convert amount input
            double amount = Convert.ToDouble(withdrawalAmountTextBox.Text.Replace("$", string.Empty).Replace(",", string.Empty));

            Share selectedShare = DataHelper.GetShare(selectedShareID);
            // Verify that the share has sufficient funds
            if (amount > Convert.ToDouble(selectedShare.Balance))
            {
                MessageBox.Show("The selected share does not have enough funds. Please select a different share and try again.");
                return;
            }
            // Create new row
            DataRow withdrawalRow = pendingTransactionsTable.NewRow();
            // Set values for row
            withdrawalRow["Share"] = selectedShareID;
            withdrawalRow["Type"] = "Withdrawal";
            withdrawalRow["Exchange"] = withdrawalTypeComboBox.SelectedItem.ToString();
            withdrawalRow["Amount"] = amount;
            // Add row to pending table
            pendingTransactionsTable.Rows.Add(withdrawalRow);

            // Clear data
            sharesDT.Clear();
            withdrawalAmountTextBox.Text = "";
            withdrawalTypeComboBox.SelectedIndex = -1;
            withdrawalPanel.Visible = false;
        }

        // Transfer click
        private void TransferButton_Click(object sender, EventArgs e)
        {
            // Show transfer panel
            transferPanel.Visible = true;
            // Obtain shares for member
            sharesDT = DataHelper.GetShares(currentMember.MemberID);
            transferFromShareDGV.DataSource = sharesDT;
        }

        // DGV Cell Click
        private void TransferFromShareDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set selected share
            selectedShareID = Convert.ToInt32(transferFromShareDGV.SelectedRows[0].Cells[0].Value);
        }

        // Amount Text Changed
        private void TransferAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            // Change BackColor if null
            if (string.IsNullOrWhiteSpace(transferAmountTextBox.Text))
            {
                transferAmountTextBox.BackColor = Color.Salmon;
            }
            else
            {
                transferAmountTextBox.BackColor = Color.White;
            }
        }

        // Amount Leave
        private void TransferAmountTextBox_Leave(object sender, EventArgs e)
        {
            // Convert value to currency
            if (Double.TryParse(transferAmountTextBox.Text, System.Globalization.NumberStyles.Currency, null, out double amount))
            {
                transferAmountTextBox.Text = amount.ToString("C");
            }
        }

        // If in member, set destination member to current member and load member's shares
        private void TransferInMemberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            destSharesDT = DataHelper.GetShares(currentMember.MemberID);
            transferToShareDGV.DataSource = destSharesDT;
            transferToMemberName.Text = currentMember.FirstName + " " + currentMember.LastName;
        }

        // If out of member, prompt for destination member and load available shares
        private void TransferOutMembrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string response = MainForm.ShowDialog("Enter member #:", "Transfer");

            if (int.TryParse(response, out int value))
            {
                destMember = DataHelper.GetMember(Convert.ToInt32(response));
            } else
            {
                MessageBox.Show("Invalid input. Please try again.");
                return;
            }

            destSharesDT = DataHelper.GetShares(destMember.MemberID);
            transferToShareDGV.DataSource = destSharesDT;
            transferToMemberName.Text = destMember.FirstName + " " + destMember.LastName;
        }

        // DGV Cell Click
        private void TransferToShareDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set destination share
            selectedDestShareID = Convert.ToInt32(transferToShareDGV.SelectedRows[0].Cells[0].Value);
        }

        // Transfer Add Click
        private void TransferAddButton_Click(object sender, EventArgs e)
        {
            // Verify amount has values
            if (string.IsNullOrWhiteSpace(transferAmountTextBox.Text))
            {
                MessageBox.Show("Must provide an amount. Please try again.");
                transferAmountTextBox.BackColor = Color.Salmon;
                return;
            }
            // Verify a source and destination share is selected
            if (selectedShareID < 1 || selectedDestShareID < 1)
            {
                MessageBox.Show("You must specify a share to withdraw from and a share to deposit to.");
                return;
            }

            // Convert amount
            double amount = Convert.ToDouble(transferAmountTextBox.Text.Replace("$", string.Empty).Replace(",", string.Empty));

            Share selectedShare = DataHelper.GetShare(selectedShareID);
            // Verify that the share has sufficient funds
            if (amount > Convert.ToDouble(selectedShare.Balance))
            {
                MessageBox.Show("The selected share does not have enough funds. Please select a different share and try again.");
                return;
            }
            // Create new row
            DataRow transferRow = pendingTransactionsTable.NewRow();
            // Set values for row
            transferRow["Share"] = selectedShareID;
            transferRow["Type"] = "Transfer";
            transferRow["Amount"] = amount;
            if (transferOutMembrRadioButton.Checked)
            {
                transferRow["ToMember"] = destMember.MemberID;
            } else
            {
                transferRow["ToMember"] = currentMember.MemberID;
            }
            transferRow["ToAccount"] = selectedDestShareID;
            // Add row to pending table
            pendingTransactionsTable.Rows.Add(transferRow);

            // Clear data
            sharesDT.Clear();
            destSharesDT.Clear();
            transferAmountTextBox.Text = "";
            transferPanel.Visible = false;
        }

        // Payment Click
        private void PaymentButton_Click(object sender, EventArgs e)
        {
            // Show payment panel, populate available shares and loans for member
            paymentPanel.Visible = true;
            sharesDT = DataHelper.GetShares(currentMember.MemberID);
            paymentShareDGV.DataSource = sharesDT;
            loansDT = DataHelper.GetLoans(currentMember.MemberID);
            paymentLoansDGV.DataSource = loansDT;
        }

        // Cash CheckedChanged
        private void PaymentCashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Disable shares DGV
            if (paymentCashRadioButton.Checked)
            {
                paymentShareDGV.Enabled = false;
            }   
        }

        // Check Checked Changed
        private void PaymentCheckRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Disable shares DGV
            if (paymentCheckRadioButton.Checked)
            {
                paymentShareDGV.Enabled = false;
            }
        }

        // Amount Text Changed
        private void PaymentAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            // Change BackColor if null
            if (string.IsNullOrWhiteSpace(transferAmountTextBox.Text))
            {
                transferAmountTextBox.BackColor = Color.Salmon;
            }
            else
            {
                transferAmountTextBox.BackColor = Color.White;
            }
        }

        // Amount leave
        private void PaymentAmountTextBox_Leave(object sender, EventArgs e)
        {
            // Convert to currency
            if (Double.TryParse(transferAmountTextBox.Text, System.Globalization.NumberStyles.Currency, null, out double amount))
            {
                transferAmountTextBox.Text = amount.ToString("C");
            }
        }

        // Cell Click
        private void PaymentShareDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set source share
            selectedShareID = Convert.ToInt32(paymentShareDGV.SelectedRows[0].Cells[0].Value);
        }

        // Cell Click
        private void PaymentLoansDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set destination loan
            selectedLoanID = Convert.ToInt32(paymentLoansDGV.SelectedRows[0].Cells[0].Value);
        }

        // Payment Add Click
        private void PaymentAddButton_Click(object sender, EventArgs e)
        {
            // Verify amount has values
            if (string.IsNullOrWhiteSpace(paymentAmountTextBox.Text))
            {
                MessageBox.Show("Must provide an amount. Please try again.");
                paymentAmountTextBox.BackColor = Color.Salmon;
                return;
            }
            // Convert amount
            double amount = Convert.ToDouble(paymentAmountTextBox.Text.Replace("$", string.Empty).Replace(",", string.Empty));
            // Verify if share is selected as source and a share is selected
            if (paymentShareRadioButton.Checked && selectedShareID < 1)
            {
                MessageBox.Show("If payment is coming from a share, then a share must be selected.");
                return;
            }
            // Verify a loan is selected
            if (selectedLoanID < 1)
            {
                MessageBox.Show("A loan must be selected for a payment to be applied.");
                return;
            }
            // Create new row
            DataRow paymentRow = pendingTransactionsTable.NewRow();
            // Set values for row
            paymentRow["Share"] = '0';
            paymentRow["Type"] = "Payment";
            if (paymentCashRadioButton.Checked)
            {
                paymentRow["Exchange"] = "Cash";
            }
            else if (paymentCheckRadioButton.Checked)
            {
                paymentRow["Exchange"] = "Check";
            }
            else
            {
                paymentRow["Share"] = selectedShareID;
                paymentRow["Exchange"] = "Transfer";
            }
            paymentRow["Amount"] = amount;
            paymentRow["ToAccount"] = selectedLoanID;
            // Add row to pendin table
            pendingTransactionsTable.Rows.Add(paymentRow);
            // Clear data
            sharesDT.Clear();
            loansDT.Clear();
            paymentAmountTextBox.Text = "";
            paymentPanel.Visible = false;
        }

        // Submit Click
        private void MainTransactionButton_Click(object sender, EventArgs e)
        {
            // Verify there are pending transactions
            if (pendingDGV.Rows.Count < 1)
            {
                MessageBox.Show("No pending transactions to submit. Returning to main screen...");
                originatingForm.Enabled = true;
                originatingForm.Show();
                this.Close();
                Console.WriteLine("Pending transactions submitted.");
            }

            // For each pending transaction
            foreach (DataGridViewRow row in pendingDGV.Rows)
            {
                // Determine transaction type and perform proper data manipulation
                switch (row.Cells[1].Value.ToString())
                {
                    case "Deposit":
                        DataHelper.Deposit(currentMember.MemberID, Convert.ToInt32(row.Cells[0].Value), row.Cells[2].Value.ToString(),
                        Convert.ToDouble(row.Cells[3].Value), currentUser.GetUserID());
                        break;
                    case "Withdrawal":
                        DataHelper.Withdrawal(currentMember.MemberID, Convert.ToInt32(row.Cells[0].Value), row.Cells[2].Value.ToString(),
                        Convert.ToDouble(row.Cells[3].Value), currentUser.GetUserID());
                        break;
                    case "Transfer":
                        DataHelper.Transfer(currentMember.MemberID, Convert.ToInt32(row.Cells[0].Value), Convert.ToDouble(row.Cells[3].Value),
                            Convert.ToInt32(row.Cells[4].Value), Convert.ToInt32(row.Cells[5].Value), currentUser.GetUserID());
                        break;
                    case "Payment":
                        if (Convert.ToInt32(row.Cells[0].Value) > 0)
                        {
                            DataHelper.Payment(currentMember.MemberID, row.Cells[2].Value.ToString(), Convert.ToDouble(row.Cells[3].Value),
                               Convert.ToInt32(row.Cells[5].Value), currentUser.GetUserID(), Convert.ToInt32(row.Cells[0].Value));
                        } else
                        {
                            DataHelper.Payment(currentMember.MemberID, row.Cells[2].Value.ToString(), Convert.ToDouble(row.Cells[3].Value),
                               Convert.ToInt32(row.Cells[5].Value), currentUser.GetUserID());
                        }
                        break;
                }   
            }
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
            // Log transactions
            Console.WriteLine("Pending transactions submitted.");
        }

        // PendingDGV Cell Click
        private void PendingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate pending transaction details
            accountNum.Text = pendingDGV.SelectedRows[0].Cells[0].Value.ToString();
            transactionType.Text = pendingDGV.SelectedRows[0].Cells[1].Value.ToString();
            transactionAmount.Text = pendingDGV.SelectedRows[0].Cells[3].Value.ToString();
            exchangeType.Text = pendingDGV.SelectedRows[0].Cells[2].Value.ToString();
            transactionDestID.Text = pendingDGV.SelectedRows[0].Cells[4].Value.ToString();
            transactionDestAcct.Text = pendingDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        // Share Radio Button
        private void PaymentShareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Enable paymentShareDGV
            paymentShareDGV.Enabled = true;
        }

        // Cancel Button
        private void TransactionCancelButton_Click(object sender, EventArgs e)
        {
            // Clear data and close transaction panel
            sharesDT.Clear();
            loansDT.Clear();
            depositPanel.Visible = false;
            withdrawalPanel.Visible = false;
            transferPanel.Visible = false;
            paymentPanel.Visible = false;
        }

        // Remove Transaction click
        private void RemoveTransactionButton_Click(object sender, EventArgs e)
        {
            // Remove transaction from pending table
            pendingDGV.Rows.Remove(pendingDGV.SelectedRows[0]);
        }

        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
        }
    }
}
