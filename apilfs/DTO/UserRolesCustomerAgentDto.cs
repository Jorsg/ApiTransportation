using apilfs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.DTO
{
    public class UserRolesCustomerAgentDto
    {
        public string User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
        public string Role { get; set; }
        public CustomersDto Customer { get; set; }
        public SalesRepDto SalesRep { get; set; }
        public SalesKamDto SalesKam { get; set; }
    }

}
