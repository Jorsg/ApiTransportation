using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class DraftAccesorialsCharge
    {
        public int Id { get; set; }
        public int IdSelectedQuote { get; set; }
        public decimal? AccessorialCharge { get; set; }
        public string AccessorialDescription { get; set; }
        public string AccessorialCode { get; set; }
        public string AccessorialName { get; set; }
        public string AccessorialCode1 { get; set; }
        public decimal? DefaultRate { get; set; }
    }
}
