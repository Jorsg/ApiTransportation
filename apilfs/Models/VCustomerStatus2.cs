using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class VCustomerStatus2
    {
        public string ModeGroup { get; set; }
        public string BusinessUnit { get; set; }
        public string Bol { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public int? SrkDate { get; set; }
        public decimal? TotalRevenue { get; set; }
        public string Lane { get; set; }
        public int? Year { get; set; }
        public string MonthName { get; set; }
    }
}
