namespace Projekt_Przychodnia_Lekarska
{
    public class Leki 
    {
        public string nazwa;
        public int cena;

        public Leki(string nazwa, int cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }
        public override string ToString()
        {
            return $"Nazwa: {this.nazwa} - Cena: {this.cena}";
        }
    }
}
