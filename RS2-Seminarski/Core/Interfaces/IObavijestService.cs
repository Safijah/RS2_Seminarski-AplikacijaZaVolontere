using Data.EntityModels;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IObavijestService
    {
        List<ObavijestPrikazVM> Get();
        ObavijestVM GetByID(int id);
        RezultatVM Insert(ObavijestVM obavijestVM);
        void Update(ObavijestVM obavijestVM);
    }
}
