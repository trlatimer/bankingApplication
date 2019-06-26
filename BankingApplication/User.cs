namespace BankingApplication
{
    public class User
    {
        // Instance variables
        private readonly int UserID;
        private readonly string UserName;
        private string Password;
        private int AuthLevel;

        // Constructor
        public User(int ID, string name, string password, int auth)
        {
            UserID = ID;
            UserName = name;
            Password = password;
            AuthLevel = auth;
        }

        // Obtain UserID
        public int GetUserID(){ return UserID; }
        // Obtain UserName
        public string GetUserName() { return UserName; }
        // Obtain Password
        public string GetPassword() { return Password; }
        // Obtain AuthLevel
        public int GetAuthLevel() { return AuthLevel; }
        // Set Password
        public void SetPassword(string newPassword)
        {
            Password = newPassword;
        }
        // Set AuthLevel
        public void SetAuthLevel(int newLevel)
        {
            AuthLevel = newLevel;
        }
    }
}
