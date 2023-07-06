using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IDrayage
    {
        IQueryable<Models.Drayage> GetDrayages();

        IQueryable<Models.Drayage> GetDrayages(int idPortRamp, int idCustormers, int idVendors);
    }
}
