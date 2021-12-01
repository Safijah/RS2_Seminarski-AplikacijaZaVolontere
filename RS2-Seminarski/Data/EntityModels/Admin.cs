using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.EntityModels
{
   public  class Admin
    {
        [Key, ForeignKey("Korisnik")]
        public string ID { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        
       
    }
}
