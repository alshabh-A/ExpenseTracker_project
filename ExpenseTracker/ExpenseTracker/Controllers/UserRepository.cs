using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using ExpenseTracker.Models;


namespace ExpenseTracker.Database
{
    public class UserRepository
    {
        private string connectionString = "Data Source=ExpenseTracker.db;Version=3;";

        // إضافة مستخدم جديد
        public bool AddUser(User user)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Name, Email, Password) VALUES (@Name, @Email, @Password)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Adding User: " + ex.Message);
                return false;
            }
        }

        // التحقق من بيانات تسجيل الدخول
        public User GetUserByEmailAndPassword(string email, string password)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User(
                                    Convert.ToInt32(reader["UserID"]),
                                    reader["Name"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Password"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Fetching User: " + ex.Message);
            }
            return null;
        }

        // جلب جميع المستخدمين (للاختبار)
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Users";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                users.Add(new User(
                                    Convert.ToInt32(reader["UserID"]),
                                    reader["Name"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Password"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Fetching Users: " + ex.Message);
            }
            return users;
        }
    }
}
