﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia6
{
    class Osoba : IGitarzysta, ISkrzypek
    {
        public Osoba()
        {

        }
        public void Graj()
        {
            Console.WriteLine("Gram ale nie wiem na czym");
        }
        void IGitarzysta.Graj()
        {
            Console.WriteLine("Gram na gitarze");
        }
        void ISkrzypek.Graj()
        {
            Console.WriteLine("Gram na skrzypcach");

        }
    }
}
