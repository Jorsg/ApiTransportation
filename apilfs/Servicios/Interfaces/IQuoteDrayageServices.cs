using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Servicios.Interfaces
{
    public interface IQuoteDrayageServices
    {
       int InsertQuotesDrayage(DTO.QuotesDto quote);

        IQueryable<Models.Quote> GetQuotesDrayage();

        IQueryable<Models.Quote> GetQuotesDrayage(int id);

        bool updatetQuotesDrayage(DTO.Quote.UpdateQuote quote);
    }
}
