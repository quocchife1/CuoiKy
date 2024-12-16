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
    public partial class RevenueReport : Form
    {
        public RevenueReport()
        {
            InitializeComponent();
        }

        private void AllReport_Load(object sender, EventArgs e)
        {
            if(txtYear.SelectedItem == null && txtYear.Items.Count > 0)
            {
                txtYear.SelectedIndex = 0;
            }

            loadChart();
        }

        private void txtYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadChart();
        }

        private void loadChart()
        {
            if(txtYear.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một năm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedYear = txtYear.SelectedItem.ToString();
            DataBaseDataContext data = new DataBaseDataContext();

            var monthlySale = data.SALEs.Where(s => s.S_DATE.Year == int.Parse(selectedYear)).GroupBy(s => s.S_DATE.Month).Select(p => new {
                                                                                                                                 Month = p.Key,
                                                                                                                                 total = p.Sum(x => x.S_AMT)
                                                                                                                                 }).OrderBy(m => m.Month).ToList();
            chartMonthlySale.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                Name = "Doanh thu"
            };
            chartMonthlySale.Series.Add(series);
            foreach (var sale in monthlySale)
            {
                series.Points.AddXY(sale.Month, sale.total);
            }
            chartMonthlySale.ChartAreas[0].AxisX.Title = "Tháng";
            chartMonthlySale.ChartAreas[0].AxisY.Title = "Tổng doanh thu";
            chartMonthlySale.ChartAreas[0].AxisX.Interval = 1;
            chartMonthlySale.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.Owner is MainForm adminForm)
            {
                // Kiểm tra xem ReportForm đã tồn tại chưa
                foreach (Form child in adminForm.panelChildForm.Controls.OfType<Form>())
                {
                    if (child is ReportForm reportForm)
                    {
                        reportForm.Show(); // Hiển thị lại ReportForm nếu đã tồn tại
                        return;
                    }
                }

                // Nếu không tồn tại, tạo một ReportForm mới
                adminForm.openChildFormInPanel(new ReportForm());
            }
            else
            {
                MessageBox.Show("Không tìm thấy form Admin.");
            }
        }
    }
}