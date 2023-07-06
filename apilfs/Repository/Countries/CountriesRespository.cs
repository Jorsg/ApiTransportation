using apilfs.Models;
using apilfs.Repository.Interfaces;
using System.Linq;


namespace apilfs.Repository.Countries
{
    public class CountriesRespository : ICountries
    {
        private readonly BD_LFSContext _context;

        public CountriesRespository(BD_LFSContext context)
        {
            _context = context;
        }
        public void Delete(Country country)
        {
            _context.Countries.Remove(country);
        }

        public IQueryable<Country> GetCountries()
        {
            return _context.Countries.Where(elm => elm.Insurance == true);
        }

        public IQueryable<Country> GetCountries(string code)
        {
            return _context.Countries.Where(elm => elm.Iso2Code == code);
        }

        public Country GetCountryByIsoCode(string isoCode)
        {
            return _context.Countries.Where(elm => elm.Iso2Code == isoCode || elm.Iso3Code == isoCode).FirstOrDefault();
        }

        public void InsertCountries(Country country)
        {
            _context.Countries.Add(country);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Country country)
        {
            _context.Countries.Update(country);
        }
    }
}
