using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.DTO.Quote
{
    public class UpdateLeastCostCarriersDto
    {       
        public bool QuoteHistory { get; set; }
        public  List<int> ratId { get; set; }
    }
}
