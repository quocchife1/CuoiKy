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
    public partial class checkGoodsList : Form
    {
        public checkGoodsList()
        {
            InitializeComponent();
        }

        private void checkGoodsList_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            dgvGoodsList.DataSource = data.PURCHASEs.Select(p => new { p.P_ID, p.SUP_ID, p.MED_ID, MED_NAME = p.MEDICINE.MED_NAME, p.P_QTY, p.P_UNIT, p.P_COST, p.PUR_DATE, p.MFG_DATE, p.EXP_DATE, p.P_STATUS }).OrderBy(p => p.P_ID);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            reportCheckGoodsPrinter rpGL = new reportCheckGoodsPrinter();
            rpGL.LoggedInUserName = Login.GlobalLoggedInUserName;
            rpGL.LoggedInID = Login.GlobalLoggedInID;
            rpGL.ShowDialog();
        }
    }
}
