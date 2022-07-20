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
    public partial class frmpayments : MaterialForm
    {
        public frmpayments()
        {
            InitializeComponent();
        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (sleekbillEntities banks = new sleekbillEntities())
            {
                dataGridView1.AutoGenerateColumns = true;
                string clienid = cbClients.SelectedValue.ToString();
                banks.sp_getinvoicesforpayment() ;
                var inv = (from t in banks.tmpinvdatas 
                           where t.client_id== clienid
                           select new {t.id,t.number,t.due_date,t.InvoiceValue,t.Balance,t.Paid }).ToList();
                dataGridView1.DataSource = inv;
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

        private void frmpayments_Load(object sender, EventArgs e)
        {
            loadclients();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
              
                common.invno = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                frmAddPayment fr = new frmAddPayment();
                fr.ShowDialog();
                //string userId = dgtransdetails.SelectedRows[0].Cells[2].Value + string.Empty;


            }
        }
    }
}
