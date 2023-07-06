using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO
{
    public class AccesorialsPerQuotesDto
    {
        public int IdAccesorial { get; set; }
        public string AccessorialCode { get; set; }
        public int IdQuote { get; set; }
        public string Price { get; set; }
    }

    public class MapinAccesorialsPerQuotes
    {
        public AccessorialsPerQuote MapinAccesorialPerQuote(AccesorialsPerQuotesDto accesorialquote, int idQuote, int idAccesorial)
        {
            AccessorialsPerQuote _accesorialsPerQuote = new AccessorialsPerQuote();
            _accesorialsPerQuote.IdQuote = idQuote;
            _accesorialsPerQuote.IdAccessorial = idAccesorial;               
            _accesorialsPerQuote.Price = Convert.ToDecimal(accesorialquote.Price);

            return _accesorialsPerQuote;
        }
    }
}
