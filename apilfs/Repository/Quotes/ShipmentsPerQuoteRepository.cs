using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Quotes
{
    public class ShipmentsPerQuoteRepository : IShipmentsPerQuote
    {
        private readonly BD_LFSContext _context;

        public ShipmentsPerQuoteRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public bool insertShipmentsPerQuote(DTO.Quote.ShipmentsPerQuoteDto shipmentsPerQuote, int idQuotes)
        {
            bool respuesta = false;
            try
            {
                int idUnit = IdUnit(shipmentsPerQuote.Unit);
                var shipments = new DTO.Quote.MapinShipmentsPerQuote().MapinShipmentsToDto(shipmentsPerQuote, idQuotes, idUnit);
                _context.ShipmentsPerQuotes.Add(shipments);
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

        public bool updateShipmentsPerQuote(ShipmentsPerQuote shipmentsPerQuote)
        {
            throw new NotImplementedException();
        }

        private int IdUnit(string unit)
        {
            var query = _context.Units.FirstOrDefault(elm => elm.Name == unit);
            if (query != null)
                return query.Id;
            else
                return 0;
        }
    }
}
