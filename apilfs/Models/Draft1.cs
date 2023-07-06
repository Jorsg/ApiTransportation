using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Draft1
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string BolSwanleap { get; set; }
        public bool? BookWithAgent { get; set; }
        public decimal Weight { get; set; }
        public string ModeGroup { get; set; }
        public bool? Hazmat { get; set; }
        public decimal? CargoInsurance { get; set; }
        public string RateId { get; set; }
        public int CarrierId { get; set; }
        public string Scac { get; set; }
        public decimal GrossCharge { get; set; }
        public decimal? MinInsuredCost { get; set; }
        public decimal NetCharge { get; set; }
        public decimal? FuelSurcharge { get; set; }
        public decimal? Discount { get; set; }
        public decimal TotalShipmentCost { get; set; }
        public decimal NetPricesTotalShipmentCost { get; set; }
        public decimal? NetPricesFuelSurcharge { get; set; }
        public decimal NetPricesGrossCharge { get; set; }
        public decimal? NetPricesDiscount { get; set; }
        public decimal? NetPricesAccessorialCharges { get; set; }
        public int? TransitDays { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string ServiceLevelDescription { get; set; }
    }
}
