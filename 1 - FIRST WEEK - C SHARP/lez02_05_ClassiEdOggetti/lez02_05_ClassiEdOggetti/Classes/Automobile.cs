using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez02_05_ClassiEdOggetti.Classes
{
    //La classe è tutto ciò che descrive un oggetto tramite attributi e metodi, da cui possono essere istanziati oggetti con attributi propri (proprietà) 
    //La classe crea dei vincoli, appunto gli attributi.
    //La classe è come uno "stampo", gli oggetti sono le istanze di questo stampo
    //Ogni oggetto istanziato da una classe ha i suoi attributi 
    internal class Automobile
    {
        public string? modello;
        public string? colore;
        public int? cilindrata;

        //Un metodo è una funzionalità che richiamiamo quando abbiamo bisogno di qualcosa
        public void stampaDettaglio() {
            Console.WriteLine($"Modello: {modello}, Colore: {colore}, Cilindrata: {cilindrata}");
        }

    }
}
