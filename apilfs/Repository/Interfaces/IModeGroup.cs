using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IModeGroup
    {
        IQueryable<Models.ModeGroup> GetModeGroups();

        IQueryable<Models.ModeGroup> GetModeGroups(string modeGroup);
        Models.ModeGroup GetModeGroupByBusinessUnit(string businessUnit);

        void InsertModeGroup(Models.ModeGroup modeGroup);

        void Save();

        void Update(Models.ModeGroup modeGroup);

        void Delete(Models.ModeGroup modeGroup);
    }
}
