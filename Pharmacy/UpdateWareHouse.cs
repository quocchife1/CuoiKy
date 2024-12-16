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
    public partial class UpdateWareHouse : Form
    {
        public UpdateWareHouse()
        {
            InitializeComponent();
        }
        private void UpdateWareHouse_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }


        private void loadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            dgvGoodsList.DataSource = data.PURCHASEs.Select(p => new { p.P_ID, p.SUP_ID, p.MED_ID, MED_NAME = p.MEDICINE.MED_NAME, p.P_QTY, p.P_UNIT, p.P_COST, p.PUR_DATE, p.MFG_DATE, p.EXP_DATE, p.P_STATUS }).OrderBy(p => p.P_ID);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtPID.Text;
            string qty = txtQty.Text;
            string status = txtStatus.Text;
            string mfg = txtMFG.Text;
            string exp = txtEXP.Text;
            
            DataBaseDataContext data = new DataBaseDataContext();
            PURCHASE pur = data.PURCHASEs.Where(p => p.P_ID == id).SingleOrDefault();

            if (pur == null) 
            {
                MessageBox.Show("Đơn nhập hàng không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPID.Focus();
                return;
            }
            else
            {
                pur.P_STATUS = txtStatus.Text;
                pur.MFG_DATE = DateTime.Parse(txtMFG.Text.ToString());
                pur.EXP_DATE = DateTime .Parse(txtEXP.Text.ToString());

                int tmpQty;
                DateTime tmpEXP;
                DateTime tmpMFG;

                if(int.TryParse(qty, out tmpQty))
                {
                    pur.P_QTY = tmpQty;
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty.Focus();
                    return;
                }
                if(DateTime.TryParse(mfg, out tmpMFG))
                {
                    pur.MFG_DATE = tmpMFG;
                }
                else
                {
                    MessageBox.Show("Ngày sản xuất không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMFG.Focus();
                    return;
                }

                if (DateTime.TryParse(exp, out tmpEXP))
                {
                    pur.EXP_DATE = tmpEXP;
                }
                else
                {
                    MessageBox.Show("Hạn sử dụng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMFG.Focus();
                    return;
                }

                data.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtPID.Text;

            DataBaseDataContext data = new DataBaseDataContext();
            PURCHASE pur = data.PURCHASEs.Where(p => p.P_ID == id).SingleOrDefault();
            if (pur == null) 
            {
                MessageBox.Show("Đơn nhập hàng không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPID.Focus();
                return;
            }
            else
            {
                data.PURCHASEs.DeleteOnSubmit(pur);
                data.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPID.Clear();
            txtSupID.SelectedIndex = -1;
            txtMID.Clear(); 
            txtQty.Clear(); 
            txtStatus.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGoodsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow == -1)
            {
                return;
            }

            rowDisplay(idrow);
        }

        private void rowDisplay(int idrow)
        {
            DataBaseDataContext data = new DataBaseDataContext();
            string id = dgvGoodsList.Rows[idrow].Cells[0].Value.ToString();
            PURCHASE pur = data.PURCHASEs.Where(p => p.P_ID == id).SingleOrDefault();
            if (pur != null)    
            {
                txtPID.Text = pur.P_ID;
                txtSupID.Text = pur.SUP_ID;
                txtMID.Text = pur.MED_ID;
                txtQty.Text = pur.P_QTY.ToString();
                txtStatus.Text = pur.P_STATUS;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tim1 = txtPID.Text.Trim();
            string tim2 = txtSupID.Text.Trim();
            string tim3 = txtMID.Text.Trim();
            string tim4 = txtStatus.Text.Trim();

            DataBaseDataContext data = new DataBaseDataContext();

            // Lấy dữ liệu ban đầu
            var query = data.PURCHASEs.AsQueryable();

            // Áp dụng các điều kiện tìm kiếm
            if (!string.IsNullOrEmpty(tim1))
            {
                query = query.Where(p => p.P_ID.Contains(tim1));
            }
            if (!string.IsNullOrEmpty(tim2))
            {
                query = query.Where(p => p.SUP_ID.Contains(tim2));
            }
            if (!string.IsNullOrEmpty(tim3))
            {
                query = query.Where(p => p.MED_ID.Contains(tim3));
            }
            if (!string.IsNullOrEmpty(tim4))
            {
                query = query.Where(p => p.P_STATUS.Contains(tim4));
            }

            // Đổ dữ liệu tìm kiếm vào DataGridView
            dgvGoodsList.DataSource = query.Select(p => new
            {
                p.P_ID,
                p.SUP_ID,
                p.MED_ID,
                MED_NAME = p.MEDICINE.MED_NAME,
                p.P_QTY,
                p.P_UNIT,
                p.P_COST,
                p.PUR_DATE,
                p.MFG_DATE,
                p.EXP_DATE,
                p.P_STATUS
            }).OrderBy(p => p.P_ID).ToList();
        }
    }
}
