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
        public Form originatingForm = null;
        public User currentUser = null;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void AllMembersReportButton_Click(object sender, EventArgs e)
        {
            reportTextBox.Text = "";
            currentReportTitle.Text = "All Members Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;

            DataTable members = DataHelper.AllMembers();

            reportTextBox.AppendText("ID" + "     " + "Member Name\n");
            reportTextBox.AppendText("==============================================================\n\n");
            foreach (DataRow row in members.Rows)
            {
                reportTextBox.AppendText(row["ID"].ToString() + "      " + row["Name"].ToString() + "\n");
            }
        }

        private void ReportsBackButton_Click(object sender, EventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void AllAccountsReportButton_Click(object sender, EventArgs e)
        {
            double totalShareBalances = 0.00;
            double totalLoanBalances = 0.00;

            reportTextBox.Text = "";
            currentReportTitle.Text = "All Accounts Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;

            DataTable accounts = DataHelper.AllAccounts();
            reportTextBox.SelectionTabs = new int[3] { 100, 200, 300 };

            reportTextBox.AppendText("ID" + "\t" + "Member ID" + "\t" + "Type" + "\t" + "Balance" + "\n");
            reportTextBox.AppendText("===========================================================================\n\n");
            foreach (DataRow row in accounts.Rows)
            {
                if (row[2].ToString() == "Checking" || row[2].ToString() == "Savings")
                {
                    totalShareBalances += Convert.ToDouble(row["Balance"]);
                }
                if (row[2].ToString() != "Checking" && row[2].ToString() != "Savings")
                {
                    totalLoanBalances += Convert.ToDouble(row["Balance"]);
                }
                reportTextBox.AppendText(row["ID"].ToString() + "\t" + row["MemberID"].ToString() + "\t" + row["Type"].ToString() +
                    "\t" + row["Balance"].ToString() + "\n");
            }

            reportTextBox.AppendText("\n     Total Share Balance:     " + totalShareBalances.ToString("$#,###,###,##0.00") + "\n");
            reportTextBox.AppendText("      Total Loan Balance:     " + totalLoanBalances.ToString("$#,###,###,##0.00") + "\n");
        }

        private void AllSharesReportButton_Click(object sender, EventArgs e)
        {
            double totalShareBalances = 0.00;

            reportTextBox.Text = "";
            currentReportTitle.Text = "All Shares Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;

            DataTable shares = DataHelper.AllShares();
            reportTextBox.SelectionTabs = new int[3] { 100, 200, 300 };

            reportTextBox.AppendText("ID" + "\t" + "Member ID" + "\t" + "Type" + "\t" + "Balance" + "\n");
            reportTextBox.AppendText("===========================================================================\n\n");
            foreach (DataRow row in shares.Rows)
            {
                totalShareBalances += Convert.ToDouble(row["Balance"]);
                reportTextBox.AppendText(row["ID"].ToString() + "\t" + row["MemberID"].ToString() + "\t" + row["Type"].ToString() +
                    "\t" + row["Balance"].ToString() + "\n");
            }

            reportTextBox.AppendText("\n     Total Share Balance:     " + totalShareBalances.ToString("$#,###,###,##0.00") + "\n");
        }

        private void AllLoansReportButton_Click(object sender, EventArgs e)
        {
            double totalLoanBalances = 0.00;

            reportTextBox.Text = "";
            currentReportTitle.Text = "All Loans Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;

            DataTable loans = DataHelper.AllLoans();
            reportTextBox.SelectionTabs = new int[3] { 100, 200, 300 };

            reportTextBox.AppendText("ID" + "\t" + "Member ID" + "\t" + "Type" + "\t" + "Balance" + "\n");
            reportTextBox.AppendText("===========================================================================\n\n");
            foreach (DataRow row in loans.Rows)
            {
                totalLoanBalances += Convert.ToDouble(row["Balance"]);
                reportTextBox.AppendText(row["ID"].ToString() + "\t" + row["MemberID"].ToString() + "\t" + row["Type"].ToString() +
                    "\t" + row["Balance"].ToString() + "\n");
            }

            reportTextBox.AppendText("\n     Total Loan Balance:     " + totalLoanBalances.ToString("$#,###,###,##0.00") + "\n");
        }

        private void ClosedSharesReportButton_Click(object sender, EventArgs e)
        {
            double totalClosedShareBalances = 0.00;
            int closedShareCount = 0;

            reportTextBox.Text = "";
            currentReportTitle.Text = "Closed Shares Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;

            DataTable shares = DataHelper.ClosedShares();
            reportTextBox.SelectionTabs = new int[3] { 100, 200, 300};

            reportTextBox.AppendText("ID" + "\t" + "Member ID" + "\t" + "Type" + "\t" + "Balance" + "\n");
            reportTextBox.AppendText("===========================================================================\n\n");
            foreach (DataRow row in shares.Rows)
            {
                totalClosedShareBalances += Convert.ToDouble(row["Balance"]);
                closedShareCount++;
                reportTextBox.AppendText(row["ID"].ToString() + "\t" + row["MemberID"].ToString() + "\t" + row["Type"].ToString() +
                    "\t" + row["Balance"].ToString() +  "\n");
            }

            reportTextBox.AppendText("\n     Total Closed Share Balance:     " + totalClosedShareBalances.ToString("$#,###,###,##0.00") + "\n");
            reportTextBox.AppendText("       Total Closed Share Count:     " + closedShareCount.ToString() + "\n");
        }

        private void ClosedLoansReportButton_Click(object sender, EventArgs e)
        {
            double totalClosedLoanBalances = 0.00;
            int closedLoanCount = 0;

            reportTextBox.Text = "";
            currentReportTitle.Text = "All Loans Report";
            currentReportTitle.Visible = true;
            reportTextBox.Visible = true;

            DataTable loans = DataHelper.ClosedLoans();
            reportTextBox.SelectionTabs = new int[3] { 100, 200, 300 };

            reportTextBox.AppendText("ID" + "\t" + "Member ID" + "\t" + "Type" + "\t" + "Balance" + "\n");
            reportTextBox.AppendText("===========================================================================\n\n");
            foreach (DataRow row in loans.Rows)
            {
                totalClosedLoanBalances += Convert.ToDouble(row["Balance"]);
                closedLoanCount++;
                reportTextBox.AppendText(row["ID"].ToString() + "\t" + row["MemberID"].ToString() + "\t" + row["Type"].ToString() +
                    "\t" + row["Balance"].ToString() + "\n");
            }

            reportTextBox.AppendText("\n     Total Closed Loan Balance:     " + totalClosedLoanBalances.ToString("$#,###,###,##0.00") + "\n");
            reportTextBox.AppendText("       Total Closed Loan Count:     " + closedLoanCount.ToString() + "\n");
        }
    }
}
