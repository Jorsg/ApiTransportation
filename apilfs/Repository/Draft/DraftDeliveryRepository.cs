using apilfs.DTO.Draft;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Draft
{
    public class DraftDeliveryRepository : IDraftDelivery
    {
        private readonly BD_LFSContext _context;

        public DraftDeliveryRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public bool DeleteDraf(DraftDelivery draft)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DraftDelivery> GetDrafts(int idDraft)
        {
            return _context.DraftDeliveries.Where(elm => elm.IdDraft == idDraft);
        }

        public bool InsertDraft(DraftDeliveryDto draft, int idDraft)
        {
            bool respuesta = false;
            try
            {
                var delivery = new DTO.Draft.MapinDraftDelivery().MapinDtoToEntity(draft, idDraft);
                _context.DraftDeliveries.Add(delivery);
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

        public bool UpdateDraft(DTO.Draft.DraftDeliveryDto draft, int id)
        {
            bool respuesta = false;
            try
            {
                var delivery = new DTO.Draft.MapinDraftDelivery().MapinDtoToEntity(draft, id);
                _context.DraftDeliveries.Update(delivery).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
