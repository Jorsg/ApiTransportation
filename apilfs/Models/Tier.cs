using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Tier
    {
        public Tier()
        {
            Customers = new HashSet<Customer>();
            Insurances = new HashSet<Insurance>();
        }

        public int Id { get; set; }
        public string Tier1 { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Insurance> Insurances { get; set; }
    }
}
