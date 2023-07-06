using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class RolesByUser
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
