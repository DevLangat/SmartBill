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
    public partial class frmpreview : MaterialForm
    {
        public frmpreview()
        {
            InitializeComponent();

            GetData();
        }

        private void frmpreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sleekbillDataSet.sp_getinvoicedetails' table. You can move, or remove it, as needed.

            GetData();


            this.reportViewer1.RefreshReport();
        }

        private void GetData()
        {
            sleekbillEntities context = new sleekbillEntities();
            var data = context.sp_getinvoicedetails(1).ToList();
         
            var reportDataSource1 = new ReportDataSource();
            reportDataSource1.Name = "invoices";
            reportDataSource1.Value = data;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartBill.Reports.InvoiceReport.rdlc";
            this.reportViewer1.RefreshReport();

           
            //ReportDataSource datasource = new ReportDataSource("Invoice", data);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(datasource);
            //this.reportViewer1.RefreshReport();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
