using System;
using System.Collections.Generic;
using System.Data.SQLite;
using ExpenseTracker.Models; // تأكد من وجود هذا الـ using للوصول إلى كلاس Category

namespace ExpenseTracker.Database
{
    public class CategoryRepository
    {
        private readonly string _connectionString = "Data Source=ExpenseTracker.db;Version=3;";

        // إضافة فئة جديدة
        public void AddCategory(Category category)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Categories (Name, Type, UserID) VALUES (@Name, @Type, @UserID)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", category.Name);
                    command.Parameters.AddWithValue("@Type", category.Type);
                    command.Parameters.AddWithValue("@UserID", category.UserID.HasValue ? (object)category.UserID.Value : DBNull.Value);
                    command.ExecuteNonQuery();
                }
            }
        }

        // استرجاع جميع الفئات
        public List<Category> GetAllCategoriesByUser(int userId)
        {
            var categories = new List<Category>();
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Categories WHERE UserID = @UserID OR UserID IS NULL";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new Category
                            {
                                CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                Name = reader["Name"].ToString(),
                                Type = reader["Type"].ToString(),
                                UserID = reader["UserID"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["UserID"])
                            });
                        }
                    }
                }
            }
            return categories;
        }

        public void DeleteCategory(int categoryId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.ExecuteNonQuery();
                }
            }
        }



        //public List<Category> GetAllCategories()
        //{
        //    var categories = new List<Category>();

        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        connection.Open();
        //        string query = "SELECT CategoryID, Name, Type FROM Categories";

        //        using (var command = new SQLiteCommand(query, connection))
        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                categories.Add(new Category
        //                {
        //                    CategoryID = reader.GetInt32(0),
        //                    Name = reader.GetString(1),
        //                    Type = reader.GetString(2)
        //                });
        //            }
        //        }
        //    }
        //    return categories;
        //}
    }
}
