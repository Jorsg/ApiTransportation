using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class CongestionNote
    {
        public int Id { get; set; }
        public string PortRamp { get; set; }
        public int IdZipcode { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public string Note4 { get; set; }
        public string Note5Internal { get; set; }
        public string Rate1 { get; set; }
        public string Rate2 { get; set; }
        public string Rate3 { get; set; }
        public decimal? Rate1Percentage { get; set; }
        public decimal? Rate2Percentage { get; set; }
        public decimal? Rate3Percentage { get; set; }

        public virtual ZipCode IdZipcodeNavigation { get; set; }
    }
}
