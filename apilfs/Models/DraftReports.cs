using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Models
{
    public class DraftReports
    {
        public string Bol { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DateOfQuote { get; set; }
        public int TransitTime { get; set; }
        public string ServiceType { get; set; }
        public string Carrier { get; set; }
        public string Valor { get; set; }
    }
}
