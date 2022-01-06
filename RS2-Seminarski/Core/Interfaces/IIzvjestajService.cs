using Data.EntityModels;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
   public  interface IIzvjestajService
    {
         void Insert(IzvjestajVM izvještajVM);
        void Update(IzvjestajVM izvještajVM);
        List<IzvjestajPrikazVM> Get();
        IzvjestajVM GetByID(int id);
        Task<RezultatVM> PromjenaStanjaAsync(StanjeVM vm);
        List<IzvjestajPrikazVM> GetByStanje(int StanjeID);
    }
}
