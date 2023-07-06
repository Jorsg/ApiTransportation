using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.Repository.TypeTruck
{
    public class TypeTruckRepository : ITypeTruck
    {
        private readonly BD_LFSContext _context;

        public TypeTruckRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.TypeTruck> GetTypeTrucks()
        {
            return _context.TypeTrucks;
        }

        public Models.TypeTruck GetTypeTrucks(int Id)
        {
            return _context.TypeTrucks.Where(elm => elm.Id == Id).FirstOrDefault();
        }
    }
}
