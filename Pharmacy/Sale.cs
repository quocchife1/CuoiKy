using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharmacy
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            LoadMedicines();
            loadBill();
        }

        private void loadBill()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            var bills = data.BILLs.Select(b => new
            {
                b.B_MED_NAME,
                b.B_MED_QTY,
                b.B_MED_PRICE,
                b.B_MED_TOTAL
            }).ToList();

            dgvBill.DataSource = bills;
        }

        private void LoadMedicines()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            dgvMED.DataSource = data.MEDICINEs.OrderBy(p => p.MED_ID);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy tên thuốc (B_MED_NAME) từ dòng đang chọn
            string medName = dgvBill.SelectedRows[0].Cells["B_MED_NAME"].Value.ToString();

            DataBaseDataContext data = new DataBaseDataContext();

            // Tìm hóa đơn chi tiết (BILL) tương ứng
            BILL billToDelete = data.BILLs.Where(b => b.B_MED_NAME == medName).SingleOrDefault();

            if (billToDelete != null)
            {
                // Trả lại số lượng thuốc đã xóa từ hóa đơn vào kho
                MEDICINE medicine = data.MEDICINEs.Where(m => m.MED_NAME == medName).SingleOrDefault();
                if (medicine != null)
                {
                    medicine.MED_QTY += billToDelete.B_MED_QTY ?? 0;
                }

                // Xóa dòng từ bảng BILL
                data.BILLs.DeleteOnSubmit(billToDelete);

                // Lưu thay đổi vào cơ sở dữ liệu
                data.SubmitChanges();

                // Tải lại bảng BILL và cập nhật tổng tiền
                loadBill();
                UpdateTotal();

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            using (DataBaseDataContext data = new DataBaseDataContext())
            {
                // Lấy danh sách sản phẩm trong BILL
                var billItems = data.BILLs.ToList();

                // Kiểm tra nếu BILL trống
                if (!billItems.Any())
                {
                    MessageBox.Show("Không có sản phẩm nào trong hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra số lượng trong kho
                foreach (var item in billItems)
                {
                    var medicine = data.MEDICINEs.SingleOrDefault(m => m.MED_NAME == item.B_MED_NAME);
                    if (medicine == null || medicine.MED_QTY < item.B_MED_QTY)
                    {
                        MessageBox.Show($"Sản phẩm {item.B_MED_NAME} không đủ hàng trong kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Kiểm tra khách hàng
                if (string.IsNullOrWhiteSpace(txtCusID.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo S_ID mới
                int newSaleID = data.SALEs.Any() ? data.SALEs.Max(s => s.S_ID) + 1 : 1;

                // Lấy thông tin từ giao diện
                string customerID = txtCusID.Text;
                decimal totalAmount = decimal.Parse(txtTotal.Text);
                DateTime saleDate = DateTime.Now;
                TimeSpan saleTime = DateTime.Now.TimeOfDay;

                // Tạo bản ghi mới trong SALES
                SALE newSale = new SALE
                {
                    S_ID = newSaleID,
                    S_DATE = DateTime.Now.Date, // Ngày hiện tại
                    S_TIME = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss")),
                    C_ID = customerID,
                    S_AMT = totalAmount,
                    EMP_ID = Login.GlobalLoggedInID // Biến public EMP_ID
                };
                data.SALEs.InsertOnSubmit(newSale);

                // Thêm từng sản phẩm vào SALES_ITEMS và cập nhật MEDICINES
                foreach (var item in billItems)
                {
                    var medicine = data.MEDICINEs.Single(m => m.MED_NAME == item.B_MED_NAME);

                    // Thêm vào SALES_ITEMS
                    SALES_ITEM newSaleItem = new SALES_ITEM
                    {
                        S_ID = newSaleID,
                        MED_NAME = item.B_MED_NAME,
                        ST_QTY = item.B_MED_QTY.Value,
                        ST_UNIT = medicine.MED_UNIT,
                        TOTAL_PRICE = item.B_MED_TOTAL.Value
                    };
                    data.SALES_ITEMs.InsertOnSubmit(newSaleItem);

                    // Cập nhật số lượng trong kho
                    medicine.MED_QTY -= item.B_MED_QTY.Value;

                    if (medicine.MED_QTY == 0)
                    {
                        medicine.MED_STATUS = "Hết hàng"; // Cập nhật trạng thái thành "Hết hàng"
                    }
                }

                // Xóa hóa đơn hiện tại
                data.BILLs.DeleteAllOnSubmit(billItems);

                // Lưu thay đổi vào cơ sở dữ liệu
                data.SubmitChanges();

                // Hiển thị thông báo thành công
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật giao diện
                dgvMED.DataSource = data.MEDICINEs.OrderBy(p => p.MED_ID).ToList();
                dgvBill.DataSource = null;
                txtCusID.Clear();
                txtTotal.Clear();
            }
        }

        private void dgvMED_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            string id = dgvMED.Rows[idrow].Cells[1].Value.ToString();
            MEDICINE med = data.MEDICINEs.Where(p => p.MED_ID == id).SingleOrDefault();
            if (med != null)
            {
                txtMEid.Text = med.MED_ID;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu các ô không trống
            if (string.IsNullOrWhiteSpace(txtMEid.Text) || string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã thuốc và Số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string medId = txtMEid.Text.Trim();
            int qty;

            // Kiểm tra nếu số lượng nhập vào là số hợp lệ
            if (!int.TryParse(txtQty.Text.Trim(), out qty) || qty <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
                return;
            }

            DataBaseDataContext data = new DataBaseDataContext();

            // Lấy thông tin thuốc dựa vào MED_ID
            MEDICINE medicine = data.MEDICINEs.Where(m => m.MED_ID == medId).SingleOrDefault();

            if (medicine == null)
            {
                MessageBox.Show("Không tìm thấy thuốc có mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMEid.Focus();
                return;
            }

            // Kiểm tra số lượng tồn kho
            if (medicine.MED_QTY < qty)
            {
                MessageBox.Show($"Số lượng tồn kho không đủ! Hiện tại chỉ còn {medicine.MED_QTY}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
                return;
            }

            // Tính toán giá trị cần thêm
            string medName = medicine.MED_NAME;
            decimal price = medicine.MED_PRICE;
            decimal total = qty * price;

            // Kiểm tra nếu thuốc đã tồn tại trong bảng BILL
            BILL existingBill = data.BILLs.Where(b => b.B_MED_NAME == medName).SingleOrDefault();
            if (existingBill != null)
            {
                // Nếu thuốc đã có, cập nhật số lượng và tổng giá trị
                existingBill.B_MED_QTY += qty;
                existingBill.B_MED_TOTAL += total;
            }
            else
            {
                // Nếu thuốc chưa có, thêm mới vào bảng BILL
                BILL newBill = new BILL
                {
                    B_MED_NAME = medName,
                    B_MED_QTY = qty,
                    B_MED_PRICE = price,
                    B_MED_TOTAL = total
                };

                data.BILLs.InsertOnSubmit(newBill);
            }

            // Lưu thay đổi
            data.SubmitChanges();

            // Tải lại bảng BILL
            loadBill();

            // Cập nhật tổng giá trị hóa đơn vào txtTotal
            UpdateTotal();

            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void UpdateTotal()
        {
            DataBaseDataContext data = new DataBaseDataContext();

            decimal? total = data.BILLs.Sum(b => b.B_MED_TOTAL);

            // Gán giá trị cho txtTotal
            txtTotal.Text = total.HasValue ? total.Value.ToString("N2") : "0.00";
        }
    }
}
