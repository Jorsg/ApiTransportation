using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Unit
    {
        public Unit()
        {
            Quotes = new HashSet<Quote>();
            ShipmentsPerQuotes = new HashSet<ShipmentsPerQuote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<ShipmentsPerQuote> ShipmentsPerQuotes { get; set; }
    }
}
