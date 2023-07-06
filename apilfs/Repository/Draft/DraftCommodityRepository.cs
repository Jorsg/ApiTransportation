using apilfs.DTO.Draft;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Draft
{
    public class DraftCommodityRepository : IDraftCommodity
    {
        private readonly BD_LFSContext _context;

        public DraftCommodityRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public bool DeleteDraf(DraftCommodity draft)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DraftCommodity> GetDrafts(int idDraft)
        {
            return _context.DraftCommodities.Where(elm => elm.IdDraft == idDraft);
        }

        public bool InsertDraft(DraftCommodityDto draft, int idDraft)
        {
            bool respuesta = false;
            try
            {
                var commodity = new DTO.Draft.MapinDraftCommodity().MapinDtoToEntity(draft, idDraft);
                _context.DraftCommodities.Add(commodity);
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

        public bool UpdateDraft(DTO.Draft.DraftCommodityDto draft, int id)
        {
            bool respuesta = false;
            try
            {
                var commodity = new DTO.Draft.MapinDraftCommodity().MapinDtoToEntity(draft,id);
                _context.DraftCommodities.Update(commodity).State = Microsoft.EntityFrameworkCore.EntityState.Modified; 
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
