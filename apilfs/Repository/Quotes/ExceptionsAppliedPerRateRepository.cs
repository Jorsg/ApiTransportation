using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Quotes
{
    public class ExceptionsAppliedPerRateRepository : IExceptionsAppliedPerRate
    {
        private readonly BD_LFSContext _context;

        public ExceptionsAppliedPerRateRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public bool insertExceptionsAppliedPerRate(DTO.Quote.ExceptionsAppliedPerRateDto exceptionsApplied, int idRates)
        {
            bool respuesta = false;
            try
            {
                var exception = new DTO.Quote.MapinExceptionAppliePerRate().MapingToDto(exceptionsApplied, idRates);
                _context.ExceptionsAppliedPerRates.Add(exception);
                Save();
                respuesta = true;
            }
            catch (Exception)
            {
                throw;
            }
            return respuesta;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool updateExceptionsAppliedPerRate(ExceptionsAppliedPerRate exceptionsApplied)
        {
            throw new NotImplementedException();
        }
    }
}
