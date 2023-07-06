using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ILeastCostCarriers
    {
        IQueryable<Models.LeastCostCarrier> GetLeastCostCarriers();
        IQueryable<Models.LeastCostCarrier> GetLeastCostCarriers(int id);

        int InsertLestCostCarrier(DTO.Quote.LeastCostCarriersDto leastCostCarriers, int idQuote);

        bool UpdateLestCostCarrier(DTO.Quote.UpdateQuote quote);

        void Save();

    }
}
