using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Share
    {
        public int shareID { get; set; }
        public int memberID { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public decimal balance { get; set; }
        public int jointMemberID { get; set; }
        public string jointMemberName { get; set; }
        public int jointMemberSSN { get; set; }
        public DateTime dateOpened { get; set; }
        public DateTime dateClosed { get; set; }
        public string reasonClosed { get; set; }

        public Share(int ID, int memID, string shareType, string shareDescription, decimal shareBalance, DateTime openDate, DateTime closeDate, string reason, int jointID = 0, string jointName = null, int jointSSN = 0)
        {
            shareID = ID;
            memberID = memID;
            type = shareType;
            description = shareDescription;
            balance = shareBalance;
            jointMemberID = jointID;
            jointMemberName = jointName;
            jointMemberSSN = jointSSN;
            dateOpened = openDate;
            dateClosed = closeDate;
            reasonClosed = reason;
        }
    }
}
