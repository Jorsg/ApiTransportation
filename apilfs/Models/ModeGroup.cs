using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class ModeGroup
    {
        public ModeGroup()
        {
            Accessorials = new HashSet<Accessorial>();
            Insurances = new HashSet<Insurance>();
            Modes = new HashSet<Mode>();
            Quotes = new HashSet<Quote>();
            TypeTrucks = new HashSet<TypeTruck>();
        }

        public int Id { get; set; }
        public string IdModeGroup { get; set; }
        public string Description { get; set; }
        public string BusinessUnit { get; set; }
        public string Company { get; set; }
        public string ModeType { get; set; }

        public virtual ICollection<Accessorial> Accessorials { get; set; }
        public virtual ICollection<Insurance> Insurances { get; set; }
        public virtual ICollection<Mode> Modes { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<TypeTruck> TypeTrucks { get; set; }
    }
}
