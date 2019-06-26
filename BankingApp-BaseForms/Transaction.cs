using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_BaseForms
{
    class Transaction
    {
        // Instance Variables
        public int TransactionID { get; set; }
        public int MemberID { get; set; }
        public int AccountID { get; set; }
        public string TransactionType { get; set; }
        public string ExchangeType { get; set; }
        public double Amount { get; set; }
        public int DestMemberID { get; set; }
        public int DestAccountID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }

        // Constructor without a destination member or account
        public Transaction(int ID, int memberID, int accountID, string transactionType, string exchangeType, double amount)
        {
            TransactionID = ID; MemberID = memberID; AccountID = accountID; TransactionType = transactionType; ExchangeType = exchangeType; Amount = amount;
        }

        // Constructor with a destination account and member
        public Transaction(int ID, int memberID, int accountID, string transactionType, string exchangeType, double amount, int destMemberID, int destAcctID)
        {
            TransactionID = ID; MemberID = memberID; AccountID = accountID; TransactionType = transactionType; ExchangeType = exchangeType; Amount = amount;
            DestMemberID = destMemberID; DestAccountID = destAcctID;
        }
    }
}
