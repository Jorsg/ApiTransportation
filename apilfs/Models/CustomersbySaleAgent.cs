using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Models
{
    public partial class CustomersbySaleAgent
    {
        public string CodeCustomers { get; set; }
        public string NameCustomer { get; set; }
        public string CodeSalesRep { get; set; }
        public string NameSalesRep { get; set; }
        public string ProfileCustomer { get; set; }

    }
}
