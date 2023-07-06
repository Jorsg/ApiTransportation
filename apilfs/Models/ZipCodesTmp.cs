using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class ZipCodesTmp
    {
        public int Id { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public string FullZipCode { get; set; }
        public string TimeZone { get; set; }
        public string DaylightSaving { get; set; }
    }
}
