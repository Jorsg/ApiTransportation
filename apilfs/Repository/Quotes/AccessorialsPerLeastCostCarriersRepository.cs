using apilfs.DTO.Quote;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Quotes
{
    public class AccessorialsPerLeastCostCarriersRepository : IAccessorialsPerLeastCostCarriers
    {
        private readonly BD_LFSContext _context;

        public AccessorialsPerLeastCostCarriersRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public IQueryable<AccessorialsPerLeastCostCarrier> GetPerLeastCostCarriers()
        {
            return _context.AccessorialsPerLeastCostCarriers;
        }

        public IQueryable<AccessorialsPerLeastCostCarrier> GetPerLeastCostCarriers(int idLeastCostCarriers)
        {
            return _context.AccessorialsPerLeastCostCarriers.Where(elm => elm.IdLeastCostCarrier == idLeastCostCarriers);
        }

        public bool InsertAccesorialsPerLeast(AccessorialsPerLeastCostCarriersDto accessorialsPerLeastCost,
                                               int idAccesorialsLeasCost)
        {
            bool respuesta = false;
            try
            {
                int idAccesorial = GetAccesorialById(accessorialsPerLeastCost.AccessorialCode);
                if(idAccesorial > 0)
                {
                    var accesorial = new DTO.Quote.MapingAccessorialsPerLeastCostCarriers().MapingDtoToEntity(accessorialsPerLeastCost, idAccesorial, idAccesorialsLeasCost);
                    _context.AccessorialsPerLeastCostCarriers.Add(accesorial);
                    save();
                    respuesta = true;
                }
                else
                {
                    var accesorial = new DTO.Quote.MapingAccessorialsPerLeastCostCarriers().MapingDtoToEntity(accessorialsPerLeastCost, 242, idAccesorialsLeasCost);
                    _context.AccessorialsPerLeastCostCarriers.Add(accesorial);
                    save();
                    respuesta = true;
                }

                
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                throw;
            }
            return respuesta;

        }

        public void save()
        {
            _context.SaveChanges();
        }

        public bool UpdateAccesorialsPerLeast(AccessorialsPerLeastCostCarriersDto accessorialsPerLeastCost)
        {
            throw new NotImplementedException();
        }

        private int GetAccesorialById(string accesorial)
        {
            var query = _context.Accessorials.FirstOrDefault(elm => elm.IdSaas == accesorial || elm.IdYat == accesorial);
            if (query != null)
                return query.Id;
            else
                return 0;
        }
    }
}
