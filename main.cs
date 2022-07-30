using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBill
{
    public partial class main : MaterialForm
    {
        public main()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new frmsplashscreen());
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void getCount()
        {
            sleekbillEntities context = new sleekbillEntities();           
            var countunpaid = (from invoice in context.invoices
                                 where invoice.is_paid == false
                                 select new { invoice.id }).ToList();
            lblUnpaid.Text=countunpaid.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getCount();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            frminvoice inv=new frminvoice();
            inv.ShowDialog(this);
        }

        private void btnCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCompany frmCompany = new frmCompany();
            frmCompany.ShowDialog(this);
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            frmproduct frmproduct = new frmproduct();
            frmproduct.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpayments frmpayments = new frmpayments();
            frmpayments.ShowDialog(this);
        }

        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmcustomer frmCustomer = new frmcustomer();
           frmCustomer.ShowDialog(this);
        }

        private void companyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany frmCompany = new frmCompany();
             frmCompany.ShowDialog(this);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmpayments frmpayments=new frmpayments();
            frmpayments.ShowDialog(this);
        }

        private void customerStatementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcustomerstatements frmcustomerstatements = new frmcustomerstatements();
            frmcustomerstatements.ShowDialog(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmcustomerstatements frmcustomerstatements = new frmcustomerstatements();
            frmcustomerstatements.ShowDialog(this);
        }
    }
}
