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
    public partial class frminvoice : MaterialForm
    {
        DataRow dr;
        DataTable dt = new DataTable();
        public frminvoice()
        {
            InitializeComponent();
        }

        private void frminvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emloyeedbDataSet.Employee' table. You can move, or remove it, as needed.

            loadclients();
            loadproducts();
            loadtaxes();
        }
        private void loadtaxes()
        {
            try
            {
                var context = new sleekbillEntities();
                var taxes = (from Tdetails in context.taxes
                             where Tdetails.is_default_tax == true
                             select new { Tdetails.tax_percentage, Tdetails.id }).ToList();


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
        private void loadclients()
        {
            try
            {
                var context = new sleekbillEntities();
                var taxes = (from Tdetails in context.clients
                            
                             select new { Tdetails.name, Tdetails.code }).ToList();


                foreach (var s in taxes)
                {
                    cbClients.DataSource = taxes.ToArray();
                    cbClients.DisplayMember = "name";
                    cbClients.ValueMember = "code";
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
        private void loadproducts()
        {
            try
            {
                var context = new sleekbillEntities();
                var taxes = (from Tdetails in context.invoice_products
                            
                             select new { Tdetails.name, Tdetails.product_id }).ToList();


                foreach (var s in taxes)
                {
                    cboproduct.DataSource = taxes.ToArray();
                    cboproduct.DisplayMember = "name";
                    cboproduct.ValueMember = "product_id";
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chckPay_CheckedChanged(object sender, EventArgs e)
        {
            if (chckPay.Checked)
            {
                gpPay.Visible = true;
            }
            else
            {
                gpPay.Visible = false;

            }
        }

        private void cboproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(cboproduct.SelectedValue);
                var context = new sleekbillEntities();
                var taxes = (from Tdetails in context.invoice_products
                             where Tdetails.product_id== pid
                             select new { Tdetails.name, Tdetails.price }).ToList();
                foreach(var t in taxes)
                {
                    txtUnitPrice.Text = t.price.ToString();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int taxid = Convert.ToInt32(cbTax.Text);
                decimal price = Convert.ToDecimal(txtUnitPrice.Text);
                double quantity = Convert.ToDouble(txtQuantity.Text);
                int client_id = Convert.ToInt32(cbClients.SelectedValue);
                string fiscalyear = "";
                string number = "0";
                var context = new sleekbillEntities();
                var invoicecreation = new invoice()

                {
                    issue_date   = dpIssueDate.Value.ToString(),
                    client_id = client_id,
                    client_name = cbClients.Text,
                    total_tax = cbTax.Text,
                    type = cboproduct.Text,
                    fiscal_year = fiscalyear,                  
                    number=number,


                };

                context.invoices.Add(invoicecreation);
                var prod = (from sdetails in context.invoices
                            where sdetails.number == number
                            select new { sdetails.number }).ToList();
                if (prod.Count == 1)
                {
                    context.Entry(invoicecreation).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                    MessageBox.Show("Invoice Details Updated Successfully", this.Text, MessageBoxButtons.OK);


                }
                else
                {
                    context.SaveChanges();
                    MessageBox.Show("Invoice Details submitted Successfully", this.Text, MessageBoxButtons.OK);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
            //dr = dt.NewRow();
            //int no=0;
            //no = no + 1;
            //dt.Columns.Add(new DataColumn("No", typeof(int)));
            //dt.Columns.Add(new DataColumn("product", typeof(string)));
            //dt.Columns.Add(new DataColumn("Description", typeof(string)));
            //dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
            //dt.Columns.Add(new DataColumn("price", typeof(string)));
            //dt.Columns.Add(new DataColumn("value", typeof(string)));
            //dt.Columns.Add(new DataColumn("tax", typeof(string)));
            //dt.Columns.Add(new DataColumn("action", typeof(string)));
            //decimal value = Convert.ToDecimal(txtUnitPrice.Text) * Convert.ToDecimal(txtQuantity.Text);
            //decimal tax = value * Convert.ToDecimal(cbTax.Text);

            //dr["No"] = no;
            //dr["product"] = cboproduct.Text;
            //dr["Description"] = txtdesc.Text;
            //dr["Quantity"] = txtQuantity.Text;
            //dr["price"] = txtUnitPrice.Text;
            //dr["value"] = value;
            //dr["tax"] = tax;
            //dr["action"] =0;
            //dt.Rows.Add(dr);
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = dt;
            //dataGridView1.DataBindings();
        }
    }
}
