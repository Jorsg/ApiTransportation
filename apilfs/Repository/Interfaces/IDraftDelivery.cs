using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IDraftDelivery
    {
        IQueryable<Models.DraftDelivery> GetDrafts(int idDraft);

        void Save();

        bool InsertDraft(DTO.Draft.DraftDeliveryDto draft, int idDraft);

        bool UpdateDraft(DTO.Draft.DraftDeliveryDto draft, int id);

        bool DeleteDraf(Models.DraftDelivery draft);
    }
}
