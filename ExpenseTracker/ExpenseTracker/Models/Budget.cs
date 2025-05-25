using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models;


namespace ExpenseTracker.Models
{
    public class Budget
    {
        public int BudgetID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public double Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
