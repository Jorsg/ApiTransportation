using apilfs.DTO.Quote;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Quotes
{
    public class RatePerQuoteDrayageRepository : IRatePerQuoteDrayage
    {
        private readonly BD_LFSContext _context;
        public RatePerQuoteDrayageRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public IQueryable<RatesPerQuoteDrayage> GetRatesPerQuotesDrayage()
        {
            return _context.RatesPerQuoteDrayages;
        }

        public IQueryable<RatesPerQuoteDrayage> GetRatesPerQuotesDrayage(int id)
        {
            return _context.RatesPerQuoteDrayages.Where(elm => elm.Id == id);
        }

        public bool InsertQuoteDrayage(RatePerQuoteDrayageDto drayageDto, int idRate)
        {
            bool respuesta = false;
            try
            {
                var quoteDrayage = new DTO.Quote.MapingRatePerQuoteDrayage().MapinDtoToEntity(drayageDto, idRate);
                _context.RatesPerQuoteDrayages.Add(quoteDrayage);
                Save();
                respuesta = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                throw;
            }           

            return respuesta;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool UpdateQuoteDrayage(DTO.Quote.UpdateQuote quoteDto)
        {
            bool respuesta = false;
            try
            {
                foreach (var item in quoteDto.ratId)
                {
                    var quoteDrayage = GetRatesPerQuotesbyIdQuote(item.ToString());
                    if (quoteDto != null)
                    {
                        quoteDrayage.QuoteHistory = quoteDto.QuoteHistory;
                        _context.RatesPerQuoteDrayages.Update(quoteDrayage);
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

        private RatesPerQuoteDrayage GetRatesPerQuotesbyIdQuote(string rateId)
        {
            return _context.RatesPerQuoteDrayages.FirstOrDefault(elm => elm.RateId == rateId);
        }
    }
}
