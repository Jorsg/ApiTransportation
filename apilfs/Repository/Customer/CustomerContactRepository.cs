using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.DTO;

namespace apilfs.Repository.Customer
{
    public class CustomerContactRepository : ICustomerContact
    {
        private readonly BD_LFSContext _context;

        public CustomerContactRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.CustomerContact> GetCustomerContactByCustomerId(int idCustomer)
        {
            return _context.CustomerContacts.Where(elm => elm.IdCustomer == idCustomer);
        }

        public void InsertCustomerContact(Models.CustomerContact customerContact)
        {
            _context.CustomerContacts.Add(customerContact);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
