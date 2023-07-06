using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IDraftServices
    {
        int InsertDraft(DTO.Draft.DraftDto draft);

        IQueryable<Models.Draft> GetDraft();

        IQueryable<Models.VDraft> GetDraft(int id);

        DTO.Draft.DraftDto GetDraftAll(int idDraft);

        bool UpdateDraft(DTO.Draft.DraftDto dto);
    }
}
