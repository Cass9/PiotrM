using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Sredni : DekoratorNapoj
    {
        public Sredni(Napoj _napoj) : base(_napoj)
        {

        }
        public override double Koszt()
        {
            return napoj.Koszt() + 0.50;
        }
        public override string GetOpis()
        {
            return napoj.GetOpis() + ", napoj sredni";
        }
    }
}
