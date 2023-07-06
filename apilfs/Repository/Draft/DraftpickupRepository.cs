using apilfs.DTO.Draft;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Draft
{
    public class DraftpickupRepository : IDraftpickup
    {
        private readonly BD_LFSContext _context;

        public DraftpickupRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public bool DeleteDraf(DraftPickup draft)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DraftPickup> GetDrafts(int idDraft)
        {
            return _context.DraftPickups.Where(elm => elm.IdDraft == idDraft);
        }

        public bool InsertDraft(DTO.Draft.DraftpickupDto draft, int idDraft)
        {
            bool respuesta = false;
            try
            {
                var pickup = new DTO.Draft.MapinDraftPickup().MapinDtoToEntity(draft, idDraft);
                _context.DraftPickups.Add(pickup);
                Save();
                respuesta = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;                
            }
            return respuesta;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool UpdateDraft(DTO.Draft.DraftpickupDto draft, int id)
        {
            bool respuesta = false;
            try
            {
                var pickup = new DTO.Draft.MapinDraftPickup().MapinDtoToEntity(draft, id);
                _context.DraftPickups.Update(pickup).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
