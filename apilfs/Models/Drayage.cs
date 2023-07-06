using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Drayage
    {
        public int Id { get; set; }
        public int IdPortRamp { get; set; }
        public int IdCustomer { get; set; }
        public int IdVendor { get; set; }
        public string Notes { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string PorceOption1 { get; set; }
        public string PorceOption2 { get; set; }
        public string PorceOption3 { get; set; }
        public decimal ValorTarifaApi { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
        public virtual PortsRamp IdPortRampNavigation { get; set; }
        public virtual Vendor IdVendorNavigation { get; set; }
    }
}
