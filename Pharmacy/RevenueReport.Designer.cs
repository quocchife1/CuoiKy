namespace Pharmacy
{
    partial class RevenueReport
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
            this.chartMonthlySale = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlySale)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMonthlySale
            // 
            this.chartMonthlySale.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.chartMonthlySale.ChartAreas.Add(chartArea3);
            this.chartMonthlySale.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartMonthlySale.Legends.Add(legend3);
            this.chartMonthlySale.Location = new System.Drawing.Point(0, 96);
            this.chartMonthlySale.Name = "chartMonthlySale";
            series3.ChartArea = "ChartArea1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.LegendText = "Doanh thu";
            series3.Name = "ChartMonthlySale";
            this.chartMonthlySale.Series.Add(series3);
            this.chartMonthlySale.Size = new System.Drawing.Size(834, 665);
            this.chartMonthlySale.TabIndex = 0;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblDoanhThu.Location = new System.Drawing.Point(225, 43);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(385, 34);
            this.lblDoanhThu.TabIndex = 6;
            this.lblDoanhThu.Text = "DOANH THU THEO THÁNG";
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYear
            // 
            this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtYear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.FormattingEnabled = true;
            this.txtYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.txtYear.Location = new System.Drawing.Point(701, 81);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 30);
            this.txtYear.TabIndex = 1;
            this.txtYear.SelectedIndexChanged += new System.EventHandler(this.txtYear_SelectedIndexChanged);
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
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RevenueReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.chartMonthlySale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevenueReport";
            this.Text = "AllReport";
            this.Load += new System.EventHandler(this.AllReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlySale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlySale;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.ComboBox txtYear;
        private System.Windows.Forms.Button btnBack;
    }
}