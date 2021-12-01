using Core.Interfaces;
using Data.DbContext;
using Data.EntityModels;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public class ObavijestService: IObavijestService
    {
        private AppDbContext _appDbContext;
        public ObavijestService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
       public  List<ObavijestPrikazVM> Get()
       {
            return _appDbContext.Obavijest.Where(a => a.SekcijaID == 1).Select(a=>new ObavijestPrikazVM
            {
                Sadrzaj=a.Sadrzaj,
                Naslov=a.Naslov,
                ID=a.Id
            }).ToList();
       }
       public ObavijestVM GetByID(int id)
       {
            var Obavijest = _appDbContext.Obavijest.Where(a => a.Id == id).Select(a => new ObavijestVM
            {
                AdminID = a.AdminID,
                Naslov = a.Naslov,
                Id = a.Id,
                SekcijaID = a.SekcijaID,
                Sadrzaj=a.Sadrzaj
            }).FirstOrDefault();
            return Obavijest;
       }
       public RezultatVM Insert(ObavijestVM obavijestVM)
       {
            var Obavijest = new Obavijest()
            {
                AdminID = "a870b9bd-e7f7-4e10-8879-e70f4e42aa2f",
                Naslov = obavijestVM.Naslov,
                Id = obavijestVM.Id,
                SekcijaID = obavijestVM.SekcijaID,
                Sadrzaj = obavijestVM.Sadrzaj
            };
            _appDbContext.Add(Obavijest);
            _appDbContext.SaveChanges();
            return new RezultatVM()
            {
                ISUspjesno = true,
                Poruka = "Obavijest uspješno kreirana"
            };
       }
       public void Update(ObavijestVM obavijestVM)
       {
            var Obavijest = _appDbContext.Obavijest.Find(obavijestVM.Id);
            if(Obavijest!=null)
            {
                Obavijest.AdminID = obavijestVM.AdminID;
                Obavijest.Naslov = obavijestVM.Naslov;
                Obavijest.SekcijaID = obavijestVM.SekcijaID;
                Obavijest.Sadrzaj = obavijestVM.Sadrzaj;
                _appDbContext.SaveChanges();
            }
       }
    }
}
