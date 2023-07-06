using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class City
    {
        public City()
        {
            MexicoRateIdCityFromNavigations = new HashSet<MexicoRate>();
            MexicoRateIdCityToNavigations = new HashSet<MexicoRate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DaylightSaving { get; set; }
        public string TimeZone { get; set; }
        public int? IdState { get; set; }

        public virtual State IdStateNavigation { get; set; }
        public virtual ICollection<MexicoRate> MexicoRateIdCityFromNavigations { get; set; }
        public virtual ICollection<MexicoRate> MexicoRateIdCityToNavigations { get; set; }
    }
}
