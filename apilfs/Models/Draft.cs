using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Draft
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string BolSwanleap { get; set; }
        public bool? BookWithAgent { get; set; }
        public decimal Weight { get; set; }
        public string ModeGroup { get; set; }
        public bool? Hazmat { get; set; }
        public string SpecialInstructions { get; set; }
        public bool AcceptedTC { get; set; }
        public string Status { get; set; }
        public string CustomerBillingReference { get; set; }
        public decimal? TrailerLength { get; set; }
    }
}
