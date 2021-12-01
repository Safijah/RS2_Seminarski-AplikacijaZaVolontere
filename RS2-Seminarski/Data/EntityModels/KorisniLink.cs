using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.EntityModels
{
    public class KorisniLink
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Link { get; set; }
        public Admin Admin { get; set; }
        public string AdminID { get; set; }

    }
}
