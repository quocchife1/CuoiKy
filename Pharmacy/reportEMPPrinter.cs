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
    public partial class reportEMPPrinter : Form
    {
        public reportEMPPrinter()
        {
            InitializeComponent();
        }

        public string LoggedInUserName { get;  set; }
        private void reportEMPPrinter_Load(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[1];
            DataBaseDataContext data = new DataBaseDataContext();
            string userName = data.EMPLOYEEs.Where(p => p.EMP_NAME == LoggedInUserName).Select(p => p.EMP_NAME).FirstOrDefault() ?? " ";
            para[0] = new ReportParameter("User", LoggedInUserName);
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetEMP",data.EMPLOYEEs.OrderBy(p => p.EMP_ID)));

            this.reportViewer1.RefreshReport();
        }
    }
}
