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
        public Form originatingForm;
        public Member currentMember;
        public Share selectedShare;
        public Loan selectedLoan;
        public DataTable transactions = new DataTable();

        public ViewTransactionsForm()
        {
            InitializeComponent();
        }

        private void transactionsBackButton_Click(object sender, EventArgs e)
        {
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void ViewTransactionsForm_Load(object sender, EventArgs e)
        {
            if (selectedShare != null)
            {
                viewTransactionsTitle.Text += "Share " + selectedShare.ShareID;
                transactions = DataHelper.GetTransactions(currentMember.MemberID, selectedShare.ShareID);
            } else if (selectedLoan != null)
            {
                viewTransactionsTitle.Text += "Loan " + selectedLoan.LoanID;
                transactions = DataHelper.GetTransactions(currentMember.MemberID, selectedLoan.LoanID);
            }

            viewTransactionsDGV.DataSource = transactions;
        }
    }
}
