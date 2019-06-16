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
            String query = $"SELECT Salt FROM Salts WHERE UserID = {user.getUserID()};";

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
                return hashed == user.getPassword();
            }
            DBClose();
            return false;
        }

        //The salt is stored in the format of: “{#hash_iterations}.{generated_salt}”

        public static void createUser(string name, string password, int auth)
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
            }catch (Exception e)
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
            } catch (Exception e)
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
            } catch (Exception e)
            {
                MessageBox.Show("Unable to insert salt for user. \n " + e.Message.ToString(), "Insertion Error", MessageBoxButtons.OK);
                return;
            }

            Console.WriteLine($"Successfully created user: {name}");
        }

        public static void createMember(string fName, string lName, int ssn, string idNum, string dob, string street, string city,
            string state, int zipCode, int cell, string email, int userID, string mName = null, string extraAddress = null, string homePhone = null,
            string mailStreet = null, string mailExtraAddress = null, string mailCity = null, string mailState = null, string mailZipCode = null)
        {
            Console.WriteLine(dob);

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

        public static User getUser(string name)
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
                return user;
            }
            else
            {
                Console.WriteLine("No rows in reader");
                DBClose();
                throw new Exception("Unable to find user with that name");
            }
        }
    }
}
