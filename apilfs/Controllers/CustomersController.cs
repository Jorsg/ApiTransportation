using apilfs.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomers _customers;

        public CustomersController(ICustomers customers)
        {
            _customers = customers;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCustomers()
        {
            var result = _customers.GetCustomers();
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [HttpGet("{code}")]
        public IActionResult GetCustomers(string code)
        {
            var result = _customers.GetCustomers(code);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpGet("customerById/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var result = _customers.GetCustomerById(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpGet("customerByIdOrCustomerAll/{id}")]
        public IActionResult GetCustomerByIdOrCustomerAll(int id)
        {
            var result = _customers.GetCustomerByIdOrCustomerAll(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpGet("customers/{city}")]
        public IActionResult GetCustomersLocations(string city)
        {
            var result = _customers.GetCustomersLocations(city);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }


        /// <summary>
        /// Se crea un customer en la Base de datos con la entidad completa customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostCustomers(apilfs.DTO.CustomersDto customer)
        {
            try
            {
                var resultCustomer = _customers.GetCustomersExits(customer.Code);
                if (!resultCustomer)
                {
                    _customers.InsertCustomer(customer);                   
                    return Ok();
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                throw;
            }
                      
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult PutCustomers(Models.Customer customer)
        {
            try
            {try
                {
                    _customers.Update(customer);
                    _customers.Save();
                    return Ok();
                }
                catch (Exception ex) { _ = ex.Message; throw; }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                throw;
            }           
        }


    }
}
