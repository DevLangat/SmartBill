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
    public partial class frmReceiptspreview : MaterialForm
    {
        public frmReceiptspreview()
        {
            InitializeComponent();
        }

        private void frmReceiptspreview_Load(object sender, EventArgs e)
        {
            GetData();
            this.reportViewer1.RefreshReport();
        }
        private void GetData()
        {
            sleekbillEntities context = new sleekbillEntities();
            int invno = Convert.ToInt32(common.invno);
            var data = context.sp_getReceiptdetails("2", 8).ToList();


            var reportDataSource1 = new ReportDataSource();
            reportDataSource1.Name = "payments";
            reportDataSource1.Value = data;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
           
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartBill.Reports.ReceiptsReports.rdlc";
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();


            //ReportDataSource datasource = new ReportDataSource("Invoice", data);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(datasource);
            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
