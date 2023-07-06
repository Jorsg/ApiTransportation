using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ITypeTruck
    {
        IQueryable<Models.TypeTruck> GetTypeTrucks();

        Models.TypeTruck GetTypeTrucks(int Id);
    }
}
