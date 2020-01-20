using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Przychodnia_Lekarska.Osoby
{
    public class InniPracownicy : Osoba
    {
        public string stanowisko;
        public int zarobki;

        public InniPracownicy(string stanowisko, int zarobki, string imie, string nazwisko, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.stanowisko = stanowisko;
            this.zarobki = zarobki;
        }
        public override string Wypisz() => base.Wypisz() + " Stanowisko: " + $"{stanowisko}" + " Zarobki: " + $"{zarobki}";
    }
}
