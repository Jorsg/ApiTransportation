using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class DraftInsurance
    {
        public int Id { get; set; }
        public int IdDraft { get; set; }
        public string InsuredCargoOwner { get; set; }
        public string CargoOwnerCountry { get; set; }
        public decimal? TotalCargoValue { get; set; }
        public bool? InsureFreight { get; set; }
        public decimal? CargoInsuran { get; set; }
        public decimal? MinInsuredCost { get; set; }
        public string CommodityType { get; set; }
        public bool? CargoInsuranceActive { get; set; }
    }
}
