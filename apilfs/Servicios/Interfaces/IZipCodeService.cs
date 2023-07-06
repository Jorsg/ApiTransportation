using apilfs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Servicios.Interfaces
{
    public interface IZipCodeService
    {
        ZipCode GetZipCodeByZipCodeAndCountry(string country, string zipcode);
    }
}
