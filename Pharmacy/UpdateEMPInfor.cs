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
    public partial class UpdateEMPInfor : Form
    {
        public UpdateEMPInfor()
        {
            InitializeComponent();
        }

        private void UpdateEMPInfor_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            if(Login.GlobalLoggedInType == "MANAGER")
            {
                dgvUpdateInfor.DataSource = data.EMPLOYEEs.Where(p => p.EMP_STORE == Login.GlobalLoggedInStore).Select(p => new { p.EMP_ID, p.EMP_NAME, p.EMP_SEX, p.EMP_DATE_OF_BIRTH, p.EMP_TYPE, p.EMP_JOB_DATE, p.EMP_PHONE, p.EMP_MAIL, p.EMP_STORE }).OrderBy(p => p.EMP_ID);

            }
            else
            {
                dgvUpdateInfor.DataSource = data.EMPLOYEEs.Select(p => new { p.EMP_ID, p.EMP_NAME, p.EMP_SEX, p.EMP_DATE_OF_BIRTH, p.EMP_TYPE, p.EMP_JOB_DATE, p.EMP_PHONE, p.EMP_MAIL, p.EMP_STORE }).OrderBy(p => p.EMP_ID);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string sex = txtSex.Text;
            string birthday = txtBD.Text;
            string type = txtType.Text;
            string jobdate = txtJD.Text;
            string phone = txtPhone.Text;
            string mail = txtMail.Text;
            string store = txtStore.Text;

            DataBaseDataContext data = new DataBaseDataContext();
            EMPLOYEE emp = data.EMPLOYEEs.Where(p => p.EMP_ID == id).SingleOrDefault();

            if (emp == null)
            {
                MessageBox.Show("Nhân viên không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            else
            {
                data.EMPLOYEEs.DeleteOnSubmit(emp);
                data.SubmitChanges();

                loadDuLieu();

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tim1 = txtID.Text.Trim();
            string tim2 = txtName.Text.Trim();
            string tim3 = txtStore.Text.Trim();

            DataBaseDataContext data = new DataBaseDataContext();

            var query = data.EMPLOYEEs.AsQueryable();

            if (!string.IsNullOrEmpty(tim1))
            {
                query = query.Where(p => p.EMP_ID.Contains(tim1));
            }
            if (!string.IsNullOrEmpty(tim2))
            {
                query = query.Where(p => p.EMP_NAME.Contains(tim2));
            }
            if (!string.IsNullOrEmpty(tim3))
            {
                query = query.Where(p => p.EMP_STORE.Contains(tim3));
            }

            dgvUpdateInfor.DataSource = query.Select(p => new
            {
                p.EMP_ID,
                p.EMP_NAME,
                p.EMP_SEX,
                p.EMP_DATE_OF_BIRTH,
                p.EMP_TYPE,
                p.EMP_JOB_DATE,
                p.EMP_PHONE,
                p.EMP_MAIL,
                p.EMP_STORE
            }).OrderBy(p => p.EMP_ID).ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string sex = txtSex.Text;
            string birthday = txtBD.Text;
            string type = txtType.Text;
            string jobdate = txtJD.Text;
            string phone = txtPhone.Text;
            string mail = txtMail.Text;
            string store = txtStore.Text;



            DataBaseDataContext data = new DataBaseDataContext();

            EMPLOYEE emp = data.EMPLOYEEs.Where(p => p.EMP_ID == id || p.EMP_MAIL == mail).SingleOrDefault();


            if (emp != null)
            {
                MessageBox.Show("Nhân viên đã tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            else
            {
                emp = new EMPLOYEE();
                emp.EMP_ID = id;
                emp.EMP_NAME = name;
                emp.EMP_SEX = sex;
                emp.EMP_TYPE = type;
                emp.EMP_PHONE = phone;
                emp.EMP_MAIL = mail;
                emp.EMP_STORE = store;

                if (string.IsNullOrWhiteSpace(id) || !id.StartsWith("NV"))
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(phone) || phone.Length != 10 || !phone.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mail) || !mail.Contains("@gmail.com"))
                {
                    MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMail.Focus();
                    return;
                }

                DateTime tmpBirthDay;
                DateTime tmpJobDate;

                if (DateTime.TryParseExact(birthday, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out tmpBirthDay))
                {
                    emp.EMP_DATE_OF_BIRTH = tmpBirthDay;
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBD.Focus();
                    return;
                }

                if (DateTime.TryParseExact(birthday, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out tmpJobDate))
                {
                    emp.EMP_JOB_DATE = tmpJobDate;
                }
                else
                {
                    MessageBox.Show("Ngày vào làm không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtJD.Focus();
                    return;
                }

                data.EMPLOYEEs.InsertOnSubmit(emp);
                try
                {
                    data.SubmitChanges();
                    loadDuLieu();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string sex = txtSex.Text;
            string birthday = txtBD.Text;
            string type = txtType.Text;
            string jobdate = txtJD.Text;
            string phone = txtPhone.Text;
            string mail = txtMail.Text;
            string store = txtStore.Text;

            DataBaseDataContext data = new DataBaseDataContext();
            EMPLOYEE emp = data.EMPLOYEEs.Where(p => p.EMP_ID == id).SingleOrDefault();
            ACCOUNT acc = data.ACCOUNTs.Where(p => p.ID == id).SingleOrDefault();

            if (emp == null)
            {
                MessageBox.Show("Nhân viên không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            else
            {
                emp.EMP_ID = id;
                emp.EMP_NAME = name;
                emp.EMP_SEX = sex;
                emp.EMP_TYPE = type;
                acc.LEVEL = type;
                emp.EMP_PHONE = phone;
                emp.EMP_MAIL = mail;
                emp.EMP_STORE = store;

                if (string.IsNullOrWhiteSpace(id) || !id.StartsWith("NV"))
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(phone) || phone.Length != 10 || !phone.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mail) || !mail.Contains("@gmail.com"))
                {
                    MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMail.Focus();
                    return;
                }

                DateTime tmpBirthDay;
                DateTime tmpJobDate;

                if (DateTime.TryParseExact(birthday, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out tmpBirthDay))
                {
                    emp.EMP_DATE_OF_BIRTH = tmpBirthDay;
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBD.Focus();
                    return;
                }

                if (DateTime.TryParseExact(birthday, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out tmpJobDate))
                {
                    emp.EMP_JOB_DATE = tmpJobDate;
                }
                else
                {
                    MessageBox.Show("Ngày vào làm không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtJD.Focus();
                    return;
                }

                data.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvUpdateInfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            string id = dgvUpdateInfor.Rows[idrow].Cells[0].Value.ToString();
            EMPLOYEE emp = data.EMPLOYEEs.Where(p => p.EMP_ID == id).SingleOrDefault();
            if (emp != null)
            {
                txtID.Text = emp.EMP_ID;
                txtName.Text = emp.EMP_NAME;
                txtSex.Text = emp.EMP_SEX;
                txtBD.Text = emp.EMP_DATE_OF_BIRTH.ToString("dd/MM/yyyy");
                txtType.Text = emp.EMP_TYPE;
                txtJD.Text = emp.EMP_JOB_DATE.ToString("dd/MM/yyyy");
                txtPhone.Text = emp.EMP_PHONE;
                txtMail.Text = emp.EMP_MAIL;
                txtStore.Text = emp.EMP_STORE;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtSex.SelectedIndex = -1;
            txtBD.Clear();
            txtType.SelectedIndex = -1;
            txtJD.Clear();
            txtPhone.Clear();
            txtMail.Clear();
            txtStore.SelectedIndex = -1;
        }
    }
}
