using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class PortsRamp
    {
        public PortsRamp()
        {
            Drayages = new HashSet<Drayage>();
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public string ZipCode { get; set; }
        public int? IdZipcode { get; set; }
        public string Messages { get; set; }
        public bool? Activo { get; set; }

        public virtual ZipCode IdZipcodeNavigation { get; set; }
        public virtual ICollection<Drayage> Drayages { get; set; }
    }
}
