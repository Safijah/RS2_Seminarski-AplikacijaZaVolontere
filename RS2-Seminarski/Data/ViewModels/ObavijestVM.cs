using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
   public  class ObavijestVM
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public int SekcijaID { get; set; }
        public string AdminID { get; set; }
        
    }
}
