using System;

namespace Cwiczenia3
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        static int iloscKol;

        private Car()
        {

        }

        static Car()
        {
            iloscKol = 4;
        }

        private Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }

        public static Car Create()
        {
            Car c = new Car();
            return c;
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }
    }
}