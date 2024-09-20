using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_01_RecapPoly.classes
{
    internal class Universita
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }

        //---------------------------AGGREGAZIONE---------------------------
        //In questo modo la lista non esiste, perchè per creare una lista ho bisogno di new 
        //public List<Persona> Elenco { get; set; }
        //In questo modo inizializzo come valore di default una lista vuota
        public List<Persona> Elenco { get; set; } = new List<Persona>();


        #region Inserimenti
        public void InserisciStudente(Studente objStu) {
            Elenco.Add(objStu);
            Console.WriteLine("Studente aggiunto con successo!");
        }
        public void InserisciDocente(Docente objDoc) {
            Elenco.Add(objDoc);
            Console.WriteLine("Docente aggiunto con successo!");
        }
        #endregion

        #region Stampa
        public void StampaTutti() {
            foreach (Persona per in Elenco)
            {
                Console.WriteLine(per.ToString());
            }
        }

        public void StampaStudenti() {
            foreach (Persona per in Elenco)
            {
                if(per.GetType() == typeof(Studente))
                    Console.WriteLine(per.ToString());
            }
        }

        public void StampaCerificatiStudentiElenco() {
            foreach (Persona per in Elenco)
            {
                if (per.GetType() == typeof(Studente))
                    Studente studento = (Studente)per;
            }
        }

        public void StampaDocenti() {
            foreach (Persona per in Elenco)
            {
                if (per.GetType() == typeof(Docente))
                    Console.WriteLine(per.ToString());
            }
        }

        #endregion



    }
}
