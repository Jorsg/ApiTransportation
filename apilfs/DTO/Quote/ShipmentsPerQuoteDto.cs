using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.DTO.Quote
{
    public class ShipmentsPerQuoteDto
    {
        public int Id { get; set; }
        public decimal? Class { get; set; }
        public decimal? Stack { get; set; }
        public decimal? Pieces { get; set; }
        public string Unit { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string MeasurementUnit { get; set; }
        public decimal? Cft { get; set; }
        public decimal? Cmb { get; set; }       
        public decimal? Density { get; set; }
        public int IdQuote { get; set; }      

    }

    public class MapinShipmentsPerQuote
    { 
        public Models.ShipmentsPerQuote MapinShipmentsToDto(ShipmentsPerQuoteDto shipments, int IdQuote, int idUnit)
        {
            Models.ShipmentsPerQuote _shipments = new Models.ShipmentsPerQuote();

            _shipments.Cft = shipments.Cft;
            _shipments.Class = shipments.Class;
            _shipments.Cmb = shipments.Cmb;
            _shipments.Height = shipments.Height;
            _shipments.IdQuote = IdQuote;
            _shipments.IdUnit = idUnit;
            _shipments.Length = shipments.Length;
            _shipments.MeasurementUnit = shipments.MeasurementUnit;
            _shipments.Pieces = shipments.Pieces;
            _shipments.Stack = shipments.Stack;
            _shipments.Weight = shipments.Weight;
            _shipments.Width = shipments.Width;
            _shipments.Density = shipments.Density;
            
            return _shipments;
        }
    }
}
