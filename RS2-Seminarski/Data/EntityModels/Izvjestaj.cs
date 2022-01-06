using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.EntityModels
{
    public class Izvjestaj
    {
        public int Id { get; set; }
        public string Cilj { get; set; }
        public string VolonterskeAktivnosti { get; set; }
        public string Teme { get; set; }
        public string PrisutniUcenici { get; set; }
        public string OdsutniUcenici { get; set; }
        public string Napomena { get; set; }
        public Volonter Volonter { get; set; }
        public string VolonterID { get; set; }
        public Najava Najava { get; set; }
        public int  NajavaID { get; set; }
        public Stanje  Stanje { get; set; }
        public int StanjeID { get; set; }

    }
}
