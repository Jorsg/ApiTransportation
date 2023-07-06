using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Servicios.Interfaces
{
    public interface IQuoteIncServices
    {
        int InsertQuotesInc(DTO.QuotesDto quote);

        IQueryable<Models.Quote> GetQuotesInc();

        IQueryable<Models.Quote> GetQuotesInc(int id);

        bool UpdatetQuotesInc(DTO.Quote.UpdateQuote quote);
    }
}
