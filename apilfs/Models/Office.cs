using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Office
    {
        public Office()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
