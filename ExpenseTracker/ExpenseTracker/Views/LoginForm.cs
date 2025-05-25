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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("يرجى إدخال البريد الإلكتروني وكلمة المرور.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var userRepo = new UserRepository();
                var user = userRepo.GetUserByEmailAndPassword(email, password);

                if (user != null)
                {
                    Session.CurrentUser = user;
                    MessageBox.Show("تم تسجيل الدخول بنجاح ✅", "مرحبًا", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // افتح الواجهة الرئيسية أو Dashboard
                    var dashboard = new MainForm(user); // تحتاج إلى إنشاء MainForm لاحقًا
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("بيانات الدخول غير صحيحة ❌", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تسجيل الدخول:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
