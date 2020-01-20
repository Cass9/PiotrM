namespace Projekt_Przychodnia_Lekarska.Osoby
{
    public abstract class Osoba
    {
        public string imie;
        public string nazwisko;
        public string pesel;

        public virtual string Wypisz() => "Imie: " + $"{imie}" + " Nazwisko: " + $"{nazwisko}" + " Pesel: " + $"{pesel}";     
                
    }
}
