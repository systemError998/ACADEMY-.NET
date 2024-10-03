using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_07_Intefacce.classes
{
    internal class Gatto : IAnimale 
        //La classe gatto deve sottostare a tutto quello che c'è nell'interfaccia
    {
        public bool HasPelo { get; set; }
        public string? Colore { get; set; }
        public string? NumZampe { get; set; }

        public void TipoMovimento()
        {
            Console.WriteLine("Cammina");
        }

        public void VersoEmesso()
        {
            Console.WriteLine("miao");
        }

        //Grazie alle interfacce io posso obbligare lo sviluppatore a inserire dei metodi obbligatori in tutte le sottoclassi 

    }
}
