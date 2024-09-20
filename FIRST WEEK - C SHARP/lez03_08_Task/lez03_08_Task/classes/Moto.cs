using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_08_Task.classes
{
    internal class Moto : Veicolo
    {
        public bool HasSidecar { get; set; }
        public bool HasBauletto { get; set; }

        public virtual void StampaDettaglio()
        {
            Console.WriteLine($"[Moto] Modello: {Modello}, Colore: {Colore}, Cilindrata: {Cilindrata}, {Ruote} ruote , Targa: {Targa}" +
                $"{(HasSidecar ? "Ha il sidecar" : "Non ha il sidecar")},{(HasBauletto ? "Ha il bauletto" : "Non ha il bauletto")} ");
        }
    }
}
