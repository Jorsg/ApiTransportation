using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Mode
    {
        public Mode()
        {
            LeastCostCarriers = new HashSet<LeastCostCarrier>();
        }

        public int Id { get; set; }
        public string ModeGroup { get; set; }
        public string Mode1 { get; set; }
        public string Company { get; set; }
        public string ServiceLevelYat { get; set; }
        public string ServiceLevelSwanleap { get; set; }
        public string ServiceLevelSaas { get; set; }

        public virtual ModeGroup ModeGroupNavigation { get; set; }
        public virtual ICollection<LeastCostCarrier> LeastCostCarriers { get; set; }
    }
}
