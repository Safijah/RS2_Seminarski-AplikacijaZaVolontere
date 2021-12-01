using Core.Interfaces;
using Data.DbContext;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class MonitoringService: IMonitoringService
    {
        private AppDbContext _appDbContext;
        private IEmailService _emailService;
        public MonitoringService(AppDbContext appDbContext, IEmailService emailService )
        {
            _appDbContext = appDbContext;
            _emailService = emailService;
        }
        public async Task<RezultatVM> InsertAsync(MonitoringVM vm )
        {
            var korisnik = _appDbContext.Korisnik.Find(vm.VolonterID);

            await _emailService.SendEmailAsync(korisnik.Email, "Monitoring", $"<h1>Zdravo {korisnik.Ime}</h1>" +
            $"<p>Poštovani/a, administracija je zakazala monitoring za vaše volontiranje. Da biste pristupili sastanku <a href='{vm.link}'>Kliknite ovdje</a></p>");
            return new RezultatVM()
            {
                ISUspjesno = true,
                Poruka = "Uspješno zakazan sastanak."
            };
        }
    }
}
