using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Funtions
{
    public class V_InvoiceRepository : IVInvoice
    {
        private readonly BD_LFSContext _context;

        public V_InvoiceRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public IQueryable<VInvoice> GetInvoices(string docNum)
        {
            return _context.VInvoices.Where(elm => elm.DocNum == docNum);
        }
    }
}
