using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Loan
    {
        public int LoanID { get; set; }
        public int MemberID { get; set; }
        public string LoanType { get; set; }
        public string Description { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal APR { get; set; }
        public int DayDue { get; set; }
        public decimal StartingBalance { get; set; }
        public int JointMemberID { get; set; }
        public string JointMemberName { get; set; }
        public int JointMemberSSN { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }
        public decimal NextPaymentDue { get; set; }
        public DateTime NextDueDate { get; set; }
        public decimal Payoff { get; set; }


        public Loan(int ID, int memID, string loanType, string loanDescription, decimal loanBalance, decimal apr, int dayDue, decimal startingBalance, DateTime openDate, DateTime closeDate, int jointID = 0, string jointName = null, int jointSSN = 0)
        {
            LoanID = ID;
            MemberID = memID;
            LoanType = loanType;
            Description = loanDescription;
            CurrentBalance = loanBalance;
            APR = apr;
            DayDue = dayDue;
            StartingBalance = startingBalance;
            JointMemberID = jointID;
            JointMemberName = jointName;
            JointMemberSSN = jointSSN;
            DateOpened = openDate;
            DateClosed = closeDate;
        }

    }
}
