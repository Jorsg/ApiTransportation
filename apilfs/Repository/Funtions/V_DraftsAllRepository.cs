using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Funtions
{
    public class V_DraftsAllRepository : IVDraftsAll
    {
        private readonly BD_LFSContext _context;
        
        public V_DraftsAllRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<VDraftsAll> GetDraftsAll(int idDraft)
        {
            var query = _context.VDraftsAlls.Where(elm => elm.IdDrafPrincipal == idDraft);
            return query;
        }
    }
}
