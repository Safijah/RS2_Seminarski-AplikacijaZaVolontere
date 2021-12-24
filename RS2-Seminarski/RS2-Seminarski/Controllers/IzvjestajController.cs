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
        private IIzvjestajService _izvještajService;
        public IzvjestajController(IIzvjestajService izvještajService)
        {
            _izvještajService = izvještajService;
        }
        [HttpPost]
        public IActionResult Insert(IzvještajVM izvještajVM)
        {
            try
            {
                _izvještajService.Insert(izvještajVM);
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
                return Ok(_izvještajService.Get());
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
                return Ok(_izvještajService.GetByID(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Update(IzvještajVM izvještajVM)
        {
            try
            {
                _izvještajService.Update(izvještajVM);
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
            var result = await _izvještajService.PromjenaStanjaAsync(vm);
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
                return Ok(_izvještajService.GetByStanje(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
