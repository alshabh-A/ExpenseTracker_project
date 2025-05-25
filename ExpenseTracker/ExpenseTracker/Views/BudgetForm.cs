using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Controllers;
using ExpenseTracker.Database;
using ExpenseTracker.Models;

namespace ExpenseTracker.Views
{
    public partial class BudgetForm : Form
    {
        public BudgetForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            ThemeManager.ApplyTheme(this);
        }

        private void LblCategory_Click(object sender, EventArgs e)
        {

        }

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            int userId = Session.CurrentUser.UserID;
            var categoryRepo = new CategoryRepository();
            var categories = categoryRepo.GetAllCategoriesByUser(userId);
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name"; // اسم الفئة
            cmbCategory.ValueMember = "CategoryID";   // ID الفئة
            //LoadCategories(); // 
            LoadBudgets();
        }

        private void BtnSaveBudget_Click(object sender, EventArgs e)
        {
            try
            {
                var repo = new BudgetRepository();
                int userId = Session.CurrentUser.UserID;
                int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                double amount = Convert.ToDouble(txtAmount.Text);
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                var budget = new Budget
                {
                    UserID = userId,
                    CategoryID = categoryId,
                    Amount = amount,
                    StartDate = startDate,
                    EndDate = endDate
                };

                repo.AddBudget(budget);
                LoadBudgets();

                MessageBox.Show("تم حفظ الميزانية بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحفظ:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvBudgets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadBudgets()
        {
            var repo = new BudgetRepository();
            int userId = Session.CurrentUser.UserID;
            var budgets = repo.GetBudgetsByUserId(userId);

            var categories = new CategoryRepository().GetAllCategoriesByUser(userId);

            var budgetList = (from b in budgets
                              join c in categories on b.CategoryID equals c.CategoryID
                              select new
                              {
                                  رقم = b.BudgetID,
                                  الفئة = c.Name,
                                  المبلغ = b.Amount,
                                  من = b.StartDate.ToShortDateString(),
                                  إلى = b.EndDate.ToShortDateString()
                              }).ToList();

            dgvBudgets.AutoGenerateColumns = true;
            dgvBudgets.DataSource = budgetList;
        }

        private void BtnDeleteBudget_Click(object sender, EventArgs e)
        {
            if (dgvBudgets.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى تحديد ميزانية من الجدول أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("هل أنت متأكد من حذف هذه الميزانية؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // الحصول على BudgetID من الصف المحدد
                int budgetId = Convert.ToInt32(dgvBudgets.SelectedRows[0].Cells["رقم"].Value);

                var repo = new BudgetRepository();
                repo.DeleteBudget(budgetId);

                MessageBox.Show("تم حذف الميزانية بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBudgets(); // إعادة تحميل البيانات
            }
        }
    }
}
