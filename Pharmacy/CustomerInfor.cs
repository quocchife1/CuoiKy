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
    public partial class CustomerInfor : Form
    {
        public CustomerInfor()
        {
            InitializeComponent();
        }

        private void CustomerInfor_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            dgvCustomInfor.DataSource = data.CUSTOMERs.OrderBy(p => p.C_ID);
        }
    }
}
