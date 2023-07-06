using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Draft
{
    public class DraftInsuranceDto
    {
        public int Id { get; set; }
        public int IdDraft { get; set; }
        public string InsuredCargoOwner { get; set; }
        public string CargoOwnerCountry { get; set; }
        public decimal TotalCargoValue { get; set; }
        public bool? InsureFreight { get; set; }
        public decimal? cargoInsurance { get; set; }
        public decimal? MinInsuredCost { get; set; }
        public string commodityType { get; set; }
        public bool? cargoInsuranceActive { get; set; }
    }

    public class MapinDraftInsurance
    {
        public DraftInsurance MapinDtoToEntity(DraftInsuranceDto draft, int idDraft)
        {
            DraftInsurance _insurance = new DraftInsurance();
            _insurance.CargoOwnerCountry = draft.CargoOwnerCountry;
            _insurance.TotalCargoValue = draft.TotalCargoValue;
            _insurance.IdDraft = idDraft;
            _insurance.InsureFreight = draft.InsureFreight;
            _insurance.InsuredCargoOwner = draft.InsuredCargoOwner;
            _insurance.CargoInsuran = draft.cargoInsurance;
            _insurance.MinInsuredCost = draft.MinInsuredCost;
            _insurance.CommodityType = draft.commodityType;
            _insurance.CargoInsuranceActive = draft.cargoInsuranceActive;
            _insurance.Id = draft.Id;

            return _insurance;
        }
    }

}
