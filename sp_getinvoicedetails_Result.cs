//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartBill
{
    using System;
    
    public partial class sp_getinvoicedetails_Result
    {
        public long number { get; set; }
        public System.DateTime issue_date { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
        public string product_name { get; set; }
        public int product_id { get; set; }
        public double quantity { get; set; }
        public string type { get; set; }
        public decimal price { get; set; }
        public Nullable<decimal> PAmount { get; set; }
        public Nullable<decimal> pTax { get; set; }
        public string client_name { get; set; }
        public string code { get; set; }
        public string client_billingaddress { get; set; }
        public string billing_city { get; set; }
        public string client_phone { get; set; }
        public string company_address { get; set; }
        public string company_county { get; set; }
        public string company_email { get; set; }
        public string company_name { get; set; }
        public string company_pin { get; set; }
        public string company_zip { get; set; }
        public string company_phone { get; set; }
    }
}
