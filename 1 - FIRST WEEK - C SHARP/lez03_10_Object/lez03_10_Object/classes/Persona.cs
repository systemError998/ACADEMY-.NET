using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_10_Object.classes
{
    internal class Persona
    {
        public string Nominativo { get; set; }

        //ToString() è un metodo della classe Object
        public override string ToString()
        {
            return $"[Persona] {Nominativo}";
        }

    }
}
