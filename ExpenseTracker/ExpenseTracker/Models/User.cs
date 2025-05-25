using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class User
    {
        public int UserID { get; set; }         // المعرف الفريد للمستخدم
        public string Name { get; set; }        // اسم المستخدم
        public string Email { get; set; }       // البريد الإلكتروني
        public string Password { get; set; }    // كلمة المرور

        

        public User(int userID, string name, string email, string password)
        {
            UserID = userID;
            Name = name;
            Email = email;
            Password = password;
        }

        public User() { } // مُنشئ فارغ
    }
}
