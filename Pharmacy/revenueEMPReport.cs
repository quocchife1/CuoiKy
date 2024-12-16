using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class revenueEMPReport : Form
    {
        public revenueEMPReport()
        {
            InitializeComponent();
        }

        private void revenueEMPReport_Load(object sender, EventArgs e)
        {
            DataBaseDataContext data = new DataBaseDataContext();
            var emp = data.SALEs.GroupBy(p => p.EMP_ID).Select(p => p.Key).ToList();

            emp.Insert(0, "Tất cả");

            txtRevenueEMP.DataSource = emp;
            txtRevenueEMP.SelectedIndex = 0;
        }

        private void UpdateChart(string id = null)
        {
            DataBaseDataContext data = new DataBaseDataContext();
            chartRevenueEMP.Series["ChartRevenueEMP"].Points.Clear();

            if(id != null)
            {
                var revenue = data.SALEs.Where(p => p.EMP_ID == id).Sum(p => p.S_AMT);
                chartRevenueEMP.Series["ChartRevenueEMP"].IsValueShownAsLabel = true;

                chartRevenueEMP.Series["ChartRevenueEMP"].Points.AddXY(id, Convert.ToDouble(revenue));

            }
            else
            {
                var allRevenue = data.SALEs.GroupBy(p => p.EMP_ID).Select(g => new { EMP_ID = g.Key, Revenue = g.Sum(p => p.S_AMT) }).ToList();
                foreach (var item in allRevenue)
                {
                    chartRevenueEMP.Series["ChartRevenueEMP"].Points.AddXY(item.EMP_ID, item.Revenue);
                }
                chartRevenueEMP.Series["ChartRevenueEMP"].IsValueShownAsLabel = false;
            }


        }

        private void txtRevenueEMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtRevenueEMP.SelectedIndex != -1)
            {
                string selectedID = txtRevenueEMP.SelectedItem.ToString();
                if (selectedID == "Tất cả")
                {
                    UpdateChart(); // Hiển thị toàn bộ doanh thu
                }
                else
                {
                    UpdateChart(selectedID); // Hiển thị doanh thu theo nhân viên
                }
            }
            else
            {
                UpdateChart();
            }
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
