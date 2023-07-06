using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class CitiesTmp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public string DaylightSaving { get; set; }
        public string TimeZone { get; set; }
    }
}
