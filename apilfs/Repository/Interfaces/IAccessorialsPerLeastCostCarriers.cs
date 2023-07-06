using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IAccessorialsPerLeastCostCarriers
    {
        IQueryable<Models.AccessorialsPerLeastCostCarrier> GetPerLeastCostCarriers();
        IQueryable<Models.AccessorialsPerLeastCostCarrier> GetPerLeastCostCarriers(int idLeastCostCarriers);

        bool InsertAccesorialsPerLeast(DTO.Quote.AccessorialsPerLeastCostCarriersDto accessorialsPerLeastCost, 
                                        int idAccesorialsLeasCost);

        bool UpdateAccesorialsPerLeast(DTO.Quote.AccessorialsPerLeastCostCarriersDto accessorialsPerLeastCost);

        void save();
    }
}
