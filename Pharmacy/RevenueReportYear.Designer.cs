namespace Pharmacy
{
    partial class RevenueReportYear
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDoanhThuYear = new System.Windows.Forms.Label();
            this.chartYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 81);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 31);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDoanhThuYear
            // 
            this.lblDoanhThuYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoanhThuYear.AutoSize = true;
            this.lblDoanhThuYear.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblDoanhThuYear.Location = new System.Drawing.Point(253, 43);
            this.lblDoanhThuYear.Name = "lblDoanhThuYear";
            this.lblDoanhThuYear.Size = new System.Drawing.Size(329, 34);
            this.lblDoanhThuYear.TabIndex = 14;
            this.lblDoanhThuYear.Text = "DOANH THU CÁC NĂM";
            this.lblDoanhThuYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartYear
            // 
            this.chartYear.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.chartYear.ChartAreas.Add(chartArea3);
            this.chartYear.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartYear.Legends.Add(legend3);
            this.chartYear.Location = new System.Drawing.Point(0, 96);
            this.chartYear.Name = "chartYear";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.LegendText = "Doanh thu";
            series3.Name = "ChartYear";
            this.chartYear.Series.Add(series3);
            this.chartYear.Size = new System.Drawing.Size(834, 665);
            this.chartYear.TabIndex = 12;
            // 
            // RevenueReportYear
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDoanhThuYear);
            this.Controls.Add(this.chartYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevenueReportYear";
            this.Text = "RevenueReportYear";
            this.Load += new System.EventHandler(this.RevenueReportYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDoanhThuYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYear;
    }
}