using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Role
    {
        public Role()
        {
            PermissionsByRoles = new HashSet<PermissionsByRole>();
            RolesByUsers = new HashSet<RolesByUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PermissionsByRole> PermissionsByRoles { get; set; }
        public virtual ICollection<RolesByUser> RolesByUsers { get; set; }
    }
}
