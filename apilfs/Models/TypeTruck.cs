using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class TypeTruck
    {
        public TypeTruck()
        {
            AccesorialTypeTrucks = new HashSet<AccesorialTypeTruck>();
            CrossBorderCosts = new HashSet<CrossBorderCost>();
            MexicoRates = new HashSet<MexicoRate>();
            Quotes = new HashSet<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdModeGroup { get; set; }
        public string ServiceCodeYat { get; set; }

        public virtual ModeGroup IdModeGroupNavigation { get; set; }
        public virtual ICollection<AccesorialTypeTruck> AccesorialTypeTrucks { get; set; }
        public virtual ICollection<CrossBorderCost> CrossBorderCosts { get; set; }
        public virtual ICollection<MexicoRate> MexicoRates { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
    }
}
