using apilfs.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace apilfs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendor _vendor;

        public VendorController(IVendor vendor)
        {
            _vendor = vendor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetVendors()
        {
            var result = _vendor.GetVendors();
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
        public IActionResult GetVendors(string code)
        {
            var result = _vendor.GetVendors(code);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpGet("VendorByIdSaasSCAC/{IdSaasSCAC}")]
        public IActionResult GetVendorByIdSaasSCAC(string IdSaasSCAC)
        {
            var result = _vendor.GetVendorByIdSaasSCAC(IdSaasSCAC);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpGet("VendorByProviderNameSL/{providerName}")]
        public IActionResult GetVendorByIdProviderNameSwanleap(string providerName)
        {
            var result = _vendor.GetVendorByIdProviderNameSwanleap(providerName);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpPost("VendorsByIdSaasSCAC")]
        public IActionResult GetVendorsByIdSaasSCAC(string[] IdsSaasSCAC)
        {
            var result = _vendor.GetVendorsByIdSaasSCAC(IdsSaasSCAC);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpPost("VendorsByProviderNameSL")]
        public IActionResult GetVendorsByProviderNameSL(string[] names)
        {
            var result = _vendor.GetVendorsByProviderNameSL(names);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostVendor(Models.Vendor vendor)
        {
            _vendor.InsertVendor(vendor);
            _vendor.Save();
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult PustVendor(Models.Vendor vendor)
        {
            _vendor.Update(vendor);
            _vendor.Save();
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult DeleteVendor(Models.Vendor vendor)
        {
            _vendor.Delete(vendor);
            _vendor.Save();
            return Ok();
        }
    }
}
