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
    
    public partial class sp_getcustomestatements_Result
    {
        public System.DateTime INVOICE_DATE { get; set; }
        public string Status { get; set; }
        public long INVOICE_NO_ { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<System.DateTime> PAYMENT_DATE { get; set; }
        public string RECEIVING_BANK { get; set; }
        public string TRANS_NO { get; set; }
        public Nullable<decimal> Amount_KES_ { get; set; }
        public Nullable<double> EXPECTED_PAYMENT__LESS_WHT__KSH_ { get; set; }
        public Nullable<double> EXPECTED_WITHHOLDING_TAX__KSH_ { get; set; }
        public Nullable<decimal> PAYMENT_RECEIVED { get; set; }
        public Nullable<decimal> BALANCE { get; set; }
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
