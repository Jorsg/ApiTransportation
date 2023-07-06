using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.DTO.Quote;
using apilfs.Models;

namespace apilfs.DTO
{
    public class RateQuotesDto
    {
        public int Id { get; set; }
        public decimal? LowLeadTimeValue { get; set; }
        public decimal? HighLeadTimeValue { get; set; }
        public DateTime? ForPickupAfter { get; set; }
        public DateTime? ForPickupBy { get; set; }
        public int IdQuote { get; set; }
        public string CarrierPmLinehaulRate { get; set; }
        public string CarrierHighPmLinehaulRate { get; set; }
        public string CarrierLinehaulRate { get; set; }
        public string CarrierLowLinehaulRate { get; set; }
        public string CarrierHighLinehaulRate { get; set; }
        public string CarrierPmFuelRate { get; set; }
        public string CarrierFuelRate { get; set; }
        public string CarrierPmAllInRate { get; set; }
        public string CarrierLowPmAllInRate { get; set; }
        public string CarrierHighPmAllInRate { get; set; }
        public string CarrierAllInRate { get; set; }
        public string CarrierLowAllInRate { get; set; }
        public string CarrierHighAllInRate { get; set; }
        public string CarrierAccessorialCost { get; set; }
        public string CarrierAllInPlusAccessorialRate { get; set; }
        public string CustomerPmLinehaulRate { get; set; }
        public string CustomerLowPmLinehaulRate { get; set; }
        public string CustomerHighPmLinehaulRate { get; set; }
        public string CustomerLinehaulRate { get; set; }
        public string CustomerLowLinehaulRate { get; set; }
        public string CustomerHighLinehaulRate { get; set; }
        public string CustomerPmFuelRate { get; set; }
        public string CustomerFuelRate { get; set; }
        public string CustomerPmAllInRate { get; set; }
        public string CustomerLowPmAllInRate { get; set; }
        public string CustomerHighPmAllInRate { get; set; }
        public string CustomerAllInRate { get; set; }        
        public string CustomerLowAllInRate { get; set; }
        public string CustomerHighAllInRate { get; set; }
        public string CustomerAccessorialCost { get; set; }
        public string CustomerAllInPlusAccessorialRate { get; set; }
        public string CargoInsurance { get; set; }
        public bool QuoteHistory { get; set; }
        public string RateId { get; set; }
        public string CarrierLowPmLinehaulRate { get; set; }
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
        public decimal? DirectRateNetPrice { get; set; }
        public decimal? TransbordRateNetPrice { get; set; }

        public List<ExceptionsAppliedPerRateDto> ExceptionsAppliedPerRate { get; set; }

    }

    public class MapinRateQuotes
    {
       public RatesPerQuote MaperRateQuote(RateQuotesDto rateQuotesDto, int idQuote)
        {
            RatesPerQuote _rate = new RatesPerQuote();
            _rate.IdQuote = idQuote;
            _rate.CargoInsurance = Convert.ToDecimal(rateQuotesDto.CargoInsurance);
            _rate.CarrierAccessorialCost = Convert.ToDecimal(rateQuotesDto.CarrierAccessorialCost);
            _rate.CarrierAllInPlusAccessorialRate = Convert.ToDecimal(rateQuotesDto.CarrierAllInPlusAccessorialRate);
            _rate.CarrierAllInRate = Convert.ToDecimal(rateQuotesDto.CarrierAllInRate);
            _rate.CarrierFuelRate = Convert.ToDecimal(rateQuotesDto.CarrierFuelRate);
            _rate.CarrierHighAllInRate = Convert.ToDecimal(rateQuotesDto.CarrierHighAllInRate);
            _rate.CarrierHighLinehaulRate = Convert.ToDecimal(rateQuotesDto.CarrierHighLinehaulRate);
            _rate.CarrierHighPmAllInRate = Convert.ToDecimal(rateQuotesDto.CarrierHighPmAllInRate);
            _rate.CarrierHighPmLinehaulRate = Convert.ToDecimal(rateQuotesDto.CarrierHighPmLinehaulRate);
            _rate.CarrierLinehaulRate = Convert.ToDecimal(rateQuotesDto.CarrierLinehaulRate);
            _rate.CarrierLowAllInRate = Convert.ToDecimal(rateQuotesDto.CarrierLowAllInRate);
            _rate.CarrierLowLinehaulRate = Convert.ToDecimal(rateQuotesDto.CarrierLowLinehaulRate);
            _rate.CarrierLowPmAllInRate = Convert.ToDecimal(rateQuotesDto.CarrierLowPmAllInRate);
            _rate.CarrierPmAllInRate = Convert.ToDecimal(rateQuotesDto.CarrierPmAllInRate);
            _rate.CarrierPmFuelRate = Convert.ToDecimal(rateQuotesDto.CarrierPmFuelRate);
            _rate.CarrierPmLinehaulRate = Convert.ToDecimal(rateQuotesDto.CarrierPmLinehaulRate);
            _rate.CustomerAccessorialCost = Convert.ToDecimal(rateQuotesDto.CustomerAccessorialCost);
            _rate.CustomerAllInPlusAccessorialRate = Convert.ToDecimal(rateQuotesDto.CustomerAllInPlusAccessorialRate);
            _rate.CustomerAllInRate = Convert.ToDecimal(rateQuotesDto.CustomerAllInRate);
            _rate.CustomerFuelRate = Convert.ToDecimal(rateQuotesDto.CustomerFuelRate);
            _rate.CustomerHighAllInRate = Convert.ToDecimal(rateQuotesDto.CustomerHighAllInRate);
            _rate.CustomerHighLinehaulRate = Convert.ToDecimal(rateQuotesDto.CustomerHighLinehaulRate);
            _rate.CustomerHighPmAllInRate = Convert.ToDecimal(rateQuotesDto.CustomerHighPmAllInRate);
            _rate.CustomerHighPmLinehaulRate = Convert.ToDecimal(rateQuotesDto.CustomerHighPmLinehaulRate);
            _rate.CustomerLinehaulRate = Convert.ToDecimal(rateQuotesDto.CustomerLinehaulRate);
            _rate.CustomerLowAllInRate = Convert.ToDecimal(rateQuotesDto.CustomerLowAllInRate);
            _rate.CustomerLowLinehaulRate = Convert.ToDecimal(rateQuotesDto.CustomerLowLinehaulRate);
            _rate.CustomerLowPmAllInRate = Convert.ToDecimal(rateQuotesDto.CustomerLowPmAllInRate);
            _rate.CustomerLowPmLinehaulRate = Convert.ToDecimal(rateQuotesDto.CustomerLowPmLinehaulRate);
            _rate.CustomerPmAllInRate = Convert.ToDecimal(rateQuotesDto.CustomerPmAllInRate);
            _rate.CustomerPmFuelRate = Convert.ToDecimal(rateQuotesDto.CustomerPmFuelRate);
            _rate.CustomerPmLinehaulRate = Convert.ToDecimal(rateQuotesDto.CustomerPmLinehaulRate);
            _rate.ForPickupAfter = rateQuotesDto.ForPickupAfter;
            _rate.ForPickupBy = rateQuotesDto.ForPickupBy;
            _rate.HighLeadTimeValue = rateQuotesDto.HighLeadTimeValue;           
            _rate.LowLeadTimeValue = rateQuotesDto.LowLeadTimeValue;
            _rate.QuoteHistory = rateQuotesDto.QuoteHistory;
            _rate.RateId = rateQuotesDto.RateId;
            _rate.MinInsuredCost = rateQuotesDto.MinInsuredCost;
            _rate.CarrierLowPmLinehaulRate = Convert.ToDecimal(rateQuotesDto.CarrierLowPmLinehaulRate);
            _rate.DirectRate = rateQuotesDto.DirectRate;
            _rate.DirectRateCargoInsurance = rateQuotesDto.DirectRateCargoInsurance;
            _rate.DirectRateEmpty = rateQuotesDto.DirectRateEmpty;
            _rate.DirectRateMinInsuredCost = rateQuotesDto.DirectRateMinInsuredCost;
            _rate.DirectRateNetPrice = rateQuotesDto.DirectRateNetPrice;
            _rate.DirectRateOperation = rateQuotesDto.DirectRateOperation;
            _rate.DirectRateTt = rateQuotesDto.DirectRateTt;
            _rate.TransbordRate = rateQuotesDto.TransbordRate;
            _rate.TransbordRateCargoInsurance = rateQuotesDto.TransbordRateCargoInsurance;
            _rate.TransbordRateEmpty = rateQuotesDto.TransbordRateEmpty;
            _rate.TransbordRateMinInsuredCost = rateQuotesDto.TransbordRateMinInsuredCost;
            _rate.TransbordRateNetPrice = rateQuotesDto.TransbordRateNetPrice;
            _rate.TransbordRateOperation = rateQuotesDto.TransbordRateOperation;
            _rate.TransbordRateTt = rateQuotesDto.TransbordRateTt;
            
            return _rate;
        }
        
    }

   
}
