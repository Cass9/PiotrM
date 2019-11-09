using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia6
{
    class Bicycle : Vehicle, IRideable
    {
        void IRideable.Ride()
        {
            Console.WriteLine("Jade rowerem");
        }
    }

}
