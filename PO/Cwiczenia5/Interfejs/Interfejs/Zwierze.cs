using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejs
{
    class Zwierze : IZwierze
    {
        public void CoJem()
        {
            throw new NotImplementedException();
        }

        public void JakSiePoruszam()
        {
            if (this.GetType().Name == "Pies")
                Console.WriteLine("Poruszam sie na 4 lapach");
        }
    }
}
