using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190920KCSK
{
    class Kecske
    {
        public string Nev { get; set; }
        public bool Nem { get; set; }
        public DateTime Szul { get; set; }
        public Kecske(string nev, bool nem, DateTime szul)
        {
            Nev = nev;
            Nem = nem;
            Szul = szul;
        }
    }
}
