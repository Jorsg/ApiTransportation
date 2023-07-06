using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO.Quote
{
    public class ExceptionsAppliedPerRateDto
    {
        public int Id { get; set; }
        public string ExceptionName { get; set; }
        public string Mode { get; set; }
        public string Value { get; set; }
        public string LinehaulRateDelta { get; set; }
        public string FuelRateDelta { get; set; }
        public string AllInRateDelta { get; set; }
        public int IdRate { get; set; }
        public string CustomerOrCarrier { get; set; }
    }


    public class MapinExceptionAppliePerRate
    {
        public ExceptionsAppliedPerRate MapingToDto(DTO.Quote.ExceptionsAppliedPerRateDto exceptions, int idRate)
        {
            ExceptionsAppliedPerRate _exception = new ExceptionsAppliedPerRate();

            _exception.IdRate = idRate;
            _exception.CustomerOrCarrier = exceptions.CustomerOrCarrier;
            _exception.AllInRateDelta = Convert.ToDecimal(exceptions.AllInRateDelta);
            _exception.ExceptionName = exceptions.ExceptionName;
            _exception.FuelRateDelta = Convert.ToDecimal(exceptions.FuelRateDelta);           
            _exception.LinehaulRateDelta = Convert.ToDecimal(exceptions.LinehaulRateDelta);
            _exception.Mode = exceptions.Mode;
             _exception.Value = Convert.ToDecimal(exceptions.Value);

            return _exception;
        }
    }
}
