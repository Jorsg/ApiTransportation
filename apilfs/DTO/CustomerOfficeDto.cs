using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO
{
    public class CustomerOfficeDto
    {
        public int Id { get; set; }
        public int? IdCustomer { get; set; }
        public string NameCustomerOffice { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Status { get; set; }
        public DateTime? CreationDate { get; set; }
    }


    public class MapeoCustomerOffice
    {
        public CustomerOffice MapearCustomerOffice(CustomerOfficeDto customer)
        {
            CustomerOffice _customer = new CustomerOffice();
            _customer.Id = customer.Id;
            _customer.IdCustomer = customer.IdCustomer;
            _customer.NameCustomerOffice = customer.NameCustomerOffice;
            _customer.Address1 = customer.Address1;
            _customer.Address2 = customer.Address2;
            _customer.Phone = customer.Phone;
            _customer.Fax = customer.Fax;
            _customer.Email = customer.Email;
            _customer.Country = customer.Country;
            _customer.State = customer.State;
            _customer.City = customer.City;
            _customer.Zipcode = customer.Zipcode;
            _customer.Status = customer.Status;
            _customer.CreationDate = customer.CreationDate;

            return _customer;
        }

        public CustomerOfficeDto MapearCustomerOffice(CustomerOffice customer)
        {
            CustomerOfficeDto _customer = new CustomerOfficeDto();
            _customer.Id = customer.Id;
            _customer.IdCustomer = customer.IdCustomer;
            _customer.NameCustomerOffice = customer.NameCustomerOffice;
            _customer.Address1 = customer.Address1;
            _customer.Address2 = customer.Address2;
            _customer.Phone = customer.Phone;
            _customer.Fax = customer.Fax;
            _customer.Email = customer.Email;
            _customer.Country = customer.Country;
            _customer.State = customer.State;
            _customer.City = customer.City;
            _customer.Zipcode = customer.Zipcode;
            _customer.Status = customer.Status;
            _customer.CreationDate = customer.CreationDate;

            return _customer;
        }

    }
   
}
