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
    public class QuotePartialServices : IQuotePartialServices
    {

        #region [Variables Globales]

        IQuote _quote;
        IRatesPerQuote _rates;
        IShipmentsPerQuote _shipmentsPer;
        IBenchmarkRate _benchmarkRate;
        IAccessorialsPerQuote _accesorials;
        int idQuotes = 0;
        #endregion

        public QuotePartialServices(IQuote quote, IRatesPerQuote rates, IShipmentsPerQuote shipments, IBenchmarkRate benchmark, IAccessorialsPerQuote accessorials)
        {
            _quote = quote;
            _rates = rates;
            _shipmentsPer = shipments;
            _benchmarkRate = benchmark;
            _accesorials = accessorials;
        }

        public IQueryable<Quote> GetQuotes()
        {
            return _quote.GetQuotes();
        }

        public IQueryable<Quote> GetQuotes(int id)
        {
            return _quote.GetQuotes(id);
        }

        public int InsertQuotesAll(QuotesDto quote)
        {
            bool respuesta = false;
            try
            {
                idQuotes =  _quote.InsertQuote(quote);
                if (quote.RatesPerQuote != null)
                {
                    foreach (var item in quote.RatesPerQuote)
                    {
                        respuesta = _rates.inserRatesPerQuote(item, idQuotes);
                    }
                }
                if (quote.AccessorialsPerQuote != null)
                {
                    foreach (var item1 in quote.AccessorialsPerQuote)
                    {
                        respuesta = _accesorials.insertAccessorialsPerQuote(item1, idQuotes); // Inserta Accesorials
                    }
                }
                if (quote.ShipmentsPerQuote != null)
                {
                    foreach (var item in quote.ShipmentsPerQuote)
                    {
                        respuesta = _shipmentsPer.insertShipmentsPerQuote(item, idQuotes);
                    }
                }
                if (quote.BenchmarkRate != null)
                {
                    respuesta = _benchmarkRate.insertBenchmarkRate(quote.BenchmarkRate, idQuotes);
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;               
            }

            return idQuotes;
        }

        public bool UpdateQuotesAll(DTO.Quote.UpdateQuote quote)
        {
            bool respuesta = false;
            try
            {       
                 respuesta = _rates.updateRatesPerQuote(quote);
              
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                throw;
            }

            return respuesta;
        }
    }
}
