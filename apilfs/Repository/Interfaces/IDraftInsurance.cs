using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IDraftInsurance
    {
        IQueryable<Models.DraftInsurance> GetDrafts(int idDraft);

        void Save();

        bool InsertDraft(DTO.Draft.DraftInsuranceDto draftInsurance, int idDraft);

        bool UpdateDraft(DTO.Draft.DraftInsuranceDto draftInsurance, int id);

        bool DeleteDraf(Models.DraftInsurance draftInsurance);
    }
}
