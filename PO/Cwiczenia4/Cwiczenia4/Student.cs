namespace Cwiczenia4
{
    class Student : Osoba 
    {
        public int rok;
        public int numerGrupy;
        public int numerAlbumu;

        public Student(string imie, string nazwisko, int rokur, int rok, int numerGrupy, int numerAlbumu) : base(imie, nazwisko, rokur)
        {
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }
        public new string WypiszInfo()
        {
            return $"Rok: {rok} Numer Grupy: {numerGrupy} Numer Albumu: {numerAlbumu} {miejsceZam}";
        }
    }
}
