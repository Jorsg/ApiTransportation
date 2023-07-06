using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class VConfigInsurance
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Tier { get; set; }
        public int IdModeGroup { get; set; }
        public int IdCustomer { get; set; }
        public string TipoMercancia { get; set; }
        public decimal MinValorCarga { get; set; }
        public decimal MaxValorCarga { get; set; }
        public decimal ValorMinima { get; set; }
        public decimal? MinCostAsegurado { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? Formula { get; set; }
        public bool? OrigenMexico { get; set; }
        public bool? DestinoMexico { get; set; }
        public string Source { get; set; }
        public decimal? ValorMaximoMinima { get; set; }
    }
}
