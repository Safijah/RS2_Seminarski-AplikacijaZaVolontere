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
         void Insert(IzvještajVM izvještajVM);
        void Update(IzvještajVM izvještajVM);
        List<IzvještajPrikazVM> Get();
        IzvještajVM GetByID(int id);
        Task<RezultatVM> PromjenaStanjaAsync(StanjeVM vm);
        List<IzvještajPrikazVM> GetByStanje(int StanjeID);
    }
}
