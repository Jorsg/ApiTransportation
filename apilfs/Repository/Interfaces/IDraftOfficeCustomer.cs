using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IDraftOfficeCustomer
    {
        bool InsertDraftOfficeCustomer(DTO.Draft.DraftOfficeCustomerDto dto, int idDrat);

        void Save();

        bool UpdateDraftOfficeCustomer(DTO.Draft.DraftOfficeCustomerDto dto, int IdDraft);
    }
}
