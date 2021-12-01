using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Seminarski.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GradController : ControllerBase
    {

        private IGradService _gradService;
        public GradController(IGradService gradService)
        {
            _gradService = gradService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_gradService.Get());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
