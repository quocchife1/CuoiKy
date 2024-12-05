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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
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


        private void showUserName()
        {
            lblInfor.Text = "Xin chào, Admin";
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
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            hideSubMenu();
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
            hideSubMenu();
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
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
            hideSubMenu();
        }

        private void btnGoodsList_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnUpdateGoods_Click(object sender, EventArgs e)
        {
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
            hideSubMenu();
        }

        private void btnPHistory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        #endregion

        private void btnReport_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
