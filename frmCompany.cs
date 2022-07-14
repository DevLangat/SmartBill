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
    public partial class frmCompany : MaterialForm
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Boolean Result = false;
            string eMail = txtEmail.Text;
            var context = new sleekbillEntities();
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                MessageBox.Show("Please Input a valid Email Address", this.Text, MessageBoxButtons.OK);
                Result = false;
                return;
            };
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Input a Customer Name", this.Text, MessageBoxButtons.OK);
                return;
            }
            if (txtPIN.Text == "")
            {
                MessageBox.Show("Please Input a valid KRA Pin", this.Text, MessageBoxButtons.OK);
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Input a Valid address", this.Text, MessageBoxButtons.OK);
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Please Input a Valid Phone Number", this.Text, MessageBoxButtons.OK);
                return;
            }



            try
            {

                var companydetails = new company_details()

                {
                    
                    name = txtName.Text,
                    address = txtAddress.Text,
                    county = cbCounty.Text,
                    pin = txtPIN.Text,
                    country=cbCountry.Text,
                    telephone = txtPhone.Text,
                    email = txtEmail.Text,
                    website =txtWebsite.Text,
                    zip = txtZipCode.Text,
 
                };

                context.company_details.Add(companydetails);
                var company = (from company_details in context.company_details
                                     where company_details.pin == txtPIN.Text //code ammended to always update details of a company with the assumption that we always have one company we are working on
                                     select new { company_details.name }).ToList();
                if (company.Count == 1)
                {
                    context.Entry(companydetails).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                    MessageBox.Show("Company Details Updated Successfully", this.Text, MessageBoxButtons.OK);


                }
                else
                {
                    context.SaveChanges();
                    MessageBox.Show("Company Details submitted Successfully", this.Text, MessageBoxButtons.OK);
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
        private void getCompany()
        {
            var context = new sleekbillEntities();
            var company = (from company_details in context.company_details select company_details).FirstOrDefault();
            if (company != null)
            {
                txtEmail.Text= company.email;
                txtWebsite.Text= company.website;
                txtZipCode.Text= company.zip;
                txtName.Text= company.name;
                txtAddress.Text= company.address;
                txtPhone.Text= company.telephone;
                txtPIN.Text= company.pin;
                lbl_id.Text = company.id.ToString();
                
            }

        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            getCompany();
        }
    }
}
