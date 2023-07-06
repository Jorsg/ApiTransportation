using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Quotes
{
    public class RatesPerQuoteRepository : IRatesPerQuote
    {
        private readonly BD_LFSContext _context;       
        IExceptionsAppliedPerRate _exceptionsApplied;

        public RatesPerQuoteRepository(BD_LFSContext context, IExceptionsAppliedPerRate exceptionsApplied)
        {
            _context = context;
            _exceptionsApplied = exceptionsApplied;
        }

       

        public bool inserRatesPerQuote(DTO.RateQuotesDto ratesPerQuote, int IdQuote)
        {
            bool respuesta = false;
            try
            {
                var rates = new DTO.MapinRateQuotes().MaperRateQuote(ratesPerQuote, IdQuote);             

                _ = _context.RatesPerQuotes.Add(rates);
                Save();
                int idRates = rates.Id;
                foreach (var item in ratesPerQuote.ExceptionsAppliedPerRate)
                {
                  respuesta = _exceptionsApplied.insertExceptionsAppliedPerRate(item, idRates); // Inserta Excepciones por Rates
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;                
            }
            return respuesta;
        }

        public void Save()
        {
            _context.SaveChanges();
        }        


        public bool updateRatesPerQuote(DTO.Quote.UpdateQuote quote)
        {
            bool respuesta = false;
            try
            {
                foreach (var item in quote.ratId)
                {
                    var rates = GetRatesPerQuotesbyIdQuote(item.ToString());
                    if (rates != null)
                    {
                        rates.QuoteHistory = quote.QuoteHistory;
                        _ = _context.RatesPerQuotes.Update(rates);
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

        private RatesPerQuote GetRatesPerQuotesbyIdQuote(string rateId)
        {
            return _context.RatesPerQuotes.FirstOrDefault(elm => elm.RateId == rateId);
        }
    }
}
