using Core.Interfaces;
using Data.DbContext;
using Data.ViewModels;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Services
{
    public class IzvjestajService:IIzvjestajService
    {
        private AppDbContext _appDbContext;
        private IEmailService _emailService;
        public IzvjestajService(AppDbContext appDbContext,  IEmailService emailService)
        {
            _appDbContext = appDbContext;
            _emailService = emailService;
        }
        public void Insert(IzvjestajVM izvjestajVM)
        {
            var Izvjestaj = new Izvjestaj()
            {
                Cilj = izvjestajVM.Cilj,
                Teme = izvjestajVM.Teme,
                VolonterskeAktivnosti = izvjestajVM.VolonterskeAktivnosti,
                PrisutniUcenici = izvjestajVM.PrisutniUcenici,
                OdsutniUcenici = izvjestajVM.OdsutniUcenici,
                Napomena = izvjestajVM.Napomena,
                VolonterID = izvjestajVM.VolonterID,
                StanjeID=1,
                NajavaID= izvjestajVM.NajavaID
            };
            _appDbContext.Add(Izvjestaj);
            _appDbContext.SaveChanges();
        }
        public void Update(IzvjestajVM izvjestajVM)
        {
            var Izvjestaj = _appDbContext.Izvjestaj.Find(izvjestajVM.Id);
            if(Izvjestaj!=null)
            {
                Izvjestaj.Cilj = izvjestajVM.Cilj;
                Izvjestaj.Teme = izvjestajVM.Teme;
                Izvjestaj.VolonterskeAktivnosti = izvjestajVM.VolonterskeAktivnosti;
                Izvjestaj.PrisutniUcenici = izvjestajVM.PrisutniUcenici;
                Izvjestaj.OdsutniUcenici = izvjestajVM.OdsutniUcenici;
                Izvjestaj.Napomena = izvjestajVM.Napomena;
                Izvjestaj.VolonterID = izvjestajVM.VolonterID;
                Izvjestaj.StanjeID = 1;
                Izvjestaj.NajavaID = izvjestajVM.NajavaID;
                _appDbContext.SaveChanges();
            }
        }
        public List<IzvjestajPrikazVM> Get()
        {
            return _appDbContext.Izvjestaj.Where(a => a.StanjeID == 1).Select(a=>new IzvjestajPrikazVM {
                Cilj = a.Cilj,
                Teme = a.Teme,
                VolonterskeAktivnosti = a.VolonterskeAktivnosti,
                PrisutniUcenici = a.PrisutniUcenici,
                OdsutniUcenici = a.OdsutniUcenici,
                Napomena = a.Napomena,
                Volonter = _appDbContext.Korisnik.FirstOrDefault(b => b.Id == a.VolonterID).Ime,
                Stanje = _appDbContext.Stanje.FirstOrDefault(b => b.ID == a.StanjeID).Naziv,
                Id = a.Id
            }).ToList();
        }
        public IzvjestajVM GetByID(int id)
        {
            var Izvjestaj = _appDbContext.Izvjestaj.Where(a=>a.Id==id).Select(a=>new IzvjestajVM
            {
                Cilj = a.Cilj,
                Teme = a.Teme,
                VolonterskeAktivnosti = a.VolonterskeAktivnosti,
                PrisutniUcenici = a.PrisutniUcenici,
                OdsutniUcenici = a.OdsutniUcenici,
                Napomena = a.Napomena,
                VolonterID = a.VolonterID,
                StanjeID=a.StanjeID ,
                Id=id
            }).FirstOrDefault();
            return Izvjestaj;
        }
        public async Task<RezultatVM> PromjenaStanjaAsync(StanjeVM vm)
        {
            var Izvjestaj = _appDbContext.Izvjestaj.Find(vm.Id);
            if(Izvjestaj!=null)
            {
                Izvjestaj.StanjeID = vm.StanjeID;
                _appDbContext.SaveChanges();
                var korisnik = _appDbContext.Korisnik.Find(Izvjestaj.VolonterID);
                if(vm.StanjeID==2)
                {
                    await _emailService.SendEmailAsync(korisnik.Email, "Izvještaj", $"<h1>Zdravo {korisnik.Ime}</h1>" +
                    $"<p>Poštovani/a, vaš izvještaj je vraćena. Molimo Vas da ispravite izvještaj u što kraćem roku</p></br><p>{vm.Napomena}</p>");
                }
                else
                    if(vm.StanjeID==3)
                {
                    await _emailService.SendEmailAsync(korisnik.Email, "Izvještaj", $"<h1>Zdravo {korisnik.Ime}</h1>" +
                    $"<p>Poštovani/a, vaš izvještaj je prihvaćen</p>");
                }
                return new RezultatVM()
                {
                    Poruka = "Stanje uspješno promijenjeno",
                    ISUspjesno = true
                };
            }
            else
            {
                return new RezultatVM()
                {
                    Poruka = "Stanje najave nije promijenjeno",
                    ISUspjesno = false
                };
            }
        }

        public List<IzvjestajPrikazVM> GetByStanje(int StanjeID)
        {
            return _appDbContext.Izvjestaj.Where(a => a.StanjeID == StanjeID).Select(a => new IzvjestajPrikazVM
            {
                Cilj = a.Cilj,
                Teme = a.Teme,
                VolonterskeAktivnosti = a.VolonterskeAktivnosti,
                PrisutniUcenici = a.PrisutniUcenici,
                OdsutniUcenici = a.OdsutniUcenici,
                Napomena = a.Napomena,
                Volonter = _appDbContext.Korisnik.FirstOrDefault(b => b.Id == a.VolonterID).Ime,
                Stanje = _appDbContext.Stanje.FirstOrDefault(b => b.ID == a.StanjeID).Naziv,
                Id = a.Id

            }).ToList();
        }
    }
}
