using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO
{
    public class SalesKamDto
    {
        public int Id { get; set; }
        public string NameSalesKam { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }


    public class MapeoSalesKam
    {
        public SalesKam MapearSalesKam(SalesKamDto salesKam)
        {
            SalesKam _salesKam = new SalesKam();
            _salesKam.Id = salesKam.Id;
            _salesKam.NameSalesKam = salesKam.NameSalesKam;
            _salesKam.Code = salesKam.Code;
            _salesKam.Phone = salesKam.Phone;
            _salesKam.Email = salesKam.Email;

            return _salesKam;
        }

        public SalesKamDto MapearSalesKam(SalesKam salesKam)
        {
            SalesKamDto _salesKam = new SalesKamDto();
            _salesKam.Id = salesKam.Id;
            _salesKam.NameSalesKam = salesKam.NameSalesKam;
            _salesKam.Code = salesKam.Code;
            _salesKam.Phone = salesKam.Phone;
            _salesKam.Email = salesKam.Email;

            return _salesKam;
        }

    }
   
}
