using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.DTO
{
    public class RequestBodyMexicoRatesDto
    {
        public string FromZipCode { get; set; }
        public string FromCountry { get; set; }
        public string ToZipCode { get; set; }
        public string ToCountry { get; set; }
        public int IdTypeTruck { get; set; }
    }
}
