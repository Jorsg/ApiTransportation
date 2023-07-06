using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ICustomerOffice
    {
        IQueryable<Models.CustomerOffice> GetCustomerOfficeByCustomerId(int idCustomer);
        void InsertCustomerOffice(Models.CustomerOffice office);
    }
}
