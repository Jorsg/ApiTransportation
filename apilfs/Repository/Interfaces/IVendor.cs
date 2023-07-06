using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apilfs.Repository.Interfaces
{
    public interface IVendor
    {
        IQueryable<Models.Vendor> GetVendors();
        IQueryable<Models.Vendor> GetVendors(int id);
        IQueryable<Models.Vendor> GetVendors(string code);
        Models.Vendor GetVendorByIdSaasSCAC(string IdSaasSCAC);
        Models.Vendor GetVendorByIdProviderNameSwanleap(string providerName);
        List<Models.Vendor> GetVendorsByProviderNameSL(string[] providersName);
        List<Models.Vendor> GetVendorsByIdSaasSCAC(string[] IdsSaasSCAC);
        void InsertVendor(Models.Vendor vendor);
        void Save();
        void Update(Models.Vendor vendor);
        void Delete(Models.Vendor vendor);


    }
}
