using apilfs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Interfaces
{
    public interface IMexicoRate
    {

        IQueryable<Models.MexicoRate> GetMexicoRate();
        IQueryable<MexicoRatesDto> GetMexicoRate(string zipCodeFrom, string zipCodeTo, string countryFrom, string countryTo, int idTypeTruck);

    }
}
