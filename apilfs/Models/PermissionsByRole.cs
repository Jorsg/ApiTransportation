using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class PermissionsByRole
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public int IdPermission { get; set; }

        public virtual Permission IdPermissionNavigation { get; set; }
        public virtual Role IdRoleNavigation { get; set; }
    }
}
