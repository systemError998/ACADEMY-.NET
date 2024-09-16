using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_05_CostruttoriEreditari
{
    internal class Docente : Persona
    {
        public string? Dipartimento { get; set; }

        public override void StampaDettaglio()
        {
            Console.WriteLine($"[Docente] {Nome} {Cognome} {Dipartimento}");
        }
    }
}
