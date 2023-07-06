using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO
{
    public class CustomerContactsOfficesDto
    {
        public string Code { get; set; }
        public string NameCustomer { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string OfficeAssigned { get; set; }
        public string CustomerGroup { get; set; }
        public decimal? CreditLimit { get; set; }
        public string CreditTerms { get; set; }
        public string Profile { get; set; }
        public string StatusCustomer { get; set; }
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
        public string OfficeName { get; set; }
        public string SaleKamEmail { get; set; }
        public string SaleAgentEmail { get; set; }
        public string Tier { get; set; }
        public List<CustomerOfficeDto> CustomerOffices { get; set; }
        public List<CustomerContactDto> CustomerContacts { get; set; }
    }
   
}

