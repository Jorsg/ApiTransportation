using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Quote
    {
        public Quote()
        {
            AccessorialsPerQuotes = new HashSet<AccessorialsPerQuote>();
            BenchmarkRates = new HashSet<BenchmarkRate>();
            LeastCostCarriers = new HashSet<LeastCostCarrier>();
            RatesPerQuoteDrayages = new HashSet<RatesPerQuoteDrayage>();
            RatesPerQuotes = new HashSet<RatesPerQuote>();
            ShipmentsPerQuotes = new HashSet<ShipmentsPerQuote>();
        }

        public int Id { get; set; }
        public string IdQuoteYat { get; set; }
        public int IdCustomer { get; set; }
        public string IdQuoteSaas { get; set; }
        public int IdModeGroup { get; set; }
        public int? IdTypeTruck { get; set; }
        public string CityFrom { get; set; }
        public int IdZipCodeFrom { get; set; }
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
        public bool? Draft { get; set; }
        public decimal? LinearFeet { get; set; }
        public bool? Reefer { get; set; }
        public bool? OutOfGauge { get; set; }
        public decimal? Miles { get; set; }
        public string Direction { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
        public virtual ModeGroup IdModeGroupNavigation { get; set; }
        public virtual TypeTruck IdTypeTruckNavigation { get; set; }
        public virtual Unit IdUnitNavigation { get; set; }
        public virtual ZipCode IdZipCodeFromNavigation { get; set; }
        public virtual ZipCode IdZipCodeToNavigation { get; set; }
        public virtual ICollection<AccessorialsPerQuote> AccessorialsPerQuotes { get; set; }
        public virtual ICollection<BenchmarkRate> BenchmarkRates { get; set; }
        public virtual ICollection<LeastCostCarrier> LeastCostCarriers { get; set; }
        public virtual ICollection<RatesPerQuoteDrayage> RatesPerQuoteDrayages { get; set; }
        public virtual ICollection<RatesPerQuote> RatesPerQuotes { get; set; }
        public virtual ICollection<ShipmentsPerQuote> ShipmentsPerQuotes { get; set; }
    }
}
