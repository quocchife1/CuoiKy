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
    public partial class PharmacistList : Form
    {
        public PharmacistList()
        {
            InitializeComponent();
        }

        private void PharmacistList_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            CauHinhAutoComplete();
        }

        private void loadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            dgvPharmacistList.DataSource = data.EMPLOYEEs.Where(p => p.EMP_TYPE == "PHARMACIST").Select(p => new {p.EMP_ID, p.EMP_NAME, p.EMP_SEX, p.EMP_DATE_OF_BIRTH, p.EMP_TYPE, p.EMP_JOB_DATE, p.EMP_PHONE, p.EMP_MAIL, p.SUP_ADD}).OrderBy(p => p.EMP_ID);
        }

        private void CauHinhAutoComplete()
        {
            // Thiết lập chế độ AutoComplete cho TextBox
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest; // Hiển thị danh sách gợi ý
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource; // Sử dụng nguồn tùy chỉnh

            // Gắn sự kiện TextChanged để cập nhật danh sách gợi ý
            txtSearch.TextChanged += TxtTimKiem_TextChanged;
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Lấy từ khóa từ TextBox
            string tuKhoa = txtSearch.Text;

            // Kiểm tra nếu từ khóa rỗng, xóa dữ liệu hiển thị
            if (string.IsNullOrEmpty(tuKhoa))
            {
                dgvPharmacistList.DataSource = null;
                txtSearch.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                return;
            }

            // Kết nối cơ sở dữ liệu và truy vấn
            using (var dataContext = new DataBaseDataContext())
            {
                // Lọc danh sách nhân viên theo từ khóa
                var ketQua = dataContext.EMPLOYEEs
                    .Where(emp =>
                        emp.EMP_ID.Contains(tuKhoa) ||
                        emp.EMP_NAME.Contains(tuKhoa) ||
                        emp.EMP_SEX.Contains(tuKhoa) ||
                        emp.EMP_DATE_OF_BIRTH.ToString().Contains(tuKhoa) ||
                        emp.EMP_TYPE.Contains(tuKhoa) ||
                        emp.EMP_JOB_DATE.ToString().Contains(tuKhoa) ||
                        emp.EMP_PHONE.Contains(tuKhoa) ||
                        (emp.EMP_MAIL != null && emp.EMP_MAIL.Contains(tuKhoa)) ||
                        emp.SUP_ADD.Contains(tuKhoa)
                    )
                    .ToList();

                // **Cập nhật DataGridView**
                dgvPharmacistList.DataSource = ketQua;

                // **Cập nhật AutoComplete**
                var danhSachGoiY = ketQua.Select(emp => emp.EMP_NAME).Distinct().ToArray();
                var nguonGoiY = new AutoCompleteStringCollection();
                nguonGoiY.AddRange(danhSachGoiY);
                txtSearch.AutoCompleteCustomSource = nguonGoiY;
            }
        }
    }
}
