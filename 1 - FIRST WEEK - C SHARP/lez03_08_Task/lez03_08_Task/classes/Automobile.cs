using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_08_Task.classes
{

    internal class Automobile : Veicolo
    {

        public int? Porte { get; set; }
        public int? Posti { get; set; }

        public virtual void StampaDettaglio()
        {
            Console.WriteLine($"[Automobile] Modello: {Modello}, Colore: {Colore}, Cilindrata: {Cilindrata}, {Ruote} ruote , Targa: {Targa}, Porte: {Porte}, Posti: {Posti}");
        }
    }
}
