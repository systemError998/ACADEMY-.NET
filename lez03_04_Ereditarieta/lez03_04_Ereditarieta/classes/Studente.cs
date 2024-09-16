using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_04_Ereditarieta.classes
{
    //L'EREDITARIETA' è il concetto secondo cui una classe può ereditare attributi e metodi da un'altra classe
    internal class Studente : Persona // studente extends persona
    {
        public string? Matricola { get; set; }

        //con Override ho sovrascritto il metodo StampaDettaglio() di persona
        public override void StampaDettaglio()
        {
            Console.WriteLine($"[Persona] {Nome} {Cognome} {Matricola}");
        }
    }
}
