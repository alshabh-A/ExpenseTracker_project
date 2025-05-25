using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ExpenseTracker.Controllers;
using ExpenseTracker.Database;
using ExpenseTracker.Models;
//using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseTracker.Views
{
    public partial class ReportChartForm : Form
    {
        public ReportChartForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            ThemeManager.ApplyTheme(this);
        }

        private void ReportChartForm_Load(object sender, EventArgs e)
        {
            int userId = Session.CurrentUser.UserID;
            var expenses = new ExpenseRepository().GetExpensesByUserId(userId);
            var categories = new CategoryRepository().GetAllCategoriesByUser(userId);

            var grouped = expenses
                .GroupBy(exp => exp.CategoryID)
                .Select(g => new
                {
                    CategoryName = categories.First(c => c.CategoryID == g.Key).Name,
                    TotalAmount = g.Sum(x => x.Amount)
                }).ToList();

            chartExpenses.Series.Clear();
            chartExpenses.ChartAreas.Clear();
            chartExpenses.Titles.Clear();

            chartExpenses.Titles.Add("تحليل النفقات حسب الفئة");

            var chartArea = new ChartArea();
            chartExpenses.ChartAreas.Add(chartArea);

            var series = new Series("النفقات");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            chartExpenses.ChartAreas[0].AxisX.Title = "الفئة";
            chartExpenses.ChartAreas[0].AxisY.Title = "إجمالي النفقات";


            foreach (var item in grouped)
            {
                series.Points.AddXY(item.CategoryName, item.TotalAmount);
            }

            chartExpenses.Series.Add(series);
        }
    }
}