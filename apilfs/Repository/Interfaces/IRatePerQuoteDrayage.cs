using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IRatePerQuoteDrayage
    {
        IQueryable<Models.RatesPerQuoteDrayage> GetRatesPerQuotesDrayage();

        IQueryable<Models.RatesPerQuoteDrayage> GetRatesPerQuotesDrayage(int id);

        bool InsertQuoteDrayage(DTO.Quote.RatePerQuoteDrayageDto drayageDto, int idRate);

        void Save();
        
        bool UpdateQuoteDrayage(DTO.Quote.UpdateQuote quote);
    }
}
