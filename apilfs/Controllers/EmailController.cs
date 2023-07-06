using apilfs.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using EmailServices;

namespace apilfs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly ILogger<EmailController> _ilogger;
        private readonly EmailServices.IEmailSender _emailSend;

        public EmailController(ILogger<EmailController> ilogger, EmailServices.IEmailSender emailSend)
        {
            _emailSend = emailSend;
            _ilogger = ilogger;
        }

        [HttpPost]
        public IActionResult PostEmail(Message message)
        {
            try
            {
                _emailSend.SendEmail(message);                
                return Ok();
            }
            catch (Exception ex)
            {
                _ilogger.LogError(ex, this.ControllerContext.ActionDescriptor.AttributeRouteInfo.Template);
                throw;
            }
           
        }

        [HttpPost("send-email-base64")]
        public IActionResult SendEmailBase64(MessageRequestBase64 message)
        {
            try
            {
                _emailSend.SendEmailBase64(message);
                return Ok("The email was sent correctly");
            }
            catch (Exception ex)
            {
                _ilogger.LogError(ex, this.ControllerContext.ActionDescriptor.AttributeRouteInfo.Template);
                return BadRequest(ex.Message);
            }

        }

    }
}
