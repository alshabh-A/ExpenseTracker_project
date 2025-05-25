using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class Category
    {
        public int CategoryID { get; set; }   // معرف الفئة
        public string Name { get; set; }      // اسم الفئة
        public string Type { get; set; }      // نوع الفئة (Expense / Income)
        public int? UserID { get; set; }


        public Category() { } // منشئ فارغ

        public Category(int categoryID, string name, string type)
        {
            CategoryID = categoryID;
            Name = name;
            Type = type;
        }
    }
}