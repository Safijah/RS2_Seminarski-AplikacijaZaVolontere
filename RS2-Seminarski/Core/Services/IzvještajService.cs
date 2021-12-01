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
    public class IzvještajService:IIzvještajService
    {
        private AppDbContext _appDbContext;
        private IEmailService _emailService;
        public IzvještajService(AppDbContext appDbContext,  IEmailService emailService)
        {
            _appDbContext = appDbContext;
            _emailService = emailService;
        }
        public void Insert(IzvještajVM izvještajVM)
        {
            var Izvjestaj = new Izvještaj()
            {
                Cilj = izvještajVM.Cilj,
                Teme = izvještajVM.Teme,
                VolonterskeAktivnosti = izvještajVM.VolonterskeAktivnosti,
                PrisutniUcenici = izvještajVM.PrisutniUcenici,
                OdsutniUcenici = izvještajVM.OdsutniUcenici,
                Napomena = izvještajVM.Napomena,
                VolonterID = izvještajVM.VolonterID,
                StanjeID=1,
                NajavaID=izvještajVM.NajavaID
            };
            _appDbContext.Add(Izvjestaj);
            _appDbContext.SaveChanges();
        }
        public void Update(IzvještajVM izvještajVM)
        {
            var Izvjestaj = _appDbContext.Izvještaj.Find(izvještajVM.Id);
            if(Izvjestaj!=null)
            {
                Izvjestaj.Cilj = izvještajVM.Cilj;
                Izvjestaj.Teme = izvještajVM.Teme;
                Izvjestaj.VolonterskeAktivnosti = izvještajVM.VolonterskeAktivnosti;
                Izvjestaj.PrisutniUcenici = izvještajVM.PrisutniUcenici;
                Izvjestaj.OdsutniUcenici = izvještajVM.OdsutniUcenici;
                Izvjestaj.Napomena = izvještajVM.Napomena;
                Izvjestaj.VolonterID = izvještajVM.VolonterID;
                Izvjestaj.StanjeID = 1;
                Izvjestaj.NajavaID = izvještajVM.NajavaID;
                _appDbContext.SaveChanges();
            }
        }
        public List<IzvještajPrikazVM> Get()
        {
            return _appDbContext.Izvještaj.Where(a => a.StanjeID == 1).Select(a=>new IzvještajPrikazVM {
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
        public IzvještajVM GetByID(int id)
        {
            var Izvjestaj = _appDbContext.Izvještaj.Where(a=>a.Id==id).Select(a=>new IzvještajVM
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
            var Izvjestaj = _appDbContext.Izvještaj.Find(vm.Id);
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

        public List<IzvještajPrikazVM> GetByStanje(int StanjeID)
        {
            return _appDbContext.Izvještaj.Where(a => a.StanjeID == StanjeID).Select(a => new IzvještajPrikazVM
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
