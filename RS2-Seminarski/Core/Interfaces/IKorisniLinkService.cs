using Data.EntityModels;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
   public  interface IKorisniLinkService
    {
        List<KorisniLinkPrikazVM> Get();
        KorisniLinkVM GetByID(int id);
        RezultatVM Insert(KorisniLinkVM korisniLinkVM);
        void Update(KorisniLinkVM korisniLinkVM);

    }
}
