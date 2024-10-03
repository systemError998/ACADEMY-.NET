using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez06_02_protected.Models
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Titolo { get; protected set; }
        //con il modificatore di accesso protected le classi che ereditano possono vedere gli attributi/metodi della superclasse
    }
}
