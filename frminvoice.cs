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
            generateinvoiceno();
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
                var taxes = (from Tdetails in context.products
                            
                             select new { Tdetails.name, Tdetails.id }).ToList();


                foreach (var s in taxes)
                {
                    cboproduct.DataSource = taxes.ToArray();
                    cboproduct.DisplayMember = "name";
                    cboproduct.ValueMember = "id";
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
                var taxes = (from Tdetails in context.products
                             where Tdetails.id== pid
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
                if (txtdesc.Text == "")
                {
                    MessageBox.Show("Missing Description,please provide", this.Text, MessageBoxButtons.OK);
                    return;
                }
                if (txtUnitPrice.Text == "")
                {
                    MessageBox.Show("Missing price,,please provide  ", this.Text, MessageBoxButtons.OK);
                    return;
                }
                if (txtdocnumber.Text == "")
                {
                    MessageBox.Show("Missing Document Number ,please provide ", this.Text, MessageBoxButtons.OK);
                    return;
                }
                if (cbClients.Text == "")
                {
                    MessageBox.Show("Missing Customer ,please provide ", this.Text, MessageBoxButtons.OK);
                    return;
                }
                if (cboproduct.Text == "")
                {
                    MessageBox.Show("Missing Document Number ,please provide ", this.Text, MessageBoxButtons.OK);
                    return;
                }
                int taxid = Convert.ToInt32(cbTax.SelectedValue);

                int docno = Convert.ToInt32(txtdocnumber.Text);
                int prdid = Convert.ToInt32(cboproduct.SelectedValue);
                string UoM = "";
                decimal price = Convert.ToDecimal(txtUnitPrice.Text);
                double quantity = Convert.ToDouble(txtQuantity.Text);
                string client_id =  cbClients.SelectedValue.ToString();
                string fiscalyear = "";
                string number = "0";
                var context = new sleekbillEntities();
                var invoicecreation = new invoice_products()

                {
                    product_id   = prdid,
                    invoice_id= docno,
                    name = cboproduct.Text,
                    description = txtdesc.Text,
                    measuring_unit = UoM,
                    price = price,
                    quantity = quantity,                  
                    tax_id=taxid,
                    type=cboproduct.Text,
                    deleted="n",


                };

                context.invoice_products.Add(invoicecreation);
                var prod = (from sdetails in context.invoice_products
                            where sdetails.invoice_id == docno
                            select new { sdetails.invoice_id }).ToList();
                if (prod.Count == 1)
                {
                    context.Entry(invoicecreation).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    //MessageBox.Show("Invoice Details Updated Successfully", this.Text, MessageBoxButtons.OK);
                }
                else
                {
                    context.SaveChanges();
                    //MessageBox.Show("Invoice Details submitted Successfully", this.Text, MessageBoxButtons.OK);
                }
                var duedate = dpIssueDate.Value.AddDays(30);
                //var quantity = Convert.ToDouble(txtQuantity.Text);
                var invdetails = new invoice()

                {
                    
                    number = docno,
                    due_date = duedate,
                    issue_date= dpIssueDate.Value.Date,
                    client_id = client_id,
                    client_name = cbClients.Text,
                    total_no_tax = "1",
                    total_tax = cbTax.Text,
                    //fiscal_year = fiscalyear,            
                    po_number=txtponumber.Text,
                    Quantity=quantity,

                };

                context.invoices.Add(invdetails);
                var inv = (from sdetails in context.invoices
                            where sdetails.number == docno
                            select new { sdetails.number }).ToList();
                if (inv.Count == 1)
                {
                    context.Entry(invdetails).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    //MessageBox.Show("Invoice Details Updated Successfully", this.Text, MessageBoxButtons.OK);
                }
                else
                {
                    context.SaveChanges();
                    //MessageBox.Show("Invoice Details submitted Successfully", this.Text, MessageBoxButtons.OK);
                }
                MessageBox.Show("Invoice Details submitted Successfully", this.Text, MessageBoxButtons.OK);
                //generateinvoiceno();
                using (sleekbillEntities banks = new sleekbillEntities())
                {
                    dataGridView1.DataSource = banks.sp_getinvoices();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
            
        }

        private void generateinvoiceno()
        {
            try
            {
                var context = new sleekbillEntities();
                var Rcode = context.invoice_products.Select(p => p.invoice_id).DefaultIfEmpty(0).Max();
               Rcode= Rcode + 1;
                txtdocnumber.Text = Rcode.ToString();
                
                //var invoices = (from m in context.invoice_products
                //               select new { m.invoice_id,m.type,m.description,m.quantity,m.price,m.tax_id }).ToList();
                ////dataGridView1.AutoGenerateColumns = false;
                ////dataGridView1.DataSource = invoices;

                //dr = dt.NewRow();
                //int no = 0;
                //no = no + 1;
                //dt.Columns.Add(new DataColumn("No", typeof(int)));
                //dt.Columns.Add(new DataColumn("product", typeof(string)));
                //dt.Columns.Add(new DataColumn("Description", typeof(string)));
                //dt.Columns.Add(new DataColumn("Quantity", typeof(string)));
                //dt.Columns.Add(new DataColumn("price", typeof(string)));
                //dt.Columns.Add(new DataColumn("value", typeof(string)));
                //dt.Columns.Add(new DataColumn("tax", typeof(string)));
                //dt.Columns.Add(new DataColumn("action", typeof(CheckBox)));
                ////decimal value = Convert.ToDecimal(txtUnitPrice.Text) * Convert.ToDecimal(txtQuantity.Text);
                ////decimal tax = value * Convert.ToDecimal(cbTax.Text);
                //foreach (var t in invoices)
                //{
                //    //select new { m.invoice_id, m.type, m.description, m.quantity, m.price, m.tax_id }).ToList();
                //    dr["No"] = t.invoice_id;
                //    dr["product"] =t.type;
                //    dr["Description"] = t.description;
                //    dr["Quantity"] = t.quantity;
                //    dr["price"] =t.price;
                //    dr["value"] = Convert.ToDecimal(t.price) * Convert.ToDecimal(t.quantity);
                //    dr["tax"] = t.tax_id;
                //    //dr["action"] = false;
                //    dt.Rows.Add(dr);

                //    //dataGridView1.DataBindings();
                //}
                //dataGridView1.AutoGenerateColumns = false;
                //dataGridView1.DataSource = dt;
                clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }


        }

        private void clear()
        {
            txtdesc.Text = "";
            txtAmountPaid.Text = "";
            //txtdocnumber.Text = "";
            txtponumber.Text = "";
            txtQuantity.Text = "";
            txtUnitPrice.Text = "";
             
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {

                common.invno = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                frmpreview fr = new frmpreview();
                fr.ShowDialog();
                //string userId = dgtransdetails.SelectedRows[0].Cells[2].Value + string.Empty;


            }
        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbClients_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var context = new sleekbillEntities();
            string code = cbClients.SelectedValue.ToString();
            var invoices = (from m in context.invoice_products                           
                            where m.deleted=="n" 
                            select new { m.invoice_id }).ToList();
            foreach (var s in invoices)
            {
                cboinvoices.DataSource = invoices.ToArray();
                cboinvoices.DisplayMember = "invoice_id";
                cboinvoices.ValueMember = "invoice_id";
            }
        }

        private void cboinvoices_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboinvoices_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //var context = new sleekbillEntities();
            int code = Convert.ToInt32(cboinvoices.SelectedValue.ToString());
            //var invoices = (from m in context.invoice_products
            //                where m.invoice_id == code
            //                select new { m.invoice_id, m.type, m.description, m.quantity, m.price, m.tax_id }).ToList();
            ////dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = invoices;
            common.invno = cboinvoices.SelectedValue.ToString(); ;
            frmpreview fr = new frmpreview();
            fr.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
