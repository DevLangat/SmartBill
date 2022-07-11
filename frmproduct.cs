﻿using MaterialSkin.Controls;
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
    public partial class frmproduct : MaterialForm
    {
        int prodid = 1;
        public frmproduct()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPrdctName.Text=="")
            {
                MessageBox.Show("Missing Product Name", this.Text, MessageBoxButtons.OK);
                return;
            }
            if (prodid == 0)
            {
                MessageBox.Show("Missing ProductId  ", this.Text, MessageBoxButtons.OK);
                return;
            }
            if (cbType.Text == "")
            {
                MessageBox.Show("Missing Product typ  ", this.Text, MessageBoxButtons.OK);
                return;
            }
            try
            {
             
                
                int taxid   =Convert.ToInt32(cbTax.Text);
                decimal price= Convert.ToDecimal(txtPrice.Text);
                double quantity=Convert.ToDouble(txtQuantity.Text);
                var context = new sleekbillEntities();
                var products = new invoice_products()
              
                {
                    product_id = prodid,
                    name = txtPrdctName.Text,
                    description = txtDesc.Text,
                    price = price,
                    tax_id = taxid,
                    quantity = quantity,
                    type=cbType.Text,   
                    measuring_unit=cbUOM.Text,
                  

                };

                context.invoice_products.Add(products);
                var prod = (from sdetails in context.invoice_products
                                     where sdetails.product_id == prodid
                                     select new { sdetails.name }).ToList();
                if (prod.Count == 1)
                {
                    context.Entry(products).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                    MessageBox.Show("Product Details Updated Successfully", this.Text, MessageBoxButtons.OK);


                }
                else
                {
                    context.SaveChanges();
                    MessageBox.Show("Product Details submitted Successfully", this.Text, MessageBoxButtons.OK);
                }
                generatecode();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void generatecode()
        {
            try
            {
                var context = new sleekbillEntities();
                var Rcode = context.invoice_products.Select(p => p.product_id).DefaultIfEmpty(0).Max();
                prodid = (int)Rcode;

                var clients = (from m in context.invoice_products
                               select new { m.product_id, m.name, m.type }).ToList();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = clients;
                clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void clear()
        {
            txtPrdctName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtDesc.Text = "";
        }

        private void frmproduct_Load(object sender, EventArgs e)
        {
            generatecode();
            loadtaxes();
        }

        private void loadtaxes()
        {
            try
            {
                var context = new sleekbillEntities();
                var taxes = (from Tdetails in context.taxes
                                    where Tdetails.is_default_tax == true
                                    select new { Tdetails.tax_percentage, Tdetails.id  }).ToList();


                foreach (var s in taxes)
                {
                    cbTax.DataSource = taxes.ToArray();
                    cbTax.DisplayMember = "tax_percentage";
                    cbTax.ValueMember = "id";
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
    }
}
