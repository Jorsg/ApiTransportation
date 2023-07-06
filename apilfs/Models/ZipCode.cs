using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class ZipCode
    {
        public ZipCode()
        {
            CongestionNotes = new HashSet<CongestionNote>();
            PortsRamps = new HashSet<PortsRamp>();
            QuoteIdZipCodeFromNavigations = new HashSet<Quote>();
            QuoteIdZipCodeToNavigations = new HashSet<Quote>();
        }

        public int Id { get; set; }
        public string ZipCode1 { get; set; }
        public string City { get; set; }
        public string FullZipCode { get; set; }
        public string TimeZone { get; set; }
        public string DaylightSaving { get; set; }
        public int IdState { get; set; }

        public virtual State IdStateNavigation { get; set; }
        public virtual ICollection<CongestionNote> CongestionNotes { get; set; }
        public virtual ICollection<PortsRamp> PortsRamps { get; set; }
        public virtual ICollection<Quote> QuoteIdZipCodeFromNavigations { get; set; }
        public virtual ICollection<Quote> QuoteIdZipCodeToNavigations { get; set; }
    }
}
