namespace ExpenseTracker.Views
{
    partial class BudgetForm
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.grpBudgetDetails = new System.Windows.Forms.GroupBox();
            this.btnSaveBudget = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.dgvBudgets = new System.Windows.Forms.DataGridView();
            this.btnDeleteBudget = new System.Windows.Forms.Button();
            this.grpBudgetDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(431, 78);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 32);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "الفئة";
            this.lblCategory.Click += new System.EventHandler(this.LblCategory_Click);
            // 
            // grpBudgetDetails
            // 
            this.grpBudgetDetails.Controls.Add(this.btnDeleteBudget);
            this.grpBudgetDetails.Controls.Add(this.btnSaveBudget);
            this.grpBudgetDetails.Controls.Add(this.dtpEndDate);
            this.grpBudgetDetails.Controls.Add(this.dtpStartDate);
            this.grpBudgetDetails.Controls.Add(this.txtAmount);
            this.grpBudgetDetails.Controls.Add(this.cmbCategory);
            this.grpBudgetDetails.Controls.Add(this.lblEndDate);
            this.grpBudgetDetails.Controls.Add(this.lblStartDate);
            this.grpBudgetDetails.Controls.Add(this.lblAmount);
            this.grpBudgetDetails.Controls.Add(this.lblCategory);
            this.grpBudgetDetails.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBudgetDetails.Location = new System.Drawing.Point(539, -1);
            this.grpBudgetDetails.Name = "grpBudgetDetails";
            this.grpBudgetDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpBudgetDetails.Size = new System.Drawing.Size(497, 434);
            this.grpBudgetDetails.TabIndex = 1;
            this.grpBudgetDetails.TabStop = false;
            this.grpBudgetDetails.Text = "إعداد الميزانية";
            // 
            // btnSaveBudget
            // 
            this.btnSaveBudget.BackColor = System.Drawing.Color.Blue;
            this.btnSaveBudget.ForeColor = System.Drawing.Color.White;
            this.btnSaveBudget.Location = new System.Drawing.Point(154, 369);
            this.btnSaveBudget.Name = "btnSaveBudget";
            this.btnSaveBudget.Size = new System.Drawing.Size(172, 50);
            this.btnSaveBudget.TabIndex = 8;
            this.btnSaveBudget.Text = "حفظ الميزانية";
            this.btnSaveBudget.UseVisualStyleBackColor = false;
            this.btnSaveBudget.Click += new System.EventHandler(this.BtnSaveBudget_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(6, 283);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(271, 39);
            this.dtpEndDate.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(6, 217);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(271, 39);
            this.dtpStartDate.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(6, 144);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(271, 39);
            this.txtAmount.TabIndex = 5;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(6, 78);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(271, 39);
            this.cmbCategory.TabIndex = 4;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(354, 283);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(134, 32);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "تاريخ النهاية";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(358, 217);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(130, 32);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "تاريخ البداية";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(291, 144);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(197, 32);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "الميزانية المخصصة";
            // 
            // dgvBudgets
            // 
            this.dgvBudgets.AllowUserToResizeRows = false;
            this.dgvBudgets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBudgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgets.Location = new System.Drawing.Point(12, 12);
            this.dgvBudgets.Name = "dgvBudgets";
            this.dgvBudgets.ReadOnly = true;
            this.dgvBudgets.RowTemplate.Height = 26;
            this.dgvBudgets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBudgets.Size = new System.Drawing.Size(521, 421);
            this.dgvBudgets.TabIndex = 2;
            this.dgvBudgets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBudgets_CellContentClick);
            // 
            // btnDeleteBudget
            // 
            this.btnDeleteBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteBudget.Location = new System.Drawing.Point(31, 369);
            this.btnDeleteBudget.Name = "btnDeleteBudget";
            this.btnDeleteBudget.Size = new System.Drawing.Size(106, 50);
            this.btnDeleteBudget.TabIndex = 9;
            this.btnDeleteBudget.Text = "حذف";
            this.btnDeleteBudget.UseVisualStyleBackColor = false;
            this.btnDeleteBudget.Click += new System.EventHandler(this.BtnDeleteBudget_Click);
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 445);
            this.Controls.Add(this.dgvBudgets);
            this.Controls.Add(this.grpBudgetDetails);
            this.Name = "BudgetForm";
            this.Text = "BudgetForm";
            this.Load += new System.EventHandler(this.BudgetForm_Load);
            this.grpBudgetDetails.ResumeLayout(false);
            this.grpBudgetDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox grpBudgetDetails;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSaveBudget;
        private System.Windows.Forms.DataGridView dgvBudgets;
        private System.Windows.Forms.Button btnDeleteBudget;
    }
}