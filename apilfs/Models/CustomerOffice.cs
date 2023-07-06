using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class CustomerOffice
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

        public virtual Customer IdCustomerNavigation { get; set; }
    }
}
