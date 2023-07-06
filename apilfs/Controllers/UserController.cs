using apilfs.DTO;
using apilfs.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("userByEmail/{email}")]
        public IActionResult GetUserWithRoles(string email)
        {
            try
            {
                var result = _userService.GetUserWithRoles(email); 
                if (result != null)
                    return Ok(result);
                else
                    return NotFound("User not found");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
           
        }

        [HttpPost("createUserWithRolesAndCustomerAndAgent")]
        public IActionResult CreateUserWithRolesAndCustomerAndAgent(UserRolesCustomerAgentDto userRolesCustomerAgent)
        {
            try
            {
                var result = _userService.CreateUserWithRolesAndCustomerAndAgent(userRolesCustomerAgent);
                if (result != null)
                    return Ok(result);
                else
                    return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

    }
}
