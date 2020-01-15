using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Duzy : DekoratorNapoj
    {
        public Duzy(Napoj _napoj) : base(_napoj)
        {

        }
        public override double Koszt()
        {
            return napoj.Koszt() + 1.00;
        }
        public override string GetOpis()
        {
            return napoj.GetOpis() + ", napoj duzy";
        }
    }
}
