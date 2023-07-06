using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.DTO.Quote;
using apilfs.Models;

namespace apilfs.DTO
{
    public class QuotesDto
    {
        public int Id { get; set; }
        public string IdQuoteYAT { get; set; }
        public string IdQuoteSaas { get; set; }
        public DateTime DateQuote { get; set; }
        public int IdCustomer { get; set; }
        public string ModeGroup { get; set; }        
        public string CountryFrom { get; set; }
        public string CountryTo { get; set; }
        public string ZipCodeTo { get; set; }
        public string ZipCodeFrom { get; set; }
        public int? Unit { get; set; } 
        public bool? Hazmat { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Quantity { get; set; }
        public bool? TeamService { get; set; } 
        public bool? CrossBorder { get; set; }
        public decimal? TotalCargoValue { get; set; }
        public bool? InsureFreight { get; set; }
        public string User { get; set; }
        public decimal? LinearFeet { get; set; }
        public bool? Reefer { get; set; }
        public bool? OutOfGauge { get; set; }
        public decimal? Miles { get; set; }
        public int? TypeTruck { get; set; }
        public string Direction { get; set; }
        public List<AccesorialsPerQuotesDto> AccessorialsPerQuote { get; set; }
        public List<RateQuotesDto> RatesPerQuote { get; set; }
        public BenchmarRateDto BenchmarkRate { get; set; }
        public List<ShipmentsPerQuoteDto> ShipmentsPerQuote { get; set; }      
        public List<LeastCostCarriersDto> LeastCostCarrier { get; set; } // arry
        public List<RatePerQuoteDrayageDto> RatesPerQuoteDrayage { get; set; }
    }

    public class MapingQuotes
    {
        public Models.Quote MapiQuotes(QuotesDto quotesDto)
        {
            Models.Quote _quote = new Models.Quote();
            _quote.IdQuoteYat = quotesDto.IdQuoteYAT;
            _quote.DateQuote = quotesDto.DateQuote;
            _quote.IdCustomer = quotesDto.IdCustomer;
            _quote.IdModeGroup = Convert.ToInt32(quotesDto.ModeGroup); 
            _quote.IdTypeTruck = quotesDto.TypeTruck;
            _quote.IdQuoteSaas = quotesDto.IdQuoteSaas;           
            _quote.IdUnit = quotesDto.Unit;
            _quote.IdZipCodeFrom = Convert.ToInt32(quotesDto.ZipCodeFrom);
            _quote.IdZipCodeTo = Convert.ToInt32(quotesDto.ZipCodeTo);
            _quote.Quantity = quotesDto.Quantity;
            _quote.TeamService = quotesDto.TeamService;
            _quote.TotalCargoValue = quotesDto.TotalCargoValue;
            _quote.User = quotesDto.User;
            _quote.Weight = quotesDto.Weight;          
            _quote.Hazmat = quotesDto.Hazmat;
            _quote.Id = quotesDto.Id;
            _quote.LinearFeet = quotesDto.LinearFeet;
            _quote.Miles = quotesDto.Miles;
            _quote.OutOfGauge = quotesDto.OutOfGauge;
            _quote.InsureFreight = quotesDto.InsureFreight;
            _quote.Reefer = quotesDto.Reefer;
            _quote.CrossBorder = quotesDto.CrossBorder;
            _quote.Direction = quotesDto.Direction;            

            return _quote;
        }
    }
}
