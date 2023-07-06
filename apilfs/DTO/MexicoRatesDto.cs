using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.DTO
{
    public class MexicoRatesDto
    {
        public int Id { get; set; }
        public int IdCityFrom { get; set; }
        public int IdCityTo { get; set; }
        public int? IdTypeTruck { get; set; }
        public string TypeTruck { get; set; }
        public int IdServiceMode { get; set; }
        public string ServiceMode { get; set; }
        public string Operation { get; set; }
        public string TT { get; set; }
        public decimal Cost { get; set; }
        public decimal? Sale { get; set; }
        public decimal Empty { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }

    }
}
