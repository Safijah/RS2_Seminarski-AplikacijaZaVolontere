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
    public class SkolaController : ControllerBase
    {
        private ISkolaService _skolaService;
        public SkolaController(ISkolaService skolaService)
        {
            _skolaService = skolaService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_skolaService.Get());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
