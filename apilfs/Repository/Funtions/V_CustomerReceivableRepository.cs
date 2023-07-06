using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Funtions
{
    public class V_CustomerReceivableRepository : IVCustomerReceivable
    {
        private readonly BD_LFSContext _context;

        public V_CustomerReceivableRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public IQueryable<VCustomerReceivable> GetCustomerReceivables(string cardCode)
        {
            var query = _context.VCustomerReceivables.Where(elm => elm.Code == cardCode);
            return query;
        }
    }
}
