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
            Console.ReadKey();

        }
    }
}
