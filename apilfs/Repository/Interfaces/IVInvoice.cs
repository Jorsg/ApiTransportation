using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IVInvoice
    {
        IQueryable<Models.VInvoice> GetInvoices(string  docNum);
    }
}
