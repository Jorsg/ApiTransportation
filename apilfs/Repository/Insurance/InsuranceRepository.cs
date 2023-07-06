using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Repository.Insurance
{
    public class InsuranceRepository : IInsurance
    {
        private readonly BD_LFSContext _context;

        public InsuranceRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public IQueryable<Models.Insurance> GetInsurances()
        {
            return _context.Insurances;
        }

        public IQueryable<Models.Insurance> GetInsurancesMode(int mode)
        {
            return _context.Insurances.Where(elm=> elm.IdModeGroup == mode); // cambiar a post, filtro, mode, customer, tier, valor minimo, business unit, origen, destino
        }

        public void InsertInsurance(Models.Insurance insurance)
        {
            try
            {
                _context.Insurances.Add(insurance);
                Save();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                throw;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateInsurance(Models.Insurance insurance)
        {
            throw new NotImplementedException();
        }
    }
}
