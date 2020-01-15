using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Maly : DekoratorNapoj
    {
        public Maly(Napoj _napoj) : base(_napoj)
        {

        }
        public override double Koszt()
        {
            return napoj.Koszt();
        }
        public override string GetOpis()
        {
            return napoj.GetOpis() + ", napoj maly";
        }
    }
}
