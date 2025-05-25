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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ExpenseTracker.Views
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            ThemeManager.ApplyTheme(this);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                int userId = Session.CurrentUser.UserID;
                var categoryRepo = new CategoryRepository();
                var categories = categoryRepo.GetAllCategoriesByUser(userId);

                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "Name"; // اسم الفئة
                cmbCategory.ValueMember = "CategoryID";   // ID الفئة
                cmbCategory.SelectedIndex = -1; // لا شيء محدد بالبداية
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء تحميل الفئات: " + ex.Message);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date;

                var expenseRepo = new ExpenseRepository();
                var expenses = expenseRepo.GetExpensesByCategoryAndDate(categoryId, fromDate, toDate);

                dgvReport.DataSource = expenses;

                // حساب الإجمالي
                double total = expenses.Sum(exp => exp.Amount);
                lblTotal.Text = $"إجمالي المبلغ: {total:F2} ريال";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnShowCharts_Click(object sender, EventArgs e)
        {
            var chartForm = new ReportChartForm();
            chartForm.ShowDialog();
        }

        private void GrpFilter_Enter(object sender, EventArgs e)
        {

        }

        private void BtnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count > 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFile.FileName = "ExpenseReport.pdf";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                        PdfWriter.GetInstance(pdfDoc, new FileStream(saveFile.FileName, FileMode.Create));
                        pdfDoc.Open();

                        // إنشاء جدول PDF بعدد الأعمدة
                        PdfPTable pdfTable = new PdfPTable(dgvReport.Columns.Count);

                        // إضافة عناوين الأعمدة
                        foreach (DataGridViewColumn column in dgvReport.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            pdfTable.AddCell(cell);
                        }

                        // إضافة البيانات
                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();

                        MessageBox.Show("تم حفظ التقرير كـ PDF بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("لا يوجد بيانات لتصديرها!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
