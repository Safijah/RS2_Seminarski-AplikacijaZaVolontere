using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
   public  class NajavaPrikazVM
    {
        public int ID { get; set; }
        public string Mjesto { get; set; }
        public int VrijemeOd { get; set; }
        public int VrijemeDo { get; set; }
        public string Volonter { get; set; }
        public string Mentori { get; set; }
        public string Napomena { get; set; }
        public DateTime Datum { get; set; }
        public string Grad { get; set; }
        public string Stanje { get; set; }
    }
}
