using Core.Interfaces;
using Data.ViewModels;
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
    public class UplataController : ControllerBase
    {
        private IUplataService _uplataService;
        public UplataController(IUplataService uplataService)
        {
            _uplataService = uplataService;
        }
        [HttpPost]
        public async Task<IActionResult> InsertAsync(UplataVM uplata)
        {
           var result= await _uplataService.EvidentiranjeUplateAsync(uplata);
            try
            {
                
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_uplataService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(string id)
        {
            return Ok(_uplataService.GetByID(id));
        }
    }
}
