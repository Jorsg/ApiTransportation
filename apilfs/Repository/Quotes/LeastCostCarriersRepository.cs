using apilfs.DTO.Quote;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Quotes
{
    public class LeastCostCarriersRepository : ILeastCostCarriers
    {
        private readonly BD_LFSContext _context;
        int id = 0;

        public LeastCostCarriersRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public IQueryable<LeastCostCarrier> GetLeastCostCarriers()
        {
            return _context.LeastCostCarriers;
        }

        public IQueryable<LeastCostCarrier> GetLeastCostCarriers(int id)
        {
            return _context.LeastCostCarriers.Where(elm => elm.Id == id);
        }

        public int InsertLestCostCarrier(LeastCostCarriersDto leastCostCarriers, int idQuote)
        {           
            try
            {
                int? idVendor = GetidVendor(leastCostCarriers.SCAC);
                if (idVendor > 0)
                {
                    var lestCostCarrier = new DTO.Quote.MapingLeastCostCarrier().MapingDtoToEntity(leastCostCarriers, idQuote, (int)idVendor);
                    _context.LeastCostCarriers.Add(lestCostCarrier);
                    Save();
                    id = lestCostCarrier.Id;
                }
                else
                {
                    var lestCostCarrier = new DTO.Quote.MapingLeastCostCarrier().MapingDtoToEntity(leastCostCarriers, idQuote, null);
                    _context.LeastCostCarriers.Add(lestCostCarrier);
                    Save();
                    id = lestCostCarrier.Id;
                }
               
            }
            catch (Exception ex)
            {
                _ = ex.Message;                
            }
            return id;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool UpdateLestCostCarrier(DTO.Quote.UpdateQuote quote)
        {
            bool respuesta = false;
           
            try
            {
                foreach (var idLestCost in quote.ratId)
                {
                    var lestCostCarrier = GetLeastCostCarrierbyIdQuote(idLestCost.ToString());
                    if (lestCostCarrier != null)
                    {
                        lestCostCarrier.QuoteHistory = quote.QuoteHistory;
                        _context.LeastCostCarriers.Update(lestCostCarrier);
                        Save();
                        respuesta = true;
                    }                      
                }   
            }
            catch (Exception ex)
            {
                _ = ex.Message;         
            }
            return respuesta;
        }

        private LeastCostCarrier GetLeastCostCarrierbyIdQuote(string rateId)
        {
            return _context.LeastCostCarriers.FirstOrDefault(elm => elm.RateId == rateId);
        }

        private int GetidVendor(string name)
        {
            var query = _context.Vendors.FirstOrDefault(elm => elm.ProviderScacSaas == name);
            if (query != null)
                return query.Id;
            else
                return 0;
        }
    }
}
