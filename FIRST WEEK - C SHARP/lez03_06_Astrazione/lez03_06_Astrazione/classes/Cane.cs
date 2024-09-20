using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_06_Astrazione.classes
{
    internal class Cane : Animale
    {
        public override void VersoEmesso()
        {
            Console.WriteLine("bau bau");
        }
    }
}
