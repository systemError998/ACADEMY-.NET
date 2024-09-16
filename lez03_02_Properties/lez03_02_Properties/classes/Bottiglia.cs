using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_02_Properties.classes
{
    internal class Bottiglia
    {
        // PROPERTY:

        //prop + tab 
        public string? Materiale { get; set; }

        //--------------------------------------------------

        //propfull + tab
        private string? marca;

        public string? Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        //--------------------------------------------------

        private float altezza;

        public float Altezza
        {
            get { return altezza; }
            set { 
                if(value>0)
                    altezza = value;
                else
                    Console.WriteLine("Errore di altezza");
            }
        }
    }
}
