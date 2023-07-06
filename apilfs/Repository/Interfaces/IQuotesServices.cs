using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IQuotesServices
    {
       int InsertQuotesAll(DTO.QuotesDto quote);

        IQueryable<Models.Quote> GetQuotes();

        IQueryable<Models.Quote> GetQuotes(int id);

        bool UpdatetQuotesAll(DTO.Quote.UpdateQuote quote);
    }
}
