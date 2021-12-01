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
    public class ObavijestController : ControllerBase
    {
        private IObavijestService _obavijestService;
        public ObavijestController(IObavijestService obavijestService)
        {
            _obavijestService = obavijestService;
        }
        [HttpPost]
        public IActionResult Insert(ObavijestVM obavijestVM)
        {
               var result= _obavijestService.Insert(obavijestVM);
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
            try
            {
                return Ok(_obavijestService.Get());
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
                return Ok(_obavijestService.GetByID(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Update(ObavijestVM obavijestVM)
        {
            try
            {
                _obavijestService.Update(obavijestVM);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
