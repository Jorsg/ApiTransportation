using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            Drayages = new HashSet<Drayage>();
            LeastCostCarriers = new HashSet<LeastCostCarrier>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Contact { get; set; }
        public string VendorGroup { get; set; }
        public string PaymentMetod { get; set; }
        public string Payto { get; set; }
        public string PaytoCountry { get; set; }
        public string PaytoZipcode { get; set; }
        public string PaytoCity { get; set; }
        public string PaytoAddress { get; set; }
        public string Company { get; set; }
        public string Mc { get; set; }
        public decimal? ServiceScore { get; set; }
        public string Image { get; set; }
        public string Services { get; set; }
        public decimal? CarrierLiability { get; set; }
        public string ProviderScacSwanleap { get; set; }
        public string ProviderNameSwanleap { get; set; }
        public string ProviderNameSaas { get; set; }
        public string ProviderScacSaas { get; set; }
        public string Details { get; set; }
        public string ValidityRate { get; set; }
        public bool? Tsa { get; set; }
        public bool? Cfs { get; set; }

        public virtual ICollection<Drayage> Drayages { get; set; }
        public virtual ICollection<LeastCostCarrier> LeastCostCarriers { get; set; }
    }
}
