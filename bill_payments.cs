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
    
    public partial class bill_payments
    {
        public int id { get; set; }
        public Nullable<int> payment_id { get; set; }
        public Nullable<int> bill_id { get; set; }
        public string amount { get; set; }
        public string deleted { get; set; }
        public Nullable<int> payment_document_id { get; set; }
    }
}