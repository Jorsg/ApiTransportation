using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class SalesKam
    {
        public SalesKam()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string NameSalesKam { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
