using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ISalesAgent
    {
        IQueryable<Models.SalesRep> GetSalesReps();

        IQueryable<Models.SalesRep> GetSalesReps(string codeSalesRep);
        Models.SalesRep GetSalesRepByEmail(string email);
        Models.SalesRep GetSalesRepByName(string name);

        void InsertSalesRep(Models.SalesRep salesRep);

        void Save();

        void Update(Models.SalesRep salesRep);

        void Delete(Models.SalesRep salesRep);
        bool GetSalesRepExits(string name, string email);
    }
}
