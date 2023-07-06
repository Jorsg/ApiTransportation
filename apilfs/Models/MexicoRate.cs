using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class MexicoRate
    {
        public int Id { get; set; }
        public int IdCityFrom { get; set; }
        public int IdCityTo { get; set; }
        public int? IdTypeTruck { get; set; }
        public int IdServiceMode { get; set; }
        public string Operation { get; set; }
        public string Tt { get; set; }
        public decimal Cost { get; set; }
        public decimal Empty { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        public decimal? Sale { get; set; }

        public virtual City IdCityFromNavigation { get; set; }
        public virtual City IdCityToNavigation { get; set; }
        public virtual ServiceMode IdServiceModeNavigation { get; set; }
        public virtual TypeTruck IdTypeTruckNavigation { get; set; }
    }
}
