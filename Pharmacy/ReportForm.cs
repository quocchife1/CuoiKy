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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnMontlySale_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.Owner is MainForm adminForm)
            {
                // Kiểm tra xem RevenueReport đã tồn tại trong panel
                foreach (Form child in adminForm.panelChildForm.Controls.OfType<Form>())
                {
                    if (child is RevenueReport revenueReport)
                    {
                        revenueReport.Show(); // Hiển thị lại RevenueReport nếu đã tồn tại
                        return;
                    }
                }

                // Nếu không tồn tại, tạo một RevenueReport mới
                var revenueReportNew = new RevenueReport
                {
                    Owner = adminForm // Đặt Admin làm Owner
                };
                adminForm.openChildFormInPanel(revenueReportNew);
            }
            else
            {
                MessageBox.Show("Không tìm thấy form Admin.");
            }

        }

        private void btnRevenueEMP_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.Owner is MainForm adminForm)
            {
                // Kiểm tra xem RevenueReport đã tồn tại trong panel
                foreach (Form child in adminForm.panelChildForm.Controls.OfType<Form>())
                {
                    if (child is revenueEMPReport report)
                    {
                        report.Show(); // Hiển thị lại RevenueReport nếu đã tồn tại
                        return;
                    }
                }

                // Nếu không tồn tại, tạo một RevenueReport mới
                var revenueReportEMP = new revenueEMPReport
                {
                    Owner = adminForm // Đặt Admin làm Owner
                };
                adminForm.openChildFormInPanel(revenueReportEMP);
            }
            else
            {
                MessageBox.Show("Không tìm thấy form Admin.");
            }
        }

        private void btnRevenueYear_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.Owner is MainForm adminForm)
            {
                // Kiểm tra xem RevenueReport đã tồn tại trong panel
                foreach (Form child in adminForm.panelChildForm.Controls.OfType<Form>())
                {
                    if (child is RevenueReportYear report)
                    {
                        report.Show(); // Hiển thị lại RevenueReport nếu đã tồn tại
                        return;
                    }
                }

                // Nếu không tồn tại, tạo một RevenueReport mới
                var revenueReportYear = new RevenueReportYear
                {
                    Owner = adminForm // Đặt Admin làm Owner
                };
                adminForm.openChildFormInPanel(revenueReportYear);
            }
            else
            {
                MessageBox.Show("Không tìm thấy form Admin.");
            }
        }
    }
}
