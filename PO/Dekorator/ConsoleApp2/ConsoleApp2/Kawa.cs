using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Kawa : Napoj
    {
        public override double Koszt()
        {
            return 2.00;
        }
        public override string GetOpis()
        {
            return "Kawa czarna";
        }
        
    }
}
