using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IExceptionsAppliedPerRate
    {
        bool insertExceptionsAppliedPerRate(DTO.Quote.ExceptionsAppliedPerRateDto exceptionsApplied, int idRates);

        bool updateExceptionsAppliedPerRate(apilfs.Models.ExceptionsAppliedPerRate exceptionsApplied);

        void Save();
    }
}
