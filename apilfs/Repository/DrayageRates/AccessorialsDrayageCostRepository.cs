using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.DrayageRates
{
    public class AccessorialsDrayageCostRepository : IAccessorialsDrayageCost
    {
        private readonly BD_LFSContext _context;
        public AccessorialsDrayageCostRepository(BD_LFSContext context)
        {
            _context = context;
        }


        public IQueryable<AccessorialsDrayageCost> GetAccessorialsDrayageCosts()
        {
            return _context.AccessorialsDrayageCosts;
        }
    }
}
