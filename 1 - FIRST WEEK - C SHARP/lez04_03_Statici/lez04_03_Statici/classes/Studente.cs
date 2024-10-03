using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez04_03_Statici.classes
{
    internal class Studente
    {
        public string? Nominativo { get; set; }
        public string? Matricola { get; set; }

        //STATIC è una keyword che serve per rendere comune una proprietà o un metodo a tutte le istanze di una classe
        //gli elementi static vengono allocati per primi in memoria
        //E' una proprietà accessibile anche senza la creazione di un'istanza 
        // public static int? Contatore { get; private set; }

        private static int contatore = 0;

        public Studente() {
            contatore++;
        }
        public int getContatore() { 
            return contatore;
        }
    }
}
