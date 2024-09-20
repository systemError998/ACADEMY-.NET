using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_01_RecapPoly.classes
{
    internal class Studente : Persona
    {
        public string? Matricola { get; set; }
        public string? Corso { get; set; }

        //costruttore di default, genero un overloading di costruttori
        public Studente() { }
        public Studente(string varNome, string varCognome, string varCodFis, string varMatricola, string varCorso) {
            Nome = varNome;
            Cognome = varCognome;
            CodFis = varCodFis;
            Matricola = varMatricola;
            Corso = varCorso;
        }
            
        public override string ToString()
        {
            return $"[STUDENTE] Nome: {base.Nome} Cognome: {base.Cognome} \n CODICE FISCALE: {base.CodFis}, \n " +
                $"Matricola: {this.Matricola}, \n Corso: {this.Corso}";
        }

        public void StampaCartaInt() {
            Console.WriteLine(" --------------------------- ***** --------------------------");
            Console.WriteLine($"Lo studente: {Nome} {Cognome} ");
            Console.WriteLine($"iscritto al corso di: {Corso}");
            Console.WriteLine($"Laureato in merendinofobia applciata");
            Console.WriteLine(" --------------------------- ***** --------------------------");
        }

    }
}
