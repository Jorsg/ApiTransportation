using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class RatesPerQuote
    {
        public RatesPerQuote()
        {
            ExceptionsAppliedPerRates = new HashSet<ExceptionsAppliedPerRate>();
        }

        public int Id { get; set; }
        public decimal? LowLeadTimeValue { get; set; }
        public decimal? HighLeadTimeValue { get; set; }
        public int IdQuote { get; set; }
        public decimal? CarrierPmLinehaulRate { get; set; }
        public decimal? CarrierLowPmLinehaulRate { get; set; }
        public decimal? CarrierHighPmLinehaulRate { get; set; }
        public decimal? CarrierLinehaulRate { get; set; }
        public decimal? CarrierLowLinehaulRate { get; set; }
        public decimal? CarrierHighLinehaulRate { get; set; }
        public decimal? CarrierPmFuelRate { get; set; }
        public decimal? CarrierFuelRate { get; set; }
        public decimal? CarrierPmAllInRate { get; set; }
        public decimal? CarrierLowPmAllInRate { get; set; }
        public decimal? CarrierHighPmAllInRate { get; set; }
        public decimal? CarrierAllInRate { get; set; }
        public decimal? CarrierLowAllInRate { get; set; }
        public decimal? CarrierHighAllInRate { get; set; }
        public decimal? CarrierAccessorialCost { get; set; }
        public decimal? CarrierAllInPlusAccessorialRate { get; set; }
        public decimal? CustomerPmLinehaulRate { get; set; }
        public decimal? CustomerLowPmLinehaulRate { get; set; }
        public decimal? CustomerHighPmLinehaulRate { get; set; }
        public decimal? CustomerLinehaulRate { get; set; }
        public decimal? CustomerLowLinehaulRate { get; set; }
        public decimal? CustomerHighLinehaulRate { get; set; }
        public decimal? CustomerPmFuelRate { get; set; }
        public decimal? CustomerFuelRate { get; set; }
        public decimal? CustomerPmAllInRate { get; set; }
        public decimal? CustomerLowPmAllInRate { get; set; }
        public decimal? CustomerHighPmAllInRate { get; set; }
        public decimal? CustomerAllInRate { get; set; }
        public decimal? CustomerLowAllInRate { get; set; }
        public decimal? CustomerHighAllInRate { get; set; }
        public decimal? CustomerAccessorialCost { get; set; }
        public decimal? CustomerAllInPlusAccessorialRate { get; set; }
        public decimal? CargoInsurance { get; set; }
        public decimal? MinInsuredCost { get; set; }
        public decimal? DirectRate { get; set; }
        public string DirectRateOperation { get; set; }
        public string DirectRateTt { get; set; }
        public decimal? DirectRateEmpty { get; set; }
        public decimal? TransbordRate { get; set; }
        public string TransbordRateOperation { get; set; }
        public string TransbordRateTt { get; set; }
        public decimal? TransbordRateEmpty { get; set; }
        public decimal? DirectRateCargoInsurance { get; set; }
        public decimal? DirectRateMinInsuredCost { get; set; }
        public decimal? TransbordRateCargoInsurance { get; set; }
        public decimal? TransbordRateMinInsuredCost { get; set; }
        public string RateId { get; set; }
        public decimal? DirectRateNetPrice { get; set; }
        public decimal? TransbordRateNetPrice { get; set; }
        public bool QuoteHistory { get; set; }
        public DateTime? ForPickupAfter { get; set; }
        public DateTime? ForPickupBy { get; set; }

        public virtual Quote IdQuoteNavigation { get; set; }
        public virtual ICollection<ExceptionsAppliedPerRate> ExceptionsAppliedPerRates { get; set; }
    }
}
