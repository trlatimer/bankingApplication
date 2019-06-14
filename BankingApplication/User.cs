using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class User
    {
        private int UserID;
        private string UserName;
        private string Password;
        private int AuthLevel;

        public User(int ID, string name, string password, int auth)
        {
            UserID = ID;
            UserName = name;
            Password = password;
            AuthLevel = auth;
        }

        public int getUserID(){ return UserID; }
        public string getUserName() { return UserName; }
        public string getPassword() { return Password; }
        public int getAuthLevel() { return AuthLevel; }

        public void setPassword(string newPassword)
        {
            Password = newPassword;
        }

        public void setAuthLevel(int newLevel)
        {
            AuthLevel = newLevel;
        }
    }
}
