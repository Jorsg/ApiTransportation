using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;


namespace apilfs.DTO.Draft
{
    public class DraftOfficeCustomerDto
    {
        public int Id { get; set; }
        public int IdDraft { get; set; }           
        public string LocationId { get; set; }
        public DraftOfficeCustomerAddressDto address { get; set; }
    }

    public class MapinDraftOfficeCustomer
    {
        public DraftOfficeCustomer MapinDtoToEntity(DTO.Draft.DraftOfficeCustomerDto draftOffice, int idDraft)
        {
            DraftOfficeCustomer _dto = new DraftOfficeCustomer();
          
            _dto.City = draftOffice.address.City;
            _dto.Country = draftOffice.address.Country;
            _dto.Email = draftOffice.address.Email;
            _dto.IdDraft = idDraft;
            _dto.LocationId = draftOffice.LocationId;
            _dto.Name = draftOffice.address.Name;
            _dto.Phone = draftOffice.address.Phone;
            _dto.State = draftOffice.address.State;
            _dto.Street1 = draftOffice.address.Street1;
            _dto.Zip = draftOffice.address.Zip;
            _dto.Id = draftOffice.Id;

            return _dto;
        }
    }
}
