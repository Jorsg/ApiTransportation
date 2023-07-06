using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.DTO;

namespace apilfs.Repository.Customer
{
    public class CustomerOfficeRepository : ICustomerOffice
    {
        private readonly BD_LFSContext _context;

        public CustomerOfficeRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.CustomerOffice> GetCustomerOfficeByCustomerId(int idCustomer)
        {
            return _context.CustomerOffices.Where(elm => elm.IdCustomer == idCustomer);
        }

        public void InsertCustomerOffice(Models.CustomerOffice office)
        {
            _context.CustomerOffices.Add(office);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
