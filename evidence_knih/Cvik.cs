using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_knih
{
    class Cvik
    {
        public string Nazev { get; set; }
        public string Kategorie { get; set; }
        public int Obtiznost { get; set; }
        public int Tydny { get; set; }
        public string Poznamka { get; set; }
        public bool Splneno { get; set; }

        public Cvik(string nazev, string kategorie, int obtiznost, int tydny, string poznamka, bool zvladnuto)
        {
            this.Nazev = nazev;
            this.Kategorie = kategorie;
            this.Obtiznost = obtiznost;
            this.Tydny = tydny;
            this.Poznamka = poznamka;
            this.Splneno = zvladnuto;
        }
}
}
