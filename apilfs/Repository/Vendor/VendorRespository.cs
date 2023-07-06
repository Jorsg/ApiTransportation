using apilfs.Models;
using apilfs.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace apilfs.Repository.Vendor
{
    public class VendorRespository : IVendor
    {
        private readonly BD_LFSContext _context;

        public VendorRespository(BD_LFSContext context)
        {
            _context = context;
        }

        public void Delete(Models.Vendor vendor)
        {
            _context.Remove(vendor);
        }

        public IQueryable<Models.Vendor> GetVendors()
        {
            return _context.Vendors;
        }

        public IQueryable<Models.Vendor> GetVendors(int id)
        {
            return _context.Vendors.Where(elm => elm.Id == id);
        }

        public Models.Vendor GetVendorByIdSaasSCAC(string IdSaasSCAC)
        {
            return _context.Vendors.Where(elm => elm.ProviderScacSaas == IdSaasSCAC).FirstOrDefault();
        }

        public Models.Vendor GetVendorByIdProviderNameSwanleap(string providerName)
        {
            return _context.Vendors.Where(elm => elm.ProviderNameSwanleap == providerName).FirstOrDefault();
        }

        public List<Models.Vendor> GetVendorsByIdSaasSCAC(string[] IdsSaasSCAC)
        {
            List<Models.Vendor> carriers = new List<Models.Vendor>();
            foreach (string idScac in IdsSaasSCAC)
            {
                Models.Vendor carrier = _context.Vendors.Where(elm => elm.ProviderScacSaas == idScac).FirstOrDefault();
                if(carrier != null && carrier.ProviderScacSaas != "" && carrier.ProviderScacSaas != null)
                {
                    carriers.Add(carrier);
                }
            }
            return carriers;
        }

        public List<Models.Vendor> GetVendorsByProviderNameSL(string[] providersName)
        {
            List<Models.Vendor> carriers = new List<Models.Vendor>();
            foreach (string name in providersName)
            {
                Models.Vendor carrier = _context.Vendors.Where(elm => elm.ProviderNameSwanleap == name).FirstOrDefault();
                if (carrier != null)
                {
                    carriers.Add(carrier);
                }
            }
            return carriers;
        }

        public IQueryable<Models.Vendor> GetVendors(string code)
        {
            return _context.Vendors.Where(elm => elm.Code == code);
        }

        public void InsertVendor(Models.Vendor vendor)
        {
            _context.Vendors.Add(vendor);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Models.Vendor vendor)
        {
            _context.Update(vendor);
        }
    }
}
