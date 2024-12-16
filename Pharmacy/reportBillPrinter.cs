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
    public partial class reportBillPrinter : Form
    {
        public reportBillPrinter()
        {
            InitializeComponent();
        }

        public string LoggedInUserName { get; set; }
        public string LoggedInID { get; set; }
        public string LoggedInStore { get; set; }
        public int SaleID { get; set; }
        public string CustomerID { get; set; }
        public string SaleDate { get; set; }
        public string SaleTime { get; set; }

        public string EMPname { get; set; }
        public string EMPid { get; set; }

        public string EMPstore { get; set; }
        private void reportBillPrinter_Load(object sender, EventArgs e)
        {
            DataBaseDataContext data = new DataBaseDataContext();

            var cus = data.CUSTOMERs.Where(p => p.C_ID == CustomerID).FirstOrDefault();
            var valPara = (from SALE in data.SALEs
                           join CUSTOMER in data.CUSTOMERs on SALE.C_ID equals CUSTOMER.C_ID
                           join EMPLOYEE in data.EMPLOYEEs on SALE.EMP_ID equals EMPLOYEE.EMP_ID
                           select new
                           {
                               CusName = CUSTOMER.C_NAME,
                               CusID = CUSTOMER.C_ID,
                               SaleID = SALE.EMP_ID,
                               SaleName = EMPLOYEE.EMP_NAME

                           }).FirstOrDefault(); 
            int qty = data.SALES_ITEMs.Where(p => p.S_ID == SaleID).Count();
            decimal total = data.SALES_ITEMs.Where(p => p.S_ID == SaleID).Sum(p => p.TOTAL_PRICE);
            ReportParameter[] para = new ReportParameter[9];
            para[0] = new ReportParameter("CustomerName", cus.C_NAME);
            para[1] = new ReportParameter("CustomerID", CustomerID);
            para[2] = new ReportParameter("EMPName", EMPname);
            para[3] = new ReportParameter("EMPID", EMPid);
            para[4] = new ReportParameter("EMPStore", EMPstore);
            para[5] = new ReportParameter("BillDate",SaleDate);
            para[6] = new ReportParameter("BillTime",SaleTime);
            para[7] = new ReportParameter("TongSL", qty.ToString());
            para[8] = new ReportParameter("Total",total.ToString("C"));

            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetHoaDon", data.SALES_ITEMs.Where(p => p.S_ID == SaleID).OrderBy(p => p.S_ID)));
            this.reportViewer1.RefreshReport();
        }
    }
}
