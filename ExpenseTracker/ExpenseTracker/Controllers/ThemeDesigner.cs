
//public static Font DefaultFont = new Font("Times New Roman", 16F);
//public static Font ButtonFont = new Font("Times New Roman", 16F, FontStyle.Bold);
//private static int FortyEight;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace ExpenseTracker.Controllers

{
    public static class ThemeManager
    {
        // الخطوط
        public static readonly Font DefaultFont = new Font("Times New Roman", 16F, FontStyle.Regular);
        public static readonly Font ButtonFont = new Font("Times New Roman", 16F, FontStyle.Bold);

        // الألوان
        public static readonly Color FormBackColor = ColorTranslator.FromHtml("#F0EFEA");
        public static readonly Color TextColor = ColorTranslator.FromHtml("#2C3E50");
        public static readonly Color AddButtonColor = ColorTranslator.FromHtml("#1ABC9C"); // أخضر
        public static readonly Color DeleteButtonColor = ColorTranslator.FromHtml("#E74C3C"); // أحمر
        public static readonly Color ActionButtonColor = ColorTranslator.FromHtml("#3498DB"); // أزرق للأزرار العامة
        public static readonly Color SurfaceBackColor = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color BorderColor = ColorTranslator.FromHtml("#BDC3C7");

        public static void ApplyTheme(Form form)
        {
            form.AutoScaleMode = AutoScaleMode.None;
            form.BackColor = FormBackColor;
            form.ForeColor = TextColor;
            ApplyToControls(form.Controls);
        }

        private static void ApplyToControls(Control.ControlCollection ctrls)
        {
            foreach (Control ctl in ctrls)
            {
                // زر الإضافة
                if (ctl is Button btn &&
                    (btn.Name.StartsWith("btnAdd", StringComparison.OrdinalIgnoreCase)
                     || btn.Text.Contains("إضافة")))
                {
                    StyleButton(btn, AddButtonColor);
                }
                // زر الحذف
                else if (ctl is Button btnDel &&
                         (btnDel.Name.StartsWith("btnDelete", StringComparison.OrdinalIgnoreCase)
                          || btnDel.Text.Contains("حذف")))
                {
                    StyleButton(btnDel, DeleteButtonColor);
                }
                // زر البحث / الطباعة / تنقل
                else if (ctl is Button btnAct &&
                         (btnAct.Name.IndexOf("Search", StringComparison.OrdinalIgnoreCase) >= 0
                          || btnAct.Name.IndexOf("Print", StringComparison.OrdinalIgnoreCase) >= 0
                          || btnAct.Name.IndexOf("Nav", StringComparison.OrdinalIgnoreCase) >= 0
                          || btnAct.Name.IndexOf("Back", StringComparison.OrdinalIgnoreCase) >= 0
                          || btnAct.Name.IndexOf("Next", StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    StyleButton(btnAct, ActionButtonColor);
                }
                // باقي الأزرار (كأزرار حفظ/تحديث/إلغاء) كأزرار عامة
                else if (ctl is Button btnOther)
                {
                    StyleButton(btnOther, ActionButtonColor);
                }
                // TextBox
                else if (ctl is TextBox txt)
                {
                    txt.BackColor = SurfaceBackColor;
                    txt.ForeColor = TextColor;
                    txt.Font = DefaultFont;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                // ComboBox
                else if (ctl is ComboBox cb)
                {
                    cb.BackColor = SurfaceBackColor;
                    cb.ForeColor = TextColor;
                    cb.Font = DefaultFont;
                    cb.FlatStyle = FlatStyle.Flat;
                }
                // DataGridView
                else if (ctl is DataGridView dgv)
                {
                    dgv.BackgroundColor = SurfaceBackColor;
                    dgv.DefaultCellStyle.BackColor = SurfaceBackColor;
                    dgv.DefaultCellStyle.ForeColor = TextColor;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = BorderColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.Font = DefaultFont;
                }
                // GroupBox
                else if (ctl is GroupBox gb)
                {
                    gb.ForeColor = TextColor;
                    gb.BackColor = FormBackColor;
                    gb.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
                }
                // Label
                else if (ctl is Label lbl)
                {
                    lbl.ForeColor = TextColor;
                    lbl.BackColor = Color.Transparent;
                    lbl.Font = DefaultFont;
                }
                // Panel
                else if (ctl is Panel pnl)
                {
                    pnl.BackColor = FormBackColor;
                }
                // أي كنترول آخر
                else
                {
                    ctl.BackColor = FormBackColor;
                    ctl.ForeColor = TextColor;
                    ctl.Font = DefaultFont;
                }

                // تطبيق على الأبناء
                if (ctl.HasChildren)
                    ApplyToControls(ctl.Controls);
            }
        }

        private static void StyleButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Font = ButtonFont;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }
    }
}