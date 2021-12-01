using Data.EntityModels;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
   public interface INajavaService
    {
        void Insert(NajavaVM najavaVM);
        void Update(NajavaVM  najavaVM);
        List<NajavaPrikazVM> Get();
        NajavaVM GetByID(int id);
         Task<RezultatVM>  PromjenaStanjaAsync(StanjeVM vm);
        List<NajavaPrikazVM> GetByStanje(int StanjeID);
       


    }
}
