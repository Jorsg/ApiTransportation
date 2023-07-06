using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.Repository.Commodity
{
    public class CommoditiesRespository : ICommodities
    {
        private readonly BD_LFSContext _context;

        public CommoditiesRespository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.Commodity> GetCommodities()
        {
            return _context.Commodities;
        }

        public IQueryable<Models.Commodity> GetCommodities(string code)
        {
            return _context.Commodities.Where(elm => elm.CodeCommodities == code);
        }

        public IQueryable<Models.Commodity> GetCommoditiesName(string name)
        {
            return _context.Commodities.Where(elm => elm.Name == name);
        }
    }
}
