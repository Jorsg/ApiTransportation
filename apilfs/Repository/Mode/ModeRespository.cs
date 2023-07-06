using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Repository.Mode
{
    public class ModeRespository :  IMode
    {
        private readonly BD_LFSContext _context;

        public ModeRespository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.Mode> GetModes()
        {
            return  _context.Modes;           
        }

        public IQueryable<Models.Mode> GetModes(string modeGroup)
        {
            var query = _context.Modes.Where(elm => elm.ServiceLevelYat == modeGroup || elm.ServiceLevelSwanleap == modeGroup 
                                             || elm.ServiceLevelSaas == modeGroup);
            return query;
        }

        public IQueryable<Models.Mode> GetModesbyMode(string mode)
        {
            return _context.Modes.Where(elm => elm.Mode1 == mode);
        }

        public Models.Mode GetModebyServiceLevelSaas(string serviceLevelSaas)
        {
            return _context.Modes.Where(elm => elm.ServiceLevelSaas == serviceLevelSaas).FirstOrDefault();
        }

        public Models.Mode GetModebyServiceLevelYat(string serviceLevelYat)
        {
            return _context.Modes.Where(elm => elm.ServiceLevelYat == serviceLevelYat).FirstOrDefault();
        }
    }
}
