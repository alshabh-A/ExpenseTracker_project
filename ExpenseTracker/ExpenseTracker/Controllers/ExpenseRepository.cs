using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using ExpenseTracker.Database;
using ExpenseTracker.Models;
using ExpenseTracker.Views;
using System.Windows.Forms;

namespace ExpenseTracker.Database
{
    public class ExpenseRepository
    {
        private readonly string _connectionString = "Data Source=ExpenseTracker.db;Version=3;";

        public void AddExpense(int userId, int categoryId, double amount, DateTime date, string description)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Expenses (UserID, CategoryID, Amount, Date, Description) VALUES (@UserID, @CategoryID, @Amount, @Date, @Description)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Description", description);
                    command.ExecuteNonQuery();
                }

                // بعد الإضافة: تحقق من مجموع النفقات
                string sumQuery = @"SELECT IFNULL(SUM(Amount), 0) FROM Expenses 
                            WHERE UserID = @UserID AND CategoryID = @CategoryID";

                using (var sumCommand = new SQLiteCommand(sumQuery, connection))
                {
                    sumCommand.Parameters.AddWithValue("@UserID", userId);
                    sumCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                    double totalExpenses = Convert.ToDouble(sumCommand.ExecuteScalar());

                    // احصل على الميزانية
                    string budgetQuery = @"SELECT Amount FROM Budget 
                                   WHERE UserID = @UserID AND CategoryID = @CategoryID";

                    using (var budgetCommand = new SQLiteCommand(budgetQuery, connection))
                    {
                        budgetCommand.Parameters.AddWithValue("@UserID", userId);
                        budgetCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                        object result = budgetCommand.ExecuteScalar();
                        if (result != null)
                        {
                            double budgetAmount = Convert.ToDouble(result);
                            double ratio = totalExpenses / budgetAmount;

                            if (ratio >= 0.9) // أكثر من 90% من الميزانية
                            {
                                MessageBox.Show("تنبيه: أنت تقترب من الحد الأقصى للميزانية المحددة لهذه الفئة!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }

        public double GetTotalExpensesForCategory(int userId, int categoryId)
        {
            double total = 0;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"SELECT SUM(Amount) 
                         FROM Expenses 
                         WHERE UserID = @UserID AND CategoryID = @CategoryID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);

                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        total = Convert.ToDouble(result);
                    }
                }
            }

            return total;
        }


        public List<Expense> GetExpensesByCategoryAndDate(int categoryId, DateTime from, DateTime to)
        {
            var expenses = new List<Expense>();
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"SELECT ExpenseID, UserID, CategoryID, Amount, Date, Description 
                         FROM Expenses 
                         WHERE CategoryID = @CategoryID 
                         AND Date BETWEEN @From AND @To";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@From", from.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@To", to.ToString("yyyy-MM-dd"));

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            expenses.Add(new Expense
                            {
                                ExpenseID = Convert.ToInt32(reader["ExpenseID"]),
                                UserID = Convert.ToInt32(reader["UserID"]),
                                CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                Amount = Convert.ToDouble(reader["Amount"]),
                                Date = DateTime.Parse(reader["Date"].ToString()),
                                Description = reader["Description"].ToString()
                            });
                        }
                    }
                }
            }
            return expenses;
        }

        public List<Expense> GetExpensesByUserId(int userId)
        {
            var expenses = new List<Expense>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Expenses WHERE UserID = @UserID ORDER BY Date DESC";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            expenses.Add(new Expense
                            {
                                ExpenseID = Convert.ToInt32(reader["ExpenseID"]),
                                UserID = Convert.ToInt32(reader["UserID"]),
                                CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                Amount = Convert.ToDouble(reader["Amount"]),
                                Date = DateTime.Parse(reader["Date"].ToString()),
                                Description = reader["Description"].ToString()
                            });
                        }
                    }
                }
            }

            return expenses;
        }

        public void DeleteExpense(int expenseId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Expenses WHERE ExpenseID = @ExpenseID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ExpenseID", expenseId);
                    command.ExecuteNonQuery();
                }
            }
        }



    }
}
