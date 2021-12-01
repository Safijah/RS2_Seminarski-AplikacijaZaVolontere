using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityModels
{
    public class Korisnik:IdentityUser
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Spol Spol { get; set; }
        public int SpolID { get; set; }
        public Grad Grad { get; set; }
        public int GradID { get; set; }

    }
}
