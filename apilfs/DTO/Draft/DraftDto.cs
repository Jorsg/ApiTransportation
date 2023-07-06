using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Draft
{
    public class DraftDto
    { 
        public int id { get; set; }
        public int CustomerId { get; set; }
        public string BolSwanleap { get; set; }
        public bool? BookWithAgent { get; set; }
        public decimal Weight { get; set; }
        public string ModeGroup { get; set; }
        public bool? Hazmat { get; set; }      
        public string SpecialInstructions { get; set; }
        public string Status { get; set; }
        public bool AcceptedTC { get; set; }
        public string customerBillingReference { get; set; }
        public decimal? trailerLength { get; set; }
        public List<DraftCommodityDto> commodities { get; set; }
        public DraftDeliveryDto delivery { get; set; }
        public DraftInsuranceDto Insurance { get; set; }
        public DraftpickupDto pickup { get; set; }
        public DraftSelectQuoteDto selectedQuote { get; set; }
        public DraftOfficeCustomerDto officeCustomer { get; set; }
    }

    public class MapinDraft
    {
        public Models.Draft MapinDtoToEntity(DraftDto draftDto)
        {
            Models.Draft _draft = new Models.Draft();
            _draft.BolSwanleap = draftDto.BolSwanleap;
            _draft.BookWithAgent = draftDto.BookWithAgent;          
            _draft.Hazmat = draftDto.Hazmat;           
            _draft.ModeGroup = draftDto.ModeGroup;          
            _draft.Weight = draftDto.Weight;
            _draft.AcceptedTC = draftDto.AcceptedTC;
            _draft.SpecialInstructions = draftDto.SpecialInstructions;
            _draft.Status = draftDto.Status;
            _draft.CustomerId = draftDto.CustomerId;
            _draft.CustomerBillingReference = draftDto.customerBillingReference;
            _draft.TrailerLength = draftDto.trailerLength;
            _draft.Id = draftDto.id;

            return _draft;
        }
    }
}
