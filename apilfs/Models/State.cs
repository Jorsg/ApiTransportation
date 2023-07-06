using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
            ZipCodes = new HashSet<ZipCode>();
        }

        public int Id { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<ZipCode> ZipCodes { get; set; }
    }
}
