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
    public partial class AddExpenseForm : Form
    {
        public AddExpenseForm()
        {
            InitializeComponent();
            
            this.AutoScaleMode = AutoScaleMode.None;
            ThemeManager.ApplyTheme(this);

        }

        private void GrpExpenseDetails_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAddExpense_Click(object sender, EventArgs e)
        {
            try
            {
                var repo = new ExpenseRepository();

                int userId = Session.CurrentUser.UserID;
                int categoryId = ((ComboBoxItem)cmbCategory.SelectedItem).Value;
                double amount = Convert.ToDouble(txtAmount.Text);
                DateTime date = dtpDate.Value;
                string description = txtDescription.Text;


                


                repo.AddExpense(userId, categoryId, amount, date, description);
                LoadExpenses();
                MessageBox.Show("تمت إضافة النفقة بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAmount.Text = "";
                txtDescription.Text = "";
                dtpDate.Value = DateTime.Now;
                cmbCategory.SelectedIndex = 0;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الإضافة:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadExpenses();
           


        }

        public void LoadCategories()
        {
            CategoryRepository categoryRepo = new CategoryRepository();
            int userId = Session.CurrentUser.UserID;
            var categories = categoryRepo.GetAllCategoriesByUser(userId);


            cmbCategory.Items.Clear();

            foreach (var category in categories)
            {
                if (category.Type == "Expense")
                {
                    cmbCategory.Items.Add(new ComboBoxItem
                    {
                        Text = category.Name,
                        Value = category.CategoryID
                    });
                }
            }

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }
        }


        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void DgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadExpenses()
        {

            var repo = new ExpenseRepository();
            int userId = Session.CurrentUser.UserID;
            var expenses = repo.GetExpensesByUserId(userId);

            // دمج الفئة باستخدام LINQ
            var categories = new CategoryRepository().GetAllCategoriesByUser(userId);

            var expenseList = (from exp in expenses
                               join cat in categories on exp.CategoryID equals cat.CategoryID
                               select new
                               {
                                   رقم = exp.ExpenseID,
                                   التاريخ = exp.Date.ToShortDateString(),
                                   الفئة = cat.Name,
                                   المبلغ = exp.Amount,
                                   الوصف = exp.Description
                               }).ToList();
            dgvExpenses.AutoGenerateColumns = true;
            dgvExpenses.DataSource = expenseList;

            if (dgvExpenses.Columns["رقم"] != null)
                dgvExpenses.Columns["رقم"].Visible = false;
        }

        private void BtnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow != null)
            {
                int selectedExpenseId = Convert.ToInt32(dgvExpenses.CurrentRow.Cells["رقم"].Value);
                DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذه النفقة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var repo = new ExpenseRepository();
                    repo.DeleteExpense(selectedExpenseId);
                    LoadExpenses();
                    MessageBox.Show("تم حذف النفقة بنجاح ✅", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد النفقة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
