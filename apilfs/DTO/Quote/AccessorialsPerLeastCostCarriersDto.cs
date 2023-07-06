using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Quote
{
    public class AccessorialsPerLeastCostCarriersDto
    {
        public int Id { get; set; }
        public int IdLeastCostCarrier { get; set; }
        public string AccessorialCode { get; set; }
        public decimal? Charge { get; set; }
        public string AccessorialDescription { get; set; }

    }

    public class MapingAccessorialsPerLeastCostCarriers
    {
        public AccessorialsPerLeastCostCarrier MapingDtoToEntity(DTO.Quote.AccessorialsPerLeastCostCarriersDto accessorialsPerLeast, 
                                                                 int IdAccesorials, int IdLeastCostCarrier)
        {
            AccessorialsPerLeastCostCarrier cost = new AccessorialsPerLeastCostCarrier();
            cost.AccessorialDescription = accessorialsPerLeast.AccessorialDescription;
            cost.Charge = accessorialsPerLeast.Charge;
            cost.IdAccessorial = IdAccesorials;
            cost.IdLeastCostCarrier = IdLeastCostCarrier;

            return cost;
        }
    }
}
