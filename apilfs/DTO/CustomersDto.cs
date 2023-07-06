using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO
{
    public class CustomersDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameCustomer { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string OfficeAssigned { get; set; }
        public string Rep { get; set; }
        public string Kam { get; set; }
        public string Tier { get; set; }
        public string CustomerGroup { get; set; }
        public decimal? CreditLimit { get; set; }
        public string CreditTerms { get; set; }
        public string Profile { get; set; }
        public string StatusCustomer { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CompanyDomain { get; set; }
        public string LinkedinCompanyPage { get; set; }
        public string WebsiteUrl { get; set; }
        public string ClientCodeSaas { get; set; }
        public string ProfileCodeSaas { get; set; }
        public string CustomerIdYat { get; set; }
        public string IdClientSwanleap { get; set; }
        public string CustomerType { get; set; }
        public string UserFrontEnd { get; set; }
        public string PasswordFrontEnd { get; set; }
        public string UserProfile { get; set; }
        public string MajorCode { get; set; }
        public string MajorName { get; set; }
        public string W9Rfc { get; set; }
        public string Arrepresentative { get; set; }
        public string Company { get; set; }
        public int? IdOffice { get; set; }
        public int? IdTier { get; set; }
        public int? IdSalesKam { get; set; }
        public int? IdSalesRep { get; set; }
        public string OfficeName { get; set; }
        public string SaleKamName { get; set; }
        public string SaleAgentName { get; set; }
        public List<CustomerOfficeDto> CustomerOffices { get; set; }
        public List<CustomerContactDto> CustomerContacts { get; set; }
    }


    public class MapeoCustomers
    {
        public Customer MapearCustomer(CustomersDto customer)
        {
            Customer _customer = new Customer();
            _customer.Id = customer.Id;
            _customer.Code = customer.Code;
            _customer.NameCustomer = customer.NameCustomer;
            _customer.Address1 = customer.Address1;
            _customer.Address2 = customer.Address2;
            _customer.Phone = customer.Phone;
            _customer.Fax = customer.Fax;
            _customer.Email = customer.Email;
            _customer.City = customer.City;
            _customer.State = customer.State;
            _customer.ZipCode = customer.ZipCode;
            _customer.Country = customer.Country;
            _customer.OfficeAssigned = customer.OfficeAssigned;
            _customer.Rep = customer.Rep;
            _customer.Kam = customer.Kam;
            _customer.Tier = customer.Tier;
            _customer.CustomerGroup = customer.CustomerGroup;
            _customer.CreditLimit = customer.CreditLimit;
            _customer.CreditTerms = customer.CreditTerms;
            _customer.Profile = customer.Profile;
            _customer.StatusCustomer = customer.StatusCustomer;
            _customer.CreationDate = customer.CreationDate;
            _customer.CompanyDomain = customer.CompanyDomain;
            _customer.LinkedinCompanyPage = customer.LinkedinCompanyPage;
            _customer.WebsiteUrl = customer.WebsiteUrl;
            _customer.ClientCodeSaas = customer.ClientCodeSaas;
            _customer.ProfileCodeSaas = customer.ProfileCodeSaas;
            _customer.CustomerIdYat = customer.CustomerIdYat;
            _customer.IdClientSwanleap = customer.IdClientSwanleap;
            _customer.CustomerType = customer.CustomerType;
            _customer.UserFrontEnd = customer.UserFrontEnd;
            _customer.PasswordFrontEnd = customer.PasswordFrontEnd;
            _customer.UserProfile = customer.UserProfile;
            _customer.MajorCode = customer.MajorCode;
            _customer.MajorName = customer.MajorName;
            _customer.W9Rfc = customer.W9Rfc;
            _customer.Arrepresentative = customer.Arrepresentative;
            _customer.Company = customer.Company;
            _customer.IdOffice = customer.IdOffice;
            _customer.IdTier = customer.IdTier;
            _customer.IdSalesKam = customer.IdSalesKam;
            _customer.IdSalesRep = customer.IdSalesRep;

            return _customer;
        }

        public CustomersDto MapearCustomer(Customer customer)
        {
            CustomersDto _customer = new CustomersDto();
            _customer.Id = customer.Id;
            _customer.Code = customer.Code;
            _customer.NameCustomer = customer.NameCustomer;
            _customer.Address1 = customer.Address1;
            _customer.Address2 = customer.Address2;
            _customer.Phone = customer.Phone;
            _customer.Fax = customer.Fax;
            _customer.Email = customer.Email;
            _customer.City = customer.City;
            _customer.State = customer.State;
            _customer.ZipCode = customer.ZipCode;
            _customer.Country = customer.Country;
            _customer.OfficeAssigned = customer.OfficeAssigned;
            _customer.Rep = customer.Rep;
            _customer.Kam = customer.Kam;
            _customer.Tier = customer.Tier;
            _customer.CustomerGroup = customer.CustomerGroup;
            _customer.CreditLimit = customer.CreditLimit;
            _customer.CreditTerms = customer.CreditTerms;
            _customer.Profile = customer.Profile;
            _customer.StatusCustomer = customer.StatusCustomer;
            _customer.CreationDate = customer.CreationDate;
            _customer.CompanyDomain = customer.CompanyDomain;
            _customer.LinkedinCompanyPage = customer.LinkedinCompanyPage;
            _customer.WebsiteUrl = customer.WebsiteUrl;
            _customer.ClientCodeSaas = customer.ClientCodeSaas;
            _customer.ProfileCodeSaas = customer.ProfileCodeSaas;
            _customer.CustomerIdYat = customer.CustomerIdYat;
            _customer.IdClientSwanleap = customer.IdClientSwanleap;
            _customer.CustomerType = customer.CustomerType;
            _customer.UserFrontEnd = customer.UserFrontEnd;
            _customer.PasswordFrontEnd = customer.PasswordFrontEnd;
            _customer.UserProfile = customer.UserProfile;
            _customer.MajorCode = customer.MajorCode;
            _customer.MajorName = customer.MajorName;
            _customer.W9Rfc = customer.W9Rfc;
            _customer.Arrepresentative = customer.Arrepresentative;
            _customer.Company = customer.Company;
            _customer.IdOffice = customer.IdOffice;
            _customer.IdTier = customer.IdTier;
            _customer.IdSalesKam = customer.IdSalesKam;
            _customer.IdSalesRep = customer.IdSalesRep;

            return _customer;
        }
    }
   
}
