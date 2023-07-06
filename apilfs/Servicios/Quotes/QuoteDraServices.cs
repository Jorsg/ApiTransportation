using apilfs.DTO;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using apilfs.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Servicios.Quotes
{
    public class QuoteDraServices : IQuoteDrayageServices
    {
        #region [Variables Globales]

        IQuote _quote;       
        IAccessorialsPerLeastCostCarriers _accessorialsPerLeast;
        ILeastCostCarriers _leastCostCarrier;
        IRatePerQuoteDrayage _ratePerQuote;
        int idQuotes = 0;
        int idLestCostCarrier = 0;
        #endregion

        public QuoteDraServices(IQuote quote, IAccessorialsPerLeastCostCarriers accessorialsPerLeast, 
                                 ILeastCostCarriers leastCostCarriers, IRatePerQuoteDrayage ratePerQuote )
        {
            _accessorialsPerLeast = accessorialsPerLeast;
            _leastCostCarrier = leastCostCarriers;
            _quote = quote;
            _ratePerQuote = ratePerQuote;
        }
      
        public IQueryable<Quote> GetQuotesDrayage()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Quote> GetQuotesDrayage(int id)
        {
            throw new NotImplementedException();
        }       

        public int InsertQuotesDrayage(QuotesDto quote)
        {
            bool respuesta = false;
            try
            {
                idQuotes =  _quote.InsertQuote(quote);
                respuesta = Insertquote(quote, idQuotes);
            }
            catch (Exception ex)
            {
                _ = ex.Message;            
            }
            
            return idQuotes;
        }

        public bool updatetQuotesDrayage(DTO.Quote.UpdateQuote quote)
        {
             bool respuesta = false;
            try
            {   
                    respuesta = _leastCostCarrier.UpdateLestCostCarrier(quote); 
                    respuesta = _ratePerQuote.UpdateQuoteDrayage(quote);               
            }
            catch (Exception ex)
            {
                _ = ex.Message;                
            }

            return respuesta;
        }

        private bool Insertquote(QuotesDto quote, int idQuote)
        {
            bool respuesta = false;
            try
            {
                if (quote.LeastCostCarrier != null)
                {
                    foreach (var item in quote.LeastCostCarrier)
                    {
                        idLestCostCarrier = _leastCostCarrier.InsertLestCostCarrier(item, idQuotes);

                        foreach (var item1 in item.AccessorialsPerLeastCostCarriers)
                        {
                            respuesta = _accessorialsPerLeast.InsertAccesorialsPerLeast(item1, idLestCostCarrier);
                        }
                    }
                }
                if (quote.RatesPerQuoteDrayage != null)
                {
                    foreach (var item in quote.RatesPerQuoteDrayage)
                    {
                        respuesta = _ratePerQuote.InsertQuoteDrayage(item, idQuotes);
                    }
                }               
            }
            catch (Exception ex)
            {
                _ = ex.Message;                
            }
            return respuesta;
        }
    }
}
