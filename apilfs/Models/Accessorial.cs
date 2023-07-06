using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Accessorial
    {
        public Accessorial()
        {
            AccesorialTypeTrucks = new HashSet<AccesorialTypeTruck>();
            AccessorialsPerLeastCostCarriers = new HashSet<AccessorialsPerLeastCostCarrier>();
            AccessorialsPerQuotes = new HashSet<AccessorialsPerQuote>();
        }

        public int Id { get; set; }
        public string AccessorialCode { get; set; }
        public string Name { get; set; }
        public string IdYat { get; set; }
        public string IdSaas { get; set; }
        public string IdSwanLeap { get; set; }
        public decimal? Cost { get; set; }
        public string NameYat { get; set; }
        public string NameSaas { get; set; }
        public string NameSwanLeap { get; set; }
        public bool? CheckAccesorials { get; set; }
        public int? IdModegroup { get; set; }
        public string Type { get; set; }

        public virtual ModeGroup IdModegroupNavigation { get; set; }
        public virtual ICollection<AccesorialTypeTruck> AccesorialTypeTrucks { get; set; }
        public virtual ICollection<AccessorialsPerLeastCostCarrier> AccessorialsPerLeastCostCarriers { get; set; }
        public virtual ICollection<AccessorialsPerQuote> AccessorialsPerQuotes { get; set; }
    }
}
