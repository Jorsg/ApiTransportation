using apilfs.DTO;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.MexicoRates
{
    public class CrossBorderCostRepository : ICrossBorderCost
    {
        private readonly BD_LFSContext _context;      

        public CrossBorderCostRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public CrossBorderCost GetCrosBorderCostByTypeTruck(int IdTypeTruck)
        {
            return _context.CrossBorderCosts.Where(elm => elm.IdTypeTruck == IdTypeTruck).FirstOrDefault();
        }
    }
}
