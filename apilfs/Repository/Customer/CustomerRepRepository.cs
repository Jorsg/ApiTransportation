using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Customer
{
    public class CustomerRepRepository : ICustomerRep
    {
        private readonly BD_LFSContext _context;

        public CustomerRepRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public CustomerRep GetCustomersRepbyId(string codCard)
        {

            var query = (from custo in _context.Customers
                         join custoRep in _context.VCustomerReps on custo.Code equals custoRep.Code
                         where custo.Code == codCard
                         select new CustomerRep { Id = custo.Id, Code = custo.Code, NameCustomer = custo.NameCustomer, Address1 = custo.Address1,
                                                 Address2 = custo.Address2, Phone = custo.Phone, Fax = custo.Fax, Email = custo.Email, City = custo.City,
                                                 State = custo.State, ZipCode = custo.ZipCode, Country = custo.Country, OfficeAssigned = custo.OfficeAssigned,
                                                 Rep = custo.Rep, Kam = custo.Kam, Tier = custo.Tier, CustomerGroup = custo.CustomerGroup, CreditLimit = custo.CreditLimit,
                                                 CreditTerms = custo.CreditTerms, Profile = custo.Profile, StatusCustomer = custo.StatusCustomer, CreationDate = custo.CreationDate,
                                                 LinkedinCompanyPage = custo.LinkedinCompanyPage, WebsiteUrl = custo.WebsiteUrl, NameSalesRep = custoRep.NameSalesRep,
                                                 EmailRep = custoRep.EmailRep});
            return query.FirstOrDefault();
        }
    }
}
