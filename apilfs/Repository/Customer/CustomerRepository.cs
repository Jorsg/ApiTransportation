using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.DTO;

namespace apilfs.Repository.Customer
{
    public class CustomerRepository : ICustomers
    {
        private readonly BD_LFSContext _context;

        public CustomerRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public void Delete(Models.Customer customer)
        {
            _context.Customers.Remove(customer);
        }

        public IQueryable<Models.Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public Models.Customer GetCustomers(string code)
        {
            return _context.Customers.Where(elm => elm.Code == code).FirstOrDefault();
        }

        public Models.Customer GetCustomerById(int id)
        {
            return _context.Customers.Where(elm => elm.Id == id).FirstOrDefault();
        }

        public Models.Customer GetCustomerByEmail(string email){
            return _context.Customers.Where(elm => elm.Email == email).FirstOrDefault();
        }

        public IQueryable<Models.Customer> GetCustomerByIdSalesRep(int idSalesRep)
        {
            return _context.Customers.Where(elm => elm.IdSalesRep == idSalesRep);
        }

        public Models.Customer GetCustomerByIdOrCustomerAll(int id)
        {
            var customer = GetCustomerById(id);
            if (customer == null)
            {
                customer = GetCustomers("ALL");
            }
            return customer;
        }

        public IQueryable<Models.Customer> GetCustomersLocations(string city)
        {
            return _context.Customers.Where(elm => elm.City.Contains(city));
        }

        public Models.Customer InsertCustomer(DTO.CustomersDto customer)
        {
            var _custo = new apilfs.DTO.MapeoCustomers();
            Models.Customer customerInserted = _custo.MapearCustomer(customer);
            _context.Customers.Add(customerInserted);
            Save();
            return customerInserted;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Models.Customer customer)
        {
            _context.Customers.Update(customer);
            Save();
        }

        public bool GetCustomersExits(string code)
        {
            bool respuesta = false;
            var result = _context.Customers.Where(elm => elm.Code == code);
            if (result.Any())
                return respuesta = true;
            else
                return respuesta;            
        }


    }
}
