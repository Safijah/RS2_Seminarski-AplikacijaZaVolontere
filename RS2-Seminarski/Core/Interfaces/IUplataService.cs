using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUplataService
    {
        Task<RezultatVM> EvidentiranjeUplateAsync(UplataVM uplata);
        List<PrikazUplataVM> Get();
        List<PrikazUplataVM> GetByID(string VolonterID=null, int MjesecID = 0);
        


    }
}
