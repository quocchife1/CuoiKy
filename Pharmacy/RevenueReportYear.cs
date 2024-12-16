using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pharmacy
{
    public partial class RevenueReportYear : Form
    {
        public RevenueReportYear()
        {
            InitializeComponent();
        }

        private void RevenueReportYear_Load(object sender, EventArgs e)
        {
            LoadChartData();
        }

        private void LoadChartData()
        {
            DataBaseDataContext data = new DataBaseDataContext();

            var years = data.SALEs
                .Select(s => s.S_DATE.Year)
                .Distinct()
                .OrderBy(y => y)
                .ToList();

            chartYear.Series.Clear();

            foreach (var year in years)
            {
                var monthlyRevenue = data.SALEs
                          .Where(s => s.S_DATE.Year == year)
                          .GroupBy(s => s.S_DATE.Month)
                          .Select(g => new { Month = g.Key, TotalRevenue = g.Sum(s => s.S_AMT) })
                          .OrderBy(m => m.Month)
                          .ToList();

                var series = new Series
                {
                    ChartType = SeriesChartType.Line,
                    Name = year.ToString(),
                    BorderWidth = 4,
                    BorderDashStyle = ChartDashStyle.Solid,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    MarkerColor = Color.Black
                };

                foreach (var revenue in monthlyRevenue)
                {
                    series.Points.AddXY(revenue.Month, revenue.TotalRevenue);
                }

                chartYear.Series.Add(series);
            }

            chartYear.ChartAreas[0].AxisX.Title = "Tháng";
            chartYear.ChartAreas[0].AxisY.Title = "Doanh thu";
            chartYear.ChartAreas[0].AxisX.Interval = 1; chartYear.Legends[0].Title = "Năm"; chartYear.Titles.Clear();
            chartYear.Titles.Add("Biểu đồ doanh thu hằng tháng theo năm");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.Owner is MainForm adminForm)
            {
                foreach (Form child in adminForm.panelChildForm.Controls.OfType<Form>())
                {
                    if (child is ReportForm reportForm)
                    {
                        reportForm.Show(); return;
                    }
                }

                adminForm.openChildFormInPanel(new ReportForm());
            }
            else
            {
                MessageBox.Show("Không tìm thấy form Admin.");
            }
        }
    }
}
