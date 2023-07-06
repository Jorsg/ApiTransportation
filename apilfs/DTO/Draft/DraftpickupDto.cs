using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Draft
{
    public class DraftpickupDto
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

    public class MapinDraftPickup
    {
        public DraftPickup MapinDtoToEntity(DraftpickupDto draft, int idDraft)
        {
            DraftPickup _draftpickup = new DraftPickup();
            _draftpickup.Accesorials = draft.Accesorials;
            _draftpickup.AddreesType = draft.AddreesType;
            _draftpickup.Country = draft.Country;
            _draftpickup.ContactName = draft.ContactName;
            _draftpickup.Email = draft.Email;
            _draftpickup.FinalTime = TimeSpan.Parse(draft.FinalTime);
            _draftpickup.IdDraft = idDraft;
            _draftpickup.InitialTime = TimeSpan.Parse(draft.InitialTime);
            _draftpickup.LocationName = draft.LocationName;
            _draftpickup.Phone = draft.Phone;
            _draftpickup.Reference = draft.Reference;
            _draftpickup.SpecialIntruction = draft.specialInstructions;
            _draftpickup.Street = draft.Street;
            _draftpickup.Street2 = draft.Street2;
            _draftpickup.ZipCode = draft.ZipCode;
            _draftpickup.FinalDate = draft.FinalDate;
            _draftpickup.InitialDate = draft.InitialDate;
            _draftpickup.Id = draft.Id;

            return _draftpickup;
        }
    }
}
