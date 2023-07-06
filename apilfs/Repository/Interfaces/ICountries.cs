using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ICountries
    {
        IQueryable<Models.Country> GetCountries();

        IQueryable<Models.Country> GetCountries(string name);
        Models.Country GetCountryByIsoCode(string isoCode);
        void InsertCountries(Models.Country country);

        void Save();

        void Delete(Models.Country country);

        void Update(Models.Country country);
    }
}
