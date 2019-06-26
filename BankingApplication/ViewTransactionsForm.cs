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
    public partial class ViewTransactionsForm : Form
    {
        // Store calling form
        public Form originatingForm;
        // Store current member and selected share or loan
        public Member currentMember;
        public Share selectedShare;
        public Loan selectedLoan;
        // Store transactions for selected account
        public DataTable transactions = new DataTable();

        // Constructor
        public ViewTransactionsForm()
        {
            InitializeComponent();
        }

        // Back Click
        private void transactionsBackButton_Click(object sender, EventArgs e)
        {
            // Return to calling form
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        // Form Load
        private void ViewTransactionsForm_Load(object sender, EventArgs e)
        {
            // If a share is selected, obtain transactions and set title
            if (selectedShare != null)
            {
                viewTransactionsTitle.Text += "Share " + selectedShare.ShareID;
                transactions = DataHelper.GetTransactions(currentMember.MemberID, selectedShare.ShareID);
            // If a loan is selected, obtain transactions and set title
            } else if (selectedLoan != null)
            {
                viewTransactionsTitle.Text += "Loan " + selectedLoan.LoanID;
                transactions = DataHelper.GetTransactions(currentMember.MemberID, selectedLoan.LoanID);
            }
            // Set DGV datasource to show data
            viewTransactionsDGV.DataSource = transactions;
        }
    }
}
