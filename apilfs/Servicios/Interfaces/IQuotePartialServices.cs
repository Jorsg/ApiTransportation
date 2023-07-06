using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Servicios.Interfaces
{
    public interface IQuotePartialServices
    {
        int InsertQuotesAll(DTO.QuotesDto quote);

        IQueryable<Models.Quote> GetQuotes();

        IQueryable<Models.Quote> GetQuotes(int id);

        bool UpdateQuotesAll(DTO.Quote.UpdateQuote quote);
    }
}
