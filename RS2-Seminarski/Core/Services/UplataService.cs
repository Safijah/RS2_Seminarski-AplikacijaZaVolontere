using ClosedXML.Excel;
using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
        public List<PrikazUplataVM> GetByID(string VolonterID=null, int MjesecID=0)
        {
            if (VolonterID != null && MjesecID != 0)
            {
                var Lista = _appDbContext.Uplata.Where(a => a.MjesecID == MjesecID).ToList();
                var Uplata = new PrikazUplataVM();
                var ListaUplata = new List<PrikazUplataVM>();
                foreach (var x in Lista)
                {
                    if (x.VolonterID == VolonterID)
                    {
                        if (Uplata.ImeiPrezime == null)
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
                if (Uplata.ImeiPrezime != null)
                {
                    ListaUplata.Add(Uplata);
                    return ListaUplata;
                }
                else
                {
                    return ListaUplata;
                }
            }
            else if (VolonterID != null && MjesecID == 0)
            {
                    var Lista = _appDbContext.Uplata.ToList();
                    var Uplata = new PrikazUplataVM();
                    var ListaUplata = new List<PrikazUplataVM>();
                    foreach (var x in Lista)
                    {
                        if (x.VolonterID == VolonterID)
                        {
                            if (Uplata.ImeiPrezime == null)
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
                    if (Uplata != null)
                    {
                        ListaUplata.Add(Uplata);
                        return ListaUplata;
                    }
                    else
                    {
                        return ListaUplata;
                    }

            }
            else if(VolonterID==null && MjesecID!=0)
            {
                var Lista = _appDbContext.Uplata.Where(a => a.MjesecID == MjesecID).ToList();
                var ListaPrikaz = new List<PrikazUplataVM>();
                foreach (var x in Lista)
                {
                    var clan = ListaPrikaz.FirstOrDefault(a => x.VolonterID == a.VolonterID);
                    if (clan == null)
                    {
                        var Uplata = new PrikazUplataVM();

                        Uplata.VolonterID = x.VolonterID;
                        Uplata.ImeiPrezime = _appDbContext.Volonter.Include(a => a.Korisnik).Where(a => x.VolonterID == a.ID).FirstOrDefault().Korisnik.Ime + " " + _appDbContext.Volonter.Include(a => a.Korisnik).Where(a => x.VolonterID == a.ID).FirstOrDefault().Korisnik.Prezime;
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
            else
            {
                var Lista = _appDbContext.Uplata.Where(a => a.MjesecID == MjesecID).ToList();
                var ListaUplata = new List<PrikazUplataVM>();
                foreach (var x in Lista)
                {
                    var clan = ListaUplata.FirstOrDefault(a => x.VolonterID == a.VolonterID);
                    if (clan == null)
                    {
                        var Uplata = new PrikazUplataVM();

                        Uplata.VolonterID = x.VolonterID;
                        Uplata.ImeiPrezime = _appDbContext.Volonter.Include(a => a.Korisnik).Where(a => x.VolonterID == a.ID).FirstOrDefault().Korisnik.Ime + " " + _appDbContext.Volonter.Include(a => a.Korisnik).Where(a => x.VolonterID == a.ID).FirstOrDefault().Korisnik.Prezime;
                        Uplata.UkupnoUplaceno = x.Iznos;
                        Uplata.StatusVolontera = "Student";
                        ListaUplata.Add(Uplata);
                    }
                    else
                    {
                        clan.UkupnoUplaceno += x.Iznos;

                    }
                }
                return ListaUplata;
            }
           
        }
        //public RezultatVM Report(ParametriVM parametri)
        //{
        //        Application excel = new Application();
        //        Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
        //        Worksheet ws = (Worksheet)excel.ActiveSheet;
        //        excel.Visible = false;
        //        ws.Cells[1, 1] = "Ime i prezime";
        //        ws.Cells[1, 2] = "Ukupno potroseno";
        //        ws.Cells[1, 3] = "Status studenta";
        //        ws.Cells[1, 4] = "VolonterID";
        //        int index = 1;
        //        foreach (var x in parametri.lista)
        //        {
        //            index++;
        //            ws.Cells[index, 1] = x.ImeiPrezime;
        //            ws.Cells[index, 2] = x.UkupnoUplaceno;
        //            ws.Cells[index, 3] = x.StatusVolontera;
        //            ws.Cells[index, 4] = x.VolonterID;
        //        }
        //        ws.SaveAs(parametri.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
        //        excel.Quit();
        //    return new RezultatVM()
        //    {
        //        Poruka = "Uspjesno preuzet izvjestaj",
        //        ISUspjesno = true
        //    };
        //}

    }
}
