using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia6
{
    class Programista : Pracownik
    {
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Obowiazki programisty");
        }
    }
}
