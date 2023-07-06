using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class DraftDelivery
    {
        public int Id { get; set; }
        public int IdDraft { get; set; }
        public string LocationName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string AddreesType { get; set; }
        public string ContactName { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string Reference { get; set; }
        public string SpecialIntruction { get; set; }
        public string Accesorials { get; set; }
        public TimeSpan? InitialTime { get; set; }
        public TimeSpan? FinalTime { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }
    }
}
