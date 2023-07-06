using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class AccessorialsPerQuote
    {
        public int Id { get; set; }
        public int IdAccessorial { get; set; }
        public int IdQuote { get; set; }
        public decimal? Price { get; set; }

        public virtual Accessorial IdAccessorialNavigation { get; set; }
        public virtual Quote IdQuoteNavigation { get; set; }
    }
}
