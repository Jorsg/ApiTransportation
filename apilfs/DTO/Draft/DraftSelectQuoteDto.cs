using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Draft
{
    public class DraftSelectQuoteDto
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
        public decimal? all_in_rate { get; set; }
        public decimal? fuel_rate { get; set; }
        public decimal? linehaul_rate { get; set; }
        public decimal? accessorial_cost { get; set; }
        public decimal? all_in_plus_accessorial_rate { get; set; }
        public decimal? strike_all_in_rate { get; set; }
        public decimal? strike_fuel_rate { get; set; }
        public decimal? strike_linehaul_rate { get; set; }
        public decimal? strike_accessorial_cost { get; set; }
        public decimal? strike_all_in_plus_accessorial_rate { get; set; }
        public string rate { get; set; }
        public decimal? direct_rate { get; set; }
        public string direct_rate_operation { get; set; }
        public decimal? direct_rate_net_price { get; set; }
        public decimal? direct_rate_cargo_insurance { get; set; }
        public decimal? direct_rate_min_insured_cost { get; set; }
        public decimal? transbord_rate { get; set; }
        public string transbord_rate_operation { get; set; }
        public decimal? transbord_rate_net_price { get; set; }
        public decimal? transbord_rate_cargo_insurance { get; set; }
        public decimal? transbord_rate_min_insured_cost { get; set; }
        public string selectedMexicoRate { get; set; }
        public decimal? TotalCost { get; set; }
        public string carrierQuoteNumber { get; set; }
        public List<DraftAccesorialsChargeDto> accessorialCharges { get; set; }

    }

    public class MapinSelectedQuote
    {
        public DraftSelectedQuote MapinDtoToEntity(DraftSelectQuoteDto draftSelect, int idDraft)
        {          
          
            DraftSelectedQuote quote = new DraftSelectedQuote();
            quote.AccessorialCost = draftSelect.accessorial_cost;
            quote.AllInPlusAccessorialRate = draftSelect.all_in_plus_accessorial_rate;
            quote.AllInRate = draftSelect.all_in_rate;
            quote.CargoInsurance = draftSelect.CargoInsurance;
            quote.CarrierId = draftSelect.CarrierId;
            quote.DeliveryDate = draftSelect.DeliveryDate;
            quote.Discount = draftSelect.Discount;
            quote.ForPickupAfter = draftSelect.ForPickupAfter;
            quote.ForPickupBy = draftSelect.ForPickupBy;
            quote.FuelRate = draftSelect.fuel_rate;
            quote.FuelSurcharge = draftSelect.FuelSurcharge;
            quote.GrossCharge = draftSelect.GrossCharge;
            quote.IdDraft = idDraft;
            quote.LinehaulRate = draftSelect.linehaul_rate;
            quote.MinInsuredCost = draftSelect.MinInsuredCost;
            quote.NetCharge = draftSelect.NetCharge;
            quote.NetPricesAccessorialCharges = draftSelect.NetPricesAccessorialCharges;
            quote.NetPricesDiscount = draftSelect.NetPricesDiscount;
            quote.NetPricesFuelSurcharge = draftSelect.NetPricesFuelSurcharge;
            quote.NetPricesGrossCharge = draftSelect.NetPricesGrossCharge;
            quote.NetPricesTotalShipmentCost = draftSelect.NetPricesTotalShipmentCost;
            quote.RateId = draftSelect.RateId;
            quote.Scac = draftSelect.Scac;
            quote.ServiceLevelDescription = draftSelect.ServiceLevelDescription;
            quote.StrikeAccessorialCost = draftSelect.strike_accessorial_cost;
            quote.StrikeAllInPlusAccessorialRate = draftSelect.strike_all_in_plus_accessorial_rate;
            quote.StrikeAllInRate = draftSelect.strike_all_in_rate;
            quote.StrikeFuelRate = draftSelect.strike_fuel_rate;
            quote.StrikeLinehaulRate = draftSelect.strike_linehaul_rate;
            quote.TotalShipmentCost = draftSelect.TotalShipmentCost;
            quote.TransitDays = draftSelect.TransitDays;
            quote.Rate = draftSelect.rate;
            quote.DirectRate = draftSelect.direct_rate;
            quote.DirectRateOperation = draftSelect.direct_rate_operation;
            quote.DirectRateNetPrice = draftSelect.direct_rate_net_price;
            quote.DirectRateCargoInsurance = draftSelect.direct_rate_cargo_insurance;
            quote.DirectRateMinInsuredCost = draftSelect.direct_rate_min_insured_cost;
            quote.TransbordRate = draftSelect.transbord_rate;
            quote.TransbordRateOperation = draftSelect.transbord_rate_operation;
            quote.TransbordRateNetPrice = draftSelect.transbord_rate_net_price;
            quote.TransbordRateCargoInsurance = draftSelect.transbord_rate_cargo_insurance;
            quote.TransbordRateMinInsuredCost = draftSelect.transbord_rate_min_insured_cost;
            quote.SelectedMexicoRate = draftSelect.selectedMexicoRate;
            quote.TotalCost = draftSelect.TotalCost;
            quote.CarrierQuoteNumber = draftSelect.carrierQuoteNumber;
            quote.Id = draftSelect.Id;

            return quote;
        }
    }
}
