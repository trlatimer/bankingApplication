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
    public partial class ReportForm : Form
    {
        // Store current user and calling form
        public Form originatingForm = null;
        public User currentUser = null;

        // Constructor
        public ReportForm()
        {
            InitializeComponent();
        }

        // All Members Click
        private void AllMembersReportButton_Click(object sender, EventArgs e)
        {
            // Clear report area
            reportTextBox.Text = "";
            // Set Title, set text area to visible
            currentReportTitle.Text = "All Members Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;

            // Store retrieved members
            DataTable members = DataHelper.AllMembers();

            // Create report header
            reportTextBox.AppendText("ID" + "     " + "Member Name\n");
            reportTextBox.AppendText("==============================================================\n\n");
            // Loop over each retrieved member
            foreach (DataRow row in members.Rows)
            {
                // Print information into report area
                reportTextBox.AppendText(row["ID"].ToString() + "      " + row["Name"].ToString() + "\n");
            }
        }

        // Back Click
        private void ReportsBackButton_Click(object sender, EventArgs e)
        {
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // All Accounts Click
        private void AllAccountsReportButton_Click(object sender, EventArgs e)
        {
            // Store balances
            double totalShareBalances = 0.00;
            double totalLoanBalances = 0.00;

            // Clear report area
            reportTextBox.Text = "";
            // Set title and show report area
            currentReportTitle.Text = "All Accounts Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;

            // Store retrieved accounts
            DataTable accounts = DataHelper.AllAccounts();

            // Set tab stops within report
            reportTextBox.SelectionTabs = new int[3] { 100, 200, 300 };

            // Create report header
            reportTextBox.AppendText("ID" + "\t" + "Member ID" + "\t" + "Type" + "\t" + "Balance" + "\n");
            reportTextBox.AppendText("===========================================================================\n\n");
            // Loop through all retrieved accounts
            foreach (DataRow row in accounts.Rows)
            {
                //Deterimine if share or loan and add to appropriate balance
                if (row[2].ToString() == "Checking" || row[2].ToString() == "Savings")
                {
                    totalShareBalances += Convert.ToDouble(row["Balance"]);
                }
                if (row[2].ToString() != "Checking" && row[2].ToString() != "Savings")
                {
                    totalLoanBalances += Convert.ToDouble(row["Balance"]);
                }
                // Print account information into report
                reportTextBox.AppendText(row["ID"].ToString() + "\t" + row["MemberID"].ToString() + "\t" + row["Type"].ToString() +
                    "\t" + row["Balance"].ToString() + "\n");
            }
            // Print total balances
            reportTextBox.AppendText("\n     Total Share Balance:     " + totalShareBalances.ToString("$#,###,###,##0.00") + "\n");
            reportTextBox.AppendText("      Total Loan Balance:     " + totalLoanBalances.ToString("$#,###,###,##0.00") + "\n");
        }

        // All Shares Click
        private void AllSharesReportButton_Click(object sender, EventArgs e)
        {
            // Store total
            double totalShareBalances = 0.00;

            // Clear report area
            reportTextBox.Text = "";
            // Set report title and show report area
            currentReportTitle.Text = "All Shares Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;

            // Store retrieved shares
            DataTable shares = DataHelper.AllShares();

            // Set tab stops within report
            reportTextBox.SelectionTabs = new int[3] { 100, 200, 300 };
            // Create report header
            reportTextBox.AppendText("ID" + "\t" + "Member ID" + "\t" + "Type" + "\t" + "Balance" + "\n");
            reportTextBox.AppendText("===========================================================================\n\n");
            // Loop over each retrieved share
            foreach (DataRow row in shares.Rows)
            {
                // Add to total balance
                totalShareBalances += Convert.ToDouble(row["Balance"]);
                // Print share details for report
                reportTextBox.AppendText(row["ID"].ToString() + "\t" + row["MemberID"].ToString() + "\t" + row["Type"].ToString() +
                    "\t" + row["Balance"].ToString() + "\n");
            }
            // Print total share balance
            reportTextBox.AppendText("\n     Total Share Balance:     " + totalShareBalances.ToString("$#,###,###,##0.00") + "\n");
        }

        // All Loans Click
        private void AllLoansReportButton_Click(object sender, EventArgs e)
        {
            // Store loan total
            double totalLoanBalances = 0.00;

            // Clear report area
            reportTextBox.Text = "";
            // Set report title and show report area
            currentReportTitle.Text = "All Loans Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;

            // Store retrieved loans
            DataTable loans = DataHelper.AllLoans();
            // Set report tab stops
            reportTextBox.SelectionTabs = new int[3] { 100, 200, 300 };
            // Print report header
            reportTextBox.AppendText("ID" + "\t" + "Member ID" + "\t" + "Type" + "\t" + "Balance" + "\n");
            reportTextBox.AppendText("===========================================================================\n\n");
            // Loop over each retrieved loan
            foreach (DataRow row in loans.Rows)
            {
                // Add balance to total balance
                totalLoanBalances += Convert.ToDouble(row["Balance"]);
                // Print loan details
                reportTextBox.AppendText(row["ID"].ToString() + "\t" + row["MemberID"].ToString() + "\t" + row["Type"].ToString() +
                    "\t" + row["Balance"].ToString() + "\n");
            }
            // Print total loan balance
            reportTextBox.AppendText("\n     Total Loan Balance:     " + totalLoanBalances.ToString("$#,###,###,##0.00") + "\n");
        }

        // Closed Shares Click
        private void ClosedSharesReportButton_Click(object sender, EventArgs e)
        {
            // Store total balance and count
            double totalClosedShareBalances = 0.00;
            int closedShareCount = 0;

            // Clear report area
            reportTextBox.Text = "";
            // Set report title and show report area
            currentReportTitle.Text = "Closed Shares Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;
            // Store all retrieved shares
            DataTable shares = DataHelper.ClosedShares();
            // Set report tab stops
            reportTextBox.SelectionTabs = new int[3] { 100, 200, 300};
            // Print report header
            reportTextBox.AppendText("ID" + "\t" + "Member ID" + "\t" + "Type" + "\t" + "Balance" + "\n");
            reportTextBox.AppendText("===========================================================================\n\n");
            // Loop over each retrieved share
            foreach (DataRow row in shares.Rows)
            {
                // Add balance to total balance
                totalClosedShareBalances += Convert.ToDouble(row["Balance"]);
                // Increment count
                closedShareCount++;
                // Print share details
                reportTextBox.AppendText(row["ID"].ToString() + "\t" + row["MemberID"].ToString() + "\t" + row["Type"].ToString() +
                    "\t" + row["Balance"].ToString() +  "\n");
            }
            // Print total balance and count
            reportTextBox.AppendText("\n     Total Closed Share Balance:     " + totalClosedShareBalances.ToString("$#,###,###,##0.00") + "\n");
            reportTextBox.AppendText("       Total Closed Share Count:     " + closedShareCount.ToString() + "\n");
        }

        // Closed Loans Click
        private void ClosedLoansReportButton_Click(object sender, EventArgs e)
        {
            // Store count and balances
            double totalClosedLoanBalances = 0.00;
            int closedLoanCount = 0;

            // Clear report
            reportTextBox.Text = "";
            // Set report title and show report area
            currentReportTitle.Text = "All Loans Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;
            //Store retrieved loans
            DataTable loans = DataHelper.ClosedLoans();
            // Set report tab stops
            reportTextBox.SelectionTabs = new int[3] { 100, 200, 300 };
            // Print report header
            reportTextBox.AppendText("ID" + "\t" + "Member ID" + "\t" + "Type" + "\t" + "Balance" + "\n");
            reportTextBox.AppendText("===========================================================================\n\n");
            // Loop over each loan retrieved
            foreach (DataRow row in loans.Rows)
            {
                // Add balance to total balance
                totalClosedLoanBalances += Convert.ToDouble(row["Balance"]);
                // Increment count
                closedLoanCount++;
                // Print loan details
                reportTextBox.AppendText(row["ID"].ToString() + "\t" + row["MemberID"].ToString() + "\t" + row["Type"].ToString() +
                    "\t" + row["Balance"].ToString() + "\n");
            }
            // Print total balance and count
            reportTextBox.AppendText("\n     Total Closed Loan Balance:     " + totalClosedLoanBalances.ToString("$#,###,###,##0.00") + "\n");
            reportTextBox.AppendText("       Total Closed Loan Count:     " + closedLoanCount.ToString() + "\n");
        }
    }
}
