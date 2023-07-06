using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ISalesKam
    {
        Models.SalesKam GetSalesKamByEmail(string email);
        Models.SalesKam GetSalesKamByName(string name);
        bool GetSalesKamExits(string name, string email);
        void InsertSalesKam(Models.SalesKam salesKam);
    }
}
