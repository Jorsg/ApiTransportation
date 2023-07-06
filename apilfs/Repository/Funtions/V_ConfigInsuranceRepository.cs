
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.Repository.Funtions
{
    public class V_ConfigInsuranceRepository : IV_ConfigInsurance
    {
        private readonly BD_LFSContext _context;

        public V_ConfigInsuranceRepository(BD_LFSContext context)
        {
            _context = context;
        }

        public VConfigInsurance GetVConfigInsurances(string customerCode, string modeGroup, string from, string to)
        {
            string origin = string.Empty;
            string destin = string.Empty;

            var idMode = _context.ModeGroups.FirstOrDefault(elm => elm.BusinessUnit == modeGroup).Id;
            if(from.Length ==3)          
                origin = _context.Countries.FirstOrDefault(elm => elm.Iso3Code == from).Iso3Code;
            else
                origin = origin = _context.Countries.FirstOrDefault(elm => elm.Iso2Code == from).Iso2Code;

            if(to.Length == 3)
                destin = _context.Countries.FirstOrDefault(elm => elm.Iso3Code == to).Iso3Code;
            else
                destin = destin = _context.Countries.FirstOrDefault(elm => elm.Iso2Code == to).Iso2Code;


            bool mexOring = false;
            bool mexDestin = false;
            if(origin == "MX" || origin == "MEX")           
                mexOring = true;

            if (destin == "MX" || destin == "MEX")
                mexDestin = true;
   
            var query = _context.VConfigInsurances.Where(elm => elm.Code == customerCode && elm.IdModeGroup == idMode && elm.OrigenMexico == mexOring
                                                         && elm.DestinoMexico == mexDestin);
            return query.FirstOrDefault();
        }
    }
}
