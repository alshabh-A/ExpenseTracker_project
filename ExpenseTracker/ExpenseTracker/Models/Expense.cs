using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public int UserID { get; set; }  // نفترض أن المستخدم الحالي له ID ثابت مؤقتًا
        public int CategoryID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}

