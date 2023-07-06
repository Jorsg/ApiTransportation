using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Repository.Drayage
{
    public class DrayageRepository : IDrayage
    {
        private readonly BD_LFSContext _context;
        public DrayageRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.Drayage> GetDrayages()
        {
            return _context.Drayages;
        }

        public IQueryable<Models.Drayage> GetDrayages(int idPortRamp, int idCustormers, int idVendors)
        {
            return _context.Drayages.Where(elm => elm.IdPortRamp == idPortRamp && elm.IdCustomer == idCustormers && elm.IdVendor == idVendors );
        }
    }
}
