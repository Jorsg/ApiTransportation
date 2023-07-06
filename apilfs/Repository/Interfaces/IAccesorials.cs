using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IAccesorials
    {
        IQueryable<apilfs.Models.Accessorial>  GetAccessorials();
        IQueryable<apilfs.Models.Accessorial> GetAccessorialsByIdsOrCodes(List<int> ids, List<string> codes);

        IQueryable<Models.Accessorial> GetAccessorials(string accesorials);

        void InsertAccesorials(Models.Accessorial accessoria);

        void Save();

       // Task<IAsyncEnumerable<Models.Accessorial>> GetAccesorialTask();
    }
}
