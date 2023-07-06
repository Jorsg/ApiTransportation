using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IV_ConfigInsurance
    {
        Models.VConfigInsurance GetVConfigInsurances(string customerCode, string modeGroup, string from, string to);
    }
}
