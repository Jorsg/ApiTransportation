using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class ShipmentsPerQuote
    {
        public int Id { get; set; }
        public decimal? Class { get; set; }
        public decimal? Stack { get; set; }
        public decimal? Pieces { get; set; }
        public int? IdUnit { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string MeasurementUnit { get; set; }
        public decimal? Cft { get; set; }
        public decimal? Cmb { get; set; }
        public decimal? Density { get; set; }
        public int IdQuote { get; set; }

        public virtual Quote IdQuoteNavigation { get; set; }
        public virtual Unit IdUnitNavigation { get; set; }
    }
}
