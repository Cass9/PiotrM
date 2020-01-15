using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Napoj nowakawa = new Kawa();
            Console.WriteLine(nowakawa.GetOpis() + " kosztuje: " + $"{nowakawa.Koszt()}");

            nowakawa = new Mleko(nowakawa);
            Console.WriteLine(nowakawa.GetOpis() + " kosztuje: " + $"{nowakawa.Koszt()}");

            nowakawa = new Czekolada(nowakawa);
            Console.WriteLine(nowakawa.GetOpis() + " kosztuje: " + $"{nowakawa.Koszt()}");

            nowakawa = new Maly(nowakawa);
            Console.WriteLine(nowakawa.GetOpis() + " kosztuje: " + $"{nowakawa.Koszt()}");

            nowakawa = new Sredni(nowakawa);
            Console.WriteLine(nowakawa.GetOpis() + " kosztuje: " + $"{nowakawa.Koszt()}");

            nowakawa = new Duzy(nowakawa);
            Console.WriteLine(nowakawa.GetOpis() + " kosztuje: " + $"{nowakawa.Koszt()}");

            Console.ReadKey();
        }
    }
}
