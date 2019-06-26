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
    public class DataHelper
    {
        // Connection string to MySql database hosted by AWS
        public static string connectionString = "server=bankingapp.cp7exr1x8hkd.us-west-2.rds.amazonaws.com;userid=root;database=bankingappdb;password=bankingapp;";
        // Variables for Database Interaction
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlCommand cmd;
        public static MySqlDataReader reader;

        public static int createdUserID;

        // Variables for password hashing
        private static string salt;
        private static ICryptoService cryptoService = new PBKDF2();
        private const int SALT_SIZE = 16;
        private const int HASH_ITERATIONS = 50;

        // Open the database using connection string
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

        // Validate password using provided password, stored password, and stored salt value
        public static bool ValidatePassword(User user, string password)
        {
            // Default hash iteration is 5000, default salt size is 16
            // Retrieve salt from Salts table
            String query = $"SELECT Salt FROM Salts WHERE UserID = {user.GetUserID()};";

            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            // If a salt is found for the user
            if (reader.HasRows)
            {
                // set the Salt to salt variable
                salt = reader[0].ToString();
                DBClose();
                //hash the password with the saved salt for that user
                string hashed = cryptoService.Compute(password, salt);
                //return true if both hashes are the same
                return hashed == user.GetPassword();
            }
            DBClose();
            // return false if no match found
            return false;
        }

        //The salt is stored in the format of: “{#hash_iterations}.{generated_salt}”

        // Create User row in database
        public static void CreateUser(string name, string password, int auth)
        {
            // Default hash iteration is 5000, default salt size is 16
            // Variables for password hashing
            // Generate and store salt for user
            string salt = cryptoService.GenerateSalt();
            // Compute the hashed password using the generated salt
            string hashedPassword = cryptoService.Compute(password, salt);

            try
            {
                // Attempt to insert new user into database
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
                // Attempt to retrieve the created UserID
                String query = $"SELECT UserID FROM Users WHERE UserName = '{name}';";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    // If found, set to local variable
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
                // Insert salt into Salts table with relation to UserID created
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
            // Log the creation of the user
            Console.WriteLine($"Successfully created user: {name}");
        }

        // Update User with Password change
        public static void UpdateUserWithPassword(int userID, string name, string password, int auth)
        {
            // Generate salt for new password
            string salt = cryptoService.GenerateSalt();
            // Compute new password hash and store in local variable
            string hashedPassword = cryptoService.Compute(password, salt);

            try
            {
                // Attempt to update user with new values and new hashed password
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
                // Update Salts table with new salt for user
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
            // Log user update
            Console.WriteLine($"Successfully updated user: {name}");
        }

        // Update user with no password change
        public static void UpdateUserWOPassword(int userID, string name, int auth)
        {
            try
            {
                // Attempt to update user row with new values
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
            // Log user update
            Console.WriteLine($"Successfully updated user: {name}");
        }

        // Delete User
        public static void DeleteUser(int userID)
        {
            try
            {
                // Attempt to remove user row from database
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
            // Log removal of user
            Console.WriteLine($"Successfully deleted user: {userID}");
        }

        // Obtain user based on name
        public static User GetUser(string name)
        {
            // Retrieve user information from database matching name provided
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
                // If user matching is found, store values in local variables and create a User instance
                userID = Convert.ToInt32(reader[0]);
                userName = reader[1].ToString();
                password = reader[2].ToString();
                auth = Convert.ToInt32(reader[3]);
                user = new User(userID, userName, password, auth);
                DBClose();
            }
            else
            {
                // If no user found, log result and throw exception
                Console.WriteLine("No rows in reader");
                DBClose();
                throw new Exception("Unable to find user with that name");
            }
            // Return user if found
            return user;

        }

        // Obtain a list of Users as strings
        public static List<string> GetUsers()
        {
            // List to store users found
            List<string> foundUsers = new List<string>();

            // Retrieve all usernames from the Users table
            String query = "SELECT UserName FROM Users;";
            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // If any rows are found, add values to List
                foundUsers.Add(reader[0].ToString());
            }
            DBClose();
            if (foundUsers.Count == 0)
            {
                // If none found, log result
                Console.WriteLine("No users found");
            }
            // return list of usernames
            return foundUsers;
        }

        // Obtain member based on Member ID
        public static Member GetMember(int memberNum)
        {
            // Member Instance Variables
            Member member;
            int memberID;
            string firstName;
            string middleName;
            string lastName;
            string socialSecurityNumber;
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
            string cellPhone;
            string homePhone;
            string email;

            // Obtain all information from Members table for Member row matching ID provided
            String query = $"SELECT MemberID, FName, MName, LName, SSN, IDNum, Birthdate, Street, ExtraAddress, City, State, ZipCode, MailStreet, MailExtraAddress, MailCity, " +
                $"MailState, MailZipCode, CellPhone, HomePhone, Email FROM Members WHERE MemberID = {memberNum};";
            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                // If a user is found, set values to local variables
                memberID = Convert.ToInt32(reader[0]);
                firstName = reader[1].ToString();
                middleName = reader[2].ToString();
                lastName = reader[3].ToString();
                socialSecurityNumber = reader[4].ToString();
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
                cellPhone = reader[17].ToString();
                homePhone = reader[18].ToString();
                email = reader[19].ToString();
                // Create a new Member instance
                member = new Member(memberID, firstName, lastName, socialSecurityNumber, IDNumber, birthdate, street, city, state, zipCode, cellPhone, email, middleName, extraAddress,
                    homePhone, mailStreet, mailExtraAddress, mailCity, mailState, mailZipCode);
                DBClose();
                // Return created member instance
                return member;
            }
            else
            {
                // If no member found, log result and throw exception
                Console.WriteLine("No rows in reader");
                DBClose();
                throw new Exception("Unable to find member matching that member ID");
            }
        }

        // Create a New Member
        public static void CreateMember(string fName, string lName, string ssn, string idNum, string dob, string street, string city,
            string state, int zipCode, string cell, string email, int userID, string mName = null, string extraAddress = null, string homePhone = null,
            string mailStreet = null, string mailExtraAddress = null, string mailCity = null, string mailState = null, string mailZipCode = null)
        {
            try
            {
                // Create a new Member row in database
                String query = $"INSERT INTO Members (FName, MName, LName, SSN, IDNum, Birthdate, Street, ExtraAddress, City, State, ZipCode, " +
                    $"MailStreet, MailExtraAddress, MailCity, MailState, MailZipCode, CellPhone, HomePhone, Email, CreatedBy) VALUES (" +
                    $"'{fName}', '{mName}', '{lName}', '{ssn}', '{idNum}', '{dob}', '{street}', '{extraAddress}', '{city}', '{state}', '{zipCode}', " +
                    $"'{mailStreet}', '{mailExtraAddress}', '{mailCity}', '{mailState}', '{mailZipCode}', '{cell}', '{homePhone}', '{email}', {userID});";
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                // If creation failed, display error and cancel creation
                MessageBox.Show("Unable to create new member. \n " + e.Message.ToString(), "Insertion Error", MessageBoxButtons.OK);
                return;
            }
        }

        // Update an existing member
        public static void UpdateMember(int memberID, string fName, string lName, string ssn, string idNum, string dob, string street, string city,
            string state, int zipCode, string cell, string email, int userID, string mName = null, string extraAddress = null, string homePhone = null,
            string mailStreet = null, string mailExtraAddress = null, string mailCity = null, string mailState = null, string mailZipCode = null)
        {
            try
            {  
                // Update Members row with new values or same value if not changed
                String query = $"UPDATE Members SET " +
                    $"FName = '{fName}', MName = '{mName}', LName = '{lName}', SSN = '{ssn}', IDNum = '{idNum}', Birthdate = '{dob}', Street = '{street}', " +
                    $"ExtraAddress = '{extraAddress}', City = '{city}', State = '{state}', ZipCode = '{zipCode}', MailStreet = '{mailStreet}', " +
                    $"MailExtraAddress = '{mailExtraAddress}', MailCity = '{mailCity}', MailState = '{mailState}', MailZipCode = '{mailZipCode}', " +
                    $"CellPhone = '{cell}', HomePhone = '{homePhone}', Email = '{email}', LastUpdatedBy = {userID} WHERE MemberID = {memberID};";
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

        // Delete a member
        public static void DeleteMember(int memberID)
        {
            // DataTables to hold existing accounts for a member
            DataTable shares = GetShares(memberID);
            DataTable loans = GetLoans(memberID);

            // If the member has shares or loans, deny deletion
            if (shares.Rows.Count > 0 || loans.Rows.Count > 0)
            {
                MessageBox.Show("This member still has accounts in their name. The accounts must be closed before this member can be deleted.");
                return;
            }

            try
            {
                // If no accounts open, delete member row where MemberID matches
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

        // Create a new share for a member
        public static void CreateShare(int memberID, string description, string type, int userID, int jointID = 0)
        {
            String query;

            // If no joint member, insert with default joint information
            if (jointID == 0)
            {
                query = $"INSERT INTO Shares (MemberID, ShareType, ShareDescription, OpenedBy) VALUES ({memberID}, '{type}', '{description}', {userID});";
            }
            // If there is a joint member, insert with joint information
            else
            {
                query = $"INSERT INTO Shares (MemberID, ShareType, ShareDescription, OpenedBy, JointMemberID) VALUES ({memberID}, '{type}', '{description}', {userID}, {jointID});";
            }

            try
            {
                // Attempt to create new share
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

        // Update an existing share for a member
        public static void UpdateShare(int shareID, string description, string type, int userID, int jointID = 0)
        {
            String query;

            // If no joint, update with default joint information
            if (jointID == 0)
            {
                query = $"UPDATE Shares SET ShareDescription = '{description}', ShareType = '{type}',  LastUpdatedBy = {userID} WHERE ShareID = {shareID};";
            }
            // If joint, update with joint information
            else
            {
                query = $"UPDATE Shares SET ShareDescription = '{description}', ShareType = '{type}', JointMemberID = {jointID},  LastUpdatedBy = {userID} WHERE ShareID = {shareID};";
            }

            try
            {
                // Attempt to update share
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

        // Close a share
        public static void CloseShare(int shareID, string reason, int userID)
        {
            try
            {
                // Attempt to update the sare and set DateClosed to the current date
                // Accounts are not "deleted" for record keeping purposes
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


        // Obtain shares within a provided member ID
        public static DataTable GetShares(int memberID)
        {
            // DataTable for storing shares found
            DataTable memberShares = new DataTable();

            // Select necessary details for each share that matches member ID as primary or joint
            String query = $"SELECT Shares.ShareID AS ID, Shares.ShareType AS Type, Shares.ShareDescription AS Description, Shares.Balance, " +
                $"CONCAT(Members.FName, ' ', Members.LName) AS Joint " +
                $"FROM Shares LEFT JOIN Members ON Shares.JointMemberID = Members.MemberID WHERE (Shares.MemberID = {memberID} OR Shares.JointMemberID = {memberID}) AND Shares.DateClosed IS NULL;";

            try
            {
                // Attempt to retrieve the shares
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
            // Return DataTable of found shares
            return memberShares;
        }

        // Obtain a share based on ID
        public static Share GetShare(int ID)
        {
            // Share instance for located share
            Share foundShare;

            // Select share details for share that matches current member ID and provided share ID
            String query = $"SELECT Shares.ShareID AS ID, Shares.MemberID, Shares.ShareType AS Type, Shares.ShareDescription AS Description, Shares.Balance, Shares.OpenedDate,  " +
                $"Shares.DateClosed, Shares.CloseReason, Shares.JointMemberID, CONCAT(Members.FName, ' ', Members.LName) AS Joint, Members.SSN " +
                $"FROM Shares LEFT JOIN Members ON Shares.JointMemberID = Members.MemberID WHERE Shares.ShareID = {ID} AND Shares.DateClosed IS NULL;";

            // Attempt to retrieve share information
            DBOpen();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                // If share is found, set values to local variables
                DateTime closeDate;
                string reason;
                int jointID;
                string jointName;
                string jointSSN;
                if (reader[6] == DBNull.Value) { closeDate = Convert.ToDateTime("11/11/1111"); }
                else { closeDate = Convert.ToDateTime(reader[6].ToString()); }
                if (reader[7] == DBNull.Value) { reason = ""; } else { reason = reader[7].ToString(); }
                if (reader[8] == DBNull.Value) { jointID = 0; } else { jointID = Convert.ToInt32(reader[8]); }
                if (reader[9] == DBNull.Value) { jointName = ""; } else { jointName = reader[9].ToString(); }
                if (reader[10] == DBNull.Value) { jointSSN = ""; } else { jointSSN = reader[10].ToString(); }

                // Create a new share instance using values obtained
                foundShare = new Share(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), reader[2].ToString(), reader[3].ToString(),
                    Convert.ToDecimal(reader[4]), Convert.ToDateTime(reader[5]), closeDate, reason, jointID,
                    jointName, jointSSN);
                DBClose();
            }
            else
            {
                // If no share found, log result and throw exception
                Console.WriteLine("No rows in reader");
                DBClose();
                throw new Exception("Unable to find loan with that ID");
            }
            // Return located share
            return foundShare;
        }

        // Create a new loan for a member
        public static void CreateLoan(int memberID, string type, string description, double initialBalance, double apr, int term, int dayDue, int userID, int jointID = 0)
        {
            String query;

            // If no joint, create with default joint information
            if (jointID == 0)
            {
                query = $"INSERT INTO Loans (MemberID, LoanType, LoanDescription, CurrentBalance, APR, TermLength, DayDue, StartingBalance, OpenedBy) " +
                    $"VALUES ({memberID}, '{type}', '{description}', {initialBalance}, {apr}, {term}, {dayDue}, {initialBalance}, {userID});";
            }
            // If joint, create with joint information
            else
            {
                query = $"INSERT INTO Loans (MemberID, LoanType, LoanDescription, CurrentBalance, APR, TermLength, DayDue, StartingBalance, OpenedBy, JointID) " +
                    $"VALUES ({memberID}, '{type}', '{description}', {initialBalance}, {apr}, {term}, {dayDue}, {initialBalance}, {userID}, {jointID});";
            }

            try
            {
                // Attempt to create new loan
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                // If error, display message with error
                MessageBox.Show("Unable to create account. \n" + e.Message.ToString());
            }
        }

        // Update a Member's existing loan
        public static void UpdateLoan(int loanID, string type, string description, double apr, int term, int dayDue, int userID, int jointID = 0)
        {
            String query;

            // If no joint, update without joint info
            if (jointID == 0)
            {
                query = $"UPDATE Loans SET LoanType = '{type}', LoanDescription = '{description}', " +
                    $"APR = {apr}, TermLength = {term}, DayDue = {dayDue}, UpdatedBy = {userID} WHERE LoanID = {loanID};";
            }
            // If joint, update with joint info
            else
            {
                query = $"UPDATE Loans SET LoanType = '{type}', LoanDescription = '{description}', " +
                    $"APR = {apr}, TermLength = {term}, DayDue = {dayDue}, UpdatedBy = {userID}, JointID = {jointID} WHERE LoanID = {loanID};";
            }

            try
            {
                // Attempt to update row
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

        // Close a member's loan
        public static void CloseLoan(int loanID, int userID)
        {
            try
            {
                // Attempt to update Loan with matching loanID and set DateClosed to current date
                // Loans are not "deleted" for record-keeping purposes
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

        // Obtain loans for a given member ID
        public static DataTable GetLoans(int memberID)
        {
            // DataTable to store found loans
            DataTable memberShares = new DataTable();

            // Select loan details and joint details for loan that matches member ID as primary or joint
            String query = $"SELECT Loans.LoanID AS ID, Loans.LoanType AS Type, Loans.LoanDescription AS Description, Loans.CurrentBalance AS Balance, " +
                $"Loans.DayDue AS Due, CONCAT(Members.FName, ' ', Members.LName) AS Joint " +
                $"FROM Loans LEFT JOIN Members ON Loans.JointID = Members.MemberID WHERE (Loans.MemberID = {memberID} OR Loans.JointID = {memberID}) AND Loans.DateClosed IS NULL;";

            try
            {
                // Attempt to retrieve loans
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
            // Return datatable with found loans
            return memberShares;
        }

        // Obtain a loan based on loan ID
        public static Loan GetLoan(int ID)
        {
            // Loan instance to store located loan
            Loan foundLoan;

            // Select Loan and joint details based on current member ID and provided Loan ID
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
                // If loans are foind, set values to local variables
                DateTime closeDate;
                int jointID;
                string jointName;
                string jointSSN;
                if (reader[10] == DBNull.Value) { closeDate = Convert.ToDateTime("11/11/1111"); }
                else { closeDate = Convert.ToDateTime(reader[10].ToString()); }
                if (reader[11] == DBNull.Value) { jointID = 0; } else { jointID = Convert.ToInt32(reader[11]); }
                if (reader[12] == DBNull.Value) { jointName = ""; } else { jointName = reader[12].ToString(); }
                if (reader[13] == DBNull.Value) { jointSSN = ""; } else { jointSSN = reader[13].ToString(); }

                // Create a loan instance to store obtained data
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
            // Return located loan
            return foundLoan;
        }


        // TRANSACTIONS

        // Deposit Transaction
        public static void Deposit(int memberID, int shareID, string exchange, double amount, int userID)
        {
            // Update Share and add deposit amount to balance
            String query = $"UPDATE Shares SET Balance = Balance + {amount}, LastUpdatedBy = {userID} WHERE MemberID = {memberID} AND ShareID = {shareID};";

            try
            {
                // Attempt to submit change
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            } catch (Exception e)
            {
                MessageBox.Show("Unable to add deposit to share balance. \n" + e.Message, "Update Error");
                return;
            }

            // Create new transaction row to log transcation details
            query = $"INSERT INTO Transactions (MemberID, AccountID, TransactionType, ExchangeType, Amount, UserID) " +
                $"VALUES ({memberID}, {shareID}, 'Deposit', '{exchange}', {amount}, {userID});";

            try
            {
                // Attempt to insert row
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to update Transactions. \n" + e.Message, "Insert Error");
                return;
            }
            // Log successful deposit
            Console.WriteLine($"Deposit completed for member {memberID} on account {shareID}");
        }

        // Withdrawal Transaction
        public static void Withdrawal(int memberID, int shareID, string exchange, double amount, int userID)
        {
            // Update Share and subtract amount from balance
            String query = $"UPDATE Shares SET Balance = Balance - {amount}, LastUpdatedBy = {userID} WHERE MemberID = {memberID} AND ShareID = {shareID};";

            try
            {
                // Attempt to post transaction
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to subtract withdrawal to share balance. \n" + e.Message, "Update Error");
                return;
            }

            // Create new transaction row to log transaction details
            query = $"INSERT INTO Transactions (MemberID, AccountID, TransactionType, ExchangeType, Amount, UserID) " +
                $"VALUES ({memberID}, {shareID}, 'Withdrawal', '{exchange}', {amount}, {userID});";

            try
            {
                // Attempt to insert new row
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to update Transactions. \n" + e.Message, "Insert Error");
                return;
            }
            // Log successful withdrawal
            Console.WriteLine($"Withdrawal completed for member {memberID} on account {shareID}");
        }

        // Transfer Transaction - In Member and Out of Member
        public static void Transfer(int memberID, int shareID, double amount, int destMemberID, int destShareID, int userID)
        {
            // Remove transfer amount from originating share
            String query = $"UPDATE Shares SET Balance = Balance - {amount}, LastUpdatedBy = {userID} WHERE MemberID = {memberID} AND ShareID = {shareID};";

            try
            {
                // Attempt to withdraw transfer amount
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to withdraw amount from initial share. \n" + e.Message, "Update Error");
                return;
            }

            // Add transfer amount to destination share, if same member, use current members Member ID
            query = $"UPDATE Shares SET Balance = Balance + {amount}, LastUpdatedBy = {userID} WHERE MemberID = {destMemberID} AND ShareID = {destShareID};";

            try
            {
                // Attempt to add transfer amount
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                // If unsuccessful, restore transfer amount to originating share, if unsuccessful, inform user to correct manually
                MessageBox.Show("Unable to deposit amount to destination share. \n" + e.Message, "Update Error");
                query = $"UPDATE Shares SET Balance = Balance + {amount}, LastUpdatedBy = {userID} WHERE MemberID = {memberID} AND ShareID = {shareID};";
                try
                {
                    DBOpen();
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DBClose();
                } catch (Exception)
                {
                    MessageBox.Show("Unable restore original balance to originating share. Please correct manually.");
                    return;
                }
                return;
            }

            // Add transaction details to Transactions table
            query = $"INSERT INTO Transactions (MemberID, AccountID, TransactionType, ExchangeType, Amount, DestMemberID, DestAccountID, UserID) " +
                $"VALUES ({memberID}, {shareID}, 'Transfer', 'Transfer', {amount}, {destMemberID}, {destShareID}, {userID});";

            try
            {
                // Attempt to add transactoin
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to update Transactions. \n" + e.Message, "Insert Error");
                return;
            }
            // Log successful transfer
            Console.WriteLine($"Transfer completed for member {memberID} on account {shareID}");
        }

        // Make a payment on a member's Loan
        public static void Payment(int memberID, string exchange, double amount, int destAccountID, int userID, int shareID = 0)
        {
            // Update loan balance by subtracting payment amount from current balance
            String query = $"UPDATE Loans SET CurrentBalance = CurrentBalance - {amount}, UpdatedBy = {userID} WHERE MemberID = {memberID} AND LoanID = {destAccountID};";

            try
            {
                // Attempt to post payment
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to post payment to loan balance. \n" + e.Message, "Update Error");
                return;
            }

            // If a share is selected
            if (shareID > 0)
            {
                // Withdraw payment amount from designated share
                query = $"UPDATE Shares SET Balance = Balance - {amount}, LastUpdatedBy = {userID} WHERE MemberID = {memberID} AND ShareID = {shareID};";
                try
                {
                    DBOpen();
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DBClose();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unable to subtract payment from share balance. Please manually withdraw the payment. \n" + e.Message, "Update Error");
                    return;
                }
            }   

            // If share is selected, insert share ID with transaction details
            if (shareID > 0)
            {
                query = $"INSERT INTO Transactions (MemberID, AccountID, TransactionType, ExchangeType, Amount, DestAccountID, UserID) " +
                $"VALUES ({memberID}, {shareID}, 'Payment', '{exchange}', {amount}, {destAccountID}, {userID});";
            // If no share, leave out share ID
            } else
            {
                query = $"INSERT INTO Transactions (MemberID, AccountID, TransactionType, ExchangeType, Amount, DestAccountID, UserID) " +
                $"VALUES ({memberID}, 'Payment', '{exchange}', {amount}, {destAccountID}, {userID});";
            }

            try
            {
                // Attempt to post transaction details
                DBOpen();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to update Transactions. \n" + e.Message, "Insert Error");
                return;
            }
            // Log successful payment
            Console.WriteLine($"Payment completed for member {memberID} on account {destAccountID}");
        }

        // Obtain a list of transactions for a member and account
        public static DataTable GetTransactions(int memberID, int shareID = 0, int loanID = 0)
        {
            // DataTable to store found transactions
            DataTable transactions = new DataTable();
            String query;
            // If share is specified, select from Shares table
            if (shareID > 0)
            {
                query = $"SELECT TransactionID, TransactionType, ExchangeType, Amount, DestMemberID, DestAccountID, Date FROM Transactions WHERE (MemberID = {memberID} AND AccountID = {shareID}) OR (DestMemberID = {memberID} AND DestAccountID = {shareID});";
            // If no share is specified, select from Loans table
            } else
            {
                query = $"SELECT TransactionID, TransactionType, ExchangeType, Amount, DestMemberID, DestAccountID, Date FROM Transactions WHERE MemberID = {memberID} AND AccountID = {loanID};";
            }

            try
            {
                // Attempt to retrieve transactions
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(transactions);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve transaction information. \n" + e.Message, "Retrieval Error");
                return null;
            }
            // Return DataTable with transactions
            return transactions;
        }

        // REPORTS

        // Obtain information for all members
        public static DataTable AllMembers()
        {
            // DataTable to store found members
            DataTable members = new DataTable();
            // Select member details for all members
            String query = "SELECT MemberID AS ID, CONCAT(FName, ' ', LName) AS Name FROM Members;";

            try
            {
                // Attempt to retrieve members
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(members);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve member information. \n" + e.Message, "Retrieval Error");
                return null;
            }
            // Return found members
            return members;
        }

        // Obtain information for all accounts
        public static DataTable AllAccounts()
        {
            // DataTable for storing located accounts
            DataTable accounts = new DataTable();
            // Select share details for all shares from Shares
            String query = "SELECT ShareID AS ID, MemberID AS MemberID, ShareType AS Type, Balance FROM Shares;";

            try
            {
                // Attempt to retrieve shares
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(accounts);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve account information. \n" + e.Message, "Retrieval Error");
                return null;
            }

            // Select loan details for all loans from Loans
            query = "SELECT LoanID AS ID, MemberID AS MemberID, LoanType AS Type, CurrentBalance AS Balance FROM Loans;";
            try
            {
                // Attempt to retrieve loans
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(accounts);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve loan informatoion. \n" + e.Message, "Retrieval Error");
                return null;
            }
            // Return all accounts located
            return accounts;
        }

        // Obtain information for all shares
        public static DataTable AllShares()
        {
            // DataTable to store located shares
            DataTable accounts = new DataTable();
            // Select share details for all shares from Shares
            String query = "SELECT ShareID AS ID, MemberID AS MemberID, ShareType AS Type, Balance FROM Shares;";

            try
            {
                // Attempt to retrieve shares
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(accounts);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve account information. \n" + e.Message, "Retrieval Error");
                return null;
            }
            // Return all shares found
            return accounts;
        }

        // Obtain information for all loans
        public static DataTable AllLoans()
        {
            // DataTable to store located loans
            DataTable accounts = new DataTable();
            // Select loan details for all loans in Loans
            String query = "SELECT LoanID AS ID, MemberID, LoanType AS Type, CurrentBalance AS Balance FROM Loans;";

            try
            {
                // Attempt to retrieve loans
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(accounts);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve account information. \n" + e.Message, "Retrieval Error");
                return null;
            }
            // Return all located loans
            return accounts;
        }

        // Obtain information for all closed shares
        public static DataTable ClosedShares()
        {
            // DataTable for storing located shares
            DataTable accounts = new DataTable();
            // Select share details for all shares who have DateClosed values
            String query = "SELECT ShareID AS ID, MemberID, ShareType AS Type, Balance FROM Shares WHERE DateClosed IS NOT NULL;";

            try
            {
                // Attempt to retrieve closed shares
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(accounts);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve account information. \n" + e.Message, "Retrieval Error");
                return null;
            }
            // Return all located closed shares
            return accounts;
        }

        // Obtain information for all closed loans
        public static DataTable ClosedLoans()
        {
            // DataTable for storing located closed loans
            DataTable accounts = new DataTable();
            // Select loan details for all loans who have values in DateClosed
            String query = "SELECT LoanID AS ID, MemberID, LoanType AS Type, CurrentBalance AS Balance FROM Loans WHERE DateClosed IS NOT NULL;";

            try
            {
                // Attempt to retrieve closed loans
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(accounts);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve account information. \n" + e.Message, "Retrieval Error");
                return null;
            }
            // Return all closed loans found
            return accounts;
        }


        // SEARCHES

        // Obtain member matching a provided member ID
        public static DataTable SearchByID(int ID)
        {
            // DataTable storing located members
            DataTable members = new DataTable();
            // Select member details for members who match Member ID provided
            String query = $"SELECT MemberID, FName, LName, SSN FROM Members WHERE MemberID = {ID};";
            try
            {
                // Attempt to retrieve members
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(members);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve member information. \n" + e.Message, "Retrieval Error");
                return null;
            }
            // Return all located members
            return members;
        }

        // Obtain members by name provided
        public static DataTable SearchByName(string name)
        {
            // DataTable for storing located members
            DataTable members = new DataTable();
            // Select member details for members with similar names to the name provided
            String query = $"SELECT MemberID, FName, LName, SSN FROM Members WHERE CONCAT(FName, ' ', LName) LIKE '%{name}%';";
            try
            {
                // Attempt to retrieve members
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(members);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve member information. \n" + e.Message, "Retrieval Error");
                return null;
            }
            // Return all located members
            return members;
        }

        // Obtain members by provided SSN
        public static DataTable SearchBySSN(string social)
        {
            // DataTable for storing located members
            DataTable members = new DataTable();
            // Select member details for members with a social similar to the social provided
            String query = $"SELECT MemberID, FName, LName, SSN FROM Members WHERE SSN LIKE '%{social}%';";
            try
            {
                // Attempt to retrieve members
                DBOpen();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adp);
                adp.Fill(members);
                DBClose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to retrieve member information. \n" + e.Message, "Retrieval Error");
                return null;
            }
            // Return all members located
            return members;
        }
    }
}
