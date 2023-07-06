using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class VCustomerBilling
    {
        public string CompanyName { get; set; }
        public string DocumentType { get; set; }
        public string Invoice { get; set; }
        public DateTime? Issued { get; set; }
        public DateTime? DueDate { get; set; }
        public string Bol { get; set; }
        public string Code { get; set; }
        public string NameCustomer { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Pending { get; set; }
        public int? OverDays { get; set; }
        public decimal? Future { get; set; }
        public decimal? _130Days { get; set; }
        public decimal? _3160Days { get; set; }
        public decimal? _6190Days { get; set; }
        public decimal? _91120Days { get; set; }
        public decimal? _121Days { get; set; }
        public string Status { get; set; }
        public string ReferenceBol { get; set; }
        public string Reference2 { get; set; }
        public string InvoiceStatus { get; set; }
    }
}
