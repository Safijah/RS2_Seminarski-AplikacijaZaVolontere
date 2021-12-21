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
    public class KorisniLinkController : ControllerBase
    {
        private IKorisniLinkService _korisniLinkService;
        public KorisniLinkController(IKorisniLinkService korisniLinkService)
        {
            _korisniLinkService = korisniLinkService;
        }
        [HttpPost]
        public IActionResult Insert(KorisniLinkVM korisniLinkVM)
        {
            var admin = HttpContext.User.Claims.ToList();
            korisniLinkVM.AdminID = admin[1].Value;
            var result = _korisniLinkService.Insert(korisniLinkVM);
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
                return Ok(_korisniLinkService.Get());
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
                return Ok(_korisniLinkService.GetByID(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Update(KorisniLinkVM korisniLinkVM)
        {
            try
            {
                _korisniLinkService.Update(korisniLinkVM);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
