using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Draft
{
    public class DraftInsuranceRepository : IDraftInsurance
    {
        private readonly BD_LFSContext _context;

        public DraftInsuranceRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public bool DeleteDraf(DraftInsurance draftInsurance)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DraftInsurance> GetDrafts(int idDraft)
        {
            return _context.DraftInsurances.Where(elm => elm.IdDraft == idDraft);
        }

        public bool InsertDraft(DTO.Draft.DraftInsuranceDto draftInsurance, int idDraft)
        {
            bool respuesta = false;
            try
            {
                var insurance = new DTO.Draft.MapinDraftInsurance().MapinDtoToEntity(draftInsurance, idDraft);
                _context.DraftInsurances.Add(insurance);
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

        public bool UpdateDraft(DTO.Draft.DraftInsuranceDto draftInsurance, int id)
        {
            bool respuesta = false;
            try
            {
                var insurance = new DTO.Draft.MapinDraftInsurance().MapinDtoToEntity(draftInsurance, id);
                _context.DraftInsurances.Update(insurance).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
