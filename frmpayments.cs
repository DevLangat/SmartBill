using ClosedXML.Excel;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            common.invno = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
            frmpreview fr = new frmpreview();
            fr.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
              
                common.invno = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                //frmpreview fr = new frmpreview();
                //fr.ShowDialog();
                frmAddPayment fr = new frmAddPayment();
                fr.ShowDialog();
                //string userId = dgtransdetails.SelectedRows[0].Cells[2].Value + string.Empty;


            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.ValueType != null || column.HeaderText !=null)
                    {
                        dt.Columns.Add(column.HeaderText, column.ValueType);
                    }
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dt.Rows.Add();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                        }

                    }
                }
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                //Exporting to Excel
                string folderpath = Application.StartupPath + "\\" + userName + "\\Excel\\";
                if (!Directory.Exists(folderpath))
                {
                    Directory.CreateDirectory(folderpath);
                }
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Invoice Customer Data");
                    wb.SaveAs(Path.Combine(folderpath, "Invoice Customer Data.xlsx"));
                }
                var mySheet = Path.Combine(folderpath, "Invoice Customer Data.xlsx");
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlApp.Visible = true;


                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }

                try
                {
                    Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(mySheet);

                }
                catch (Exception ex)
                {
                    File.AppendAllText(Application.StartupPath + "log.txt", ex.Message);
                    xlApp.Quit();

                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception err)
            {
                File.AppendAllText(Application.StartupPath + "log.txt", err.Message);
                MessageBox.Show(err.Message);
            }

        }
    }
}
