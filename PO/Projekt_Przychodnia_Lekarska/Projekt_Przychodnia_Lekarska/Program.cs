using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Przychodnia_Lekarska
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Osoby.Lekarz Pediatra = new Osoby.Lekarz("Pediatra", 5000, "Jarosław", "Psikuta", "76121208574");
            Osoby.Lekarz Rodzinny = new Osoby.Lekarz("Rodzinny", 5000, "Mirosław", "Jackowski", "56081104756");
            Osoby.Lekarz Chirurg = new Osoby.Lekarz("Chirurg", 7000, "Franz", "Maurer", "730323847362");


            Osoby.InniPracownicy Recepcjonistka = new Osoby.InniPracownicy("Recepcjonistka", 2700, "Anna", "Maciąg", "92020567463");
            Osoby.InniPracownicy Dyrektor = new Osoby.InniPracownicy("Dyrektor", 20000, "Natalia", "Pochwarska", "991104584736");
            Osoby.InniPracownicy Sprzataczka = new Osoby.InniPracownicy("Sprzątaczka", 2500, "Katarzyna", "Piasecka", "681212857463");

            Osoby.Pacjent pacjent1 = new Osoby.Pacjent("Piotr", "Mikiciuk", "990724756438");
            Osoby.Pacjent pacjent2 = new Osoby.Pacjent("Olga", "Jackowska", "850586362512");

            Leki Marihuanen = new Leki("Marihuanen", 40);
            Leki Mefedron = new Leki("Mefedron", 30);
            Leki Koks = new Leki("Kosk", 100);
            Leki Rak = new Leki("Lek na raka", 1000000);

            Magazyn.DodajLekarza(Pediatra);
            Magazyn.DodajLekarza(Rodzinny);
            Magazyn.DodajLekarza(Chirurg);
            Magazyn.DodajPracownika(Recepcjonistka);
            Magazyn.DodajPracownika(Dyrektor);
            Magazyn.DodajPracownika(Sprzataczka);
            Magazyn.DodajPacjenta(pacjent1);
            Magazyn.DodajPacjenta(pacjent2);
            Magazyn.DodajLek(Marihuanen, 1000);
            Magazyn.DodajLek(Mefedron, 100);
            Magazyn.DodajLek(Koks, 1000);
            Magazyn.DodajLek(Rak, 0);

            Console.WriteLine("=====================LEKARZE==========================================================================================");
            Console.WriteLine();

            Magazyn.WypiszLekarzy();

            Console.WriteLine();
            Console.WriteLine("=====================PRACOWNICY=======================================================================================");
            Console.WriteLine();

            Magazyn.WypiszPracownicy();

            Console.WriteLine();
            Console.WriteLine("=====================PACJENCI=========================================================================================");
            Console.WriteLine();

            Magazyn.WypiszPacjetow();

            Console.WriteLine();
            Console.WriteLine("=====================LEKI=============================================================================================");
            Console.WriteLine();

            Magazyn.WypiszLeki();
            Console.WriteLine();

            Recepta recepta1 = new Recepta(Rodzinny, pacjent1, Rak);
            Recepta recepta2 = new Recepta(Pediatra, pacjent2, Marihuanen);
            Magazyn.Dodajrecepte(recepta1);
            Magazyn.Dodajrecepte(recepta2);

            Console.WriteLine("=====================RECEPTY==========================================================================================");
            Console.WriteLine();
            Magazyn.WypiszRecepty();

            Console.WriteLine();
            Console.WriteLine("=====================DOSTEPNOSC LEKOW Z RECEPTY=======================================================================");
            Console.WriteLine();
            Console.WriteLine(recepta1.Szukaj());
            Console.WriteLine(recepta2.Szukaj());
            Console.ReadKey();
        }
    }
}
