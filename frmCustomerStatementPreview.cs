using MaterialSkin.Controls;
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

namespace SmartBill
{
    public partial class frmCustomerStatementPreview : MaterialForm
    {
        public frmCustomerStatementPreview()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            sleekbillEntities context = new sleekbillEntities();
            // int invno = Convert.ToInt32(common.invno);
            var statdate = new DateTime(2022,07,10);
            var edate = new DateTime(2022,07,30);
            //var data2 = context.sp_getStatement("CL-000002", statdate, edate,).ToString();
            //Console.WriteLine(data2);
            //var cust = "CL-000002";
            var data = context.sp_getcustomestatements(common.custoid).ToList();
           

            var reportDataSource1 = new ReportDataSource();
            reportDataSource1.Name = "customerstatements";
            reportDataSource1.Value = data;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer1.LocalReport.DisplayName = common.custoid + "-CustomerStatement";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartBill.Reports.CustomerStatementReport.rdlc";
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();


            //ReportDataSource datasource = new ReportDataSource("Invoice", data);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(datasource);
            //this.reportViewer1.RefreshReport();
        }

        private void frmCustomerStatementPreview_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
