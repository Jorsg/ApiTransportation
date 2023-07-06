using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IQuoteHistory
    {
        IQueryable<apilfs.Models.VQuoteHistory> GetQuoteHistory(int idCustomer);
    }
}
