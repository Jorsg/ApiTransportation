using apilfs.Models;
using apilfs.Repository.Interfaces;
using apilfs.Repository.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.DTO;
using apilfs.Repository.Quote;

namespace apilfs.Services
{
    public class QuoteFtlServices : IQuotesServices
    {

        #region [Variables Globales]
      
        IQuote _quote;      
        IRatesPerQuote _rates;       
        IAccessorialsPerQuote _accesorials;       
        IBenchmarkRate _benchmarkRate;      
       int idQuotes = 0;
       #endregion

        public QuoteFtlServices(IQuote quote, IRatesPerQuote rates, IAccessorialsPerQuote accessorials, IBenchmarkRate benchmarkRate)
        {
            _quote = quote;
            _accesorials = accessorials;
            _benchmarkRate = benchmarkRate;
            _rates = rates;

        }

        public IQueryable<Quote> GetQuotes()
        {
           return _quote.GetQuotes();
        }

        public IQueryable<Quote> GetQuotes(int id)
        {
            return _quote.GetQuotes(id);
        }

        public int InsertQuotesAll(DTO.QuotesDto quote)
        {
            bool respuesta = false;
            idQuotes =  _quote.InsertQuote(quote);
            respuesta =  InsertQuote(quote, idQuotes);
            return  idQuotes;
        }

        public bool UpdatetQuotesAll(DTO.Quote.UpdateQuote quote)
        {
            bool respuesta = false;
            try
            {  
                 respuesta = _rates.updateRatesPerQuote(quote); // Inserta RatePerQueotes
            }
            catch (Exception ex)
            {
                _ = ex.Message;              
            }
            return respuesta;
        }

        private bool InsertQuote(QuotesDto quote, int idQuote)
        {
            bool respuesta = false;
            try
            {
                if (quote.RatesPerQuote != null)
                {
                    foreach (var item in quote.RatesPerQuote)
                    {
                        respuesta = _rates.inserRatesPerQuote(item, idQuotes); // Inserta RatePerQueotes
                    }
                }
                if (quote.AccessorialsPerQuote != null)
                {
                    foreach (var item1 in quote.AccessorialsPerQuote)
                    {
                        respuesta = _accesorials.insertAccessorialsPerQuote(item1, idQuotes); // Inserta Accesorials
                    }
                }
                if (quote.BenchmarkRate != null)
                {
                    respuesta = _benchmarkRate.insertBenchmarkRate(quote.BenchmarkRate, idQuotes);// Inserta BenchmarkRates
                }
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
