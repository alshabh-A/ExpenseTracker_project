using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Database;
using ExpenseTracker.Models;
using ExpenseTracker.Views;

namespace ExpenseTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DatabaseHelper.TestDatabaseConnection();

            Application.Run(new LoginForm());
        }
    }
}
