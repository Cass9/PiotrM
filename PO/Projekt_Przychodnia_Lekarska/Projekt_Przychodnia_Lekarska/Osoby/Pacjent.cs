namespace Projekt_Przychodnia_Lekarska.Osoby
{
    public class Pacjent : Osoba
    {
        public Pacjent(string imie, string nazwisko, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }

        
        public override string Wypisz() => base.Wypisz();
    }
}
