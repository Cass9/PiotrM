using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_lekarska
{
    class Lekarze
    {
        public string imie;
        public string nazwisko;
        public int wiek;
        public double zarobki;

        public Lekarze(string imie, string nazwisko, int wiek, double zarobki)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.zarobki = zarobki;
        }
    }
}
