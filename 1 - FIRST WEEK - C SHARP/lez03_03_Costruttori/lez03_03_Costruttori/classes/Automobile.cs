using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_03_Costruttori.classes
{
    internal class Automobile
    {
        public string Marca { get; set; } = null!; //null! => una volta valorizzato non puoi più tornare su null
        public int Cilindrata { get; set; } = 0;
        public string Colore { get; set; } = null!;

        // Il costruttore è il primo metodo che viene invocato in automatico quando crei un nuovo oggetto 
        //ED E' POSSIBILE RICHIAMARLO SOLO DURANTE LA CREAZIONE DELL'OGGETTO, non in altri momenti. 
        // Non ha tipo di ritorno perchè non restituisce nulla
         
        // signature: (string, int, string)
        public Automobile(string varMarca, int varCilindrata, string varColore)
        { 
            this.Marca = varMarca;
            this.Cilindrata = varCilindrata;
            //Posso scrivere anche senza this poichè è implicito che è riferito a QUESTO oggetto
            Colore = varColore;
        }

        // signature: (int, string, string)
        public Automobile( int varCilindrata, string varMarca, string varColore)
        {
            this.Marca = varMarca;
            this.Cilindrata = varCilindrata;
            //Posso scrivere anche senza this poichè è implicito che è riferito a QUESTO oggetto
            Colore = varColore;
        }

        //OVERLOAD DEI METODI e SIGNATURE
        //I metodi possono avere lo stesso nome , ma se hanno firme o signature (parametri) diversi
        //In base ai TIPI di parametri che inserisco lui sa quale funzione richiamare 

        public Automobile() 
        {
            Console.WriteLine("Sono il costruttore di default");
        }

        public void StampaDettaglio()
        {
            Console.WriteLine($"[Automobile] {Marca} {Cilindrata} {Colore}");
        }

        //Uguale a stampa dettaglio 
        public override string ToString()
        {
            return $"[Automobile] {Marca} {Cilindrata} {Colore}";
        }

    }
}
