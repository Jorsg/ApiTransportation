using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IDraftAccesorialsCharge
    {
        IQueryable<Models.DraftAccesorialsCharge> GetDrafts(int idDraft);

        void Save();

        bool InsertDraft(DTO.Draft.DraftAccesorialsChargeDto draft, int idQuote);

        bool UpdateDraft(DTO.Draft.DraftAccesorialsChargeDto draft, int id);

        bool DeleteDraf(Models.DraftAccesorialsCharge draft);
    }
}
