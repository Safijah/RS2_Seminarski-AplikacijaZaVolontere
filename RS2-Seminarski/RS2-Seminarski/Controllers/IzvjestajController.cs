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
    public class IzvjestajController : ControllerBase
    {
        private IIzvjestajService _izvjestajService;
        public IzvjestajController(IIzvjestajService izvjestajService)
        {
            _izvjestajService = izvjestajService;
        }
        [HttpPost]
        public IActionResult Insert(IzvjestajVM izvještajVM)
        {
            try
            {
                _izvjestajService.Insert(izvještajVM);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_izvjestajService.Get());
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
                return Ok(_izvjestajService.GetByID(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Update(IzvjestajVM izvještajVM)
        {
            try
            {
                _izvjestajService.Update(izvještajVM);
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
            var result = await _izvjestajService.PromjenaStanjaAsync(vm);
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
        
        public IActionResult GetByStanje(int id)
        {
            try
            {
                return Ok(_izvjestajService.GetByStanje(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
