using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Repository.Accessorial
{
    public class AccesorialsRespository : IAccesorials
    {
        private readonly BD_LFSContext _context;

        public AccesorialsRespository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.Accessorial> GetAccessorials()
        {
            var query = _context.Accessorials;
            return query;
        }

        public IQueryable<Models.Accessorial> GetAccessorialsByIdsOrCodes(List<int> ids, List<string> codes)
        {
            var query = from a in _context.Accessorials where ids.Contains(a.Id) || codes.Contains(a.AccessorialCode) select a;
            return query;
        }


        public IQueryable<Models.Accessorial> GetAccessorials(string accesorials)
        {
            return _context.Accessorials.Where(elm => elm.Name.Contains(accesorials)).OrderBy(x => x.Id);
        }

        public void InsertAccesorials(Models.Accessorial accessorial)
        {
            _context.Accessorials.Add(accessorial);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


    }
}
