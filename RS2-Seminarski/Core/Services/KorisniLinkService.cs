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
    public class KorisniLinkService: IKorisniLinkService
    {
        private AppDbContext _appDbContext;
        public KorisniLinkService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public  List<KorisniLinkPrikazVM> Get()
        {
          return   _appDbContext.KorisniLink.Select(a=>new KorisniLinkPrikazVM
          {
              Id=a.Id,
              Naziv=a.Naziv,
              Link=a.Link
          }).ToList();
        }
       public KorisniLinkVM GetByID(int id)
       {
            return _appDbContext.KorisniLink.Where(a => a.Id == id).Select(a => new KorisniLinkVM
            {
                Id = id,
                Link = a.Link,
                AdminID = a.AdminID,
                Naziv = a.Naziv
            }).FirstOrDefault();
       }
       public RezultatVM Insert(KorisniLinkVM korisniLinkVM)
       {
            var KorisniLink = new KorisniLink()
            {
                Link = korisniLinkVM.Link,
                AdminID = "a870b9bd-e7f7-4e10-8879-e70f4e42aa2f",
                Naziv = korisniLinkVM.Naziv
            };
            _appDbContext.Add(KorisniLink);
            _appDbContext.SaveChanges();
            return new RezultatVM()
            {
                Poruka = "Korisni link uspješno kreiran",
                ISUspjesno = true
            };
       }
       public void Update(KorisniLinkVM korisniLinkVM)
       {
            var KorisniLink = _appDbContext.KorisniLink.Find(korisniLinkVM.Id);
            if(KorisniLink!=null)
            {
                KorisniLink.Link = korisniLinkVM.Link;
                KorisniLink.Naziv = korisniLinkVM.Naziv;
                KorisniLink.AdminID = korisniLinkVM.AdminID;
                _appDbContext.SaveChanges();
            }
       }
    }
}
