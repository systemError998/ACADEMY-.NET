using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_05_CostruttoriEreditari
{
    internal class Studente : Persona // studente extends persona
    {
        public string? Matricola { get; set; }

        public Studente(string varNome, string varCognome, string varMatricola) {
            base.Nome = varNome;
            base.Cognome = varCognome;     //base si riferisce alla classe base, quella da cui eredito 
            this.Matricola = varMatricola; //this è riferito a studente
        }
        // Quando stampo il costruttore di studente, in automatico stampa anche il costruttore di persona,
        // in quanto per creare uno studente ho bisogno di Nome e Cognome , che sono di persona
        // quindi nella memoria viene allocato Nome e Cognome di Persona, ma Matricola di Studente.
        // Ovviamente sono tutti collegati tra di loro 

        public override void StampaDettaglio()
        {
            Console.WriteLine($"[Studente] {Nome} {Cognome} {Matricola}");
        }
    }
}
