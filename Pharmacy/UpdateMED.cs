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
    public partial class UpdateMED : Form
    {
        public UpdateMED()
        {
            InitializeComponent();
        }
        private void UpdateMED_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            checkPermission();
        }

        private void checkPermission()
        {
            if (Login.GlobalLoggedInType == "PHARMACIST")
            {
                btnAdd.Enabled = btnDel.Enabled = btnUpdate.Enabled = false;
            }


        }
        private void loadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            dgvUpdateInforMED.DataSource = data.MEDICINEs.OrderBy(p => p.MED_ID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string barcode = txtBarCode.Text;
            string id = txtID.Text;
            string name = txtName.Text;
            string qty = txtQty.Text;
            string unit = txtUnit.Text;
            string category = txtCategory.Text;
            string price = txtPrice.Text;
            string status = txtStatus.Text;

            DataBaseDataContext data = new DataBaseDataContext();

            MEDICINE med = data.MEDICINEs.Where(p => p.MED_ID == id || p.MED_BARCODE == barcode).SingleOrDefault();

            if (med != null)
            {
                MessageBox.Show("Thuốc đã tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarCode.Focus();
                return;
            }
            else
            {
                med = new MEDICINE();
                med.MED_BARCODE = barcode;
                med.MED_ID = id;
                med.MED_NAME = name;
                med.MED_UNIT = unit;
                med.MED_CATEGORY = category;
                med.MED_STATUS = status;

                decimal tmpPrice;
                int tmpQty;

                if (int.TryParse(qty, out tmpQty))
                {
                    if (tmpQty < 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUnit.Focus();
                        return;
                    }
                    else
                    {
                        med.MED_QTY = tmpQty;
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUnit.Focus();
                    return;
                }

                if (decimal.TryParse(price, out tmpPrice))
                {
                    if (tmpPrice < 0)
                    {
                        MessageBox.Show("Đơn giá không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrice.Focus();
                        return;
                    }
                    else
                    {
                        med.MED_PRICE = tmpPrice;
                    }
                }
                else
                {
                    MessageBox.Show("Đơn giá không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(barcode) || barcode.Length != 13)
                {
                    MessageBox.Show("Barcode phải có độ dài 13 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarCode.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(id) || id.Length > 6)
                {
                    MessageBox.Show("ID thuốc phải có tối đa 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Tên thuốc không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(unit))
                {
                    MessageBox.Show("Đơn vị không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUnit.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(status))
                {
                    MessageBox.Show("Trạng thái không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStatus.Focus();
                    return;
                }

                data.MEDICINEs.InsertOnSubmit(med);
                try
                {
                    data.SubmitChanges();
                    loadDuLieu();
                    MessageBox.Show("Thêm thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBarCode.Clear();
            txtID.Clear();
            txtName.Clear();
            txtQty.Clear();
            txtUnit.SelectedIndex = -1;
            txtCategory.SelectedIndex = -1;
            txtPrice.Clear();
            txtStatus.SelectedIndex = -1;
        }

        private void dgvUpdateInforMED_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            string id = dgvUpdateInforMED.Rows[idrow].Cells[1].Value.ToString();
            MEDICINE med = data.MEDICINEs.Where(p => p.MED_ID == id).SingleOrDefault();
            if (med != null)
            {
                txtBarCode.Text = med.MED_BARCODE;
                txtID.Text = med.MED_ID;
                txtName.Text = med.MED_NAME;
                txtQty.Text = med.MED_QTY.ToString();
                txtUnit.Text = med.MED_UNIT;
                txtCategory.Text = med.MED_CATEGORY;
                txtPrice.Text = med.MED_PRICE.ToString();
                txtStatus.Text = med.MED_STATUS;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string barcode = txtBarCode.Text;
            string id = txtID.Text;
            string name = txtName.Text;
            string qty = txtQty.Text;
            string unit = txtUnit.Text;
            string category = txtCategory.Text;
            string price = txtPrice.Text;
            string status = txtStatus.Text;

            DataBaseDataContext data = new DataBaseDataContext();

            MEDICINE med = data.MEDICINEs.Where(p => p.MED_ID == id || p.MED_BARCODE == barcode).SingleOrDefault();

            if (med == null)
            {
                MessageBox.Show("Thuốc không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarCode.Focus();
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(barcode) && string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Không được để trống barcode hoặc id.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarCode.Focus();
                    return;
                }

                data.MEDICINEs.DeleteOnSubmit(med);
                data.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string barcode = txtBarCode.Text;
            string id = txtID.Text;
            string name = txtName.Text;
            string qty = txtQty.Text;
            string unit = txtUnit.Text;
            string category = txtCategory.Text;
            string price = txtPrice.Text;
            string status = txtStatus.Text;

            DataBaseDataContext data = new DataBaseDataContext();

            MEDICINE med = data.MEDICINEs.Where(p => p.MED_ID == id || p.MED_BARCODE == barcode).SingleOrDefault();

            if (med == null)
            {
                MessageBox.Show("Thuốc không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarCode.Focus();
                return;
            }
            else
            {
                med.MED_BARCODE = barcode;
                med.MED_ID = id;
                med.MED_NAME = name;
                med.MED_UNIT = unit;
                med.MED_CATEGORY = category;
                med.MED_STATUS = status;

                decimal tmpPrice;
                int tmpQty;

                if (int.TryParse(qty, out tmpQty))
                {
                    if (tmpQty < 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUnit.Focus();
                        return;
                    }
                    else
                    {
                        med.MED_QTY = tmpQty;
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUnit.Focus();
                    return;
                }

                if (decimal.TryParse(price, out tmpPrice))
                {
                    if (tmpPrice < 0)
                    {
                        MessageBox.Show("Đơn giá không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrice.Focus();
                        return;
                    }
                    else
                    {
                        med.MED_PRICE = tmpPrice;
                    }
                }
                else
                {
                    MessageBox.Show("Đơn giá không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(barcode) || barcode.Length != 13)
                {
                    MessageBox.Show("Barcode phải có độ dài 13 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarCode.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(id) || id.Length > 6)
                {
                    MessageBox.Show("ID thuốc phải có tối đa 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Tên thuốc không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(unit))
                {
                    MessageBox.Show("Đơn vị không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUnit.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(status))
                {
                    MessageBox.Show("Trạng thái không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStatus.Focus();
                    return;
                }

                data.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tim = txtID.Text;
            DataBaseDataContext data = new DataBaseDataContext();
            if(tim == "")
            {
                loadDuLieu();
            }
            else
            {
                dgvUpdateInforMED.DataSource = data.MEDICINEs.Where(p => p.MED_ID == tim).ToList();
            }
        }
    }
}
