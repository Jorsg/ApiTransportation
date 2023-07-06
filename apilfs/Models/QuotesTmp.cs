using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class QuotesTmp
    {
        public int Id { get; set; }
        public string IdQuoteYat { get; set; }
        public int IdCustomer { get; set; }
        public string IdQuoteSaas { get; set; }
        public int IdModeGroup { get; set; }
        public int? IdMode { get; set; }
        public int IdCountryFrom { get; set; }
        public int? IdStateFrom { get; set; }
        public string CityFrom { get; set; }
        public int IdZipCodeFrom { get; set; }
        public int IdCountryTo { get; set; }
        public int? IdStateTo { get; set; }
        public string CityTo { get; set; }
        public int IdZipCodeTo { get; set; }
        public DateTime? DateQuote { get; set; }
        public decimal? Quantity { get; set; }
        public int? IdUnit { get; set; }
        public decimal? Weight { get; set; }
        public bool? Hazmat { get; set; }
        public bool? TeamService { get; set; }
        public bool? CrossBorder { get; set; }
        public decimal? TotalCargoValue { get; set; }
        public string User { get; set; }
        public bool? InsureFreight { get; set; }
    }
}
