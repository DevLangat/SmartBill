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
    
    public partial class invoice_payments
    {
        public int id { get; set; }
        public Nullable<int> payment_id { get; set; }
        public string invoice_id { get; set; }
        public decimal amount { get; set; }
        public bool deleted { get; set; }
        public Nullable<int> credit_note_id { get; set; }
        public Nullable<int> payment_document_id { get; set; }
        public string Receiptno { get; set; }
        public string PaymentMode { get; set; }
    }
}
