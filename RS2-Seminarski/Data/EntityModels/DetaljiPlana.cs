using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityModels
{
   public  class DetaljiPlana
    {
        public int Id { get; set; }
        public string NazivTeme1 { get; set; }
        public string NazivTeme2 { get; set; }
        public string Cilj1 { get; set; }
        public string Cilj2 { get; set; }
        public string Aktivnost1 { get; set; }
        public string Aktivnost2 { get; set; }
        public string Mjesec { get; set; }
        public GodisnjiPlan GodisnjiPlan { get; set; }
        public int GodisnjiPlanID { get; set; }
        public Volonter Volonter { get; set; }
        public string VolonterID { get; set; }
    }
}
