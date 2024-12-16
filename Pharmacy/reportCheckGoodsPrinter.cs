using Microsoft.Reporting.WinForms;
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
    public partial class reportCheckGoodsPrinter : Form
    {
        public reportCheckGoodsPrinter()
        {
            InitializeComponent();
        }

        public string LoggedInUserName { get; set; }
        public string LoggedInID { get; set; }

        private void checkGoodsPrinter_Load(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[2];

            DataBaseDataContext data = new DataBaseDataContext();
            string userName = data.EMPLOYEEs.Where(p => p.EMP_NAME == LoggedInUserName).Select(p => p.EMP_NAME).FirstOrDefault() ?? " ";
            string id = data.EMPLOYEEs.Where(p => p.EMP_ID == LoggedInID).Select(p => p.EMP_ID).FirstOrDefault() ?? " ";
            para[0] = new ReportParameter("User", userName);
            para[1] = new ReportParameter("UserID", id);
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetCheckGoods", data.PURCHASEs.OrderBy(p => p.P_ID)));
            this.reportViewer1.RefreshReport();
        }
    }
}
