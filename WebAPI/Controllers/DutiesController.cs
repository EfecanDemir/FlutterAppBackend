using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DutiesController : ControllerBase
    {
        IDutyService _dutyService;
        public DutiesController(IDutyService dutyService)
        {
            _dutyService = dutyService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _dutyService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetByCouponId(int couponId)
        {
            var result = _dutyService.GetByCouponId(couponId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
