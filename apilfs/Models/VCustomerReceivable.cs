using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class VCustomerReceivable
    {
        public string Code { get; set; }
        public decimal? ValorOverdue { get; set; }
        public decimal? ValorNoDue { get; set; }
        public decimal? TotalReceivables { get; set; }
        public decimal? CreditLimit { get; set; }
        public decimal? CreditAvailable { get; set; }
    }
}
