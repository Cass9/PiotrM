using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia6b
{
    class Kwadrat : Figura
    {
        public Kwadrat(double a)
        {
            this.a = a;
        }
        public override double Pole()
        {
            return a * a;
        }
    }
}
