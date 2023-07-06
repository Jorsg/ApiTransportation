using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class DraftCommodity
    {
        public int Id { get; set; }
        public int IdDraft { get; set; }
        public decimal? CommodityClass { get; set; }
        public string Unit { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public string Description { get; set; }
        public decimal? Weight { get; set; }
        public bool? Hazmat { get; set; }
        public string HazmatClass { get; set; }
        public string UnNumber { get; set; }
        public string ParkingGroup { get; set; }
        public decimal? Height { get; set; }
        public bool? TeamService { get; set; }
        public bool? CrossBorder { get; set; }
    }
}
