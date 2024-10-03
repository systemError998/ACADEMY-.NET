using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_09_Poly.classes
{
    internal class Veicolo
    {
        //ATTRIBUTI
        public string? Modello { get; set; }
        public string? Colore { get; set; }
        public int? Cilindrata { get; set; }
        public int? Ruote { get; set; }
        public string? Targa { get; set; }

        //IL COSTRUTTORE NON PUO' ESSERE RICHIAMATO IN UNA CLASSE ASTRATTA
        public Veicolo() { }

        public virtual void StampaDettaglio()
        {
            Console.WriteLine($"[Veicolo] Modello: {Modello}, Colore: {Colore}, Cilindrata: {Cilindrata} {Ruote} ruote , Targa: {Targa}");
        }
    }
}
