using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class DraftSelectedQuote
    {
        public int Id { get; set; }
        public int IdDraft { get; set; }
        public decimal? CargoInsurance { get; set; }
        public string RateId { get; set; }
        public int? CarrierId { get; set; }
        public string Scac { get; set; }
        public decimal? GrossCharge { get; set; }
        public decimal? MinInsuredCost { get; set; }
        public decimal? NetCharge { get; set; }
        public decimal? FuelSurcharge { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TotalShipmentCost { get; set; }
        public decimal? NetPricesTotalShipmentCost { get; set; }
        public decimal? NetPricesFuelSurcharge { get; set; }
        public decimal? NetPricesGrossCharge { get; set; }
        public decimal? NetPricesDiscount { get; set; }
        public decimal? NetPricesAccessorialCharges { get; set; }
        public int? TransitDays { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string ServiceLevelDescription { get; set; }
        public DateTime? ForPickupAfter { get; set; }
        public DateTime? ForPickupBy { get; set; }
        public decimal? AllInRate { get; set; }
        public decimal? FuelRate { get; set; }
        public decimal? LinehaulRate { get; set; }
        public decimal? AccessorialCost { get; set; }
        public decimal? AllInPlusAccessorialRate { get; set; }
        public decimal? StrikeAllInRate { get; set; }
        public decimal? StrikeFuelRate { get; set; }
        public decimal? StrikeLinehaulRate { get; set; }
        public decimal? StrikeAccessorialCost { get; set; }
        public decimal? StrikeAllInPlusAccessorialRate { get; set; }
        public string Rate { get; set; }
        public decimal? DirectRate { get; set; }
        public string DirectRateOperation { get; set; }
        public decimal? DirectRateNetPrice { get; set; }
        public decimal? DirectRateCargoInsurance { get; set; }
        public decimal? DirectRateMinInsuredCost { get; set; }
        public decimal? TransbordRate { get; set; }
        public string TransbordRateOperation { get; set; }
        public decimal? TransbordRateNetPrice { get; set; }
        public decimal? TransbordRateCargoInsurance { get; set; }
        public decimal? TransbordRateMinInsuredCost { get; set; }
        public string SelectedMexicoRate { get; set; }
        public decimal? TotalCost { get; set; }
        public string CarrierQuoteNumber { get; set; }
    }
}
