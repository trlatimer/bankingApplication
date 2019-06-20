namespace BankingApplication
{
    public class User
    {
        private readonly int UserID;
        private readonly string UserName;
        private string Password;
        private int AuthLevel;

        public User(int ID, string name, string password, int auth)
        {
            UserID = ID;
            UserName = name;
            Password = password;
            AuthLevel = auth;
        }

        public int GetUserID(){ return UserID; }
        public string GetUserName() { return UserName; }
        public string GetPassword() { return Password; }
        public int GetAuthLevel() { return AuthLevel; }

        public void SetPassword(string newPassword)
        {
            Password = newPassword;
        }

        public void SetAuthLevel(int newLevel)
        {
            AuthLevel = newLevel;
        }
    }
}
