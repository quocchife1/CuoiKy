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
    public partial class OrderApproval : Form
    {
        public OrderApproval()
        {
            InitializeComponent();
            checkPermission();
        }

        private void OrderApproval_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            
        }

        private void checkPermission()
        {
            if (Login.GlobalLoggedInType == "MANAGER")
            {
                btnReject.Enabled = btnDel.Enabled = false;
            }

        }

        private void loadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            dgvUpdateReqInfor.DataSource = data.MED_REQs.OrderBy(p => p.MED_REQ_STATUS);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string unit = txtUnit.Text;
            string qty = txtQty.Text;
            string cost = txtCost.Text;
            string supid = txtSupID.Text;

            DataBaseDataContext data = new DataBaseDataContext();

            PURCHASE pur = new PURCHASE();
            string lastID = data.PURCHASEs.Max(p => p.P_ID);
            int createNewID = int.Parse(lastID) + 1;
            string newID = createNewID.ToString();
            pur.P_ID = newID;
            pur.SUP_ID = supid;
            pur.MED_ID = id;
            MEDICINE med = data.MEDICINEs.SingleOrDefault(m => m.MED_ID == id);
            pur.P_QTY = int.Parse(qty);
            pur.P_UNIT = unit;
            pur.P_COST = decimal.Parse(cost);
            
            pur.PUR_DATE = DateTime.Now;
            pur.MFG_DATE = null;
            pur.EXP_DATE = null;
            pur.P_STATUS = "Chưa giao";

            

            MED_REQ req = new MED_REQ();
            req.MED_ID = id;
            req.MED_NAME = med.MED_NAME;
            req.MED_UNIT = unit;
            req.MED_QTY = int.Parse(qty);
            req.MED_REQ_P = int.Parse(cost);
            req.SUP_ID = supid;
            req.MED_REQ_D = DateTime.Now;
            if (Login.GlobalLoggedInType == "MANAGER")
            {
                req.MED_REQ_STATUS = "Chưa duyệt";

            }
            else
            {
                if(Login.GlobalLoggedInType == "ADMIN")
                {
                    req.MED_REQ_STATUS = "Đã duyệt";
                }
            }
            if(req.MED_REQ_STATUS == "Đã duyệt")
            {
                data.PURCHASEs.InsertOnSubmit(pur);
            }
            data.MED_REQs.InsertOnSubmit(req);

            
            try
            {
                data.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Duyệt đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Duyệt đơn không thành công:  {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUpdateReqInfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            string id = dgvUpdateReqInfor.Rows[idrow].Cells[0].Value.ToString();
            MED_REQ req = data.MED_REQs.Where(p => p.MED_ID == id).SingleOrDefault();
            if (req != null) 
            {
                txtID.Text  = req.MED_ID.ToString();
                txtName.Text = req.MED_NAME;
                txtUnit.Text = req.MED_UNIT;
                txtQty.Text = req.MED_QTY.ToString();
                txtCost.Text = req.MED_REQ_P.ToString();
                txtSupID.Text = req.SUP_ID;
                txtDate.Text = req.MED_REQ_D.ToString("dd/MM/yyyy");
                txtStatus.Text = req.MED_REQ_STATUS;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtUnit.SelectedIndex = -1;
            txtQty.Clear();
            txtCost.Clear();
            txtSupID.SelectedIndex = -1;
            txtDate.Clear();
            txtStatus.SelectedIndex = -1;
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            MED_REQ req = new MED_REQ();
            req.MED_REQ_STATUS = "Từ chối";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
