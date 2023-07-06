using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class VQuoteHistory
    {
        public int IdCustomer { get; set; }
        public int IdQuote { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime? DateOfQoute { get; set; }
    }
}
