using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IAccessorialsPerQuote
    {
        bool insertAccessorialsPerQuote(DTO.AccesorialsPerQuotesDto accessorialsPerQuote, int idQuotes);

        bool updateAccessorialsPerQuote(apilfs.Models.AccessorialsPerQuote accessorialsPerQuote);

        void Save();
    }
}
