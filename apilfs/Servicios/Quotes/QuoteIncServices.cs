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
    public class QuoteIncServices : IQuoteIncServices
    {
        #region [Variables Globales]

        IQuote _quote;       
        IAccessorialsPerLeastCostCarriers _accessorialsPerLeast;
        ILeastCostCarriers _leastCostCarrier;
        int idQuotes = 0;
        int idLestCostCarrier = 0;
        #endregion
        
        public QuoteIncServices(IQuote quote, IAccessorialsPerLeastCostCarriers accessorialsPerLeast,
                                ILeastCostCarriers leastCostCarriers)
        {
            _quote = quote;           
            _accessorialsPerLeast = accessorialsPerLeast;
            _leastCostCarrier = leastCostCarriers;
        }
       

        public IQueryable<Quote> GetQuotesInc()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Quote> GetQuotesInc(int id)
        {
            throw new NotImplementedException();
        }       

        public int InsertQuotesInc(QuotesDto quote)
        {
            bool respuesta = false;
            try
            {
                idQuotes = _quote.InsertQuote(quote);
                if (quote.LeastCostCarrier != null)
                {
                    foreach (var item in quote.LeastCostCarrier)
                    {
                        idLestCostCarrier = _leastCostCarrier.InsertLestCostCarrier(item, idQuotes);

                        if (item.AccessorialsPerLeastCostCarriers != null)
                        {
                            foreach (var item1 in item.AccessorialsPerLeastCostCarriers)
                            {
                                respuesta = _accessorialsPerLeast.InsertAccesorialsPerLeast(item1, idLestCostCarrier);
                            }
                        }                        
                    }
                }              
                   
            }
            catch (Exception ex)
            {
                _ = ex.Message;              
            }
            return idQuotes;
        }

        public bool UpdatetQuotesInc(DTO.Quote.UpdateQuote quote)
        {
            bool respuesta = false;
            try
            {               
                    respuesta = _leastCostCarrier.UpdateLestCostCarrier(quote);                  
       
            }
            catch (Exception ex)
            {
                _ = ex.Message;             
            }

            return respuesta;
        }
    }
}
