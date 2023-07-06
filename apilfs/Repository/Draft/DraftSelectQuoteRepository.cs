using apilfs.DTO.Draft;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.Repository.Draft
{
    public class DraftSelectQuoteRepository : IDraftSelectQuote
    {
        private readonly BD_LFSContext _context;

        public  DraftSelectQuoteRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public int InsertDraft(DraftSelectQuoteDto draft, int idDraft)
        {
            int id = 0;
            try
            {
                var quote = new DTO.Draft.MapinSelectedQuote().MapinDtoToEntity(draft, idDraft);
                _context.DraftSelectedQuotes.Add(quote);
                Save();
                id = quote.Id;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                throw;
            }
            return id;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool UpdateDraft(DraftSelectQuoteDto dto, int id)
        {
            bool respuesta = false;
            try
            {
                var quote = new DTO.Draft.MapinSelectedQuote().MapinDtoToEntity(dto, id);
                _context.DraftSelectedQuotes.Update(quote).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
