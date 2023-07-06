using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Quote
{
    public class LeastCostCarriersDto
    {
        public int Id { get; set; }
        public int IdQuote { get; set; }
        public string SCAC { get; set; }
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
        public List<AccessorialsPerLeastCostCarriersDto> AccessorialsPerLeastCostCarriers { get; set; }
    }

    public class MapingLeastCostCarrier
    {
        public LeastCostCarrier MapingDtoToEntity(DTO.Quote.LeastCostCarriersDto leastCostCarriers, int idQuote, int? idVendor)
        {
            LeastCostCarrier _dto = new LeastCostCarrier();
            _dto.ApiCallDuration = leastCostCarriers.ApiCallDuration;
            _dto.CargoInsurance = leastCostCarriers.CargoInsurance;
            _dto.CarrierQuoteNo = leastCostCarriers.CarrierQuoteNo;
            _dto.DeliveryDate = leastCostCarriers.DeliveryDate;
            _dto.Discount = leastCostCarriers.Discount;
            _dto.DiscountRate = leastCostCarriers.DiscountRate;
            _dto.FuelSurcharge = leastCostCarriers.FuelSurcharge;
            _dto.GrossCharge = leastCostCarriers.GrossCharge;
            _dto.IdMode = leastCostCarriers.IdMode;
            _dto.IdQuote = idQuote;
            _dto.IdVendor = idVendor;
            _dto.MinInsuredCost = leastCostCarriers.MinInsuredCost;
            _dto.ModeDescription = leastCostCarriers.ModeDescription;
            _dto.NetCharge = leastCostCarriers.NetCharge;
            _dto.RateId = leastCostCarriers.RateId;
            _dto.TotalShipmentCost = leastCostCarriers.TotalShipmentCost;
            _dto.TransitDays = leastCostCarriers.TransitDays;
            _dto.QuoteHistory = leastCostCarriers.QuoteHistory;

            return _dto;
        }
    }
}
