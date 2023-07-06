using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IDraftCommodity
    {
        IQueryable<Models.DraftCommodity> GetDrafts(int idDraft);

        void Save();

        bool InsertDraft(DTO.Draft.DraftCommodityDto draft, int idDraft);

        bool UpdateDraft(DTO.Draft.DraftCommodityDto draft, int id);

        bool DeleteDraf(Models.DraftCommodity draft);
    }
}
