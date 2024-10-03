using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez05_03_Utilizzo.classes
{
    internal class Ordine
    {
        //ESSENDO UNA COMPOSIZIONE, LA LISTA INIZIALMENTE E' NULLABLE (?)
        public List<Oggetto>? ElencoProdotti { get; set; }
        public string? Codice { get; set; }
        public Indirizzo Spedizione { get; set; }
        public Indirizzo Fatturazione   { get; set; }

        public void AggiungiOggetto(Oggetto ogg)
        { 
            if(ElencoProdotti is null)
                ElencoProdotti = new List<Oggetto>();
            ElencoProdotti.Add(ogg);
        }

        public override string ToString()
        {
            return $"{Codice} {Spedizione} {Fatturazione}";
        }

    }
}
