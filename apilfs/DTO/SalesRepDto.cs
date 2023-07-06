using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO
{
    public class SalesRepDto
    {
        public int Id { get; set; }
        public string NameSalesRep { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<CustomersDto> customersBySalesRepDto { get; set; }
    }


    public class MapeoSalesRep
    {
        public SalesRep MapearSalesRep(SalesRepDto salesRep)
        {
            SalesRep _salesRep = new SalesRep();
            _salesRep.Id = salesRep.Id;
            _salesRep.NameSalesRep = salesRep.NameSalesRep;
            _salesRep.Code = salesRep.Code;
            _salesRep.Phone = salesRep.Phone;
            _salesRep.Email = salesRep.Email;

            return _salesRep;
        }

        public SalesRepDto MapearSalesRep(SalesRep salesRep)
        {
            SalesRepDto _salesRep = new SalesRepDto();
            _salesRep.Id = salesRep.Id;
            _salesRep.NameSalesRep = salesRep.NameSalesRep;
            _salesRep.Code = salesRep.Code;
            _salesRep.Phone = salesRep.Phone;
            _salesRep.Email = salesRep.Email;

            return _salesRep;
        }

    }
   
}
