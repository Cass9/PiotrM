using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Mleko : DekoratorNapoj
    {
        public Mleko(Napoj _napoj) : base(_napoj)
        {

        }
        public override double Koszt()
        {
            return 0.50 + napoj.Koszt();
        }
        public override string GetOpis()
        {
            return napoj.GetOpis() + "Mleko";
        }
    }
}
