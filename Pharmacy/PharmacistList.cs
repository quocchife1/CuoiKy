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
    public partial class PharmacistList : Form
    {
        public PharmacistList()
        {
            InitializeComponent();
        }

        private void PharmacistList_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            if(Login.GlobalLoggedInType == "MANAGER")
            {
                dgvPharmacistList.DataSource = data.EMPLOYEEs.Where(p => p.EMP_TYPE == "PHARMACIST" && p.EMP_STORE == Login.GlobalLoggedInStore).Select(p => new { p.EMP_ID, p.EMP_NAME, p.EMP_SEX, p.EMP_DATE_OF_BIRTH, p.EMP_TYPE, p.EMP_JOB_DATE, p.EMP_PHONE, p.EMP_MAIL, p.EMP_STORE }).OrderBy(p => p.EMP_ID).ToList();
            }
            else
            {
                dgvPharmacistList.DataSource = data.EMPLOYEEs.Where(p => p.EMP_TYPE == "PHARMACIST").Select(p => new {p.EMP_ID, p.EMP_NAME, p.EMP_SEX, p.EMP_DATE_OF_BIRTH, p.EMP_TYPE, p.EMP_JOB_DATE, p.EMP_PHONE, p.EMP_MAIL, p.EMP_STORE}).OrderBy(p => p.EMP_ID);
            }
        }
    }
}
