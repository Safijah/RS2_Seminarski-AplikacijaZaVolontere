using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.EntityModels
{
    public class Skola
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public TipSkole TipSkole { get; set; }
        public int  TipSkoleID { get; set; }
    }
}
