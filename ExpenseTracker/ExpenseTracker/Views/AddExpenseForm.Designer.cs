namespace ExpenseTracker.Views
{
    partial class AddExpenseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpExpenseDetails = new System.Windows.Forms.GroupBox();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.grpExpenseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // grpExpenseDetails
            // 
            this.grpExpenseDetails.Controls.Add(this.btnDeleteExpense);
            this.grpExpenseDetails.Controls.Add(this.btnAddExpense);
            this.grpExpenseDetails.Controls.Add(this.txtDescription);
            this.grpExpenseDetails.Controls.Add(this.label4);
            this.grpExpenseDetails.Controls.Add(this.label3);
            this.grpExpenseDetails.Controls.Add(this.dtpDate);
            this.grpExpenseDetails.Controls.Add(this.txtAmount);
            this.grpExpenseDetails.Controls.Add(this.label2);
            this.grpExpenseDetails.Controls.Add(this.cmbCategory);
            this.grpExpenseDetails.Controls.Add(this.label1);
            this.grpExpenseDetails.Controls.Add(this.lblTitle);
            this.grpExpenseDetails.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExpenseDetails.Location = new System.Drawing.Point(675, -1);
            this.grpExpenseDetails.Name = "grpExpenseDetails";
            this.grpExpenseDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpExpenseDetails.Size = new System.Drawing.Size(472, 450);
            this.grpExpenseDetails.TabIndex = 0;
            this.grpExpenseDetails.TabStop = false;
            this.grpExpenseDetails.Text = "تفاصيل النفقة";
            this.grpExpenseDetails.Enter += new System.EventHandler(this.GrpExpenseDetails_Enter);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteExpense.Location = new System.Drawing.Point(39, 388);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(100, 42);
            this.btnDeleteExpense.TabIndex = 10;
            this.btnDeleteExpense.Text = "حذف";
            this.btnDeleteExpense.UseVisualStyleBackColor = false;
            this.btnDeleteExpense.Click += new System.EventHandler(this.BtnDeleteExpense_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.Blue;
            this.btnAddExpense.ForeColor = System.Drawing.Color.White;
            this.btnAddExpense.Location = new System.Drawing.Point(145, 388);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(221, 42);
            this.btnAddExpense.TabIndex = 9;
            this.btnAddExpense.Text = "إضافة";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.BtnAddExpense_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(20, 318);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(346, 31);
            this.txtDescription.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "الوصف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "التاريخ";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(20, 239);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(346, 39);
            this.dtpDate.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(20, 167);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(346, 37);
            this.txtAmount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "المبلغ";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(20, 91);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(346, 39);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.CmbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "الفئة";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(142, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة نفقة";
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(4, 4);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.RowTemplate.Height = 26;
            this.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenses.Size = new System.Drawing.Size(665, 453);
            this.dgvExpenses.TabIndex = 1;
            this.dgvExpenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExpenses_CellContentClick);
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 461);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.grpExpenseDetails);
            this.Name = "AddExpenseForm";
            this.Text = "AddExpenseForm";
            this.Load += new System.EventHandler(this.AddExpenseForm_Load);
            this.grpExpenseDetails.ResumeLayout(false);
            this.grpExpenseDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpExpenseDetails;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Button btnDeleteExpense;
    }
}