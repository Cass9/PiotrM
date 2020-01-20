namespace Projekt_Przychodnia_Lekarska
{
    public class Recepta : Interface1
    {
        public Osoby.Lekarz lekarz;
        public Osoby.Pacjent pacjent;
        public Leki lek;

        public Recepta(Osoby.Lekarz lekarz, Osoby.Pacjent pacjent, Leki lek)
        {
            this.lekarz = lekarz;
            this.pacjent = pacjent;
            this.lek = lek;
        }
        public override string ToString()
        {
            return $"Lekarz: {lekarz.Wypisz()} - Pacjent: {pacjent.Wypisz()} - Lek: {lek.ToString()}";
        }
        public string Szukaj()
        {
            foreach (var l in Magazyn.StanMagazynuLekow)
            {
                if (l.Key == lek && l.Value > 0)
                {
                    return $"Lek {lek} - jest dostepny w magazynie w ilości {l.Value}";
                }
            }
            return $"Lek {lek} - jest niedostepny";
        }
    }
}
