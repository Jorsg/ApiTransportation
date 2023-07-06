using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface ICustomerBySaleAgent
    {
        IQueryable<Models.CustomersbySaleAgent> GetCustomersbySaleAgents();

        IQueryable<Models.CustomersbySaleAgent> GetCustomersbySaleAgents(string codeCustomers);

        IQueryable<Models.CustomersbySaleAgent> GetCustomersbySaleAgentsCode(string codeSalesRep);
    }
}
