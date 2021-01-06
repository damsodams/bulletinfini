using System;
using System.Collections.Generic;

namespace fr.bulletinfini.metier.Classe
{
    public class Promotion
    {
        public int id { get; set; }
        public String intitule { get; set; }
        public DateTime date { get; set; }

        public List<Eleve> eleves { get; set; }
    }
}
