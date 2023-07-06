using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class AccessorialsCopy
    {
        public int Id { get; set; }
        public string AccessorialCode { get; set; }
        public string Name { get; set; }
        public string IdYat { get; set; }
        public string IdSaas { get; set; }
        public string IdSwanLeap { get; set; }
        public decimal? Cost { get; set; }
        public string NameYat { get; set; }
        public string NameSaas { get; set; }
        public string NameSwanLeap { get; set; }
        public bool? CheckAccesorials { get; set; }
        public int? IdModegroup { get; set; }
        public string Type { get; set; }
    }
}
