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
    
    public partial class vendor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string contact { get; set; }
        public string billing_address { get; set; }
        public string billing_zip { get; set; }
        public string billing_city { get; set; }
        public string shipping_address { get; set; }
        public string shipping_zip { get; set; }
        public string shipping_city { get; set; }
        public Nullable<int> billing_state_id { get; set; }
        public Nullable<int> shipping_state_id { get; set; }
        public string details { get; set; }
        public string details_public { get; set; }
        public string deleted { get; set; }
        public string tin { get; set; }
        public string pan { get; set; }
        public string vendor_code { get; set; }
        public string vat_number { get; set; }
        public string gstin { get; set; }
        public Nullable<bool> ship_my_address { get; set; }
        public Nullable<bool> SEZ { get; set; }
        public Nullable<int> currency_id { get; set; }
    }
}
