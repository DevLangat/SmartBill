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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class sleekbillEntities : DbContext
    {
        public sleekbillEntities()
            : base("name=sleekbillEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bill_payments> bill_payments { get; set; }
        public virtual DbSet<bill_products> bill_products { get; set; }
        public virtual DbSet<bill> bills { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<client_vendor_conversions> client_vendor_conversions { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<company_details> company_details { get; set; }
        public virtual DbSet<credit_note_products> credit_note_products { get; set; }
        public virtual DbSet<credit_notes> credit_notes { get; set; }
        public virtual DbSet<currency> currencies { get; set; }
        public virtual DbSet<debit_note_payments> debit_note_payments { get; set; }
        public virtual DbSet<debit_note_products> debit_note_products { get; set; }
        public virtual DbSet<debit_notes> debit_notes { get; set; }
        public virtual DbSet<estimate> estimates { get; set; }
        public virtual DbSet<estimate_conversions> estimate_conversions { get; set; }
        public virtual DbSet<estimate_payments> estimate_payments { get; set; }
        public virtual DbSet<estimate_products> estimate_products { get; set; }
        public virtual DbSet<expense_items> expense_items { get; set; }
        public virtual DbSet<expense_products> expense_products { get; set; }
        public virtual DbSet<expens> expenses { get; set; }
        public virtual DbSet<facturi_stornate> facturi_stornate { get; set; }
        public virtual DbSet<fisc_year> fisc_year { get; set; }
        public virtual DbSet<flag> flags { get; set; }
        public virtual DbSet<gst_port_codes> gst_port_codes { get; set; }
        public virtual DbSet<invoice_payments> invoice_payments { get; set; }
        public virtual DbSet<invoice_products> invoice_products { get; set; }
        public virtual DbSet<invoice> invoices { get; set; }
        public virtual DbSet<packing_slip_conversions> packing_slip_conversions { get; set; }
        public virtual DbSet<packing_slip_products> packing_slip_products { get; set; }
        public virtual DbSet<packing_slips> packing_slips { get; set; }
        public virtual DbSet<page_size> page_size { get; set; }
        public virtual DbSet<payment_documents> payment_documents { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<purchase_order> purchase_order { get; set; }
        public virtual DbSet<purchase_order_conversions> purchase_order_conversions { get; set; }
        public virtual DbSet<purchase_order_products> purchase_order_products { get; set; }
        public virtual DbSet<release_notes> release_notes { get; set; }
        public virtual DbSet<service_tax_services> service_tax_services { get; set; }
        public virtual DbSet<state> states { get; set; }
        public virtual DbSet<stock_history> stock_history { get; set; }
        public virtual DbSet<stock> stocks { get; set; }
        public virtual DbSet<tax_combo> tax_combo { get; set; }
        public virtual DbSet<tax> taxes { get; set; }
        public virtual DbSet<tip> tips { get; set; }
        public virtual DbSet<vendor> vendors { get; set; }
        public virtual DbSet<version> versions { get; set; }
        public virtual DbSet<config> configs { get; set; }
        public virtual DbSet<tmpinvdata> tmpinvdatas { get; set; }
        public virtual DbSet<tmpinvdata1> tmpinvdata1 { get; set; }
        public virtual DbSet<tmppayment> tmppayments { get; set; }
        public virtual DbSet<tmpReceiptsdata> tmpReceiptsdatas { get; set; }
        public virtual DbSet<tmpstatementdata> tmpstatementdatas { get; set; }
    
        public virtual ObjectResult<sp_getcustomestatements_Result> sp_getcustomestatements(string client_code)
        {
            var client_codeParameter = client_code != null ?
                new ObjectParameter("client_code", client_code) :
                new ObjectParameter("client_code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getcustomestatements_Result>("sp_getcustomestatements", client_codeParameter);
        }
    
        public virtual ObjectResult<sp_getinvoicedetails_Result> sp_getinvoicedetails(Nullable<int> inv)
        {
            var invParameter = inv.HasValue ?
                new ObjectParameter("inv", inv) :
                new ObjectParameter("inv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getinvoicedetails_Result>("sp_getinvoicedetails", invParameter);
        }
    
        public virtual ObjectResult<sp_getinvoices_Result> sp_getinvoices(Nullable<int> invoiceno)
        {
            var invoicenoParameter = invoiceno.HasValue ?
                new ObjectParameter("invoiceno", invoiceno) :
                new ObjectParameter("invoiceno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getinvoices_Result>("sp_getinvoices", invoicenoParameter);
        }
    
        public virtual int sp_getinvoicesforpayment()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_getinvoicesforpayment");
        }
    
        public virtual ObjectResult<sp_getReceiptdetails_Result> sp_getReceiptdetails(string recNo, Nullable<int> inv)
        {
            var recNoParameter = recNo != null ?
                new ObjectParameter("recNo", recNo) :
                new ObjectParameter("recNo", typeof(string));
    
            var invParameter = inv.HasValue ?
                new ObjectParameter("inv", inv) :
                new ObjectParameter("inv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getReceiptdetails_Result>("sp_getReceiptdetails", recNoParameter, invParameter);
        }
    
        public virtual int sp_getStatement(string custId, Nullable<System.DateTime> startdate, Nullable<System.DateTime> enddate, Nullable<int> serv)
        {
            var custIdParameter = custId != null ?
                new ObjectParameter("custId", custId) :
                new ObjectParameter("custId", typeof(string));
    
            var startdateParameter = startdate.HasValue ?
                new ObjectParameter("startdate", startdate) :
                new ObjectParameter("startdate", typeof(System.DateTime));
    
            var enddateParameter = enddate.HasValue ?
                new ObjectParameter("enddate", enddate) :
                new ObjectParameter("enddate", typeof(System.DateTime));
    
            var servParameter = serv.HasValue ?
                new ObjectParameter("serv", serv) :
                new ObjectParameter("serv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_getStatement", custIdParameter, startdateParameter, enddateParameter, servParameter);
        }
    }
}
