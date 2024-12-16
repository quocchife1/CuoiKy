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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void panelALL_MouseHover(object sender, EventArgs e)
        {
            panelALL.BackColor = Color.Gainsboro;
        }

        private void panelALL_MouseLeave(object sender, EventArgs e)
        {
            panelALL.BackColor = Color.White;
        }

        private void panelALL_MouseDown(object sender, MouseEventArgs e)
        {

            panelALL.BorderStyle = BorderStyle.FixedSingle;
            panelALL.BackColor = Color.Silver;
        }

        private void panelALL_MouseUp(object sender, MouseEventArgs e)
        {
            panelALL.BorderStyle = BorderStyle.None;
            panelALL.BackColor= Color.Gainsboro;
            reportEMPPrinter rpEMP = new reportEMPPrinter();
            rpEMP.LoggedInUserName = Login.GlobalLoggedInUserName;
            rpEMP.ShowDialog();
        }

        private void panelmanagerPrint_MouseHover(object sender, EventArgs e)
        {
            panelmanagerPrint.BackColor = Color.Gainsboro;
        }

        private void panelmanagerPrint_MouseLeave(object sender, EventArgs e)
        {
            panelmanagerPrint.BackColor = Color.White;
        }

        private void panelmanagerPrint_MouseDown(object sender, MouseEventArgs e)
        {
            panelmanagerPrint.BackColor = Color.Silver;
            panelmanagerPrint.BorderStyle = BorderStyle.FixedSingle;
            
            
        }

        private void panelmanagerPrint_MouseUp(object sender, MouseEventArgs e)
        {
            reportMANAGERPrinter rpMNG = new reportMANAGERPrinter();
            rpMNG.LoggedInUserName = Login.GlobalLoggedInUserName;
            rpMNG.ShowDialog();
            panelmanagerPrint.BorderStyle = BorderStyle.None;
            panelmanagerPrint.BackColor= Color.Gainsboro;
        }

        private void panelempPrint_MouseHover(object sender, EventArgs e)
        {
            panelempPrint.BackColor = Color.Gainsboro;
        }

        private void panelempPrint_MouseLeave(object sender, EventArgs e)
        {
            panelempPrint.BackColor = Color.White;
        }

        private void panelempPrint_MouseDown(object sender, MouseEventArgs e)
        {
            panelempPrint.BackColor = Color.Silver;
            panelempPrint.BorderStyle = BorderStyle.FixedSingle;


        }

        private void panelempPrint_MouseUp(object sender, MouseEventArgs e)
        {
            reportPHARMACISTPrinter rpP = new reportPHARMACISTPrinter();
            rpP.LoggedInUserName = Login.GlobalLoggedInUserName;
            rpP.ShowDialog();
            panelempPrint.BorderStyle = BorderStyle.None;
            panelempPrint.BackColor= Color.Gainsboro;
        }
    }
}
