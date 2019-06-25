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
        public Form originatingForm;

        public User currentUser;
        public Member currentMember;
        public Member destMember;
        public int selectedShareID;
        public int selectedDestShareID;
        public int selectedLoanID;

        DataTable sharesDT = new DataTable();
        DataTable destSharesDT = new DataTable();
        DataTable loansDT = new DataTable();
        DataTable pendingTransactionsTable = new DataTable();
        

        public TransactionForm()
        {
            InitializeComponent();

            pendingTransactionsTable.Columns.Add("Share");
            pendingTransactionsTable.Columns.Add("Type");
            pendingTransactionsTable.Columns.Add("Exchange");
            pendingTransactionsTable.Columns.Add("Amount");
            pendingTransactionsTable.Columns.Add("ToMember");
            pendingTransactionsTable.Columns.Add("ToAccount");
        }

        private void MainLogoutButton_Click(object sender, EventArgs e)
        {
            if (pendingDGV.Rows.Count > 0)
            {
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
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void DepositAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(depositAmountTextBox.Text))
            {
                depositAmountTextBox.BackColor = Color.Salmon;
            }
            else
            {
                depositAmountTextBox.BackColor = Color.White;
            }
        }

        private void DepositAmountTextBox_Leave(object sender, EventArgs e)
        {
            if (Double.TryParse(depositAmountTextBox.Text, System.Globalization.NumberStyles.Currency, null, out double amount))
            {
                depositAmountTextBox.Text = amount.ToString("C");
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            depositPanel.Visible = true;

            sharesDT = DataHelper.GetShares(currentMember.MemberID);
            depositSharesDGV.DataSource = sharesDT;
        }

        private void DepositSharesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedShareID = Convert.ToInt32(depositSharesDGV.SelectedRows[0].Cells[0].Value);
            selectedLoanID = -1;
        }

        private void DepositAddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(depositAmountTextBox.Text))
            {
                MessageBox.Show("Must provide an amount. Please try again.");
                depositAmountTextBox.BackColor = Color.Salmon;
                return;
            }
            if (selectedShareID < 1 || depositExchangeTypeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("You must selected a share to deposit to and specify an exchange type.");
                return;
            }

            double amount = Convert.ToDouble(depositAmountTextBox.Text.Replace("$", string.Empty).Replace(",", string.Empty));

            DataRow depositRow = pendingTransactionsTable.NewRow();
            depositRow["Share"] = selectedShareID;
            depositRow["Type"] = "Deposit";
            depositRow["Exchange"] = depositExchangeTypeComboBox.SelectedItem.ToString();
            depositRow["Amount"] = amount;
            pendingTransactionsTable.Rows.Add(depositRow);

            sharesDT.Clear();
            depositAmountTextBox.Text = "";
            depositExchangeTypeComboBox.SelectedIndex = -1;
            depositPanel.Visible = false;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            pendingDGV.DataSource = pendingTransactionsTable;
        }

        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            withdrawalPanel.Visible = true;

            sharesDT = DataHelper.GetShares(currentMember.MemberID);
            withdrawalSharesDGV.DataSource = sharesDT;
        }

        private void WithdrawalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(withdrawalAmountTextBox.Text))
            {
                withdrawalAmountTextBox.BackColor = Color.Salmon;
            }
            else
            {
                withdrawalAmountTextBox.BackColor = Color.White;
            }
        }

        private void WithdrawalAmountTextBox_Leave(object sender, EventArgs e)
        {
            if (Double.TryParse(withdrawalAmountTextBox.Text, System.Globalization.NumberStyles.Currency, null, out double amount))
            {
                withdrawalAmountTextBox.Text = amount.ToString("C");
            }
        }

        private void WithdrawalSharesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedShareID = Convert.ToInt32(withdrawalSharesDGV.SelectedRows[0].Cells[0].Value);
            selectedLoanID = -1;
        }

        private void WithdrawalAddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(withdrawalAmountTextBox.Text))
            {
                MessageBox.Show("Must provide an amount. Please try again.");
                withdrawalAmountTextBox.BackColor = Color.Salmon;
                return;
            }
            if (selectedShareID < 1)
            {
                MessageBox.Show("You must selected a share to withdraw from.");
                return;
            }

            double amount = Convert.ToDouble(withdrawalAmountTextBox.Text.Replace("$", string.Empty).Replace(",", string.Empty));

            DataRow withdrawalRow = pendingTransactionsTable.NewRow();
            withdrawalRow["Share"] = selectedShareID;
            withdrawalRow["Type"] = "Withdrawal";
            withdrawalRow["Exchange"] = withdrawalTypeComboBox.SelectedItem.ToString();
            withdrawalRow["Amount"] = amount;
            pendingTransactionsTable.Rows.Add(withdrawalRow);

            sharesDT.Clear();
            withdrawalAmountTextBox.Text = "";
            withdrawalTypeComboBox.SelectedIndex = -1;
            withdrawalPanel.Visible = false;
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            transferPanel.Visible = true;
            sharesDT = DataHelper.GetShares(currentMember.MemberID);
            transferFromShareDGV.DataSource = sharesDT;
        }

        private void TransferFromShareDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedShareID = Convert.ToInt32(transferFromShareDGV.SelectedRows[0].Cells[0].Value);
        }

        private void TransferAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(transferAmountTextBox.Text))
            {
                transferAmountTextBox.BackColor = Color.Salmon;
            }
            else
            {
                transferAmountTextBox.BackColor = Color.White;
            }
        }

        private void TransferAmountTextBox_Leave(object sender, EventArgs e)
        {
            if (Double.TryParse(transferAmountTextBox.Text, System.Globalization.NumberStyles.Currency, null, out double amount))
            {
                transferAmountTextBox.Text = amount.ToString("C");
            }
        }

        private void TransferInMemberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            destSharesDT = DataHelper.GetShares(currentMember.MemberID);
            transferToShareDGV.DataSource = destSharesDT;
            transferToMemberName.Text = currentMember.FirstName + " " + currentMember.LastName;
        }

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

        private void TransferToShareDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDestShareID = Convert.ToInt32(transferToShareDGV.SelectedRows[0].Cells[0].Value);
        }

        private void TransferAddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(transferAmountTextBox.Text))
            {
                MessageBox.Show("Must provide an amount. Please try again.");
                transferAmountTextBox.BackColor = Color.Salmon;
                return;
            }
            if (selectedShareID < 1 || selectedDestShareID < 1)
            {
                MessageBox.Show("You must specify a share to withdraw from and a share to deposit to.");
                return;
            }

            double amount = Convert.ToDouble(transferAmountTextBox.Text.Replace("$", string.Empty).Replace(",", string.Empty));

            DataRow transferRow = pendingTransactionsTable.NewRow();
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
            
            pendingTransactionsTable.Rows.Add(transferRow);

            sharesDT.Clear();
            destSharesDT.Clear();
            transferAmountTextBox.Text = "";
            transferPanel.Visible = false;
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            paymentPanel.Visible = true;
            sharesDT = DataHelper.GetShares(currentMember.MemberID);
            paymentShareDGV.DataSource = sharesDT;
            loansDT = DataHelper.GetLoans(currentMember.MemberID);
            paymentLoansDGV.DataSource = loansDT;
        }

        private void PaymentCashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            paymentShareDGV.Enabled = false;
        }

        private void PaymentCheckRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            paymentShareDGV.Enabled = false;
        }

        private void PaymentAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(transferAmountTextBox.Text))
            {
                transferAmountTextBox.BackColor = Color.Salmon;
            }
            else
            {
                transferAmountTextBox.BackColor = Color.White;
            }
        }

        private void PaymentAmountTextBox_Leave(object sender, EventArgs e)
        {
            if (Double.TryParse(transferAmountTextBox.Text, System.Globalization.NumberStyles.Currency, null, out double amount))
            {
                transferAmountTextBox.Text = amount.ToString("C");
            }
        }

        private void PaymentShareDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedShareID = Convert.ToInt32(paymentShareDGV.SelectedRows[0].Cells[0].Value);
        }

        private void PaymentLoansDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedLoanID = Convert.ToInt32(paymentLoansDGV.SelectedRows[0].Cells[0].Value);
        }

        private void PaymentAddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(paymentAmountTextBox.Text))
            {
                MessageBox.Show("Must provide an amount. Please try again.");
                paymentAmountTextBox.BackColor = Color.Salmon;
                return;
            }

            double amount = Convert.ToDouble(paymentAmountTextBox.Text.Replace("$", string.Empty).Replace(",", string.Empty));

            if (paymentShareRadioButton.Checked && selectedShareID < 1)
            {
                MessageBox.Show("If payment is coming from a share, then a share must be selected.");
                return;
            }
            if (selectedLoanID < 1)
            {
                MessageBox.Show("A loan must be selected for a payment to be applied.");
                return;
            }

            DataRow paymentRow = pendingTransactionsTable.NewRow();
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

            pendingTransactionsTable.Rows.Add(paymentRow);

            sharesDT.Clear();
            loansDT.Clear();
            paymentAmountTextBox.Text = "";
            paymentPanel.Visible = false;
        }

        private void MainTransactionButton_Click(object sender, EventArgs e)
        {
            if (pendingDGV.Rows.Count < 1)
            {
                MessageBox.Show("No pending transactions to submit. Returning to main screen...");
                originatingForm.Enabled = true;
                originatingForm.Show();
                this.Close();
                Console.WriteLine("Pending transactions submitted.");
            }

            foreach (DataGridViewRow row in pendingDGV.Rows)
            {
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
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
            Console.WriteLine("Pending transactions submitted.");
        }

        private void PendingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            accountNum.Text = pendingDGV.SelectedRows[0].Cells[0].Value.ToString();
            transactionType.Text = pendingDGV.SelectedRows[0].Cells[1].Value.ToString();
            transactionAmount.Text = pendingDGV.SelectedRows[0].Cells[3].Value.ToString();
            exchangeType.Text = pendingDGV.SelectedRows[0].Cells[2].Value.ToString();
            transactionDestID.Text = pendingDGV.SelectedRows[0].Cells[4].Value.ToString();
            transactionDestAcct.Text = pendingDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void PaymentShareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            paymentShareDGV.Enabled = true;
        }

        private void TransactionCancelButton_Click(object sender, EventArgs e)
        {
            sharesDT.Clear();
            loansDT.Clear();
            depositPanel.Visible = false;
            withdrawalPanel.Visible = false;
            transferPanel.Visible = false;
            paymentPanel.Visible = false;
        }

        private void RemoveTransactionButton_Click(object sender, EventArgs e)
        {
            pendingDGV.Rows.Remove(pendingDGV.SelectedRows[0]);
        }
    }
}
