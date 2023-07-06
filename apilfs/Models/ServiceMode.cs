using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class ServiceMode
    {
        public ServiceMode()
        {
            MexicoRates = new HashSet<MexicoRate>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MexicoRate> MexicoRates { get; set; }
    }
}
