using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.DTO.Draft;

namespace apilfs.Repository.Draft
{
    public class DraftAccesorialsChargeRepository : IDraftAccesorialsCharge
    {
        private readonly BD_LFSContext _context;

        public DraftAccesorialsChargeRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public bool DeleteDraf(DraftAccesorialsCharge draft)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DraftAccesorialsCharge> GetDrafts(int idDraft)
        {
            return _context.DraftAccesorialsCharges.Where(elm => elm.Id == idDraft);
        }

        public bool InsertDraft(DTO.Draft.DraftAccesorialsChargeDto draft, int idQuote)
        {
            bool respuesta = false;
            try
            {
                var accesorial = new DTO.Draft.MapinAccesorialsCharge().MapinDtoEntity(draft, idQuote);
                _context.DraftAccesorialsCharges.Add(accesorial);
                Save();
                respuesta = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                throw;
            }

            return respuesta;
            
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool UpdateDraft(DTO.Draft.DraftAccesorialsChargeDto draft, int id)
        {
            bool respuesta = false;
            try
            {
                var accesorial = new DTO.Draft.MapinAccesorialsCharge().MapinDtoEntity(draft, id);
                _context.DraftAccesorialsCharges.Update(accesorial).State = Microsoft.EntityFrameworkCore.EntityState.Modified; 
                Save();
                respuesta = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;               
            }
            return respuesta;
        }
    }
}
