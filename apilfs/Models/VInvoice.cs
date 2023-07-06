using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class VInvoice
    {
        public string Invoice { get; set; }
        public int? DocEntry { get; set; }
        public string TypeInvoive { get; set; }
        public string DocNum { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public string CardCode { get; set; }
        public string Bol { get; set; }
        public string Currency { get; set; }
        public string AcctCode { get; set; }
        public string ItemCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? PriceItem { get; set; }
        public decimal? TotalRevenue { get; set; }
        public string Comments { get; set; }
        public string ObjType { get; set; }
        public string Customer { get; set; }
        public string ModeGroupSap { get; set; }
        public string ItemName { get; set; }
        public string ShipmentStatus { get; set; }
        public string ModeGroup { get; set; }
        public string Service { get; set; }
        public string CodeCustomer { get; set; }
        public string CustomerOffice { get; set; }
        public string ZipcodeOrigen { get; set; }
        public string ZipcodeDestino { get; set; }
        public string OriginCountry { get; set; }
        public string OriginStreet1 { get; set; }
        public string OriginCity { get; set; }
        public string OriginCompany { get; set; }
        public string OriginName { get; set; }
        public string OriginPhone { get; set; }
        public string OriginEmail { get; set; }
        public string DestinationCountry { get; set; }
        public string DestinationStreet1 { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationCompany { get; set; }
        public string DestinationName { get; set; }
        public string Controlled { get; set; }
        public decimal? SellPrice { get; set; }
        public int? SellRate { get; set; }
        public int? SellFuel { get; set; }
        public int? SellOther { get; set; }
        public int? SellDiscount { get; set; }
        public string Hazmat { get; set; }
        public decimal? Pieces { get; set; }
        public decimal? TotalWeight { get; set; }
        public decimal? Class { get; set; }
        public decimal? Density { get; set; }
        public decimal? Ctf { get; set; }
        public string DaysOverdue { get; set; }
        public decimal? Distance { get; set; }
        public string PiecesDetail { get; set; }
        public string Commodities { get; set; }
        public string CreatorUser { get; set; }
        public string NameCustomer { get; set; }
        public string CreditTerms { get; set; }
        public string Address1 { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Fax { get; set; }
        public string Vendor { get; set; }
        public string ReferenceBol { get; set; }
    }
}
