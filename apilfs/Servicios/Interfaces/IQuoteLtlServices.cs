using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Servicios.Interfaces
{
    public interface IQuoteLtlServices
    {
        int InsertQuotesLtl(DTO.QuotesDto quote);

        IQueryable<Models.Quote> GetQuotesLtl();

        IQueryable<Models.Quote> GetQuotesLtl(int id);

        bool UpdateQuotesLtl(DTO.Quote.UpdateQuote quote);
    }
}
