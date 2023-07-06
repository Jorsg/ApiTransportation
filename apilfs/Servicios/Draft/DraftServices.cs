using apilfs.DTO.Draft;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.Servicios.Draft
{
    public class DraftServices : IDraftServices
    {
        #region ["Variables privadas"]
        private readonly IDraftAccesorialsCharge _accesorialsCharge;
        private readonly IDraftCommodity _commodity;
        private readonly IDraftDelivery _delivery;
        private readonly IDraftInsurance _insurance;
        private readonly IDraftpickup _pickup;
        private readonly IDraft _draft;
        private readonly IDraftSelectQuote _quote;
        private readonly IDraftOfficeCustomer _draftOffice;
        int idDraft = 0;
        #endregion

        public DraftServices(IDraftAccesorialsCharge accesorialsCharge, IDraftCommodity commodity, IDraftDelivery delivery, 
                                IDraftInsurance insurance, IDraftpickup pickup, IDraft draft, IDraftSelectQuote quote, IDraftOfficeCustomer draftOffice)
        {
            _accesorialsCharge = accesorialsCharge;
            _commodity = commodity;
            _delivery = delivery;
            _insurance = insurance;
            _pickup = pickup;
            _draft = draft;
            _quote = quote;
            _draftOffice = draftOffice;
        }
        public IQueryable<Models.Draft> GetDraft()
        {
            return _draft.GetDrafts();
        }

        public IQueryable<Models.VDraft> GetDraft(int id)
        {
            return _draft.GetDrafts(id);
        }

        public VDraft GetDraftAll(int idDraft)
        {
            throw new NotImplementedException();
        }

        public int InsertDraft(DraftDto draft)
        {
           
            bool respuesta = false;
            try
            {
                 idDraft = _draft.InsertDraft(draft); // inserta el draft
                if(draft.officeCustomer != null)
                respuesta = _draftOffice.InsertDraftOfficeCustomer(draft.officeCustomer, idDraft);

                var idQuote = _quote.InsertDraft(draft.selectedQuote, idDraft); // Inserta la cotización seleccionada por el customer

                foreach (var item in draft.selectedQuote.accessorialCharges)
                {
                    respuesta = _accesorialsCharge.InsertDraft(item, idQuote);
                }
                if(draft.commodities != null)
                {
                    foreach (var item in draft.commodities)
                    {
                        respuesta = _commodity.InsertDraft(item, idDraft);
                    }
                }
                if(draft.delivery != null)                
                respuesta = _delivery.InsertDraft(draft.delivery, idDraft);

                if(draft.pickup != null)
                respuesta = _pickup.InsertDraft(draft.pickup,idDraft);

                if(draft.Insurance != null)
                respuesta = _insurance.InsertDraft(draft.Insurance, idDraft);
            }
            catch (Exception ex)
            {
                _ = ex.Message;               
            }
            return idDraft;
        }

        public bool UpdateDraft(DraftDto dto)
        {
            bool respuesta = false;
            try
            {
                respuesta = _draft.UpdateDraft(dto); // Update el draft
                if (dto.officeCustomer != null)
                    respuesta = _draftOffice.UpdateDraftOfficeCustomer(dto.officeCustomer, dto.id);

                if(dto.selectedQuote != null)
                    respuesta = _quote.UpdateDraft(dto.selectedQuote, dto.id); // Update la cotización seleccionada por el customer

                foreach (var item in dto.selectedQuote.accessorialCharges)
                {
                    respuesta = _accesorialsCharge.UpdateDraft(item, dto.selectedQuote.Id);
                }
                if (dto.commodities != null)
                {
                    foreach (var item in dto.commodities)
                    {
                        respuesta = _commodity.UpdateDraft(item, dto.id);
                    }
                }
                if (dto.delivery != null)
                    respuesta = _delivery.UpdateDraft(dto.delivery, dto.id);

                if (dto.pickup != null)
                    respuesta = _pickup.UpdateDraft(dto.pickup, dto.id);

                if (dto.Insurance != null)
                    respuesta = _insurance.UpdateDraft(dto.Insurance, dto.id);
            }
            catch (Exception ex)
            {
                _ = ex.Message;               
            }
            return respuesta;

        }

        DraftDto IDraftServices.GetDraftAll(int idDraft)
        {
            throw new NotImplementedException();
        }
    }
}
