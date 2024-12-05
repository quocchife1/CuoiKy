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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string type = "";
            string id = txtEMP_ID.Text;
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            string confirmPass = txtConfirmpPassWord.Text;
            
            if (rbtnManager.Checked)
            {
                type = "MANAGER";
                DataBaseDataContext data = new DataBaseDataContext();

                bool isEMPExist = data.EMPLOYEEs.Any(p => p.EMP_ID == id);
                bool isManager = data.EMPLOYEEs.Any(m => m.EMP_ID == id && m.EMP_TYPE == type);

                if (!isEMPExist)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEMP_ID.Focus();
                    return;
                }

                if (!isManager)
                {
                    MessageBox.Show("Bạn không phải là quản lý !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ADMIN ad = data.ADMINs.Where(p => p.A_ID == id).SingleOrDefault();

                if (ad != null)  
                { 
                    MessageBox.Show("Nhân viên đã có tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEMP_ID.Focus();
                    return;
                }
                else
                {
                    ADMIN ad_user = data.ADMINs.Where(p => p.A_USERNAME == userName).SingleOrDefault();
                    if (ad_user != null)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                    }
                    else
                    {
                        if (passWord != confirmPass)
                        {
                            MessageBox.Show("Mật khẩu không khớp !", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtConfirmpPassWord.Focus();
                        }
                        else
                        {
                            ad = new ADMIN();
                            ad.A_ID = id;
                            ad.A_USERNAME = userName;
                            ad.A_PASSWORD = passWord;
                            data.ADMINs.InsertOnSubmit(ad);
                            data.SubmitChanges();

                            LoadDuLieu();
                            MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            if(rbtnEMP.Checked)
            {
                type = "PHARMACIST";
                DataBaseDataContext data = new DataBaseDataContext();

                bool isEMPExist = data.EMPLOYEEs.Any(p => p.EMP_ID == id);
                bool isPHARMACIST = data.EMPLOYEEs.Any(m => m.EMP_ID == id && m.EMP_TYPE == type);

                if (!isEMPExist)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEMP_ID.Focus();
                    return;
                }

                if (!isPHARMACIST)
                {
                    MessageBox.Show("Bạn không phải là nhân viên !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EMPACCOUNT emp = data.EMPACCOUNTs.Where(p => p.EMPAC_ID == id).SingleOrDefault();

                if (emp != null)
                {
                    MessageBox.Show("Nhân viên đã có tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEMP_ID.Focus();
                    return;
                }
                else
                {
                    EMPACCOUNT emp_user = data.EMPACCOUNTs.Where(p => p.EMPAC_USERNAME == userName).SingleOrDefault();
                    if (emp_user != null)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                    }
                    else
                    {
                        if (passWord != confirmPass)
                        {
                            MessageBox.Show("Mật khẩu không khớp !", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtConfirmpPassWord.Focus();
                        }
                        else
                        {
                            emp = new EMPACCOUNT();
                            emp.EMPAC_ID = id;
                            emp.EMPAC_USERNAME = userName;
                            emp.EMPAC_PASSWORD = passWord;
                            data.EMPACCOUNTs.InsertOnSubmit(emp);
                            data.SubmitChanges();

                            LoadDuLieu();
                            MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtConfirmpPassWord.PasswordChar == '•')
            {
                btnHide.BringToFront();
                txtConfirmpPassWord.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtConfirmpPassWord.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtConfirmpPassWord.PasswordChar = '•';
            }
        }

        private void lblLinkLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void lblLinkLogin_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblLinkLogin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
