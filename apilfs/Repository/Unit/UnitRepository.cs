using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Repository.Unit
{
    public class UnitRepository : IUnit
    {
        private readonly BD_LFSContext _context;

        public UnitRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.Unit> GetUnits()
        {
            return _context.Units;
        }

        public Models.Unit GetUnitbyId(string unit)
        {
            return _context.Units.FirstOrDefault(elm => elm.Name == unit);
        }

        public void InsertUnit(Models.Unit unit)
        {
            _context.Units.Add(unit);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
