using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IDraft
    {
        IQueryable<Models.Draft> GetDrafts();

        IQueryable<Models.VDraft> GetDrafts(int id);

        DTO.Draft.DraftDto GetDraftsAll(int idDraft);

        void Save();

        int InsertDraft(DTO.Draft.DraftDto draft);

        bool UpdateDraft(DTO.Draft.DraftDto draft);

        bool DeleteDraf(Models.Draft draft);
    }
}
