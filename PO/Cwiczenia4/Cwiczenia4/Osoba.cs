namespace Cwiczenia4
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokur;
        protected string miejsceZam;

        public Osoba(string imie, string nazwisko, int rokur)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokur = rokur;
        }

        public override string ToString()
        {
            return $"Imie: {this.imie} Nazwisko: {this.nazwisko} Rok urodzenia {this.rokur}";
        }

        public string WypiszInfo()
        {
            return $"Imie: {this.imie} Nazwisko: {this.nazwisko} Rok urodzenia {this.rokur}";
        }
        public int ObliczWiek()
        {
            return 2019 - this.rokur;
        }

    }
}
