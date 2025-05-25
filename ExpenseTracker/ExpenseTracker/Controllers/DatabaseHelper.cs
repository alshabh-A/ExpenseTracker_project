using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ExpenseTracker.Database
{
    public class DatabaseHelper
    {
        // الحصول على المسار داخل مجلد المشروع
        private static string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "ExpenseTracker.db");
        private static string connectionString = $"Data Source={dbFilePath};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            // التأكد من أن ملف قاعدة البيانات موجود
            if (!File.Exists(dbFilePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dbFilePath)); // إنشاء المجلد إذا لم يكن موجودًا
                SQLiteConnection.CreateFile(dbFilePath);
            }
            return new SQLiteConnection(connectionString);
        }

        //public static bool TestDatabaseConnection()
        //{
        //    try
        //    {
        //        using (var connection = GetConnection())
        //        {
        //            connection.Open();
        //            MessageBox.Show("✅ الاتصال بقاعدة البيانات ناجح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"❌ فشل الاتصال بقاعدة البيانات:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //}

    }
}

