using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO
{
    public class CustomerLocationsDto
    {
        public class CustomersLocationsDto
        {
            public string Code { get; set; }
            public string NameCustomer { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public string Email { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zipcode { get; set; }
            public string Country { get; set; }
            public string Contact { get; set; }
            public string OfficeAssigned { get; set; }           
            public string Profile { get; set; }
            public string StatusCustomer { get; set; }
            public DateTime CreationDate { get; set; }
            public string CompanyDomain { get; set; }          
        }

        public class MapeoCustomersLocations
        {
            public Customer MapearCustomerLocations(CustomersLocationsDto customer)
            {
                Customer _customer = new Customer();
                _customer.Code = customer.Code;
                _customer.NameCustomer = customer.NameCustomer;
                _customer.Address1 = customer.Address1;
                _customer.Address2 = customer.Address2;
                _customer.Phone = customer.Phone;
                _customer.Fax = customer.Fax;
                _customer.Email = customer.Email;
                _customer.City = customer.City;
                _customer.State = customer.State;
                _customer.ZipCode = customer.Zipcode;
                _customer.Country = customer.Country;
                _customer.CustomerType = customer.Contact;
                _customer.OfficeAssigned = customer.OfficeAssigned;             
                _customer.Profile = customer.Profile;
                _customer.StatusCustomer = customer.StatusCustomer;
                _customer.CreationDate = customer.CreationDate;
                _customer.CompanyDomain = customer.CompanyDomain;             

                return _customer;
            }
        }

    }
}
