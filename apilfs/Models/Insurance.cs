using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Insurance
    {
        public int Id { get; set; }
        public int IdModeGroup { get; set; }
        public int IdCustomer { get; set; }
        public int IdTier { get; set; }
        public string TipoMercancia { get; set; }
        public decimal MinValorCarga { get; set; }
        public decimal MaxValorCarga { get; set; }
        public decimal ValorMinima { get; set; }
        public decimal? MinCostAsegurado { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? Formula { get; set; }
        public bool? OrigenMexico { get; set; }
        public bool? DestinoMexico { get; set; }
        public decimal? ValorMaximoMinima { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
        public virtual ModeGroup IdModeGroupNavigation { get; set; }
        public virtual Tier IdTierNavigation { get; set; }
    }
}
