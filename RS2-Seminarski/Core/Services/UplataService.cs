using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UplataService: IUplataService
    {
        private AppDbContext _appDbContext;
        private IEmailService _emailService;
        public UplataService(  AppDbContext appDbContext, IEmailService emailService)
        {
            _appDbContext = appDbContext;
            _emailService = emailService;
        }
        public async Task<RezultatVM> EvidentiranjeUplateAsync(UplataVM uplata)
        {
            var NovaUplata = new Uplata()
            {
                MjesecID = uplata.MjesecID,
                Iznos = uplata.Iznos,
                Napomena = uplata.Napomena,
                VolonterID = uplata.VolonterID
            };
            _appDbContext.Add(NovaUplata);
            _appDbContext.SaveChanges();
            var korisnik = _appDbContext.Korisnik.Find(uplata.VolonterID);

            await _emailService.SendEmailAsync(korisnik.Email, "Uplata", $"<h1>Zdravo {korisnik.Ime}</h1>" +
            $"<p>Poštovani/a, administracija je evidentirala uplatu stipendije za Vas.</p>");
            return new RezultatVM()
            {
                ISUspjesno = true,
                Poruka = "Uplata uspješno evidentirana"
            };
        }
        public List<PrikazUplataVM> Get( )
        {
            var Lista = _appDbContext.Uplata.ToList();
            var ListaPrikaz = new List<PrikazUplataVM>();
          foreach (var x in Lista)
          {
                var clan = ListaPrikaz.FirstOrDefault(a => x.VolonterID == a.VolonterID);
                if(clan==null)
                {
                    var Uplata = new PrikazUplataVM();

                    Uplata.VolonterID = x.VolonterID;
                    Uplata.ImeiPrezime = _appDbContext.Volonter.Include(a=>a.Korisnik).Where(a=>x.VolonterID==a.ID).FirstOrDefault().Korisnik.Ime + " " + _appDbContext.Volonter.Include(a => a.Korisnik).Where(a => x.VolonterID == a.ID).FirstOrDefault().Korisnik.Prezime;
                    Uplata.UkupnoUplaceno = x.Iznos;
                    Uplata.StatusVolontera = "Student";
                    ListaPrikaz.Add(Uplata);
                }
                else
                {
                    clan.UkupnoUplaceno += x.Iznos;
                  
                }
          }
            return ListaPrikaz;
        }
        public PrikazUplataVM GetByID(string VolonterID)
        {
            var Lista = _appDbContext.Uplata.ToList();
            var Uplata = new PrikazUplataVM();
            foreach (var x in Lista)
            {
             if(x.VolonterID==VolonterID)
                {
                    if(Uplata.ImeiPrezime==null)
                    {
                        Uplata.VolonterID = x.VolonterID;
                        Uplata.ImeiPrezime = _appDbContext.Volonter.Include(a => a.Korisnik).Where(a => x.VolonterID == a.ID).FirstOrDefault().Korisnik.Ime + " " + _appDbContext.Volonter.Include(a => a.Korisnik).Where(a => x.VolonterID == a.ID).FirstOrDefault().Korisnik.Prezime;
                        Uplata.UkupnoUplaceno = x.Iznos;
                        Uplata.StatusVolontera = "Student";
                    }
                    else
                    {
                        Uplata.UkupnoUplaceno += x.Iznos;
                    }
                }
            }
            return Uplata;
        }

    }
}
