namespace ExpenseTracker
{
    partial class MainForm
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
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnCategorySetup = new System.Windows.Forms.Button();
            this.btnBudgetSetup = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAddExpense = new System.Windows.Forms.TabPage();
            this.tabPageBudget = new System.Windows.Forms.TabPage();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddExpense.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.Location = new System.Drawing.Point(68, 110);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(240, 48);
            this.btnAddExpense.TabIndex = 0;
            this.btnAddExpense.Text = "➕ إضافة نفقة";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.BtnAddExpense_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnViewReports);
            this.groupBox1.Controls.Add(this.btnCategorySetup);
            this.groupBox1.Controls.Add(this.btnBudgetSetup);
            this.groupBox1.Controls.Add(this.lblWelcome);
            this.groupBox1.Controls.Add(this.btnAddExpense);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1172, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(335, 515);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصفحة الرئيسية";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(68, 394);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240, 42);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "🚪 تسجيل الخروج";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewReports.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReports.Location = new System.Drawing.Point(68, 313);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(240, 42);
            this.btnViewReports.TabIndex = 4;
            this.btnViewReports.Text = "📊 التقارير";
            this.btnViewReports.UseVisualStyleBackColor = false;
            this.btnViewReports.Click += new System.EventHandler(this.BtnViewReports_Click);
            // 
            // btnCategorySetup
            // 
            this.btnCategorySetup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategorySetup.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorySetup.Location = new System.Drawing.Point(68, 247);
            this.btnCategorySetup.Name = "btnCategorySetup";
            this.btnCategorySetup.Size = new System.Drawing.Size(240, 44);
            this.btnCategorySetup.TabIndex = 3;
            this.btnCategorySetup.Text = "أعداد الفئات";
            this.btnCategorySetup.UseVisualStyleBackColor = false;
            this.btnCategorySetup.Click += new System.EventHandler(this.BtnCategorySetup_Click);
            // 
            // btnBudgetSetup
            // 
            this.btnBudgetSetup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBudgetSetup.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudgetSetup.Location = new System.Drawing.Point(68, 186);
            this.btnBudgetSetup.Name = "btnBudgetSetup";
            this.btnBudgetSetup.Size = new System.Drawing.Size(240, 43);
            this.btnBudgetSetup.TabIndex = 2;
            this.btnBudgetSetup.Text = "💰 إعداد الميزانية";
            this.btnBudgetSetup.UseVisualStyleBackColor = false;
            this.btnBudgetSetup.Click += new System.EventHandler(this.BtnBudgetSetup_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(68, 53);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(99, 32);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "مرحباً بك";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageAddExpense);
            this.tabControlMain.Controls.Add(this.tabPageBudget);
            this.tabControlMain.Controls.Add(this.tabPageReports);
            this.tabControlMain.Controls.Add(this.tabPageCategories);
            this.tabControlMain.Location = new System.Drawing.Point(2, -2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1171, 551);
            this.tabControlMain.TabIndex = 2;
            this.tabControlMain.Tag = "";
            // 
            // tabPageAddExpense
            // 
            this.tabPageAddExpense.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddExpense.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddExpense.Name = "tabPageAddExpense";
            this.tabPageAddExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddExpense.Size = new System.Drawing.Size(1163, 522);
            this.tabPageAddExpense.TabIndex = 0;
            this.tabPageAddExpense.Text = "اضافة نفقة";
            this.tabPageAddExpense.UseVisualStyleBackColor = true;
            this.tabPageAddExpense.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // tabPageBudget
            // 
            this.tabPageBudget.Location = new System.Drawing.Point(4, 25);
            this.tabPageBudget.Name = "tabPageBudget";
            this.tabPageBudget.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBudget.Size = new System.Drawing.Size(1397, 520);
            this.tabPageBudget.TabIndex = 1;
            this.tabPageBudget.Text = "اعداد الميزانية";
            this.tabPageBudget.UseVisualStyleBackColor = true;
            this.tabPageBudget.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // tabPageReports
            // 
            this.tabPageReports.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(1397, 520);
            this.tabPageReports.TabIndex = 2;
            this.tabPageReports.Text = "التقارير";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Location = new System.Drawing.Point(4, 25);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategories.Size = new System.Drawing.Size(1397, 520);
            this.tabPageCategories.TabIndex = 3;
            this.tabPageCategories.Text = "الفئات";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnCategorySetup;
        private System.Windows.Forms.Button btnBudgetSetup;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAddExpense;
        private System.Windows.Forms.TabPage tabPageBudget;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.TabPage tabPageCategories;
    }
}

