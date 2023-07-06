using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO
{
    public class CustomerContactDto
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string ContactType { get; set; }
        public int? Order { get; set; }
        public DateTime? CreationDate { get; set; }
    }


    public class MapeoCustomerContact
    {
        public CustomerContact MapearCustomerContact(CustomerContactDto customer)
        {
            CustomerContact _customer = new CustomerContact();
            _customer.Id = customer.Id;
            _customer.IdCustomer = customer.IdCustomer;
            _customer.FirstName = customer.FirstName;
            _customer.LastName = customer.LastName;
            _customer.Country = customer.Country;
            _customer.State = customer.State;
            _customer.Zipcode = customer.Zipcode;
            _customer.City = customer.City;
            _customer.Phone = customer.Phone;
            _customer.Fax = customer.Fax;
            _customer.Email = customer.Email;
            _customer.ContactType = customer.ContactType;
            _customer.Order = customer.Order;
            _customer.CreationDate = customer.CreationDate;

            return _customer;
        }

        public CustomerContactDto MapearCustomerContact(CustomerContact customer)
        {
            CustomerContactDto _customer = new CustomerContactDto();
            _customer.Id = customer.Id;
            _customer.IdCustomer = customer.IdCustomer;
            _customer.FirstName = customer.FirstName;
            _customer.LastName = customer.LastName;
            _customer.Country = customer.Country;
            _customer.State = customer.State;
            _customer.Zipcode = customer.Zipcode;
            _customer.City = customer.City;
            _customer.Phone = customer.Phone;
            _customer.Fax = customer.Fax;
            _customer.Email = customer.Email;
            _customer.ContactType = customer.ContactType;
            _customer.Order = customer.Order;
            _customer.CreationDate = customer.CreationDate;

            return _customer;
        }

    }
   
}
