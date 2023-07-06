using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class LeastCostCarrier
    {
        public LeastCostCarrier()
        {
            AccessorialsPerLeastCostCarriers = new HashSet<AccessorialsPerLeastCostCarrier>();
        }

        public int Id { get; set; }
        public int IdQuote { get; set; }
        public int? IdVendor { get; set; }
        public decimal? GrossCharge { get; set; }
        public decimal? NetCharge { get; set; }
        public decimal? FuelSurcharge { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TotalShipmentCost { get; set; }
        public decimal? TransitDays { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public decimal? DiscountRate { get; set; }
        public string CarrierQuoteNo { get; set; }
        public string ApiCallDuration { get; set; }
        public decimal? CargoInsurance { get; set; }
        public int? IdMode { get; set; }
        public string RateId { get; set; }
        public decimal? MinInsuredCost { get; set; }
        public string ModeDescription { get; set; }
        public bool QuoteHistory { get; set; }

        public virtual Mode IdModeNavigation { get; set; }
        public virtual Quote IdQuoteNavigation { get; set; }
        public virtual Vendor IdVendorNavigation { get; set; }
        public virtual ICollection<AccessorialsPerLeastCostCarrier> AccessorialsPerLeastCostCarriers { get; set; }
    }
}
