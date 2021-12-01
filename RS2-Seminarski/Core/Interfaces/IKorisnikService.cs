using Data.ViewModels;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
   public  interface IKorisnikService
    {
        Task<RezultatVM> RegistracijaAsync(RegistracijaVM model);
        Task<RezultatVM> LoginUserAsync(LoginVM model);
        List<GetKorisnikaVM> Get(FilterVM vm);
        KorisnikVM GetByID(string id);
        Task<RezultatVM> InsertAsync(KorisnikVM korisnik);
        Task<RezultatVM> DeleteAsync(string id);
        Task<RezultatVM> EditAsync(KorisnikVM korisnik);
        List<KorisniciZaListuVM> GetKorisnikaZaListu();
    }
}
