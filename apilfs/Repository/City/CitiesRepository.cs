using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.Repository.City
{
    public class CitiesRepository : ICities
    {
        private readonly BD_LFSContext _context;

        public CitiesRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public void Delete(Models.City city)
        {
            _context.Cities.Remove(city);
        }

        public IQueryable<Models.City> GetCities()
        {
            return _context.Cities;
        }

        public IQueryable<Models.City> GetCities(string name)
        {
            return _context.Cities.Where(elm => elm.Name.Contains(name));
        }

        public Models.City GetCitiesByNameAndState(string name, int idState)
        {
            return _context.Cities.Where(elm => elm.Name.Contains(name) && elm.IdState == idState).FirstOrDefault();
        }

        public void InsertCities(Models.City city)
        {
            _context.Cities.Add(city);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Models.City city)
        {
            _context.Cities.Update(city);
        }
    }
}
