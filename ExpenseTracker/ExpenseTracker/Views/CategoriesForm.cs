using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Models;
using ExpenseTracker.Database;
using ExpenseTracker.Controllers;

namespace ExpenseTracker.Views
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            ThemeManager.ApplyTheme(this);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            // قراءة البيانات المدخلة
            string categoryName = txtCategoryName.Text.Trim();
            string categoryType = cmbCategoryType.SelectedItem?.ToString();

            // التحقق من صحة الإدخال
            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(categoryType))
            {
                MessageBox.Show("يرجى إدخال اسم الفئة وتحديد النوع.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Session.CurrentUser.UserID;
            // إنشاء كائن الفئة
            Category newCategory = new Category
            {
                Name = categoryName,
                Type = categoryType,
                UserID = userId // ربط الفئة بالمستخدم الحالي
            };

            // إضافة الفئة إلى قاعدة البيانات
            CategoryRepository categoryRepo = new CategoryRepository();
            categoryRepo.AddCategory(newCategory);

            // تحديث عرض الفئات في DataGridView
            LoadCategories();
            

            // مسح الحقول بعد الإضافة
            txtCategoryName.Clear();
            cmbCategoryType.SelectedIndex = -1;
        }

        private void LoadCategories()
        {
            int userId = Session.CurrentUser.UserID;
            CategoryRepository categoryRepo = new CategoryRepository();
            
            List<Category> categories = categoryRepo.GetAllCategoriesByUser(userId);

            dgvCategories.DataSource = categories;
            dgvCategories.DataSource = null; // مسح البيانات القديمة
            dgvCategories.DataSource = categories; // عرض البيانات الجديدة
        }

        private void DgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCategories();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CmbCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

       

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                MessageBox.Show("يرجى تحديد فئة أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // افترض أن العمود الأول يحتوي على CategoryID
            int categoryId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryID"].Value);

            var result = MessageBox.Show("هل أنت متأكد من حذف هذه الفئة؟",
                                         "تأكيد الحذف",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            // الحذف من القاعدة
            var repo = new CategoryRepository();
            repo.DeleteCategory(categoryId);

            // إعادة تحميل الفئات
            LoadCategories();
            

            MessageBox.Show("تم حذف الفئة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
