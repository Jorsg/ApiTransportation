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
    public class QuoteServices : IQuoteServices
    {
        #region [Variables Globales]

        IQuote _quote;
        IRatesPerQuote _rates;
        IShipmentsPerQuote _shipmentsPer;
        IBenchmarkRate _benchmarkRate;
        IAccessorialsPerLeastCostCarriers _accessorialsPerLeast;
        ILeastCostCarriers _leastCostCarrier;
        IRatePerQuoteDrayage _ratePerQuote;
        //int idQuotes = 0;
        //int idLestCostCarrier = 0;
        #endregion

        public QuoteServices(IQuote quote, IRatesPerQuote rates, IShipmentsPerQuote shipments, IBenchmarkRate benchmark,
                             IAccessorialsPerLeastCostCarriers accessorialsPerLeast,
                                 ILeastCostCarriers leastCostCarriers, IRatePerQuoteDrayage ratePerQuote)
        {
            _quote = quote;
            _rates = rates;
            _shipmentsPer = shipments;
            _benchmarkRate = benchmark;
            _accessorialsPerLeast = accessorialsPerLeast;
            _leastCostCarrier = leastCostCarriers;
            _quote = quote;
            _ratePerQuote = ratePerQuote;
        }

        public IQueryable<QuotesDto> GetQuoteHistory()
        {
            throw new NotImplementedException();
        }

        public IQueryable<QuotesDto> GetQuoteHistory(int id)
        {
            
            throw new NotImplementedException();
        }
    }
}
