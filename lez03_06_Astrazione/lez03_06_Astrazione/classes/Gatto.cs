using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_06_Astrazione.classes
{
    internal class Gatto : Animale
    {
        //Quando la superclasse ha un metodo astratto nelle sottoclassi sono obbligato all'override
        public override void VersoEmesso()
        {
            Console.WriteLine("miao miao");
        }
    }
}
