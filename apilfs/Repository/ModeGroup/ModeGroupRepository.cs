using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.Repository.ModeGroup
{
    public class ModeGroupRepository : IModeGroup
    {
        private readonly BD_LFSContext _context;

        public ModeGroupRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public void Delete(Models.ModeGroup modeGroup)
        {
            _context.ModeGroups.Remove(modeGroup);
        }

        public IQueryable<Models.ModeGroup> GetModeGroups()
        {
            return _context.ModeGroups;
        }

        public IQueryable<Models.ModeGroup> GetModeGroups(string modeGroup)
        {
            return _context.ModeGroups.Where(elm => elm.BusinessUnit == modeGroup);
        }

        public Models.ModeGroup GetModeGroupByBusinessUnit(string businessUnit)
        {
            return _context.ModeGroups.Where(elm => elm.BusinessUnit == businessUnit).FirstOrDefault();
        }

        public void InsertModeGroup(Models.ModeGroup modeGroup)
        {
            _context.ModeGroups.Add(modeGroup);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Models.ModeGroup modeGroup)
        {
            _context.ModeGroups.Update(modeGroup);
            Save();
        }
    }
}
