using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Funtions
{
    public class V_CustomerStatusRepository : IVCustomerStatus
    {
        private readonly BD_LFSContext _context;

        public V_CustomerStatusRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public IQueryable<VCustomerStatus> GetVCustomer(string customerCode)
        {
            
            var query = _context.VCustomerStatuses.Where(elm => elm.CardCode == customerCode );
            return query;
        }
    }
}
