using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Servicios.Interfaces
{
    public interface IQuoteServices
    {

        IQueryable<DTO.QuotesDto> GetQuoteHistory();

        IQueryable<DTO.QuotesDto> GetQuoteHistory(int id);
    }
}
