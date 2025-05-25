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
using ExpenseTracker.Views;


namespace ExpenseTracker
{
    public partial class MainForm : Form
    {

        private User currentUser;
        private AddExpenseForm _addExpForm;
        private BudgetForm _budgetForm;
        private CategoriesForm _categoriesForm;
        private ReportForm _reportForm;



        public MainForm( User user)
        {

            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            ThemeManager.ApplyTheme(this);
            currentUser = user;
            

        }

        


        



        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"مرحبًا، {currentUser.Name} 👋";

            // 1) أنشئ النماذج وضمّها مرة واحدة:
            _addExpForm = new AddExpenseForm();
            _budgetForm = new BudgetForm();
            _categoriesForm = new CategoriesForm();
            _reportForm = new ReportForm();

            EmbedFormInTab(_addExpForm, tabPageAddExpense);
            EmbedFormInTab(_budgetForm, tabPageBudget);
            EmbedFormInTab(_categoriesForm, tabPageCategories);
            EmbedFormInTab(_reportForm, tabPageReports);

            // 2) اشترك في حدث تبديل التبويب **بعد** إنشاء _addExpForm:
            tabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
        }

        private void EmbedFormInTab(Form form, TabPage tab)
        {
            tab.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Margin = Padding.Empty;
            form.Padding = Padding.Empty;
            tab.Margin = Padding.Empty;
            tab.Padding = Padding.Empty;
            tab.Controls.Add(form);
            form.Show();
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            // تأكد أننا انتقلنا إلى تبويب "إضافة نفقة" وأن النموذج موجود
            if (tabControlMain.SelectedTab == tabPageAddExpense && _addExpForm != null)
            {
                _addExpForm.LoadCategories();
            }
        }

        private void BtnAddExpense_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageAddExpense;
            
            //AddExpenseForm expenseForm = new AddExpenseForm();

            //expenseForm.ShowDialog();


        }

        private void BtnBudgetSetup_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageBudget;
            //BudgetForm budgetForm = new BudgetForm();
            //budgetForm.ShowDialog();
        }

        private void BtnCategorySetup_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageCategories;
            //CategoriesForm categoriesForm = new CategoriesForm();
            //categoriesForm.ShowDialog();
        }

        private void BtnViewReports_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageReports;
            //ReportForm reportForm = new ReportForm();
            //reportForm.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); // إخفاء الواجهة الرئيسية
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // إعادة المستخدم إلى نافذة تسجيل الدخول
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
           

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
