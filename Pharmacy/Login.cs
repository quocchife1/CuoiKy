using Pharmacy;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string GlobalLoggedInUserName = "";
        public static string GlobalLoggedInID = "";
        public static string GlobalLoggedInStore = "";
        public static string GlobalLoggedInType = "";

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            DataBaseDataContext data = new DataBaseDataContext();

            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Vui lòng điền thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                ACCOUNT acc = data.ACCOUNTs.SingleOrDefault(p => p.USERNAME == userName);
                if (acc != null)
                {
                    if(acc.ACTIVE == false)
                    {
                        MessageBox.Show("Tài khoản chưa xác thực. Vui lòng nhập OTP để xác thực.", "Thông báo");
                        XacThuc frm = new XacThuc(acc.USERNAME);
                        frm.Show();
                        return;
                    }


                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = Encoding.ASCII.GetBytes(passWord + acc.RANDOMKEY);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    if (acc.PASSWORD == hashBytes)
                    {
                        EMPLOYEE emp = data.EMPLOYEEs.Where(p => p.EMP_ID == acc.ID).SingleOrDefault();
                        Login.GlobalLoggedInType = acc.LEVEL;
                        Login.GlobalLoggedInStore = emp.EMP_STORE;
                        if (acc.LEVEL == "ADMIN")
                        {
                            
                            
                            if (emp != null)
                            {
                                string empID = emp.EMP_ID;
                                string empName = emp.EMP_NAME;
                                string empStore = emp.EMP_STORE;
                                Login.GlobalLoggedInUserName = empName;
                                Login.GlobalLoggedInID = empID;
                                Login.GlobalLoggedInStore = empStore;
                                
                            }
                        }
                        else
                        {
                            if (acc.LEVEL == "MANAGER")
                            {
                                if (emp != null)
                                {
                                    string empID = emp.EMP_ID;
                                    string empName = emp.EMP_NAME;
                                    string empStore = emp.EMP_STORE;
                                    Login.GlobalLoggedInUserName = empName;
                                    Login.GlobalLoggedInID = empID;
                                    Login.GlobalLoggedInStore = empStore;
                                    
                                }
                            }
                            else if (acc.LEVEL == "PHARMACIST")
                            {
                                if (emp != null)
                                {
                                    string empID = emp.EMP_ID;
                                    string empName = emp.EMP_NAME;
                                    string empStore = emp.EMP_STORE;
                                    string type = emp.EMP_TYPE;
                                    Login.GlobalLoggedInUserName = empName;
                                    Login.GlobalLoggedInID = empID;
                                    Login.GlobalLoggedInStore = empStore;
                                    
                                }
                            }
                            
                            
                        }
                        MainForm ad = new MainForm();
                        ad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin không tồn tại!", "Thông báo", MessageBoxButtons.OK);
                        txtUsername.Focus();
                    }
                }
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
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
        private void getID(string loggedInID)
        {
            var reportForm = new reportCheckGoodsPrinter();
            var reportFormB = new reportBillPrinter();
            reportForm.LoggedInID = loggedInID;
            reportFormB.LoggedInID = loggedInID;
        }

        private void getStore(string loggedInStore)
        {
            var reporrtFormB = new reportBillPrinter();
            reporrtFormB.LoggedInStore = loggedInStore;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void forgotPassWord_Click(object sender, EventArgs e)
        {
            ForgotPassword fgpw = new ForgotPassword();
            fgpw.Show();
            this.Hide();
        }
    }
}

