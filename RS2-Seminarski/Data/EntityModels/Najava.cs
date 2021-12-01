using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.EntityModels
{
    public class Najava
    {
        public int Id { get; set; }
        public string Mjesto { get; set; }
        public int VrijemeOd { get; set; }
        public int VrijemeDo { get; set; }
        public string Mentori { get; set; }
        public string Napomena { get; set; }
        public DateTime Datum { get; set; }
        public Volonter Volonter { get; set; }
        public string VolonterID { get; set; }
        public Grad Grad { get; set; }
        public int  GradID { get; set; }
        public Stanje Stanje { get; set; }
        public int StanjeID { get; set; }

    }
}
