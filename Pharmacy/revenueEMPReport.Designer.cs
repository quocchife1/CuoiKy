namespace Pharmacy
{
    partial class revenueEMPReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtRevenueEMP = new System.Windows.Forms.ComboBox();
            this.lblDoanhThuNV = new System.Windows.Forms.Label();
            this.chartRevenueEMP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueEMP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRevenueEMP
            // 
            this.txtRevenueEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRevenueEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtRevenueEMP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevenueEMP.ForeColor = System.Drawing.Color.Black;
            this.txtRevenueEMP.FormattingEnabled = true;
            this.txtRevenueEMP.Items.AddRange(new object[] {
            "NV01",
            "NV02",
            "NV03",
            "NV04",
            "NV05",
            "NV06",
            "NV07",
            "NV08",
            "NV09",
            "NV10",
            "NV11",
            "NV12",
            "NV13",
            "NV14",
            "NV15",
            "NV16",
            "NV17",
            "NV18",
            "NV19",
            "NV20",
            "NV21",
            "NV22",
            "NV23",
            "NV24",
            "NV25",
            "NV26",
            "NV27",
            "NV28",
            "NV29",
            "NV30"});
            this.txtRevenueEMP.Location = new System.Drawing.Point(701, 59);
            this.txtRevenueEMP.Name = "txtRevenueEMP";
            this.txtRevenueEMP.Size = new System.Drawing.Size(121, 30);
            this.txtRevenueEMP.TabIndex = 8;
            this.txtRevenueEMP.SelectedIndexChanged += new System.EventHandler(this.txtRevenueEMP_SelectedIndexChanged);
            // 
            // lblDoanhThuNV
            // 
            this.lblDoanhThuNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoanhThuNV.AutoSize = true;
            this.lblDoanhThuNV.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblDoanhThuNV.Location = new System.Drawing.Point(197, 43);
            this.lblDoanhThuNV.Name = "lblDoanhThuNV";
            this.lblDoanhThuNV.Size = new System.Drawing.Size(440, 34);
            this.lblDoanhThuNV.TabIndex = 9;
            this.lblDoanhThuNV.Text = "DOANH THU THEO NHÂN VIÊN";
            this.lblDoanhThuNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartRevenueEMP
            // 
            this.chartRevenueEMP.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea8.Name = "ChartArea1";
            this.chartRevenueEMP.ChartAreas.Add(chartArea8);
            this.chartRevenueEMP.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            this.chartRevenueEMP.Legends.Add(legend8);
            this.chartRevenueEMP.Location = new System.Drawing.Point(0, 96);
            this.chartRevenueEMP.Name = "chartRevenueEMP";
            series8.ChartArea = "ChartArea1";
            series8.IsXValueIndexed = true;
            series8.Legend = "Legend1";
            series8.LegendText = "Doanh thu";
            series8.Name = "ChartRevenueEMP";
            this.chartRevenueEMP.Series.Add(series8);
            this.chartRevenueEMP.Size = new System.Drawing.Size(834, 665);
            this.chartRevenueEMP.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 71);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 31);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // revenueEMPReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtRevenueEMP);
            this.Controls.Add(this.lblDoanhThuNV);
            this.Controls.Add(this.chartRevenueEMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "revenueEMPReport";
            this.Text = "revenueEMPReport";
            this.Load += new System.EventHandler(this.revenueEMPReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenueEMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtRevenueEMP;
        private System.Windows.Forms.Label lblDoanhThuNV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenueEMP;
        private System.Windows.Forms.Button btnBack;
    }
}