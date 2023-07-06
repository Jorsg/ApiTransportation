using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class VDraft
    {
        public int? IdCustomer { get; set; }
        public string Bol { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime? DateOfQuote { get; set; }
        public string ServiceType { get; set; }
        public string Carrier { get; set; }
    }
}
