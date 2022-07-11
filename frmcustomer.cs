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
    public partial class frmcustomer : MaterialForm
    {
        string code;
      
        public frmcustomer()
        {
            InitializeComponent();
        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {
            generatecode();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { 
            var context = new sleekbillEntities();
            var clientdetails = new client()

            {
                code = code,
                name = txtName.Text,
                billing_address = txtAddress.Text,
                billing_city = cbocounty.Text,
                vat_number = txtKraPin.Text,
                telephone = txtPhone.Text,
                email = txtEmail.Text,
                deleted = "0",
                billing_zip = txtZipcode.Text,              

            };

            context.clients.Add(clientdetails);
            var countsupplier = (from sdetails in context.clients
                                 where sdetails.code == code
                                 select new { sdetails.name }).ToList();
            if (countsupplier.Count == 1)
            {
                context.Entry(clientdetails).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                MessageBox.Show("Client Details Updated Successfully", this.Text, MessageBoxButtons.OK);
                   
                        
            }
            else
            {
                context.SaveChanges();
                MessageBox.Show("Client Details submitted Successfully", this.Text, MessageBoxButtons.OK);
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
                var Rcode = context.clients.Select(p => p.code).DefaultIfEmpty("CL-001").Max();
                var recepsplit = Rcode.Split('-');
                var no = Convert.ToInt32(recepsplit[1]) + 1;
                char pad = '0';
                string newno = no.ToString();
                code = recepsplit[0] + "-" + newno.PadLeft(6, pad);
            
                var clients = (from m in context.clients                                   
                                   select new { m.code,m.name,m.email,m.telephone   }).ToList();
                //dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = clients;
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtKraPin.Text = "";
                txtName.Text = "";
                txtPhone.Text = "";
                txtZipcode.Text="";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              code = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            var context = new sleekbillEntities();
            var clients = (from m in context.clients
                           where m.code == code
                           select new {m.billing_address,m.email,m.billing_state_id,m.name,m.vat_number,m.telephone,m.billing_zip }).ToList();
            foreach(var y in clients)
            {
                txtAddress.Text = y.billing_address;
                txtEmail.Text = y.email;
                txtName.Text = y.name;
                txtKraPin.Text = y.vat_number;
                txtPhone.Text = y.telephone;
                txtZipcode.Text = y.billing_zip;
                cbocounty.ValueMember = y.billing_state_id.ToString();
                
            }
        }
    }
}
