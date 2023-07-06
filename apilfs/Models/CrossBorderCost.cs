using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class CrossBorderCost
    {
        public int Id { get; set; }
        public int IdTypeTruck { get; set; }
        public decimal? Cost { get; set; }

        public virtual TypeTruck IdTypeTruckNavigation { get; set; }
    }
}
