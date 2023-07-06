using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Funtions
{
    public class V_CustomerBillingRepository : IVCustomerBilling
    {
        private readonly BD_LFSContext _context;

        public V_CustomerBillingRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public IQueryable<VCustomerBilling> GetCustomerBillings(string customerCode)
        {
            return  _context.VCustomerBillings.Where(elm => elm.Code == customerCode);
           
            
        }
    }
}
