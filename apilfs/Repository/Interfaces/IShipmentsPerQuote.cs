using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IShipmentsPerQuote
    {
        bool insertShipmentsPerQuote(DTO.Quote.ShipmentsPerQuoteDto shipmentsPerQuote, int idQuotes);

        bool updateShipmentsPerQuote(apilfs.Models.ShipmentsPerQuote shipmentsPerQuote);

        void Save();
    }
}
