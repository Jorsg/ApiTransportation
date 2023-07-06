using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO
{
    public class CustomerBillingDto
    {
        public string CompanyName { get; set; }
        public string DocumentType { get; set; }
        public string Invoice { get; set; }
        public DateTime? Issued { get; set; }
        public DateTime? DueDate { get; set; }
        public string Bol { get; set; }
        public string Code { get; set; }
        public string NameCustomer { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Pending { get; set; }
        public int? OverDays { get; set; }
        public decimal? Future { get; set; }
        public decimal? _130Days { get; set; }
        public decimal? _3160Days { get; set; }
        public decimal? _6190Days { get; set; }
        public decimal? _91120Days { get; set; }
        public decimal? _121Days { get; set; }
        public string Status { get; set; }
    }

    public class MapinCustomerBilling
    {
        public CustomerBillingDto MapinEnityToDto(IQueryable<Models.VCustomerBilling> billing)
        {
            CustomerBillingDto _dto = new CustomerBillingDto();
            _dto.Amount = billing.FirstOrDefault().Amount;
            _dto.Bol = billing.FirstOrDefault().Bol;
            _dto.Code = billing.FirstOrDefault().Code;
            _dto.CompanyName = billing.FirstOrDefault().CompanyName;
            _dto.DocumentType = billing.FirstOrDefault().DocumentType;
            _dto.DueDate = billing.FirstOrDefault().DueDate.Value.Date;
            _dto.Invoice = billing.FirstOrDefault().Invoice;
            _dto.Future = billing.FirstOrDefault().Future;
            _dto.Issued = billing.FirstOrDefault().Issued;
            _dto.NameCustomer = billing.FirstOrDefault().NameCustomer;
            _dto.OverDays = billing.FirstOrDefault().OverDays;
            _dto.Pending = billing.FirstOrDefault().Pending;
            _dto.Status = billing.FirstOrDefault().Status;
            _dto._121Days = billing.FirstOrDefault()._121Days;
            _dto._130Days = billing.FirstOrDefault()._130Days;
            _dto._3160Days = billing.FirstOrDefault()._3160Days;
            _dto._6190Days = billing.FirstOrDefault()._6190Days;
            _dto._91120Days = billing.FirstOrDefault()._91120Days;

            return _dto;            
        }
    }
}
