using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia6b
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura kwadrat1 = new Kwadrat(2);
            Console.WriteLine(kwadrat1.Pole());

            Figura trojkat1 = new Trojkat(2, 3);
            Console.WriteLine(trojkat1.Pole());

            Console.ReadKey();
        }
    }
}
