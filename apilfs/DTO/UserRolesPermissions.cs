using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.DTO
{
    public class UserRolesPermissions
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Active { get; set; }
        public List<string> roles { get; set; }
        public List<string> permissions { get; set; }
        public CustomersDto customerDto { get; set; }
        public SalesRepDto salesRepDto { get; set; }
    }
}
