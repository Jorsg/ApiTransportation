using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Repository.Customer
{
    public class CustomersBySaleAgentRepository : ICustomerBySaleAgent
    {
        private readonly BD_LFSContext _context;

        public CustomersBySaleAgentRepository(BD_LFSContext context)
        {
            _context = context;
        }
        
        public IQueryable<Models.CustomersbySaleAgent> GetCustomersbySaleAgents()
        {
            var query = (from c in _context.Customers 
                         join s in _context.SalesReps on c.Rep equals s.Code
                         select new CustomersbySaleAgent 
                         { CodeCustomers = c.Code, 
                           NameCustomer = c.NameCustomer, 
                           CodeSalesRep = s.Code,
                           NameSalesRep = s.NameSalesRep, 
                            ProfileCustomer = c.Profile
                         });
            return query;
        }

        public IQueryable<Models.CustomersbySaleAgent> GetCustomersbySaleAgents(string codeCustomers)
        {
            var query = (from c in _context.Customers
                         join s in _context.SalesReps on c.Rep equals s.Code
                         where c.Code == codeCustomers
                         select new CustomersbySaleAgent
                         {
                             CodeCustomers = c.Code,
                             NameCustomer = c.NameCustomer,
                             CodeSalesRep = s.Code,
                             NameSalesRep = s.NameSalesRep,
                             ProfileCustomer = c.Profile
                         });
            return query;
        }

        public IQueryable<Models.CustomersbySaleAgent> GetCustomersbySaleAgentsCode(string codeSalesRep)
        {
            var query = (from c in _context.Customers
                         join s in _context.SalesReps on c.Rep equals s.Code
                         where s.Code == codeSalesRep
                         select new CustomersbySaleAgent
                         {
                             CodeCustomers = c.Code,
                             NameCustomer = c.NameCustomer,
                             CodeSalesRep = s.Code,
                             NameSalesRep = s.NameSalesRep,
                             ProfileCustomer = c.Profile
                         });
            return query;
        }
    }
}
