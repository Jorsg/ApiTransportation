using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.Repository.Interfaces
{
    public interface IZipCode
    {
        
        IQueryable<ZipCode> GetZipCode(string zipcode);

        IQueryable<ZipCodeByState> GetZipCodeFullName(string fullZipCode);

        IQueryable<ZipCode> GetZipCodeCity(string city);

        IQueryable<ZipCode> GetZipCodeCity();

        void InsertZipCode(Models.ZipCode zipCode);
        void Save();

       ZipCodeByState GetZipCodeByZipCodeAndCountry(string country, string zipcode);
       
    }
}
