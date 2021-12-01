using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModels
{
   public class RezultatVM
    {
        public string Poruka { get; set; }
        public bool ISUspjesno { get; set; }
        public IEnumerable<string> Greske { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
