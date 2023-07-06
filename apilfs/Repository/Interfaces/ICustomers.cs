using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ICustomers
    {
        IQueryable<Models.Customer> GetCustomers();

        Models.Customer GetCustomers(string code);
        Models.Customer GetCustomerById(int id);
        Models.Customer GetCustomerByEmail(string email);
        IQueryable<Models.Customer> GetCustomerByIdSalesRep(int idSalesRep);
        Models.Customer GetCustomerByIdOrCustomerAll(int id);
        IQueryable<Models.Customer> GetCustomersLocations(string city);

        bool GetCustomersExits(string code);

        Models.Customer InsertCustomer(DTO.CustomersDto  customer);

        void Save();

        void Update(Models.Customer customer);

        void Delete(Models.Customer customer);
    }
}
