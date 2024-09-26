using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models
{
    internal class Giocattolo
    {
        public int Id { get; set; }
        public int Codice { get; set; }
        public string Nome { get; set; } = null!;
        public string Materiale { get; set; } = null!;
        public int EtaMinima { get; set; }
        public double Prezzo { get; set; }


    }
}
