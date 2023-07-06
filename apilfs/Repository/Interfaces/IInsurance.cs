using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IInsurance
    {
        IQueryable<Models.Insurance> GetInsurances();

        IQueryable<Models.Insurance> GetInsurancesMode(int mode);

        void InsertInsurance(Models.Insurance insurance);

        void Save();

        void UpdateInsurance(Models.Insurance insurance);
    }
}
