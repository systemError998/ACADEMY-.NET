using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_06_Astrazione.classes
{
    //con abstract impedisco la creazione (new Animale()) della classe animale
    internal abstract class Animale
    {
        public bool hasPelo { get; set; }
        public int NumZampe { get; set; }
        public bool Vola { get; set; }
        //Possiamo creare dei METODI ASTRATTI, ma SOLO all'interno di una classe astratta

        public abstract void VersoEmesso();
    }
}
