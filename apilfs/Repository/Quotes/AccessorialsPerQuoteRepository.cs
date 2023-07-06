using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Quotes
{
    public class AccessorialsPerQuoteRepository : IAccessorialsPerQuote
    {
        private readonly BD_LFSContext _context;

        public AccessorialsPerQuoteRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public bool insertAccessorialsPerQuote(DTO.AccesorialsPerQuotesDto accessorialsPerQuote, int idQuotes)
        {
            bool respuesta = false;
            try
            {               
                int idAccesorial = GetAccesorialById(accessorialsPerQuote.AccessorialCode); // Se consulta el Id del Accesorial de la tabla Accesorial
                if (idAccesorial > 0)
                {
                    var accesorials = new DTO.MapinAccesorialsPerQuotes().MapinAccesorialPerQuote(accessorialsPerQuote, idQuotes, idAccesorial); // Se inserta en la tabla accesorials con el mapin del Dto
                    _context.AccessorialsPerQuotes.Add(accesorials);
                    Save(); // Se guardan los cambios en la Db
                    respuesta = true;
                }
                else
                {
                    var accesorials = new DTO.MapinAccesorialsPerQuotes().MapinAccesorialPerQuote(accessorialsPerQuote, idQuotes, 242); // Se inserta en la tabla accesorials con el mapin del Dto
                    _context.AccessorialsPerQuotes.Add(accesorials);
                    Save(); // Se guardan los cambios en la Db
                    respuesta = true;
                }
               
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

        public bool updateAccessorialsPerQuote(AccessorialsPerQuote accessorialsPerQuote)
        {
            throw new NotImplementedException();
        }

        private int GetAccesorialById(string accesorial)
        {
            var query = _context.Accessorials.FirstOrDefault(elm => elm.IdYat == accesorial || elm.IdSaas == accesorial);
            if (query != null)
                return query.Id;
            else
                return 0;
        }
    }
}
