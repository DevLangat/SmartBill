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
    
    public partial class bill_products
    {
        public int id { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<int> bill_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string measuring_unit { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public Nullable<bool> has_tax_included { get; set; }
        public Nullable<int> tax_id { get; set; }
        public string total_no_tax { get; set; }
        public string total_tax { get; set; }
        public string total_all { get; set; }
        public Nullable<bool> is_discount { get; set; }
        public int discount_percentage { get; set; }
        public string type { get; set; }
        public string sku { get; set; }
        public string purchase_rate { get; set; }
        public string hsn { get; set; }
        public string sac { get; set; }
        public Nullable<bool> use_inline_discount { get; set; }
        public int cess_percentage { get; set; }
        public string cess_value { get; set; }
    }
}
