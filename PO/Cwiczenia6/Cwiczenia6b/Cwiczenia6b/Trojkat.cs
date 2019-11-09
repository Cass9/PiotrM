using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia6b
{
    class Trojkat : Figura
    {
        public Trojkat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Pole()
        {
            return (1 / 2) * a * b;
        }
    }
}
