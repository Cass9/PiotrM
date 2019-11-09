using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia6
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Bicycle bicycle1 = new Bicycle();

            IRideable rideCar = car1;
            rideCar.Ride();

            IRideable rideBicycle = bicycle1;
            rideBicycle.Ride();

            Osoba os1 = new Osoba();

            os1.Graj();

            IGitarzysta gitaraOs1 = os1;
            gitaraOs1.Graj();

            ISkrzypek skrzypceOs1 = os1;
            skrzypceOs1.Graj();





            Console.ReadKey();
        }
    }
    
}
