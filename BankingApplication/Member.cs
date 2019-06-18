using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Member
    {
        private int memberID { get; set; }
        private string firstName { get; set; }
        private string middleName { get; set; }
    private string lastName { get; set; }
        private int socialSecurityNumber { get; set; }
        private string IDNumber { get; set; }
        private DateTime Birthdate { get; set; }
        private string street { get; set; }
        private string extraAddress { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private int zipCode { get; set; }
        private string mailStreet { get; set; }
        private string mailExtraAddress { get; set; }
        private string mailCity { get; set; }
        private string mailState { get; set; }
        private string mailZipCode { get; set; }
        private int cellPhone { get; set; }
        private string homePhone { get; set; }
        private string email { get; set; }


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
