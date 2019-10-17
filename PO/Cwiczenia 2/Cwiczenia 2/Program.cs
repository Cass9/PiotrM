using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia_2
{
    class Program
    {
        public class Car
        {
            private string marka;
            private int rok;
            private string model;
            private int iloscDrzwi;
            private string pojemnoscSilnika;
            public double srednieSpalanie;

            public Car(string n, int z)
            {
                marka = n;
                rok = z;
            }
            public void PokazCar()
            {
                Console.WriteLine(marka + " " + rok);
            }
            private double ObliczSpalanie(double srednieSpalanie, double dlugoscTrasy)
            {
                double spalanie;
                return spalanie = srednieSpalanie * dlugoscTrasy;
            }

        }
        static void Main(string[] args)
        {
            string carName;
            carName = "Moj samochod";

            Car car1 = new Car("Skoda", 2004);
            Car car2 = new Car("Opel", 1999);
            /*
            car1 = car2;
            */
            car1.PokazCar();
            car2.PokazCar();



            Console.ReadKey();
        }
    }
}
