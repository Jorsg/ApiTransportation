using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class UsersCopium
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
    }
}
