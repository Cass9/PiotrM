using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia4
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba os = new Osoba("imie1", "nazwisko1", 199999);
            Console.WriteLine(os.ToString());
            Console.WriteLine(os.WypiszInfo());

            Student st = new Student("Jan", "Walen", 1999, 2, 3, 150694);
            Console.WriteLine(st.ObliczWiek());

            Console.ReadKey();
        }
    }
}
