using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.DTO.Quote
{
    public class UpdateQuote
    {        
        public List<string> ratId { get; set; }
        public bool QuoteHistory { get; set; }       
    }
}
