using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_02_Composizione.classes
{
    internal class Mazzo
    {
        public bool hasFiocco { get; set; } = true; // di default sto mazzo de fiori c'ha il fiocco vb

        //In un'aggregazione, inizialmente, la lista deve essere NULL non vuota, perchè non devo occupare memoria
        //La lista non esiste finche non esiste il fiore
        public List<Fiore> lista =  null;

        // La funzione aggiungi fiore controlla se la lista è null E CREA LA LISTA DI FIORI
        //altrimenti se la lista non è null aggiunge il fiore
        public void AggiungiFiore(Fiore objFio) { 
            //
            if(lista is null )
                lista = new List<Fiore>();

            lista.Add(objFio);
        }

        public int ContaFioriNelMazzo() {
            //se la lista è null e quindi non è ancora stata creata il suo contenuto è uguale a 0
            if(lista is null)
                return 0;
            
            //è come se fosse l'else, ma se l'if non va a buon fine passa all'istruzione successiva
            return lista.Count;
        }

    }
}
