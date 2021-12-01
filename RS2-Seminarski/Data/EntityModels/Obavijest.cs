using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.EntityModels
{
    public class Obavijest
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public Sekcija Sekcija { get; set; }
        public int SekcijaID { get; set; }
        public Admin Admin { get; set; }
        public string  AdminID { get; set; }
    }
}
