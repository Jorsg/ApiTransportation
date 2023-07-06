using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.DTO.Draft;
using System.Data.Entity;

namespace apilfs.Repository.Draft
{
    public class DraftRepository : IDraft
    {
        private readonly BD_LFSContext _context;

        public DraftRepository(BD_LFSContext context)
        {
            _context = context;
        }
       

        public IQueryable<Models.Draft> GetDrafts()
        {
            return _context.Drafts;
        }

        public IQueryable<Models.VDraft> GetDrafts(int id)
        {
            return _context.VDrafts.Where(elm => elm.IdCustomer == id);
        }

        public bool DeleteDraf(Models.Draft draft)
        {
            bool respuesta = false;
            try
            {
                _context.Drafts.Remove(draft);
                respuesta = true;
            }
            catch (Exception)
            { throw; }

            return respuesta;
        }

        public int InsertDraft(DTO.Draft.DraftDto draft)
        {
            int id = 0;
            try
            {
                var draft1 = new DTO.Draft.MapinDraft().MapinDtoToEntity(draft);
                _context.Add(draft1);
                Save();
                id = draft1.Id;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                throw; }
            return id;
        }

        public bool UpdateDraft(DTO.Draft.DraftDto draft)
        {
            bool respuesta = false;
            try
            {
                var draft1 = new DTO.Draft.MapinDraft().MapinDtoToEntity(draft);
                _context.Drafts.Update(draft1).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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

        public DraftDto GetDraftsAll(int idDraft)
        {
            throw new NotImplementedException();
        }
    }
}
