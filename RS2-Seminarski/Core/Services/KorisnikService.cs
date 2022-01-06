using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class KorisnikService : IKorisnikService
    {
        private UserManager<Korisnik> _userManger;
        private IConfiguration _configuration;
        private AppDbContext _appDbContext;
        private RoleManager<IdentityRole> _roleManager;
        private IEmailService _emailService;
        public KorisnikService(UserManager<Korisnik> userManager, IConfiguration configuration, AppDbContext appDbContext, RoleManager<IdentityRole> roleManager,
            IEmailService emailService)
        {
            _userManger = userManager;
            _configuration = configuration;
            _appDbContext = appDbContext;
            _roleManager = roleManager;
            _emailService = emailService;
        }
        public async Task<RezultatVM> RegistracijaAsync(RegistracijaVM model)
        {
            if (model == null)
                throw new NullReferenceException("Morate unijeti podatke");
            var postojeci =await _userManger.FindByEmailAsync(model.Email);
            if(postojeci!=null)
            {
                return new RezultatVM
                {
                    Poruka = "Korisnik vec postoji u bazi sa tim mailom.",
                    ISUspjesno = false,
                };
            }
            if (model.Sifra != model.PotvrdjenaSifra)
                return new RezultatVM
                {
                    Poruka = "Sifre se ne podudaraju",
                    ISUspjesno = false,
                };

            var identityUser = new Korisnik
            {
                Email = model.Email,
                UserName = model.Email,
                GradID = model.GradID,
                SpolID = model.SpolID,
                Ime=model.Ime,
                Prezime=model.Prezime
            };
            var role = await  _roleManager.FindByIdAsync("2");
            
            var result = await _userManger.CreateAsync(identityUser, model.Sifra);

            if (result.Succeeded)
            {
            var roleResult = await _userManger.AddToRoleAsync(identityUser, role.Name);
            if (!roleResult.Succeeded)
                return new RezultatVM
               {
                   Poruka = "Korisnik već postoji",
                   ISUspjesno = false,
                   Greske = result.Errors.Select(e => e.Description)
               };
                var Volonter = new Volonter()
                {
                    Korisnik = identityUser,
                    SkolaID=model.SkolaID
                };
                _appDbContext.Add(Volonter);
                _appDbContext.SaveChanges();
                await _emailService.SendEmailAsync(identityUser.Email, "Pristupni podaci za aplikaciju", $"<h1>Zdravo {identityUser.Ime}</h1>" +
                        $"<p>Poštovani/a, vaši pristupni podaci za našu stranicu su:</p> </br> <p>Email: {identityUser.Email}</p> </br> <p> Šifra: {model.Sifra}</p>");
                return new RezultatVM
                {
                    Poruka = "Korisnik uspješno kreiran",
                    ISUspjesno = true,
                };
            }

            return new RezultatVM
            {
                Poruka = "Korisnik nije kreiran",
                ISUspjesno = false,
                Greske = result.Errors.Select(e => e.Description)
            };

        }
        public async Task<RezultatVM> LoginUserAsync(LoginVM model)
        {
            var user = await _userManger.FindByEmailAsync(model.Email);

            if (user == null)
            {
                return new RezultatVM
                {
                    Poruka = "Neispravni podaci",
                    ISUspjesno = false,
                };
            }

            var result = await _userManger.CheckPasswordAsync(user, model.Sifra);

            if (!result)
                return new RezultatVM
                {
                    Poruka = "Neispravni podaci",
                    ISUspjesno = false,
                };

            var claims = new[]
            {
                new Claim("Email", model.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is the key that we will use in the encryption"));

            var token = new JwtSecurityToken(
                issuer: "http://localhost:5010/",
                audience: "http://localhost:5010/",
                claims: claims,
                expires: DateTime.Now.AddDays(30),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            string tokenAsString = new JwtSecurityTokenHandler().WriteToken(token);

            return new RezultatVM
            {
                Poruka = tokenAsString,
                ISUspjesno = true,
                ExpireDate = token.ValidTo
            };
        }
        public List<GetKorisnikaVM> Get(FilterVM vm )
        {
            var Korisnici = new List<GetKorisnikaVM>();
            Korisnici = _appDbContext.Volonter.Include(a => a.Korisnik).Where(a=>(a.Korisnik.Ime.ToLower().Contains(vm.Ime)||vm.Ime==null)&&
            (a.Korisnik.Prezime.ToLower().Contains(vm.Prezime)||vm.Prezime==null) && 
            (a.SkolaID==vm.SkolaID||vm.SkolaID==0)&& (a.Korisnik.GradID==vm.GradID||vm.GradID==0)
            ).Select(a => new GetKorisnikaVM
            {
                Ime = a.Korisnik.Ime,
                Prezime = a.Korisnik.Prezime,
                Email = a.Korisnik.Email,
                Grad = _appDbContext.Grad.FirstOrDefault(b => b.ID == a.Korisnik.GradID).Naziv,
                Spol = _appDbContext.Spol.FirstOrDefault(c => c.ID == a.Korisnik.SpolID).Naziv,
                Skola = _appDbContext.Skola.FirstOrDefault(d => d.ID == a.SkolaID).Naziv
            }).ToList();
            return Korisnici;
        }
        public KorisnikVM GetByID(string id)
        {
            var Korisnik = _appDbContext.Volonter.Where(a => a.ID == id).Select(a => new KorisnikVM
            {
                Ime = a.Korisnik.Ime,
                Prezime = a.Korisnik.Prezime,
                Email = a.Korisnik.Email,
                Grad = _appDbContext.Grad.FirstOrDefault(b => b.ID == a.Korisnik.GradID).Naziv,
                Spol = _appDbContext.Spol.FirstOrDefault(c => c.ID == a.Korisnik.SpolID).Naziv,
                Skola = _appDbContext.Skola.FirstOrDefault(d => d.ID == a.SkolaID).Naziv,
                ID=a.ID
            }).FirstOrDefault();
            return Korisnik;

        }
        public async Task<RezultatVM> InsertAsync(KorisnikVM korisnik)
        {
            var role =  await _roleManager.FindByIdAsync("2");
            var identityUser = new Korisnik
            {
                Email = korisnik.Email,
                UserName = korisnik.Email,
                GradID = korisnik.GradID,
                SpolID = korisnik.SpolID
            };
            var result = await _userManger.CreateAsync(identityUser, korisnik.Sifra);
          

            if (result.Succeeded)
            {
            var roleResult = await _userManger.AddToRoleAsync(identityUser, role.Name);
            if (!roleResult.Succeeded)
                throw new NullReferenceException("Role is not good");
                var Volonter = new Volonter()
                {
                    Korisnik = identityUser,
                    SkolaID = korisnik.SkolaID
                };
                _appDbContext.Add(Volonter);
                _appDbContext.SaveChanges();
                return new RezultatVM
                {
                    Poruka = "Korisnik uspješno kreiran",
                    ISUspjesno = true,
                };
            }
            return new RezultatVM
            {
                Poruka = "Korisnik nije kreiran",
                ISUspjesno = false,
                Greske = result.Errors.Select(e => e.Description)
            };
        }
        public async Task<RezultatVM> DeleteAsync(string id)
        {
            var user = await _userManger.FindByIdAsync(id);

            var result = await _userManger.DeleteAsync(user);
            if (result.Succeeded)
            {
                var Volonter = _appDbContext.Volonter.Find(id);
                _appDbContext.Volonter.Remove(Volonter);
                return new RezultatVM
                {
                    Poruka = "Korisnik uspješno izbrisan",
                    ISUspjesno = true,
                };
            }
            else
            {
                return new RezultatVM
                {
                    Poruka = "Korisnik nije izrbisan",
                    ISUspjesno = false,
                    Greske = result.Errors.Select(e => e.Description)
                };
            }
        }
       public async Task<RezultatVM> EditAsync(KorisnikVM korisnik)
        {
            if(korisnik==null)
            {
                throw new  NullReferenceException("Morate unijeti podatke");
            }
            var User = await _userManger.FindByEmailAsync(korisnik.Email);
            if(User!=null)
            {
                User.Ime = korisnik.Ime;
                User.Prezime = korisnik.Prezime;
                User.SpolID = korisnik.SpolID;
                User.GradID = korisnik.GradID;
                await _userManger.UpdateAsync(User);
                var Volonter = _appDbContext.Volonter.FirstOrDefault(a => a.ID == korisnik.ID);
                Volonter.SkolaID = korisnik.SkolaID;
                _appDbContext.SaveChanges();
                return new RezultatVM
                {
                    Poruka = "Korisnik uspješno uređen",
                    ISUspjesno = true,
                };

            }
            else
            {
                return new RezultatVM
                {
                    Poruka = "Korisnik  nije uređen",
                    ISUspjesno = false,
                };
            }
        }

        public List<KorisniciZaListuVM> GetKorisnikaZaListu()
        {
            return _appDbContext.Volonter.Include(a => a.Korisnik).Select(a => new KorisniciZaListuVM
            {
                ID = a.ID,
                Naziv = a.Korisnik.Ime + " " + a.Korisnik.Prezime
            }).ToList();
                }
        private string NewPassword(int length)
        {
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = uppercase.ToLower();
            string special = "!@#$%^&*()_+=-";
            string numbers = "0123456789";
            return Random(numbers, 1) + Random(uppercase, 1) + Random(special, 1)
                + Random(lowercase, length - 3);
        }

        private string Random(string text, int length)
        {
            Random random = new Random();
            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += text[random.Next(text.Length)];
            }
            return result;
        }
    }

}
