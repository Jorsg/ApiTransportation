using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IRatesPerQuote
    {
        bool inserRatesPerQuote(DTO.RateQuotesDto ratesPerQuote, int idQuote);

        bool updateRatesPerQuote(DTO.Quote.UpdateQuote quote);

        void Save();
        
    }
}
