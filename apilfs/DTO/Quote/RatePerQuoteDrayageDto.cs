using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Quote
{
    public class RatePerQuoteDrayageDto
    {
        public int Id { get; set; }
        public string Rate { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? CargoInsurance { get; set; }
        public decimal? MinInsuredCost { get; set; }
        public string RateId { get; set; }
        public int IdQuote { get; set; }
        public bool QuoteHistory { get; set; }
    }

    public class MapingRatePerQuoteDrayage
    {
        public RatesPerQuoteDrayage MapinDtoToEntity(DTO.Quote.RatePerQuoteDrayageDto ratePerQuote, int idQuote)
        {
            RatesPerQuoteDrayage _dto = new RatesPerQuoteDrayage();
            _dto.CargoInsurance = ratePerQuote.CargoInsurance;
            _dto.IdQuote = idQuote;
            _dto.MinInsuredCost = ratePerQuote.MinInsuredCost;
            _dto.Rate = ratePerQuote.Rate;
            _dto.RateId = ratePerQuote.RateId;
            _dto.TotalCost = ratePerQuote.TotalCost;
            _dto.QuoteHistory = ratePerQuote.QuoteHistory;

            return _dto;
        }
    }
}
