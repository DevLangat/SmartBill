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
    using System.Collections.Generic;
    
    public partial class packing_slips
    {
        public int id { get; set; }
        public string number { get; set; }
        public string issue_date { get; set; }
        public string invoice_number { get; set; }
        public string invoice_issue_date { get; set; }
        public Nullable<int> company_details_id { get; set; }
        public Nullable<int> client_id { get; set; }
        public string client_name { get; set; }
        public string client_code { get; set; }
        public string client_email { get; set; }
        public string client_phone { get; set; }
        public string client_contact { get; set; }
        public string client_billing_address { get; set; }
        public string client_billing_zip { get; set; }
        public string client_billing_city { get; set; }
        public string client_shipping_address { get; set; }
        public string client_shipping_zip { get; set; }
        public string client_shipping_city { get; set; }
        public string packing_slip_notes { get; set; }
        public string deleted { get; set; }
        public string color { get; set; }
        public string logo { get; set; }
        public Nullable<int> page_size_id { get; set; }
        public Nullable<int> flag_id { get; set; }
        public int layout { get; set; }
        public int print_id { get; set; }
        public Nullable<int> invoice_id { get; set; }
        public string client_shipping_name { get; set; }
        public Nullable<int> client_billing_state_id { get; set; }
        public Nullable<int> client_shipping_state_id { get; set; }
        public string fiscal_year { get; set; }
    }
}
