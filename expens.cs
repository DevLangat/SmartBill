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
    
    public partial class expens
    {
        public int id { get; set; }
        public string number { get; set; }
        public string number_prefix { get; set; }
        public string issue_date { get; set; }
        public Nullable<int> company_details_id { get; set; }
        public Nullable<int> client_id { get; set; }
        public string total_no_tax { get; set; }
        public string total_tax { get; set; }
        public string total_all { get; set; }
        public string internal_notes { get; set; }
        public string expense_notes { get; set; }
        public Nullable<int> vendor_id { get; set; }
        public string vendor_name { get; set; }
        public string vendor_code { get; set; }
        public string vendor_email { get; set; }
        public string vendor_phone { get; set; }
        public string vendor_contact { get; set; }
        public string vendor_billing_address { get; set; }
        public string vendor_billing_zip { get; set; }
        public string vendor_billing_city { get; set; }
        public string vendor_shipping_address { get; set; }
        public string vendor_shipping_zip { get; set; }
        public string vendor_shipping_city { get; set; }
        public Nullable<int> vendor_billing_state_id { get; set; }
        public Nullable<int> vendor_shipping_state_id { get; set; }
        public string deleted { get; set; }
        public Nullable<int> flag_id { get; set; }
        public string gst_type { get; set; }
        public Nullable<int> supply_state_id { get; set; }
        public string fiscal_year { get; set; }
        public Nullable<bool> reverse_charges { get; set; }
    }
}
