using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Tier
{
    public class TierRepository : ITier
    {
        private readonly BD_LFSContext _context;

        public TierRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public Models.Tier GetByTier(string tier)
        {
            return _context.Tiers.Where(elm => elm.Tier1 == tier).FirstOrDefault();
        }

    }
}
