using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class ExceptionsAppliedPerRate
    {
        public int Id { get; set; }
        public string ExceptionName { get; set; }
        public string Mode { get; set; }
        public decimal? Value { get; set; }
        public decimal? LinehaulRateDelta { get; set; }
        public decimal? FuelRateDelta { get; set; }
        public decimal? AllInRateDelta { get; set; }
        public int IdRate { get; set; }
        public string CustomerOrCarrier { get; set; }

        public virtual RatesPerQuote IdRateNavigation { get; set; }
    }
}
