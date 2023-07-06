using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class RatesPerQuoteDrayage
    {
        public int Id { get; set; }
        public string Rate { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? CargoInsurance { get; set; }
        public decimal? MinInsuredCost { get; set; }
        public string RateId { get; set; }
        public int IdQuote { get; set; }
        public bool QuoteHistory { get; set; }

        public virtual Quote IdQuoteNavigation { get; set; }
    }
}
