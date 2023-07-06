using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Models
{
    public class ZipCodeByState
    {
        public int Id { get; set; }
        public string ZipCode1 { get; set; }
        public string City { get; set; }
        public string FullZipCode { get; set; }
        public string TimeZone { get; set; }
        public string DaylightSaving { get; set; }
        public string CountryIsoCode2 { get; set; }
        public string CountryIsoCode3 { get; set; }
        public string State { get; set; }
        public int IdState { get; set; }
    }
}
