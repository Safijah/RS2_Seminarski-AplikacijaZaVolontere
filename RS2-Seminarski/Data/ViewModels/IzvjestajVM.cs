using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
    public class IzvjestajVM
    {
        public int Id { get; set; }
        public string Cilj { get; set; }
        public string VolonterskeAktivnosti { get; set; }
        public string Teme { get; set; }
        public string PrisutniUcenici { get; set; }
        public string OdsutniUcenici { get; set; }
        public string Napomena { get; set; }
        public string VolonterID { get; set; }
        public int NajavaID { get; set; }
        public int StanjeID { get; set; }
    }
}
