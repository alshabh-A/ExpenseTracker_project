namespace ExpenseTracker.Views
{
    partial class ReportChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // chartExpenses
            // 
            chartArea2.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend2);
            this.chartExpenses.Location = new System.Drawing.Point(21, 12);
            this.chartExpenses.Name = "chartExpenses";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartExpenses.Series.Add(series2);
            this.chartExpenses.Size = new System.Drawing.Size(767, 347);
            this.chartExpenses.TabIndex = 0;
            this.chartExpenses.Text = "chart1";
            // 
            // ReportChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartExpenses);
            this.Name = "ReportChartForm";
            this.Text = "ReportChartForm";
            this.Load += new System.EventHandler(this.ReportChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
    }
}