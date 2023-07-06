using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Draft
{
    public class DraftCommodityDto
    {
        public int Id { get; set; }
        public int IdDraft { get; set; }
        public decimal CommodityClass { get; set; }
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public decimal length { get; set; }
        public decimal height { get; set; }
        public decimal Width { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public bool? Hazmat { get; set; }           
        public string HazmatClass { get; set; }
        public string UnNumber { get; set; }
        public string ParkingGroup { get; set; }
        public bool? teamService { get; set; }
        public bool? crossBorder { get; set; }

    }

    public class MapinDraftCommodity
    {
        public DraftCommodity MapinDtoToEntity(DraftCommodityDto draft, int idDraft)
        {
            DraftCommodity _draftComm = new DraftCommodity();
            _draftComm.CommodityClass = draft.CommodityClass;          
            _draftComm.Description = draft.Description;
            _draftComm.Hazmat = draft.Hazmat;
            _draftComm.HazmatClass = draft.HazmatClass;
            _draftComm.IdDraft = idDraft;
            _draftComm.ParkingGroup = draft.ParkingGroup;
            _draftComm.Quantity = draft.Quantity;        
            _draftComm.Unit = draft.Unit;
            _draftComm.UnNumber = draft.UnNumber;
            _draftComm.Weight = draft.Weight;
            _draftComm.Width = draft.Width;
            _draftComm.Length = draft.length;
            _draftComm.Height = draft.height;
            _draftComm.CrossBorder = draft.crossBorder;
            _draftComm.TeamService = draft.teamService;
            _draftComm.Id = draft.Id;
            return _draftComm;
        }
    }
}
