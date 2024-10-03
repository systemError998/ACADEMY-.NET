using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez05_Calcolatrice
{
    internal class Calcolatrice
    {
        //SINGLETON
        //Creo un'attributo privato che contiene la calcolatrice stessa
        private static Calcolatrice? instance;
        //Creo un metodo pubblico per accedere all'attributo privato
        public static Calcolatrice? GetInstance()
        { 
            if(instance == null)                // se l'istanza è nulla
                instance = new Calcolatrice();  // allora ne creo una
            return instance;                    // altrimenti, se già esiste, ritorno quella già esistennte
        }  
        //rendo il costruttore privato
        private Calcolatrice() { }


        public float Addizione(float a, float b)
        {
            return a + b;
        }
        public float Sottrazione(float a, float b)
        {
            return a - b;
        }
        public float Moltiplicazione(float a, float b)
        {
            return a * b;
        }
        public float Divisione(float a, float b)
        {
            return a / b;
        }
    }
}
