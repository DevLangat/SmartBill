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
    public partial class frmpreview : MaterialForm
    {
        public frmpreview()
        {
            InitializeComponent();
        }

        private void frmpreview_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel2.BackColor = colorDialog1.Color;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception err)
            {

            }
        }
    }
}
