using apilfs.DTO.Draft;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Repository.Draft
{
    public class DraftOfficeCustomerRepository : IDraftOfficeCustomer
    {
        private readonly BD_LFSContext _context;

        public DraftOfficeCustomerRepository(BD_LFSContext context)
        {
            _context = context;
        }
        public bool InsertDraftOfficeCustomer(DraftOfficeCustomerDto dto, int idDrat)
        {
            bool respuesta = false;
            try
            {
                var offices = new DTO.Draft.MapinDraftOfficeCustomer().MapinDtoToEntity(dto, idDrat);
                _context.DraftOfficeCustomers.Add(offices);
                Save();
                respuesta = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;               
            }
            return respuesta;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool UpdateDraftOfficeCustomer(DraftOfficeCustomerDto dto, int id)
        {
            bool respuesta = false;
            try
            {
                var offices = new DTO.Draft.MapinDraftOfficeCustomer().MapinDtoToEntity(dto, id);
                _context.DraftOfficeCustomers.Update(offices).State = Microsoft.EntityFrameworkCore.EntityState.Modified; 
                Save();
                respuesta = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
            return respuesta;
        }
    }
}
