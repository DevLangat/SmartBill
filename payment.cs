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
    
    public partial class payment
    {
        public int id { get; set; }
        public string amount { get; set; }
        public string type { get; set; }
        public string note { get; set; }
        public string pay_date { get; set; }
        public string deleted { get; set; }
        public Nullable<bool> advance { get; set; }
    }
}
