using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.DTO;

namespace apilfs.Repository.Interfaces
{
    public interface IQuote
    {
        IQueryable<apilfs.Models.Quote> GetQuotes();

        IQueryable<apilfs.Models.Quote> GetQuotes(int id);

       int InsertQuote(DTO.QuotesDto quote);       

        bool UpdateQuote(Models.Quote quote);

        void Save();

       
    }
}
