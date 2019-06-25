using System;

namespace BankingApplication
{
    public class Share
    {
        public int ShareID { get; set; }
        public int MemberID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
        public int JointMemberID { get; set; }
        public string JointMemberName { get; set; }
        public string JointMemberSSN { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }
        public string ReasonClosed { get; set; }

        public Share(int ID, int memID, string shareType, string shareDescription, decimal shareBalance, DateTime openDate, DateTime closeDate, string reason, int jointID = 0, string jointName = null, string jointSSN = null)
        {
            ShareID = ID;
            MemberID = memID;
            Type = shareType;
            Description = shareDescription;
            Balance = shareBalance;
            JointMemberID = jointID;
            JointMemberName = jointName;
            JointMemberSSN = jointSSN;
            DateOpened = openDate;
            DateClosed = closeDate;
            ReasonClosed = reason;
        }
    }
}
