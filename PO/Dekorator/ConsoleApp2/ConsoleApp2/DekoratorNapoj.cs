using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class DekoratorNapoj : Napoj
    {
        protected Napoj napoj;
        public DekoratorNapoj(Napoj _napoj)
        {
            napoj = _napoj;
        }
        public override string GetOpis()
        {
            return napoj.GetOpis();
        }
        public override double Koszt()
        {
            return napoj.Koszt();
        }
    }
}
