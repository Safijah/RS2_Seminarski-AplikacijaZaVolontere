using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.ViewModels
{
   public  class RegistracijaVM
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Sifra { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string PotvrdjenaSifra { get; set; }
        [Required]
        public int GradID { get; set; }
        [Required]
        public int SpolID { get; set; }
        [Required]
        public int SkolaID { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }


    }
}
