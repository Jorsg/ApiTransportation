using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ICities
    {
        IQueryable<Models.City> GetCities();

        IQueryable<Models.City> GetCities(string name);
        Models.City GetCitiesByNameAndState(string name, int idState);

        void InsertCities(Models.City city);

        void Save();

        void Update(Models.City city);

        void Delete(Models.City city);
    }
}
