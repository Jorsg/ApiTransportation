using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class User
    {
        public User()
        {
            RolesByUsers = new HashSet<RolesByUser>();
        }

        public int Id { get; set; }
        public string User1 { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<RolesByUser> RolesByUsers { get; set; }
    }
}
