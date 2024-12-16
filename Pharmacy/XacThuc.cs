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
    public partial class XacThuc : Form
    {
        string taikhoan;
        public XacThuc()
        {
            InitializeComponent();
        }
        public XacThuc(string _tk)
        {
            InitializeComponent();
            taikhoan = _tk;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataBaseDataContext data = new DataBaseDataContext();
            ACCOUNT acc = data.ACCOUNTs.SingleOrDefault(p => p.USERNAME == taikhoan);
            if (acc != null)
            {
                if (acc.OTP == txtOTP.Text)
                {
                    DateTime otpdatesend = (DateTime)acc.OTPDATESEND;
                    if ((DateTime.Now - otpdatesend).TotalMinutes <= 5)
                    {
                        acc.ACTIVE = true;
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

        private void btnAgain_Click(object sender, EventArgs e)
        {
            DataBaseDataContext data = new DataBaseDataContext();
            ACCOUNT acc = data.ACCOUNTs.SingleOrDefault(p => p.USERNAME == taikhoan);
            if(acc != null)
            {
                Random rd = new Random();
                acc.OTP = rd.Next(1000, 9999).ToString();
                SendMail.sendMailTo(acc.EMAIL, "Mã xác thực là: " + acc.OTP);
                acc.OTPDATESEND = DateTime.Now; 
                data.SubmitChanges();
                MessageBox.Show("Đã gửi mã xác thực, vui lòng kiểm tra email của bạn", "Thông báo");

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
