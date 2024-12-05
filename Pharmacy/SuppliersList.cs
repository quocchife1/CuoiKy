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
    public partial class SuppliersList : Form
    {
        public SuppliersList()
        {
            InitializeComponent();
        }

        private void SuppliersList_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            DataBaseDataContext data = new DataBaseDataContext();
            dgvSuppliersList.DataSource = data.SUPPLIERs.OrderBy(p => p.SUP_ID);
        }
    }
}
