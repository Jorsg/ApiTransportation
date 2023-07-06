using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IVCustomerBilling
    {
        IQueryable<Models.VCustomerBilling> GetCustomerBillings(string customerCode);

    }
}
