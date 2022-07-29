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
                var prdid = Convert.ToString(cbType.SelectedValue);
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
    }
}
