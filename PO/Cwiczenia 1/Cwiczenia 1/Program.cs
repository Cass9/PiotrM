using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 1");

            int[] tab = new int[] { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < tab.Length - 1; i++)
            {
                Console.Write(tab[i] + ",");
            }
            Console.Write(tab[tab.Length - 1]);
            Console.WriteLine();


            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }

            for (int i = tab.Length-1; i >= 0; i--)
            {
                Console.Write(tab[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Cwiczenie 2");

            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if ((a < b + c) && (b < a + c) && (c < b + a))
            {
                Console.WriteLine("Z tych bokow moze powstac trojkat");
            }
            else
            {
                Console.WriteLine("Trojkat nie moze powstac");
            }

            Console.WriteLine();
            Console.WriteLine("Cwiczenie 3");

            int d;
            d = int.Parse(Console.ReadLine());
            if (d >= 5 && d <= 15)
            {
                while(d > 0)
                {
                    d = d - 1;
                    Console.WriteLine(d);
                }
            }
            else
            {
                Console.WriteLine("Podaj inna liczbe");
            }

            Console.WriteLine();
            Console.WriteLine("Cwiczenie 4");

            int e;

            do
            {
                e = int.Parse(Console.ReadLine());
                if(e == 4)
                {
                    Console.WriteLine("Zgadłes liczbe");
                }
                else
                {
                    Console.WriteLine("Jeszcze raz");
                }
            } while (e != 4);



            Console.ReadKey();

        }
    }
}
