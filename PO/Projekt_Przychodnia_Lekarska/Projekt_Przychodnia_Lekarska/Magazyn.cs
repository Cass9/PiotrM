using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Przychodnia_Lekarska
{
    public static class Magazyn
    {
        public static Dictionary<Leki, int> StanMagazynuLekow = new Dictionary<Leki, int>();
        public static List<Osoby.Lekarz> Lekarze = new List<Osoby.Lekarz>();
        public static List<Osoby.Pacjent> Pacjenci = new List<Osoby.Pacjent>();
        public static List<Osoby.InniPracownicy> Pracownicy = new List<Osoby.InniPracownicy>();
        public static List<Recepta> Recepty = new List<Recepta>();

        public static void DodajLek(Leki lek, int ilosc)
        {
            StanMagazynuLekow.Add(lek, ilosc);
        }
        public static void DodajLekarza(Osoby.Lekarz lekarz)
        {
            Lekarze.Add(lekarz);
        }
        public static void DodajPacjenta(Osoby.Pacjent pacjent)
        {
            Pacjenci.Add(pacjent);
        }
        public static void DodajPracownika(Osoby.InniPracownicy pracownik)
        {
            Pracownicy.Add(pracownik);
        }
        public static void Dodajrecepte(Recepta recepta)
        {
            Recepty.Add(recepta);
        }
        public static void WypiszLeki()
        {
            foreach (var m in StanMagazynuLekow)
            {
                Console.WriteLine($"{m.Key} - Ilość: {m.Value}");
            }
        }
        public static void WypiszLekarzy()
        {
            foreach (var l in Lekarze)
            {
                Console.WriteLine(l.Wypisz());
            }
        }
        public static void WypiszPacjetow()
        {
            foreach (var p in Pacjenci)
            {
                Console.WriteLine(p.Wypisz());
            }
        }
        public static void WypiszPracownicy()
        {
            foreach (var p in Pracownicy)
            {
                Console.WriteLine(p.Wypisz());
            }
        }
        public static void WypiszRecepty()
        {
            foreach (var r in Recepty)
            {
                Console.WriteLine(r.ToString());
            }
        }
        
    }
}
