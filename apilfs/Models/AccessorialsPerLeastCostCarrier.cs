using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class AccessorialsPerLeastCostCarrier
    {
        public int Id { get; set; }
        public int IdLeastCostCarrier { get; set; }
        public int IdAccessorial { get; set; }
        public decimal? Charge { get; set; }
        public string AccessorialDescription { get; set; }

        public virtual Accessorial IdAccessorialNavigation { get; set; }
        public virtual LeastCostCarrier IdLeastCostCarrierNavigation { get; set; }
    }
}
