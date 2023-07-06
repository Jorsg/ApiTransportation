using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IDraftSelectQuote
    {
        void Save();

        int InsertDraft(DTO.Draft.DraftSelectQuoteDto draft, int idDraft);

        bool UpdateDraft(DTO.Draft.DraftSelectQuoteDto dto, int id);
    }
}
