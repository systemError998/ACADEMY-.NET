using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_10_Object.classes
{
    internal class Studente : Persona
    {

        public override string ToString()
        {
            return $"[Studente] {Nominativo}";
        }
    }
}
