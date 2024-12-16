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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {

            DataBaseDataContext data = new DataBaseDataContext();
            ACCOUNT acc = data.ACCOUNTs.SingleOrDefault(p => p.USERNAME == txtUserName.Text);
            if (acc != null)
            {
                Random rd = new Random();
                acc.OTP = rd.Next(1000, 9999).ToString();
                SendMail.sendMailTo(txtEmail.Text, "Mã xác thực là: " + acc.OTP);
                acc.OTPDATESEND = DateTime.Now;
                data.SubmitChanges();
                MessageBox.Show("Đã gửi mã xác thực, vui lòng kiểm tra email của bạn", "Thông báo");

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataBaseDataContext data = new DataBaseDataContext();
            ACCOUNT acc = data.ACCOUNTs.SingleOrDefault(p => p.USERNAME == txtUserName.Text);
            if (acc != null)
            {
                if (acc.OTP == txtOTP.Text)
                {
                    DateTime otpdatesend = (DateTime)acc.OTPDATESEND;
                    if ((DateTime.Now - otpdatesend).TotalMinutes <= 5)
                    {
                        acc.PASSWORD = Encoding.UTF8.GetBytes("123");
                        data.SubmitChanges();
                        MessageBox.Show("Đã kích hoạt thành công tài khoản", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mã OTP hết hiệu lực. Vui lòng nhập lại mã OTP mới", "Thông báo");
                        btnAgain_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Mã OTP hết hiệu lực. Vui lòng nhập lại mã OTP mới", "Thông báo");
                    return;
                }
            }
        }
    }
}
