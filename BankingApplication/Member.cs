using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Member
    {
        public int memberID { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public int socialSecurityNumber { get; set; }
        public string IDNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string street { get; set; }
        public string extraAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipCode { get; set; }
        public string mailStreet { get; set; }
        public string mailExtraAddress { get; set; }
        public string mailCity { get; set; }
        public string mailState { get; set; }
        public string mailZipCode { get; set; }
        public int cellPhone { get; set; }
        public string homePhone { get; set; }
        public string email { get; set; }


        public Member(int ID, string fName, string lName, int ssn, string idNum, string dob, string Street, string City,
            string State, int ZipCode, int cell, string Email, string mName = null, string extraAddress = null, string home = null,
            string MailStreet = null, string MailExtraAddress = null, string MailCity = null, string MailState = null, string MailZipCode = null)
        {
            memberID = ID; firstName = fName; middleName = mName; lastName = lName; socialSecurityNumber = ssn; IDNumber = idNum;
            Birthdate = Convert.ToDateTime(dob); street = Street; city = City; state = State; zipCode = ZipCode; mailStreet = MailStreet;
            mailExtraAddress = MailExtraAddress; mailCity = MailCity; mailState = MailState; mailZipCode = MailZipCode; cellPhone = cell;
            homePhone = home; email = Email;
        }
    }
}
