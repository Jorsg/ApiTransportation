using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IDraftpickup
    {
        IQueryable<Models.DraftPickup> GetDrafts(int idDraft);

        void Save();

        bool InsertDraft(DTO.Draft.DraftpickupDto draft, int idDraft);

        bool UpdateDraft(DTO.Draft.DraftpickupDto draft, int id);

        bool DeleteDraf(Models.DraftPickup draft);
    }
}
