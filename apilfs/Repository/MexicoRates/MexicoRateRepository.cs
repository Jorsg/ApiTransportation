using apilfs.DTO;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.MexicoRates
{
    public class MexicoRateRepository : IMexicoRate
    {
        private readonly BD_LFSContext _context;

        private readonly IZipCode _zipCode;
        private readonly ICities _cities;
        private readonly ITypeTruck _typeTruck;
        

        public MexicoRateRepository(BD_LFSContext contexto, IZipCode zipCode, ITypeTruck typeTruck, ICities cities)
        {
            _context = contexto;        
            _typeTruck = typeTruck;
            _zipCode = zipCode;
            _cities = cities;
        }
        public IQueryable<MexicoRate> GetMexicoRate()
        {
            return _context.MexicoRates;
        }

        public IQueryable<MexicoRatesDto> GetMexicoRate(string zipCodeFrom, string zipCodeTo, string countryFrom, string countryTo, int idTypeTruck)
        {
            var zipFrom = _zipCode.GetZipCodeByZipCodeAndCountry(countryFrom, zipCodeFrom);
            var zipTo = _zipCode.GetZipCodeByZipCodeAndCountry(countryTo, zipCodeTo);

            var idCityFrom = _cities.GetCitiesByNameAndState(zipFrom.City, zipFrom.IdState).Id;
            var idCityTo = _cities.GetCitiesByNameAndState(zipTo.City, zipTo.IdState).Id;

            var query = from mx in _context.MexicoRates
                        join sm in _context.ServiceModes on mx.IdServiceMode equals sm.Id
                        join tt in _context.TypeTrucks on mx.IdTypeTruck equals tt.Id
                        where mx.IdTypeTruck == idTypeTruck && mx.IdCityFrom == idCityFrom && mx.IdCityTo == idCityTo
                        select new MexicoRatesDto
                        {
                            Id = mx.Id,
                            IdCityFrom = mx.IdCityFrom,
                            IdCityTo = mx.IdCityTo,
                            IdTypeTruck = mx.IdTypeTruck,
                            TypeTruck = tt.Name,
                            IdServiceMode = mx.IdServiceMode,
                            ServiceMode = sm.Name,
                            Operation = mx.Operation,
                            TT = mx.Tt,
                            Cost = mx.Cost,
                            Sale = mx.Sale,
                            Empty = mx.Empty,
                            CityFrom = mx.CityFrom,
                            CityTo = mx.CityTo
                        };


            return query;

        }     
       
    }
}
