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
    public partial class frmAddPayment : MaterialForm
    {
        long paymentid;
        public frmAddPayment()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            try {
                if(Convert.ToDouble(txtpamount.Text)> Convert.ToDouble(txtamountdue.Text))
                {
                    MessageBox.Show("Invoice Balance is less than the Amount Entered, please confirm",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;  
                }
                if (txtpamount.Text=="")
                {
                    MessageBox.Show("Please Provide the Amount to Pay", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtcheqno.Text=="" )
                {
                    MessageBox.Show("Please enter the cheque number, please confirm", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var context = new sleekbillEntities();
                var amount = Convert.ToDecimal(txtpamount.Text);
                var invid = Convert.ToInt32(txtinvoiceno.Text);

                
                    var payments = new invoice_payments()

                    {

                        payment_id = paymentid,
                        invoice_id = invid,
                        amount = amount,
                        deleted = false,
                        payment_document_id = txtcheqno.Text,
                        Receiptno = txtrno.Text,
                        PaymentMode = cbomode.Text,
                       

                    };

                    context.invoice_payments.Add(payments);
                    var company = (from p in context.invoice_payments
                                   where p.Receiptno == txtrno.Text //code ammended to always update details of a company with the assumption that we always have one company we are working on
                                   select new { p.Receiptno }).ToList();
                    if (company.Count == 1)
                    {
                        context.Entry(payments).State = System.Data.Entity.EntityState.Modified;

                        context.SaveChanges();
                        MessageBox.Show("Receipt Generated   Successfully", this.Text, MessageBoxButtons.OK);


                    }
                    else
                    {
                        context.SaveChanges();
                        MessageBox.Show("Receipt Generated   Successfully", this.Text, MessageBoxButtons.OK);
                    this.Close(); 
                    
                }
                }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbomode.Text== "Cash")
            {
                txtcheqno.Text = txtrno.Text;
                 
            }
            else
            {
                txtcheqno.Text = "";
            }
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            txtinvoiceno.Text =common.invno;
            var context = new sleekbillEntities();
            paymentid = (from t in context.invoice_payments select t.payment_id).DefaultIfEmpty(0).Max();
            paymentid = paymentid + 1;
            txtrno.Text = paymentid.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void txtinvoiceno_TextChanged(object sender, EventArgs e)
        {
            var context = new sleekbillEntities();
            var inv = Convert.ToInt64(txtinvoiceno.Text);
            var invdetails = (from p in context.tmpinvdatas
                           where p.number == inv //code ammended to always update details of a company with the assumption that we always have one company we are working on
                           select new { p.number,p.InvoiceValue,p.Balance,p.issue_date, }).ToList();
            foreach(var x in invdetails)
            {
                txtinvdate.Text = x.issue_date.ToString();
                txtinvdate.Text = x.issue_date.ToString();
                txtinvamount.Text = x.InvoiceValue.ToString();
                txtamountdue.Text = x.Balance.ToString();

            }
        }
    }
}
