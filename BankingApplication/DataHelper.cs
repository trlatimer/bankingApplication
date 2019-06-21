using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SimpleCrypto;
using System.Windows.Forms;

namespace BankingApplication
{
    class DataHelper
    {

        public static string connectionString = "server=bankingapp.cp7exr1x8hkd.us-west-2.rds.amazonaws.com;userid=root;database=bankingappdb;password=bankingapp;";
        // Variables for Database Interaction
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand cmd;
        public static MySqlDataReader reader;
        public static int createdUserID;

        private static string salt;
        private static ICryptoService cryptoService = new PBKDF2();
        private const int SALT_SIZE = 16;
        private const int HASH_ITERATIONS = 50;

        public static void DBOpen()
        {
            // If connection is not open, obtain string and open connection
            if (conn.State != ConnectionState.Open)
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
            }
        }

        // Close Database connection
        public static void DBClose()
        {
            conn.Close();
        }

        // Default hash iteration is 5000, default salt size is 16
        //private void SetNewPassword(User user, string newPassword)
        //{
        //    //a new password hash is generated from a generated salt with the default settings
        //    user.setPassword(cryptoService.Compute(newPassword));
        //    //assigning the generated salt to the user
        //    user.setSalt(cryptoService.Salt);
        //}

        public static bool ValidatePassword(User user, string password)
        {
            String query = $"SELECT Salt FROM Salts WHERE UserID = {user.GetUserID()};";

            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                salt = reader[0].ToString();
                DBClose();
                //hash the password with the saved salt for that user
                string hashed = cryptoService.Compute(password, salt);
                //return true if both hashes are the same
                return hashed == user.GetPassword();
            }
            DBClose();
            return false;
        }

        //The salt is stored in the format of: “{#hash_iterations}.{generated_salt}”

        public static void CreateUser(string name, string password, int auth)
        {
            string salt = cryptoService.GenerateSalt();
            string hashedPassword = cryptoService.Compute(password, salt);

            try
            {
                String query = $"INSERT INTO Users (UserName, Password, AuthLevel) VALUES ('{name}', '{hashedPassword}', {auth});";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to create new user. \n " + e.Message.ToString(), "Insertion Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                String query = $"SELECT UserID FROM Users WHERE UserName = '{name}';";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    createdUserID = Convert.ToInt32(reader[0]);
                }
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve ID for username. \n " + e.Message.ToString(), "Retrieval Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                String query = $"INSERT INTO Salts (UserID, Salt) VALUES ('{createdUserID}', '{salt}');";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to insert salt for user. \n " + e.Message.ToString(), "Insertion Error", MessageBoxButtons.OK);
                return;
            }

            Console.WriteLine($"Successfully created user: {name}");
        }

        public static void UpdateUserWithPassword(int userID, string name, string password, int auth)
        {
            string salt = cryptoService.GenerateSalt();
            string hashedPassword = cryptoService.Compute(password, salt);

            try
            {
                String query = $"UPDATE Users SET UserName = '{name}', Password = '{hashedPassword}', AuthLevel = {auth} WHERE UserID = {userID};";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to update user. \n " + e.Message.ToString(), "Insertion Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                String query = $"UPDATE Salts SET Salt = '{salt}' WHERE UserID = {userID};";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to update salt for user. \n " + e.Message.ToString(), "Insertion Error", MessageBoxButtons.OK);
                return;
            }

            Console.WriteLine($"Successfully updated user: {name}");
        }

        public static void UpdateUserWOPassword(int userID, string name, int auth)
        {
            try
            {
                String query = $"UPDATE Users SET UserName = '{name}', AuthLevel = {auth} WHERE UserID = {userID};";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to update user. \n " + e.Message.ToString(), "Insertion Error", MessageBoxButtons.OK);
                return;
            }

            Console.WriteLine($"Successfully updated user: {name}");
        }

        public static void DeleteUser(int userID)
        {
            try
            {
                String query = $"DELETE FROM Users WHERE UserID = {userID};";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to delete. \n " + e.Message.ToString(), "Deletion Error", MessageBoxButtons.OK);
                return;
            }

            Console.WriteLine($"Successfully deleted user: {userID}");
        }

        public static User GetUser(string name)
        {
            String query = $"SELECT UserID, UserName, Password, AuthLevel FROM Users WHERE UserName = '{name}';";
            int userID;
            string userName;
            string password;
            int auth;

            User user;

            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                userID = Convert.ToInt32(reader[0]);
                userName = reader[1].ToString();
                password = reader[2].ToString();
                auth = Convert.ToInt32(reader[3]);
                user = new User(userID, userName, password, auth);
                DBClose();
            }
            else
            {
                Console.WriteLine("No rows in reader");
                DBClose();
                throw new Exception("Unable to find user with that name");
            }

            return user;

        }

        public static List<string> GetUsers()
        {
            List<string> foundUsers = new List<string>();

            String query = "SELECT UserName FROM Users;";
            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                foundUsers.Add(reader[0].ToString());
                Console.WriteLine(reader[0]);
            }
            DBClose();
            if (foundUsers.Count == 0)
            {
                Console.WriteLine("No users found");
            }
            return foundUsers;
        }

        public static Member GetMember(int memberNum)
        {
            Member member;
            int memberID;
            string firstName;
            string middleName;
            string lastName;
            int socialSecurityNumber;
            string IDNumber;
            string birthdate;
            string street;
            string extraAddress;
            string city;
            string state;
            int zipCode;
            string mailStreet;
            string mailExtraAddress;
            string mailCity;
            string mailState;
            string mailZipCode;
            int cellPhone;
            int homePhone;
            string email;

            String query = $"SELECT MemberID, FName, MName, LName, SSN, IDNum, Birthdate, Street, ExtraAddress, City, State, ZipCode, MailStreet, MailExtraAddress, MailCity, " +
                $"MailState, MailZipCode, CellPhone, HomePhone, Email FROM Members WHERE MemberID = {memberNum};";


            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                memberID = Convert.ToInt32(reader[0]);
                firstName = reader[1].ToString();
                middleName = reader[2].ToString();
                lastName = reader[3].ToString();
                socialSecurityNumber = Convert.ToInt32(reader[4]);
                IDNumber = reader[5].ToString();
                birthdate = reader[6].ToString();
                street = reader[7].ToString();
                extraAddress = reader[8].ToString();
                city = reader[9].ToString();
                state = reader[10].ToString();
                zipCode = Convert.ToInt32(reader[11]);
                mailStreet = reader[12].ToString();
                mailExtraAddress = reader[13].ToString();
                mailCity = reader[14].ToString();
                mailState = reader[15].ToString();
                mailZipCode = reader[16].ToString();
                cellPhone = Convert.ToInt32(reader[17]);
                homePhone = Convert.ToInt32(reader[18]);
                email = reader[19].ToString();
                member = new Member(memberID, firstName, lastName, socialSecurityNumber, IDNumber, birthdate, street, city, state, zipCode, cellPhone, email, middleName, extraAddress,
                    homePhone, mailStreet, mailExtraAddress, mailCity, mailState, mailZipCode);
                DBClose();
                return member;
            }
            else
            {
                Console.WriteLine("No rows in reader");
                DBClose();
                throw new Exception("Unable to find member matching that member ID");
            }
        }

        public static void CreateMember(string fName, string lName, int ssn, string idNum, string dob, string street, string city,
            string state, int zipCode, int cell, string email, int userID, string mName = null, string extraAddress = null, int homePhone = 0,
            string mailStreet = null, string mailExtraAddress = null, string mailCity = null, string mailState = null, string mailZipCode = null)
        {
            try
            {
                String query = $"INSERT INTO Members (FName, MName, LName, SSN, IDNum, Birthdate, Street, ExtraAddress, City, State, ZipCode, " +
                    $"MailStreet, MailExtraAddress, MailCity, MailState, MailZipCode, CellPhone, HomePhone, Email, CreatedBy) VALUES (" +
                    $"'{fName}', '{mName}', '{lName}', {ssn}, '{idNum}', '{dob}', '{street}', '{extraAddress}', '{city}', '{state}', '{zipCode}', " +
                    $"'{mailStreet}', '{mailExtraAddress}', '{mailCity}', '{mailState}', '{mailZipCode}', {cell}, '{homePhone}', '{email}', {userID});";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to create new member. \n " + e.Message.ToString(), "Insertion Error", MessageBoxButtons.OK);
                return;
            }
        }

        public static void UpdateMember(int memberID, string fName, string lName, int ssn, string idNum, string dob, string street, string city,
            string state, int zipCode, int cell, string email, int userID, string mName = null, string extraAddress = null, int homePhone = 0,
            string mailStreet = null, string mailExtraAddress = null, string mailCity = null, string mailState = null, string mailZipCode = null)
        {
            try
            {
                String query = $"UPDATE Members SET " +
                    $"FName = '{fName}', MName = '{mName}', LName = '{lName}', SSN = {ssn}, IDNum = '{idNum}', Birthdate = '{dob}', Street = '{street}', " +
                    $"ExtraAddress = '{extraAddress}', City = '{city}', State = '{state}', ZipCode = '{zipCode}', MailStreet = '{mailStreet}', " +
                    $"MailExtraAddress = '{mailExtraAddress}', MailCity = '{mailCity}', MailState = '{mailState}', MailZipCode = '{mailZipCode}', " +
                    $"CellPhone = {cell}, HomePhone = {homePhone}, Email = '{email}', LastUpdatedBy = {userID} WHERE MemberID = {memberID};";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to update member. \n " + e.Message.ToString(), "Insertion Error", MessageBoxButtons.OK);
                return;
            }
        }

        public static void DeleteMember(int memberID)
        {
            // TODO Add check for accounts


            try
            {
                String query = $"DELETE FROM Members WHERE MemberID = {memberID};";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to delete member. \n" + e.Message.ToString());
            }
        }

        public static void CreateShare(int memberID, string description, string type, int userID, int jointID = 0)
        {
            String query;

            if (jointID == 0)
            {
                query = $"INSERT INTO Shares (MemberID, ShareType, ShareDescription, OpenedBy) VALUES ({memberID}, '{type}', '{description}', {userID});";
            }
            else
            {
                query = $"INSERT INTO Shares (MemberID, ShareType, ShareDescription, OpenedBy, JointMemberID) VALUES ({memberID}, '{type}', '{description}', {userID}, {jointID});";
            }

            try
            {
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to create account. \n" + e.Message.ToString());
            }
        }

        public static void UpdateShare(int shareID, string description, string type, int userID, int jointID = 0)
        {
            String query;

            if (jointID == 0)
            {
                query = $"UPDATE Shares SET ShareDescription = '{description}', ShareType = '{type}',  LastUpdatedBy = {userID} WHERE ShareID = {shareID};";
            }
            else
            {
                query = $"UPDATE Shares SET ShareDescription = '{description}', ShareType = '{type}', JointMemberID = {jointID},  LastUpdatedBy = {userID} WHERE ShareID = {shareID};";
            }

            try
            {
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to update account. \n" + e.Message.ToString());
            }
        }

        public static void CloseShare(int shareID, string reason, int userID)
        {
            try
            {
                String query = $"UPDATE Shares SET DateClosed = {DateTime.Today.Date.ToShortDateString()}, CloseReason = '{reason}', ClosedBy = {userID}, LastUpdatedBy = {userID} WHERE ShareID = {shareID};";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to close acocunt. \n" + e.Message.ToString());
            }
        }

        public static DataTable GetShares(int memberID)
        {
            DataTable memberShares = new DataTable();

            String query = $"SELECT Shares.ShareID AS ID, Shares.ShareType AS Type, Shares.ShareDescription AS Description, Shares.Balance, " +
                $"CONCAT(Members.FName, ' ', Members.LName) AS Joint " +
                $"FROM Shares LEFT JOIN Members ON Shares.JointMemberID = Members.MemberID WHERE Shares.MemberID = {memberID} AND Shares.DateClosed IS NULL;";

            try
            {
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(memberShares);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to obtain shares. \n" + e.Message, "Selection Error");
                DBClose();
            }
            return memberShares;
        }

        public static Share GetShare(int ID)
        {
            Share foundShare;

            String query = $"SELECT Shares.ShareID AS ID, Shares.MemberID, Shares.ShareType AS Type, Shares.ShareDescription AS Description, Shares.Balance, Shares.OpenedDate,  " +
                $"Shares.DateClosed, Shares.CloseReason, Shares.JointMemberID, CONCAT(Members.FName, ' ', Members.LName) AS Joint, Members.SSN " +
                $"FROM Shares LEFT JOIN Members ON Shares.JointMemberID = Members.MemberID WHERE Shares.ShareID = {ID} AND Shares.DateClosed IS NULL;";

            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                DateTime closeDate;
                string reason;
                int jointID;
                string jointName;
                int jointSSN;
                if (reader[6] == DBNull.Value) { closeDate = Convert.ToDateTime("11/11/1111"); }
                else { closeDate = Convert.ToDateTime(reader[6].ToString()); }
                if (reader[7] == DBNull.Value) { reason = ""; } else { reason = reader[7].ToString(); }
                if (reader[8] == DBNull.Value) { jointID = 0; } else { jointID = Convert.ToInt32(reader[8]); }
                if (reader[9] == DBNull.Value) { jointName = ""; } else { jointName = reader[9].ToString(); }
                if (reader[10] == DBNull.Value) { jointSSN = 0; } else { jointSSN = Convert.ToInt32(reader[10]); }

                foundShare = new Share(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), reader[2].ToString(), reader[3].ToString(),
                    Convert.ToDecimal(reader[4]), Convert.ToDateTime(reader[5]), closeDate, reason, jointID,
                    jointName, jointSSN);
                DBClose();
            }
            else
            {
                Console.WriteLine("No rows in reader");
                DBClose();
                throw new Exception("Unable to find loan with that ID");
            }

            return foundShare;
        }

        public static void CreateLoan(int memberID, string type, string description, double initialBalance, double apr, int term, int dayDue, int userID, int jointID = 0)
        {
            String query;

            if (jointID == 0)
            {
                query = $"INSERT INTO Loans (MemberID, LoanType, LoanDescription, CurrentBalance, APR, TermLength, DayDue, StartingBalance, OpenedBy) " +
                    $"VALUES ({memberID}, '{type}', '{description}', {initialBalance}, {apr}, {term}, {dayDue}, {initialBalance}, {userID});";
            }
            else
            {
                query = $"INSERT INTO Loans (MemberID, LoanType, LoanDescription, CurrentBalance, APR, TermLength, DayDue, StartingBalance, OpenedBy, JointID) " +
                    $"VALUES ({memberID}, '{type}', '{description}', {initialBalance}, {apr}, {term}, {dayDue}, {initialBalance}, {userID}, {jointID});";
            }

            try
            {
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to create account. \n" + e.Message.ToString());
            }
        }

        public static void UpdateLoan(int loanID, string type, string description, double apr, int term, int dayDue, int userID, int jointID = 0)
        {
            String query;

            if (jointID == 0)
            {
                query = $"UPDATE Loans SET LoanType = '{type}', LoanDescription = '{description}', " +
                    $"APR = {apr}, TermLength = {term}, DayDue = {dayDue}, UpdatedBy = {userID} WHERE LoanID = {loanID};";
            }
            else
            {
                query = $"UPDATE Loans SET LoanType = '{type}', LoanDescription = '{description}', " +
                    $"APR = {apr}, TermLength = {term}, DayDue = {dayDue}, UpdatedBy = {userID}, JointID = {jointID} WHERE LoanID = {loanID};";
            }

            try
            {
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to update account. \n" + e.Message.ToString());
            }
        }

        public static void CloseLoan(int loanID, int userID)
        {
            try
            {
                String query = $"UPDATE Loans SET DateClosed = {DateTime.Today.Date.ToShortDateString()}, ClosedBy = {userID}, UpdatedBy = {userID} WHERE LoanID = {loanID};";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to close acocunt. \n" + e.Message.ToString());
            }
        }

        public static DataTable GetLoans(int memberID)
        {
            DataTable memberShares = new DataTable();

            String query = $"SELECT Loans.LoanID AS ID, Loans.LoanType AS Type, Loans.LoanDescription AS Description, Loans.CurrentBalance AS Balance, " +
                $"Loans.DayDue AS Due, CONCAT(Members.FName, ' ', Members.LName) AS Joint " +
                $"FROM Loans LEFT JOIN Members ON Loans.JointID = Members.MemberID WHERE Loans.MemberID = {memberID} AND Loans.DateClosed IS NULL;";

            try
            {
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(memberShares);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to obtain loans. \n" + e.Message, "Selection Error");
                DBClose();
            }
            return memberShares;
        }

        public static Loan GetLoan(int ID)
        {
            Loan foundLoan;

            String query = $"SELECT Loans.LoanID AS ID, Loans.MemberID, Loans.LoanType AS Type, Loans.LoanDescription AS Description, Loans.CurrentBalance AS Balance, " +
                $"Loans.APR, Loans.TermLength, Loans.DayDue AS Due, Loans.StartingBalance, Loans.DateOpened, Loans.DateClosed, " +
                $"Loans.JointID, CONCAT(Members.FName, ' ', Members.LName) AS Joint, Members.SSN " +
                $"FROM Loans LEFT JOIN Members ON Loans.JointID = Members.MemberID WHERE Loans.LoanID = {ID} AND Loans.DateClosed IS NULL;";

            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                DateTime closeDate;
                int jointID;
                string jointName;
                int jointSSN;
                if (reader[10] == DBNull.Value) { closeDate = Convert.ToDateTime("11/11/1111"); }
                else { closeDate = Convert.ToDateTime(reader[10].ToString()); }
                if (reader[11] == DBNull.Value) { jointID = 0; } else { jointID = Convert.ToInt32(reader[11]); }
                if (reader[12] == DBNull.Value) { jointName = ""; } else { jointName = reader[12].ToString(); }
                if (reader[13] == DBNull.Value) { jointSSN = 0; } else { jointSSN = Convert.ToInt32(reader[13]); }

                foundLoan = new Loan(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), reader[2].ToString(), reader[3].ToString(),
                    Convert.ToDouble(reader[4]), Convert.ToDouble(reader[5]), Convert.ToInt32(reader[6]), Convert.ToInt32(reader[7]), Convert.ToDouble(reader[8]),
                    Convert.ToDateTime(reader[9]), closeDate, jointID, jointName, jointSSN);
                DBClose();
            }
            else
            {
                Console.WriteLine("No rows in reader");
                DBClose();
                throw new Exception("Unable to find loan with that ID");
            }

            return foundLoan;
        }
    }
}
