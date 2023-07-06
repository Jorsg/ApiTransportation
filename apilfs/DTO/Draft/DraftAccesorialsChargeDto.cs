using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Draft
{
    public class DraftAccesorialsChargeDto
    {
        public int id { get; set; }
        public int idDraft { get; set; }
        public decimal? AccessorialCharge { get; set; }
        public string AccessorialDescription { get; set; }
        public string AccessorialCode { get; set; }
        public string accessorial_name { get; set; }
        public string accessorial_code { get; set; }
        public decimal? default_rate { get; set; }
    }

    public class MapinAccesorialsCharge
    {
        public DraftAccesorialsCharge MapinDtoEntity(DraftAccesorialsChargeDto draftAccesorials, int idQuote)
        {
            DraftAccesorialsCharge _draft = new DraftAccesorialsCharge();
            _draft.IdSelectedQuote = idQuote;
            _draft.AccessorialCode = draftAccesorials.AccessorialCode;
            _draft.AccessorialCharge = draftAccesorials.AccessorialCharge;
            _draft.AccessorialDescription = draftAccesorials.AccessorialDescription;
            _draft.AccessorialCode1 = draftAccesorials.accessorial_code;
            _draft.AccessorialName = draftAccesorials.accessorial_name;
            _draft.DefaultRate = draftAccesorials.default_rate;
            _draft.Id = draftAccesorials.id;
            return _draft;
        }
    }


}
