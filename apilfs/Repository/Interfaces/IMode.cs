using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IMode
    {
        IQueryable<Models.Mode> GetModes();

        IQueryable<Models.Mode> GetModes(string modeGroup);

        IQueryable<Models.Mode> GetModesbyMode(string mode);
        Models.Mode GetModebyServiceLevelSaas(string serviceLevelSaas);
        Models.Mode GetModebyServiceLevelYat(string serviceLevelYat);
    }
}
