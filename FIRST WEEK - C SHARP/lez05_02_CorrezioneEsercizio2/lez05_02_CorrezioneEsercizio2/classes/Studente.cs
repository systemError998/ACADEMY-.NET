using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez05_02_CorrezioneEsercizio2.classes
{
    internal class Studente
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }

        private double voto;

        public double Voto
        {
            get { return voto; }
            set { 
                if (value >= 0 && value <= 10)
                    voto = value; 
                else
                    Console.WriteLine("voto non ammesso ");
            }
        }

       

    }
}
