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
    public class KorisnikController : ControllerBase
    {
        private IKorisnikService _korisnikService;
        public KorisnikController(IKorisnikService korisnikService)
        {
            _korisnikService = korisnikService;
        }
        [Authorize]
        [HttpPost("Registracija")]
        public async Task<IActionResult> RegistracijaAsync([FromBody] RegistracijaVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await _korisnikService.RegistracijaAsync(model);


                return Ok(result); // Status Code: 200 


            }

            return BadRequest("Neke vrijednosti nisu ispravne"); // Status code: 400
        }
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginVM model)
        {
            var result = new RezultatVM();
            if (ModelState.IsValid)
            {
                result = await _korisnikService.LoginUserAsync(model);

                if (result.ISUspjesno)
                {

                    return Ok(result);
                }

                return Ok(result);
            }
            result.Poruka = "Nisu ispravni podaci";
            result.ISUspjesno = false;
            return Ok(result);
        }
        [Authorize]
        [HttpGet("{ime}/{prezime}/{grad}/{skola}")]
        public IActionResult Get(string ime, string prezime, int grad, int skola)
        {
            var vm = new FilterVM()
            {
                Ime = ime,
                Prezime = prezime,
                GradID = grad,
                SkolaID = skola
            };
            try
            {
                return Ok(_korisnikService.Get(vm));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetByID(string id)
        {
            try
            {
                return Ok(_korisnikService.GetByID(id));
            }
            catch (Exception)
            {
                return BadRequest("Korisnik nije pronađen");
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult Insert(KorisnikVM registracijaVM)
        {
               var rezultat= _korisnikService.InsertAsync(registracijaVM);
            try
            {
                return Ok(_korisnikService.InsertAsync(registracijaVM));
            }
            catch (Exception ex)
            {

                return Ok(rezultat);
            }
        }
        [Authorize]
        [HttpGet("GetKorisnikaZaListu")]
        public IActionResult GetKorisnikaZaListu()
        {
            try
            {
                return Ok(_korisnikService.GetKorisnikaZaListu());
            }
            catch (Exception ex )
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
