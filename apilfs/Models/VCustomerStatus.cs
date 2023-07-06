using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class VCustomerStatus
    {
        public string ModeGroup { get; set; }
        public string BusinessUnit { get; set; }
        public string Bol { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string SrkDate { get; set; }
        public decimal? TotalRevenue { get; set; }
        public int? Shipments { get; set; }
        public decimal? AvgTicket { get; set; }
        public string Lane { get; set; }
        public int? Year { get; set; }
        public string MonthName { get; set; }
        public decimal? LeadTime { get; set; }
        public int? Canceled { get; set; }
        public int? OnTime { get; set; }
        public decimal? AvgDistance { get; set; }
        public decimal? AvgWeight { get; set; }
        public decimal? Cost { get; set; }
        public decimal? InvoiceAccuracy { get; set; }
        public decimal OnTimeDelivery { get; set; }
        public decimal Canceled1 { get; set; }
        public decimal AvgLeadTime { get; set; }
        public decimal AvgCostperPound { get; set; }
        public decimal AvgCostperMile { get; set; }
    }
}
