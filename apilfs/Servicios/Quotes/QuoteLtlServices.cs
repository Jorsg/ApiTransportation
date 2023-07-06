using apilfs.DTO;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using apilfs.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Servicios.Quotes
{
    public class QuoteLtlServices : IQuoteLtlServices
    {
        #region [Variables Globales]

        IQuote _quote;      
        IShipmentsPerQuote _shipmentsPer;
        IAccessorialsPerLeastCostCarriers _accessorialsPerLeast;
        ILeastCostCarriers  _leastCostCarrier;
        int idQuotes = 0;
        int idLestCostCarrier = 0;
        #endregion

        public QuoteLtlServices(IQuote quote,  IShipmentsPerQuote shipments, IAccessorialsPerLeastCostCarriers accessorialsPerLeast,
                                ILeastCostCarriers leastCostCarriers)
        {
            _quote = quote;          
            _shipmentsPer = shipments;
            _accessorialsPerLeast = accessorialsPerLeast;
            _leastCostCarrier = leastCostCarriers;
        }      

        public IQueryable<Quote> GetQuotesLtl()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Quote> GetQuotesLtl(int id)
        {
            throw new NotImplementedException();
        }       

        public int InsertQuotesLtl(QuotesDto quote)
        {
            bool respuesta = false;
            try
            {
                idQuotes =  _quote.InsertQuote(quote);
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

                if (quote.ShipmentsPerQuote != null)
                {
                    foreach (var item in quote.ShipmentsPerQuote)
                    {
                        respuesta = _shipmentsPer.insertShipmentsPerQuote(item, idQuotes);
                    }
                }

               
            }
            catch (Exception ex)
            {
                _ = ex.Message;                
            }

            return idQuotes;
        }

        public bool UpdateQuotesLtl(DTO.Quote.UpdateQuote quote)
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
