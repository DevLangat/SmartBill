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
    
    public partial class invoice_products
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public Nullable<int> invoice_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string measuring_unit { get; set; }
        public decimal price { get; set; }
        public double quantity { get; set; }
        public Nullable<bool> has_tax_included { get; set; }
        public Nullable<int> tax_id { get; set; }
        public Nullable<decimal> total_no_tax { get; set; }
        public Nullable<decimal> total_tax { get; set; }
        public Nullable<decimal> total_all { get; set; }
        public Nullable<bool> is_discount { get; set; }
        public string type { get; set; }
        public Nullable<decimal> purchase_rate { get; set; }
        public Nullable<decimal> cess_value { get; set; }
        public Nullable<int> discount_type { get; set; }
        public Nullable<decimal> discount_value { get; set; }
    }
}