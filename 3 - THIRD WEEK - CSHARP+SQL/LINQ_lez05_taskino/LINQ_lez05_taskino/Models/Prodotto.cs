using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_lez05_taskino.Models
{
    internal class Prodotto
    {
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public string Categoria { get; set; }
        public int Quantita { get; set; }

        public override string ToString()
        {
            return $"[PRODOTTO] {Nome} {Descrizione} {Prezzo} {Categoria} {Quantita}";
        }

    }
}
