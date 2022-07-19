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
        public frminvoice()
        {
            InitializeComponent();
        }

        private void frminvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emloyeedbDataSet.Employee' table. You can move, or remove it, as needed.

           

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
    }
}
