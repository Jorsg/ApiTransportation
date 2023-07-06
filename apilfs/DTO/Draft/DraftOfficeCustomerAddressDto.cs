using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Draft
{
    public class DraftOfficeCustomerAddressDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int id { get; set; }
    }

    public class MapinDraftOfficeCustomerAddressDto
    {
        public DraftOfficeCustomer MapinDtoToEntity(DTO.Draft.DraftOfficeCustomerAddressDto draftOffice, int idDraft)
        {
            DraftOfficeCustomer _dto = new DraftOfficeCustomer();
           
            _dto.City = draftOffice.City;
            _dto.Country = draftOffice.Country;
            _dto.Email = draftOffice.Email;
            _dto.IdDraft = idDraft;           
            _dto.Name = draftOffice.Name;
            _dto.Phone = draftOffice.Phone;
            _dto.State = draftOffice.State;
            _dto.Street1 = draftOffice.Street1;
            _dto.Zip = draftOffice.Zip;
            _dto.Id = draftOffice.id;

            return _dto;
        }
    }
}
