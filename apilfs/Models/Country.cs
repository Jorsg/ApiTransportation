using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Iso2Code { get; set; }
        public string Iso3Code { get; set; }
        public string NameTitleCase { get; set; }
        public string NumCode { get; set; }
        public string PhoneCode { get; set; }
        public bool? Insurance { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
