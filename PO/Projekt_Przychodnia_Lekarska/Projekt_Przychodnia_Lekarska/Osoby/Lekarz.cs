namespace Projekt_Przychodnia_Lekarska.Osoby
{
    public class Lekarz : Osoba
    {
        public string specjalizacja;
        public int zarobki;

        public Lekarz(string specjalizacja, int zarobki, string imie, string nazwisko, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.specjalizacja = specjalizacja;
            this.zarobki = zarobki;        
        }
        
        public override string Wypisz() => base.Wypisz() + " Specjalizacja: " + $"{specjalizacja}" + " Zarobki: " + $"{zarobki}";

        
    }
}
