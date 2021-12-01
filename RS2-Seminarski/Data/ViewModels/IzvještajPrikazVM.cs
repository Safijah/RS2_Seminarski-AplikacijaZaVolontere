using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
    public class IzvještajPrikazVM
    {
        public int Id { get; set; }
        public string Cilj { get; set; }
        public string VolonterskeAktivnosti { get; set; }
        public string Teme { get; set; }
        public string PrisutniUcenici { get; set; }
        public string OdsutniUcenici { get; set; }
        public string Napomena { get; set; }
        public string Volonter { get; set; }
        public string Stanje { get; set; }
    }
}
