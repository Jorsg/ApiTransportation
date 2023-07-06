using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Quotes
{
    public class QuoteHistoryRepository : IQuoteHistory
    {
        private readonly BD_LFSContext _context;

        public QuoteHistoryRepository(BD_LFSContext context)
        {
            _context = context;
        }        

        IQueryable<VQuoteHistory> IQuoteHistory.GetQuoteHistory(int idCustomer)
        {
            return _context.VQuoteHistories.Where(elm => elm.IdCustomer == idCustomer);
        }
    }
}
