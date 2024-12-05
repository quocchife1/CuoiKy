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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string type = "MANAGER";
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;


            if (rbtnManager.Checked)
            {
                DataBaseDataContext data = new DataBaseDataContext();

                ADMIN ad = data.ADMINs.Where(p => p.A_USERNAME == userName && p.A_PASSWORD == passWord).SingleOrDefault();
                if (ad != null)
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            if (rbtnEMP.Checked)
            {
                DataBaseDataContext data = new DataBaseDataContext();

                EMPACCOUNT ad = data.EMPACCOUNTs.Where(p => p.EMPAC_USERNAME == userName && p.EMPAC_PASSWORD == passWord).SingleOrDefault();
                if (ad != null)
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '•')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }

        private void lblLinkSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
        private void lblLinkSignin_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblLinkSignin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
