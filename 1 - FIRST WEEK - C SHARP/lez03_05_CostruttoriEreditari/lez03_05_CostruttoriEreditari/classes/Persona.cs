using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_05_CostruttoriEreditari
{
    //Il costruttore del genitore crea le allocazioni di memoria
    internal class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }

        //COSTRUTTORE DI DEFAULT
        //Quando sappiamo che una classe avrà eredi DOBBIAMO obbligatoriamente definire un costruttore di default
        //O perlomeno nel caso in cui ci siano altri costruttori
        public Persona() { }
        public Persona(string varNome , string varCognome)
        {
            this.Nome = varNome;
            this.Cognome = varCognome;
        }

        //con la parola chiave VIRTUAL rendo possibile l'override dalle sottoclassi
        public virtual void StampaDettaglio() {
            Console.WriteLine($"[Persona] {Nome} {Cognome}");
        }
    }
}
