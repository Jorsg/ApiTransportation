using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ICommodities
    {
        IQueryable<Models.Commodity> GetCommodities();

        IQueryable<Models.Commodity> GetCommodities(string code);

        IQueryable<Models.Commodity> GetCommoditiesName(string name);
    }
}
