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
    public partial class MainForm : Form
    {
        private Timer clockTimer;
        private Label lblClock;
        private Label lblDate;
        public MainForm()
        {
            InitializeComponent();

            // Khởi tạo Label hiển thị ngày tháng
            lblDate = new Label
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Font = new Font("Arial", 14, FontStyle.Regular),
                ForeColor = Color.Black, // Màu chữ
                Height = 30 // Chiều cao của Label ngày tháng
            };
            panelLogo.Controls.Add(lblDate);

            // Khởi tạo Label hiển thị đồng hồ
            lblClock = new Label
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Black // Màu chữ
            };
            panelLogo.Controls.Add(lblClock);

            // Khởi tạo Timer
            clockTimer = new Timer
            {
                Interval = 1000 // Cập nhật mỗi 1 giây
            };
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
            checkPermission();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            hideSubMenu();

            showUserName();
        }


        private void hideSubMenu()
        {
            panelEMPSide.Visible = false;
            panelOrderSide.Visible = false;
            panelSalesSide.Visible = false;
            panelWareHouseSide.Visible = false;
        }

        private void checkPermission()
        {
            if (Login.GlobalLoggedInType == "MANAGER")
            {
                btnManagerList.Enabled = btnReport.Enabled = false;
            }
            else
            {
                if (Login.GlobalLoggedInType == "PHARMACIST")
                {
                    btnEMP.Enabled = btnReport.Enabled = btnOrderApproval.Enabled = false;
                }
            }

        }
        private void showUserName()
        {
            lblInfor.Text = "Xin chào, " + Login.GlobalLoggedInUserName;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        #region Employee
        private void btnEMP_Click(object sender, EventArgs e)
        {


            showSubMenu(panelEMPSide);
        }
        private void btsPharmacistList_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new PharmacistList());

            hideSubMenu();
        }

        private void btnManagerList_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ManagerList());
            hideSubMenu();
        }

        private void btnUpdateEMP_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new UpdateEMPInfor());
            hideSubMenu();
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {

            openChildFormInPanel(new Print());
            hideSubMenu();
        }

        #endregion

        #region Warehouse
        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWareHouseSide);
        }

        private void btnUpdateMed_Click(object sender, EventArgs e)
        {

            openChildFormInPanel(new UpdateMED());
            hideSubMenu();
        }

        private void btnGoodsList_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new checkGoodsList());
            hideSubMenu();
        }

        private void btnUpdateGoods_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new UpdateWareHouse());
            hideSubMenu();
        }

        #endregion

        #region Order
        private void btnOrderList_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOrderSide);
        }

        private void btnOrderApproval_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new OrderApproval());
            hideSubMenu();
        }

        private void btnSupplierInfo_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new SuppliersList());
            hideSubMenu();
        }

        #endregion

        #region Sales
        private void btnSales_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSalesSide);
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CustomerInfor());
            hideSubMenu();
        }

        private void btnPHistory_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Bill());
            hideSubMenu();
        }

        #endregion

        private void btnReport_Click(object sender, EventArgs e)
        {
            foreach (Form child in panelChildForm.Controls.OfType<Form>())
            {
                if (child is ReportForm reportForm)
                {
                    reportForm.Show();
                    return;
                }
                else
                {
                    var reportNew = new ReportForm
                    {
                        Owner = this
                    };
                    openChildFormInPanel(reportNew);
                }
            }
            var reportFormNew = new ReportForm
            {
                Owner = this
            };
            openChildFormInPanel(reportFormNew);
            hideSubMenu();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIntroduce_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Introduce());
            hideSubMenu();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Sale());
            hideSubMenu();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss"); // Hiển thị giờ:phút:giây
        }
    }
}
