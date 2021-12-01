using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
  public  class KorisnikVM
    {
    public string ID { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string Spol { get; set; }
    public int SpolID { get; set; }
    public string Grad { get; set; }
    public int GradID { get; set; }
    public string Skola { get; set; }
    public int SkolaID { get; set; }
    public string Email { get; set; }
    public string Sifra { get; set; }

    }
}
