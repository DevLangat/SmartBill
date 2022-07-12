using MaterialSkin.Controls;
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
    public partial class main : MaterialForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            inv.ShowDialog();
        }

        private void btnCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCompany frmCompany = new frmCompany();
            frmCompany.ShowDialog();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            frmproduct frmproduct = new frmproduct();
            frmproduct.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpayments frmpayments = new frmpayments();
            frmpayments.ShowDialog();
        }

        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmcustomer frmCustomer = new frmcustomer();
           frmCustomer.ShowDialog();
        }

        private void companyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany frmCompany = new frmCompany();
             frmCompany.ShowDialog();
        }
    }
}
