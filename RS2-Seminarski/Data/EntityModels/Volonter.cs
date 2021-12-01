using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.EntityModels
{
   public  class Volonter
    {
        [Key, ForeignKey("Korisnik")]
        public string ID { get; set; }
       
        public virtual Korisnik Korisnik { get; set; }
        
        public Skola Skola { get; set; }
        public int SkolaID { get; set; }
    }
}
