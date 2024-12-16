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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            dgvBill.DataSource = data.SALEs.Select(p => new { p.S_ID, p.S_DATE, p.S_TIME, p.C_ID, p.S_AMT, p.EMP_ID }).OrderBy(p => p.S_ID);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (dgvBill.CurrentRow != null)
            {
                try
                {
                    int s_id = Convert.ToInt32(dgvBill.CurrentRow.Cells["S_ID"].Value);
                    string c_id = dgvBill.CurrentRow.Cells["C_ID"].Value.ToString();

                    DataBaseDataContext data = new DataBaseDataContext();
                    SALE sale = data.SALEs.Where(p => p.S_ID == s_id).SingleOrDefault();

                    if (sale != null)
                    {
                        reportBillPrinter rpb = new reportBillPrinter();
                        rpb.LoggedInUserName = Login.GlobalLoggedInUserName;
                        rpb.LoggedInID = Login.GlobalLoggedInID;
                        rpb.LoggedInStore = Login.GlobalLoggedInStore;
                        rpb.SaleID = sale.S_ID;
                        rpb.CustomerID = sale.C_ID;
                        rpb.SaleDate = sale.S_DATE.ToString("dd/MM/yyyy");
                        rpb.SaleTime = sale.S_TIME.ToString();

                        EMPLOYEE emp = data.EMPLOYEEs.Where(p => p.EMP_ID == sale.EMP_ID).SingleOrDefault();
                        rpb.EMPname = emp.EMP_NAME;
                        rpb.EMPid = emp.EMP_ID;
                        rpb.EMPstore = emp.EMP_STORE;
                        rpb.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
