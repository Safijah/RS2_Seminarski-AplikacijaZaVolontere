using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.EntityModels
{
    public class Uplata
    {
        public  int Id { get; set; }
        public  int Iznos { get; set; }
        public  Mjesec Mjesec { get; set; }
        public int MjesecID { get; set; }
        public  string Napomena { get; set; }
        public Volonter Volonter { get; set; }
        public string VolonterID { get; set; }
    }
}
