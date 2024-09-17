using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez05_01_CorrezioneEsercizio1.classes
{
    internal class Calcolatrice
    {
        //DICHIARANDOLA COME PRIVATA NE IMPEDISCO LA CREAZIONE AL DI FUORI DELLA CLASSE
        private Calcolatrice() { }  
        
        //I METODI SONO STATICI, LI ABBIAMO SEMPRE A DISPOSIZIONE, QUINDI POSSO ACCEDERVI DIRETTAMENTE CON UN'ISTANZA DI CLASSE
        public static double Addizione(double a, double b) {
            return a + b;
        }

        public static double Sottrazione(double a, double b) {
            return a - b;
        }

        public static double Moltiplicazione(double a, double b) { 
            return a * b; 
        }

        public static double? Divisione(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("error");
                return null;
            }
            else {
                return a / b;
            }
        }

    }
}
