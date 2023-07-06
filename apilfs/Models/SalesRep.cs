using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class SalesRep
    {
        public SalesRep()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string NameSalesRep { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
