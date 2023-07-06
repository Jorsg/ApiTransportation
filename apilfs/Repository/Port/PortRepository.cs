using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Repository.Port
{
    public class PortRepository : IPort
    {
        private readonly BD_LFSContext _context;

        public PortRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.PortsRamp> GetPort()
        {
            return _context.PortsRamps;
        }

        public IQueryable<Models.PortsRamp> GetPort(string codePort)
        {
            return _context.PortsRamps.Where(elm => elm.ZipCode == codePort);
        }

        public void InsertPort(Models.PortsRamp port)
        {
            _context.PortsRamps.Add(port);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
