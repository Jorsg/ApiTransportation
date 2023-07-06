using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class DraftOfficeCustomer
    {
        public int Id { get; set; }
        public int IdDraft { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string LocationId { get; set; }
    }
}
