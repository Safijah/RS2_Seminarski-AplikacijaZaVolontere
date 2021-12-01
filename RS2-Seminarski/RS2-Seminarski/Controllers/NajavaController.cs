using Core.Interfaces;
using Data.EntityModels;
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
    public class NajavaController : ControllerBase
    {
        private INajavaService _najavaService;
        public NajavaController(INajavaService najavaService)
        {
            _najavaService = najavaService;
        }
        [HttpPost]
        public IActionResult Insert(NajavaVM NajavaVM)
        {
            try
            {
                _najavaService.Insert(NajavaVM);
                return Ok();
            }
            catch (Exception ex )
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public  IActionResult Get()
        {
            try
            {
                return Ok(_najavaService.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            try
            {
                return Ok(_najavaService.GetByID(id));
            }
            catch ( Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Update(NajavaVM najavaVM)
        {
            try
            {
                _najavaService.Update(najavaVM);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost("PromjenaStanja")]
        public async Task<IActionResult> IzmjenaAsync(StanjeVM vm)
        {
            var result = await _najavaService.PromjenaStanjaAsync(vm);
            try
            {
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetByStanje/{id}")]
        public IActionResult GetByStanje(int StanjeID)
        {
            try
            {
                return Ok(_najavaService.GetByStanje(StanjeID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
