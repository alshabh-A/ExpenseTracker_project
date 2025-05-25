using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Controllers;
using ExpenseTracker.Database;
using ExpenseTracker.Models;

namespace ExpenseTracker.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("يرجى تعبئة جميع الحقول.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("صيغة البريد الالكتروني غير صحيحه يجب ان تكون بريد من نوع Gmail", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("كلمتا المرور غير متطابقتين.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var userRepo = new UserRepository();
                var existingUser = userRepo.GetUserByEmailAndPassword(email, password);

                if (existingUser != null)
                {
                    MessageBox.Show("البريد الإلكتروني مستخدم مسبقًا.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //userRepo.AddUser(name, email, password);
                var user = new User
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                };

                bool success = userRepo.AddUser(user);

                MessageBox.Show("تم إنشاء الحساب بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // بعد الإنشاء، العودة إلى شاشة تسجيل الدخول
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء إنشاء الحساب:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9]*@+gmail+\.+com$";
            return Regex.IsMatch(email, pattern);
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (IsValidEmail(email))
            {
                txtEmail.ForeColor = Color.Black;
            } else
            {
                txtEmail.ForeColor = Color.Red;
            }
        }
    }
}
