using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class AccesorialTypeTruck
    {
        public int Id { get; set; }
        public int IdAccesorial { get; set; }
        public int? IdTypeTruck { get; set; }

        public virtual Accessorial IdAccesorialNavigation { get; set; }
        public virtual TypeTruck IdTypeTruckNavigation { get; set; }
    }
}
