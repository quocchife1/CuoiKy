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
            string mail = txtMail.Text;
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            string confirmPass = txtConfirmpPassWord.Text;
            Random rd = new Random();
            string otp = rd.Next(1000, 9999).ToString();

            if (id == "" || userName == "" || mail == "" || passWord == "" || confirmPass == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin", "Thông báo");
                return;
            }

            if (passWord != confirmPass)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo");
                txtPassword.Focus();
                return;
            }

            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(passWord + otp);
            byte[] hashBytes = md5.ComputeHash(inputBytes);


            DataBaseDataContext data = new DataBaseDataContext();
            EMPLOYEE emp = data.EMPLOYEEs.Where(p => p.EMP_ID == id).SingleOrDefault();
            ACCOUNT acc = new ACCOUNT();    
            acc.ID = id;
            acc.EMAIL = mail;
            acc.USERNAME = userName;
            acc.PASSWORD = hashBytes;
            acc.OTP = otp;
            acc.RANDOMKEY = otp;
            acc.DATECRATED = DateTime.Now;
            acc.OTPDATESEND = DateTime.Now;
            acc.LEVEL = emp.EMP_TYPE;
            acc.ACTIVE = false;

            data.ACCOUNTs.InsertOnSubmit(acc);
            data.SubmitChanges();
            MessageBox.Show("Đăng ký thành công!", "Thông báo");

            SendMail.sendMailTo(acc.EMAIL, "Mã OTP xác thực là: " + acc.OTP);
            acc.OTPDATESEND = DateTime.Now;
            data.SubmitChanges();

            if(acc.ACTIVE == false)
            {
                XacThuc frm = new XacThuc(acc.USERNAME);
                frm.Show();
                return;
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
