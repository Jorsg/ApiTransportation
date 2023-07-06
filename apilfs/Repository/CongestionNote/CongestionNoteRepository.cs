using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.Repository.CongestionNote
{
    public class CongestionNoteRepository : ICongestionNotes
    {
        private readonly BD_LFSContext _context;
        private readonly IZipCode _zipCode;

        public CongestionNoteRepository(BD_LFSContext context, IZipCode zipCode)
        {
            _context = context;
            _zipCode = zipCode;
        }

        public IQueryable<Models.CongestionNote> GetCongestionNotes()
        {
            return _context.CongestionNotes;
        }

        public Models.CongestionNote GetCongestionNoteByZipcode(string zipcode, string country)
        {

            ZipCodeByState zipCodeByState = _zipCode.GetZipCodeByZipCodeAndCountry(country, zipcode);
            if(zipCodeByState == null)
            {
                return null;
            }
            return _context.CongestionNotes.Where(elm => elm.IdZipcode == zipCodeByState.Id).FirstOrDefault();
           // return zipCodeByState;
        }

        public void InsertCongestinNotes(Models.CongestionNote congestionNote)
        {
            _context.Add(congestionNote);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Models.CongestionNote congestionNote)
        {
            _context.Update(congestionNote);
            Save();
        }

        public void Delete(Models.CongestionNote congestionNote)
        {
            _context.Remove(congestionNote);
            Save();
        }

    }
}
