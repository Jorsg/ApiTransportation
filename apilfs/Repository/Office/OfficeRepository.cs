using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Office
{
    public class OfficeRepository : IOffice
    {
        private readonly BD_LFSContext _context;

        public OfficeRepository(BD_LFSContext context)
        {
            _context = context;
        }

        Models.Office IOffice.GetOfficeByName(string name)
        {
            return _context.Offices.Where(elm => elm.Name == name).FirstOrDefault();
        }

    }
}
