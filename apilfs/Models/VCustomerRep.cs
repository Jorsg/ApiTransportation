using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class VCustomerRep
    {
        public string Code { get; set; }
        public string NameCustomer { get; set; }
        public string Address1 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal CreditLimit { get; set; }
        public string NameSalesRep { get; set; }
        public string EmailRep { get; set; }
    }
}
