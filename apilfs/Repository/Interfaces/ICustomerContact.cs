using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ICustomerContact
    {
        IQueryable<Models.CustomerContact> GetCustomerContactByCustomerId(int idCustomer);
        void InsertCustomerContact(Models.CustomerContact customerContact);
    }
}
