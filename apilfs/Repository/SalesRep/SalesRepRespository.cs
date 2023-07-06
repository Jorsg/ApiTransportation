using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Repository.SalesRep
{
    public class SalesRepRespository : ISalesAgent
    {
        private readonly BD_LFSContext _context;

        public SalesRepRespository(BD_LFSContext context)
        {
            _context = context;
        }

        public void Delete(Models.SalesRep salesRep)
        {
            _context.SalesReps.Remove(salesRep);
        }

        public IQueryable<Models.SalesRep> GetSalesReps()
        {
            return _context.SalesReps;
        }

        public IQueryable<Models.SalesRep> GetSalesReps(string codeSalesRep)
        {
            return _context.SalesReps.Where(elm => elm.Code == codeSalesRep);
        }

        public Models.SalesRep GetSalesRepByEmail(string email)
        {
            return _context.SalesReps.Where(elm => elm.Email == email).FirstOrDefault();
        }

        public void InsertSalesRep(Models.SalesRep salesRep)
        {
            _context.SalesReps.Add(salesRep);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Models.SalesRep salesRep)
        {
            _context.SalesReps.Update(salesRep);
        }

        public Models.SalesRep GetSalesRepByName(string name)
        {
            return _context.SalesReps.Where(elm => elm.NameSalesRep == name).FirstOrDefault();
        }

        public bool GetSalesRepExits(string name, string email)
        {
            bool respuesta = false;
            var result = _context.SalesReps.Where(elm => elm.NameSalesRep == name || elm.Email == email);
            if (result.Any())
                return respuesta = true;
            else
                return respuesta;
        }
    }
}
