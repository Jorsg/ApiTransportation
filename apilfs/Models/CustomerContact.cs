using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class CustomerContact
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
        public string IdB2c { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
    }
}
