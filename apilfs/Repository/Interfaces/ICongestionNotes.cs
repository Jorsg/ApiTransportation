using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ICongestionNotes
    {
        IQueryable<Models.CongestionNote> GetCongestionNotes();

        Models.CongestionNote GetCongestionNoteByZipcode(string zipcode, string country);

        void InsertCongestinNotes(Models.CongestionNote congestionNote);

        void Save();

        void Update(Models.CongestionNote congestionNote);

        void Delete(Models.CongestionNote congestionNote);
    }
}
