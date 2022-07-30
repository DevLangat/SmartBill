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
    public partial class frmcustomerstatements : MaterialForm
    {
        public frmcustomerstatements()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            try
            {
                var prdid = Convert.ToInt32(cbType.SelectedValue);
                var context = new sleekbillEntities();
                context.sp_getStatement(cbClient.SelectedValue.ToString(),dtStartdate.Value.Date,dtEnddate.Value.Date, prdid);
                common.custoid = cbClient.SelectedValue.ToString();
                frmCustomerStatementPreview fr = new frmCustomerStatementPreview();
                    fr.Show();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void frmcustomerstatements_Load(object sender, EventArgs e)
        {
            loadclients();
            loadproducts();
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
                    cbClient.DataSource = taxes.ToArray();
                    cbClient.DisplayMember = "name";
                    cbClient.ValueMember = "code";
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

                             select new { Tdetails.Pname, Tdetails.id }).ToList();


                foreach (var s in taxes)
                {
                    cbType.DataSource = taxes.ToArray();
                    cbType.DisplayMember = "Pname";
                    cbType.ValueMember = "id";
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
    }
}
