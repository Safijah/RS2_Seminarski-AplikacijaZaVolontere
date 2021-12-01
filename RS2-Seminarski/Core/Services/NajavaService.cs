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
   public class NajavaService:INajavaService
    {
        private AppDbContext _appDbContext;
        private IEmailService _emailService;
        public NajavaService(AppDbContext appDbContext,IEmailService emailService)
        {
            _appDbContext = appDbContext;
            _emailService = emailService;
        }
       public void Insert(NajavaVM najavaVM)
        {
            var Najava = new Najava()
            {
                Mjesto = najavaVM.Mjesto,
                VrijemeDo = najavaVM.VrijemeDo,
                VrijemeOd = najavaVM.VrijemeOd,
                Mentori = najavaVM.Mentori,
                GradID = najavaVM.GradID,
                Napomena = najavaVM.Napomena,
                Datum = najavaVM.Datum,
                VolonterID = najavaVM.VolonterID,
                StanjeID = 1
            };
            _appDbContext.Add(Najava);
            _appDbContext.SaveChanges();
        }
       public void Update(NajavaVM najavaVM)
        {
            var Najava = _appDbContext.Najava.Find(najavaVM.ID);
            Najava.Mjesto = najavaVM.Mjesto;
            Najava.VrijemeDo = najavaVM.VrijemeDo;
            Najava.VrijemeOd = najavaVM.VrijemeOd;
            Najava.Mentori = najavaVM.Mentori;
            Najava.GradID = najavaVM.GradID;
            Najava.Napomena = najavaVM.Napomena;
            Najava.Datum = najavaVM.Datum;
            Najava.VolonterID = najavaVM.VolonterID;
            Najava.StanjeID = 1;
            _appDbContext.SaveChanges();
        }
       public List<NajavaPrikazVM> Get()
        {
            return _appDbContext.Najava.Where(a => a.StanjeID == 1).Select(a => new NajavaPrikazVM
            {
                ID = a.Id,
                Datum = a.Datum,
                VrijemeDo = a.VrijemeDo,
                VrijemeOd = a.VrijemeOd,
                Mjesto = a.Mjesto,
                Napomena = a.Napomena,
                Volonter = _appDbContext.Korisnik.FirstOrDefault(b => b.Id == a.VolonterID).Ime,
                Grad = _appDbContext.Grad.FirstOrDefault(b => b.ID == a.GradID).Naziv,
                Stanje = _appDbContext.Stanje.FirstOrDefault(b => b.ID == a.StanjeID).Naziv,
                Mentori = a.Mentori
            }).ToList();
        }
       public NajavaVM GetByID(int id)
        {
            var Najava= _appDbContext.Najava.Find(id);
            var NajavaZaSlanje = new NajavaVM()
            {
                Mjesto = Najava.Mjesto,
                VrijemeDo = Najava.VrijemeDo,
                VrijemeOd = Najava.VrijemeOd,
                Mentori = Najava.Mentori,
                GradID = Najava.GradID,
                Napomena = Najava.Napomena,
                Datum = Najava.Datum,
                VolonterID = Najava.VolonterID,
                StanjeID = Najava.StanjeID,
                Volonter = _appDbContext.Korisnik.FirstOrDefault(b => b.Id == Najava.VolonterID).Ime,
                Grad = _appDbContext.Grad.FirstOrDefault(b => b.ID == Najava.GradID).Naziv,
                Stanje = _appDbContext.Stanje.FirstOrDefault(b => b.ID == Najava.StanjeID).Naziv,
                ID =id
            };
            return NajavaZaSlanje;
        }
        public async Task<RezultatVM> PromjenaStanjaAsync(StanjeVM vm)
        {
            var Najava = _appDbContext.Najava.Find(vm.Id);
            if (Najava != null)
            {
                Najava.StanjeID = vm.StanjeID;
                _appDbContext.SaveChanges();
                var korisnik = _appDbContext.Korisnik.Find(Najava.VolonterID);
                if (vm.StanjeID == 2)
                {
                    await _emailService.SendEmailAsync(korisnik.Email, "Najava", $"<h1>Zdravo {korisnik.Ime}</h1>" +
                    $"<p>Poštovani/a, vaša najava je vraćena. Molimo Vas da ispravite najavu u što kraćem roku</p></br><p>{vm.Napomena}</p>");
                }
                else
                    if (vm.StanjeID == 3)
                {
                    await _emailService.SendEmailAsync(korisnik.Email, "Najava", $"<h1>Zdravo {korisnik.Ime}</h1>" +
                    $"<p>Poštovani/a, vaša najava je prihvaćen</p>");
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
       public List<NajavaPrikazVM> GetByStanje(int StanjeID)
        {
            return _appDbContext.Najava.Where(a => a.StanjeID == StanjeID).Select(a => new NajavaPrikazVM
            {
                ID = a.Id,
                Datum = a.Datum,
                VrijemeDo = a.VrijemeDo,
                VrijemeOd = a.VrijemeOd,
                Mjesto = a.Mjesto,
                Napomena = a.Napomena,
                Volonter = _appDbContext.Korisnik.FirstOrDefault(b => b.Id == a.VolonterID).Ime,
                Grad = _appDbContext.Grad.FirstOrDefault(b => b.ID == a.GradID).Naziv,
                Stanje = _appDbContext.Stanje.FirstOrDefault(b => b.ID == a.StanjeID).Naziv,
                Mentori = a.Mentori
            }).ToList();
        }

    }
}
