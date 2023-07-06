using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class DraftDelevery
    {
        public int Id { get; set; }
        public int IdDraft { get; set; }
        public string LocationName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string AddreesType { get; set; }
        public string CustomerName { get; set; }
        public string Stree1 { get; set; }
        public string Stree2 { get; set; }
        public int Reference { get; set; }
        public string SpecialIntruction { get; set; }
        public string Accesorials { get; set; }
        public DateTime InitialTime { get; set; }
        public DateTime? FinalTime { get; set; }
    }
}
