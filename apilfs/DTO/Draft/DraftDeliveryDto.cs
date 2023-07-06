using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Draft
{
    public class DraftDeliveryDto
    {
        public int Id { get; set; }
        public int IdDraft { get; set; }
        public string LocationName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string AddreesType { get; set; }
        public string ContactName { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string Reference { get; set; }
        public string specialInstructions { get; set; }
        public string Accesorials { get; set; }
        public string InitialTime { get; set; }
        public string FinalTime { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }
    }

    public class MapinDraftDelivery
    {
        public DraftDelivery MapinDtoToEntity(DTO.Draft.DraftDeliveryDto draft, int idDraft)
        {
          
            DraftDelivery _delevery = new DraftDelivery();
            _delevery.Accesorials = draft.Accesorials;
            _delevery.AddreesType = draft.AddreesType;
            _delevery.Country = draft.Country;
            _delevery.ContactName = draft.ContactName;
            _delevery.Email = draft.Email;
            _delevery.FinalTime = TimeSpan.Parse(draft.FinalTime);
            _delevery.IdDraft = idDraft;
            _delevery.InitialTime = TimeSpan.Parse(draft.InitialTime);
            _delevery.LocationName = draft.LocationName;
            _delevery.Phone = draft.Phone;
            _delevery.Reference = draft.Reference;
            _delevery.SpecialIntruction = draft.specialInstructions;
            _delevery.Street = draft.Street;
            _delevery.Street2 = draft.Street2;
            _delevery.ZipCode = draft.ZipCode;
            _delevery.FinalDate = draft.FinalDate;
            _delevery.InitialDate = draft.InitialDate;
            _delevery.Id = draft.Id;
            return _delevery;
        }
    }
}
