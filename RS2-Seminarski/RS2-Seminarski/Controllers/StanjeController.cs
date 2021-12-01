using Data.DbContext;
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
    public class StanjeController : ControllerBase
    {
        private AppDbContext _appDbContext;
        public StanjeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_appDbContext.Stanje.ToList());
        }
    }
}
