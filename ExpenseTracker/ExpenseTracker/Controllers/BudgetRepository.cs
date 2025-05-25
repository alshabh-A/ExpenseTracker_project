using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Database;
using ExpenseTracker.Models;
using ExpenseTracker.Views;
using System.Data.SQLite;


    namespace ExpenseTracker.Database
    {
        public class BudgetRepository
        {
            private string connectionString = "Data Source=ExpenseTracker.db;Version=3;";

            public void AddBudget(Budget budget)
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Budget (UserID, CategoryID, Amount, StartDate, EndDate) VALUES (@UserID, @CategoryID, @Amount, @StartDate, @EndDate)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", budget.UserID);
                        command.Parameters.AddWithValue("@CategoryID", budget.CategoryID);
                        command.Parameters.AddWithValue("@Amount", budget.Amount);
                        command.Parameters.AddWithValue("@StartDate", budget.StartDate.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@EndDate", budget.EndDate.ToString("yyyy-MM-dd"));
                        command.ExecuteNonQuery();
                    }
                }
            }

            public List<Budget> GetAllBudgets()
            {
                var budgets = new List<Budget>();
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Budgets";
                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            budgets.Add(new Budget
                            {
                                BudgetID = Convert.ToInt32(reader["BudgetID"]),
                                UserID = Convert.ToInt32(reader["UserID"]),
                                CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                Amount = Convert.ToDouble(reader["Amount"]),
                                StartDate = DateTime.Parse(reader["StartDate"].ToString()),
                                EndDate = DateTime.Parse(reader["EndDate"].ToString())
                            });
                        }
                    }
                }
                return budgets;
            }

        public List<Budget> GetBudgetsByUserId(int userId)
        {
            var budgets = new List<Budget>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Budget WHERE UserID = @UserID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            budgets.Add(new Budget
                            {
                                BudgetID = Convert.ToInt32(reader["BudgetID"]),
                                UserID = Convert.ToInt32(reader["UserID"]),
                                CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                Amount = Convert.ToDouble(reader["Amount"]),
                                StartDate = DateTime.Parse(reader["StartDate"].ToString()),
                                EndDate = DateTime.Parse(reader["EndDate"].ToString())
                            });
                        }
                    }
                }
            }

            return budgets;
        }

        public void DeleteBudget(int budgetId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Budget WHERE BudgetID = @BudgetId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BudgetId", budgetId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Budget GetBudgetByUserAndCategory(int userId, int categoryId)
        {
            Budget budget = null;
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Budgets WHERE UserID = @userId AND CategoryID = @categoryId";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        budget = new Budget
                        {
                            BudgetID = Convert.ToInt32(reader["BudgetID"]),
                            UserID = Convert.ToInt32(reader["UserID"]),
                            CategoryID = Convert.ToInt32(reader["CategoryID"]),
                            Amount = Convert.ToDouble(reader["Amount"])
                        };
                    }
                }
            }
            return budget;
        }

        public double GetTotalExpensesForCategory(int userId, int categoryId)
        {
            double total = 0;
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT SUM(Amount) FROM Expenses WHERE UserID = @userId AND CategoryID = @categoryId";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);

                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                    total = Convert.ToDouble(result);
            }
            return total;
        }






    }
}

