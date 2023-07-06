using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Lane
    {
        public int Id { get; set; }
        public string FromZip { get; set; }
        public string ToZip { get; set; }
        public string FromState { get; set; }
        public string ToState { get; set; }
        public string FromCountry { get; set; }
        public string ToCountry { get; set; }
        public string MilesList { get; set; }
        public decimal? Miles { get; set; }
        public decimal? Toll { get; set; }
    }
}
