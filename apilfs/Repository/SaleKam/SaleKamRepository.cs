using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.SaleKam
{
    public class SaleKamRepository : ISalesKam
    {
        private readonly BD_LFSContext _context;

        public SaleKamRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public SalesKam GetSalesKamByEmail(string email)
        {
            return _context.SalesKams.Where(elm => elm.Email == email).FirstOrDefault();
        }

        public SalesKam GetSalesKamByName(string name)
        {
            return _context.SalesKams.Where(elm => elm.NameSalesKam == name).FirstOrDefault();
        }

        public bool GetSalesKamExits(string name, string email)
        {
            bool respuesta = false;
            var result = _context.SalesKams.Where(elm => elm.NameSalesKam == name || elm.Email == email);
            if (result.Any())
                return respuesta = true;
            else
                return respuesta;
        }

        public void InsertSalesKam(Models.SalesKam salesKam)
        {
            _context.SalesKams.Add(salesKam);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
