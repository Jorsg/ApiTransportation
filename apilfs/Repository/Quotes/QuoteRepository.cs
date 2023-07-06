using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.DTO;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using apilfs.Repository;
using apilfs.Repository.ModeGroup;
using apilfs.Repository.Mode;
using apilfs.Repository.Countries;
using apilfs.Repository.ZipCodes;
using apilfs.Repository.Unit;
using AutoMapper;

namespace apilfs.Repository.Quote
{
    public class QuoteRepository : Profile, IQuote
    {
        #region[Variables Globales]
        private readonly BD_LFSContext _context;       
        IModeGroup _modeGroup;               
        ICountries _countries;           
        IZipCode _zipCode;
        #endregion

        public QuoteRepository(BD_LFSContext context, IModeGroup modeGroup, ICountries countries, IZipCode zipCode)
        {
            _context = context;
            _countries = countries;          
            _modeGroup = modeGroup;           
            _zipCode = zipCode;
        }

        public IQueryable<Models.Quote> GetQuotes()
        {
            return _context.Quotes;
        }

        public IQueryable<Models.Quote> GetQuotes(int id)
        {
            return _context.Quotes.Where(elm => elm.Id == id);
        }

        public int InsertQuote(DTO.QuotesDto quote)
        {
            var _quoute = new DTO.QuotesDto
            {
                IdCustomer = quote.IdCustomer,
                CountryFrom = GetCountriesbyId(quote.CountryFrom).ToString(),
                CountryTo = GetCountriesbyId(quote.CountryTo).ToString(),
                CrossBorder = quote.CrossBorder,
                DateQuote = quote.DateQuote,
                Hazmat = quote.Hazmat,
                IdQuoteSaas = quote.IdQuoteSaas,
                IdQuoteYAT = quote.IdQuoteYAT,
                InsureFreight = quote.InsureFreight,
                TypeTruck = quote.TypeTruck,
                ModeGroup = GetModeGruopbyId(quote.ModeGroup).ToString(),
                Quantity = quote.Quantity,
                TeamService = quote.TeamService,
                TotalCargoValue = quote.TotalCargoValue,                
                User = quote.User,
                Weight = quote.Weight,
                ZipCodeFrom = GetZipCodebyId(quote.CountryFrom, quote.ZipCodeFrom).ToString(),
                ZipCodeTo = GetZipCodebyId(quote.CountryTo, quote.ZipCodeTo).ToString(),
                LeastCostCarrier = quote.LeastCostCarrier,
                LinearFeet = quote.LinearFeet,
                Miles = quote.Miles,
                OutOfGauge = quote.OutOfGauge,
                Reefer = quote.Reefer,
                Unit = quote.Unit,
                Direction = quote.Direction
            };
            
            var _quotesInsert = new DTO.MapingQuotes().MapiQuotes(_quoute);           
            _context.Quotes.Add(_quotesInsert);
            Save();
           
            return  _quotesInsert.Id;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool UpdateQuote(Models.Quote quote)
        {
            bool respuesta = false;
            try
            {
                _context.Quotes.Update(quote);
                Save();
                respuesta = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;               
            }
            return respuesta;
        }

        private int GetModeGruopbyId(string modegroup)
        {
            return _modeGroup.GetModeGroupByBusinessUnit(modegroup).Id;           
        }      

       

        private int GetCountriesbyId(string countries)
        {
            return _countries.GetCountryByIsoCode(countries).Id;
        }

        private int GetZipCodebyId(string country,string zipCode)
        {
            return _zipCode.GetZipCodeByZipCodeAndCountry(country,zipCode).Id;
        }

        
       
    }
}
