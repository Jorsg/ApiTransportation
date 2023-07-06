using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Repository.ZipCodes
{
    public class ZipCodeRepository : IZipCode
    {
        private readonly BD_LFSContext _contexto;
        public ZipCodeRepository(BD_LFSContext context)
        {
            _contexto = context;
        }

        /// <summary>
        /// Consulta el valor del zipCode 
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns></returns>
        public IQueryable<ZipCode> GetZipCode(string zipcode)
        {
            var query = _contexto.ZipCodes.Where(elm =>elm.ZipCode1.Contains(zipcode.Substring(0,5))).Take(20).OrderBy(x => x.Id);
            return query;
        }

        public ZipCodeByState GetZipCodeByZipCodeAndCountry(string country, string zipcode)
        {
           
            var query = from zip in _contexto.ZipCodes
                        join state in _contexto.States on zip.IdState equals state.Id
                        join countries in _contexto.Countries on state.CountryCode equals countries.Iso2Code
                        where (countries.Iso2Code == country || countries.Iso3Code == country) && zip.ZipCode1 == zipcode
                        select new ZipCodeByState
                        {
                            FullZipCode = zip.FullZipCode,
                            CountryIsoCode2 = countries.Iso2Code,
                            CountryIsoCode3 = countries.Iso3Code,
                            ZipCode1 = zip.ZipCode1,
                            City = zip.City,
                            DaylightSaving = zip.DaylightSaving,
                            Id = zip.Id,
                            TimeZone = zip.TimeZone,
                            State = state.StateCode,
                            IdState = state.Id
                        };
            return query.FirstOrDefault();
        }

        public IQueryable<ZipCodeByState> GetZipCodeFullName(string fullZipCode)
        {

            var query = from zip in _contexto.ZipCodes
                        join state in _contexto.States on zip.IdState equals state.Id
                        where zip.FullZipCode.Contains(fullZipCode.Substring(0, 5))
                        select new ZipCodeByState
                        {
                            FullZipCode = zip.FullZipCode,
                            CountryIsoCode2 = state.CountryCode,
                            ZipCode1 = zip.ZipCode1,
                            City = zip.City,
                            DaylightSaving = zip.DaylightSaving,
                            Id = zip.Id,
                            TimeZone = zip.TimeZone,
                            State = state.Name
                        };
            return query.OrderBy(x => x.Id).Take(30);
               
        }

        public IQueryable<ZipCode> GetZipCodeCity(string city)
        {
            return _contexto.ZipCodes.Where(elm => elm.City.Contains(city.Substring(0,5))).Take(90).OrderBy(x => x.Id);
        }

        public IQueryable<ZipCode> GetZipCodeCity()
        {
            return _contexto.ZipCodes;
        }

        public void InsertZipCode(ZipCode zipCode)
        {
            _contexto.ZipCodes.Add(zipCode);
        }

        public void Save()
        {
            _contexto.SaveChanges();
        }

       
    }
}
