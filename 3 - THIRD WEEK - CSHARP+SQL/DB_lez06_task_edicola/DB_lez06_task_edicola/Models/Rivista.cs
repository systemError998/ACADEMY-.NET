using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models
{
    internal class Rivista
    {
        public int Id { get; set; }
        public int Codice { get; set; }
        public string Titolo { get; set; } = null!;
        public string CasaEditrice { get; set; } = null!;
        public double Prezzo { get; set; }


    }
}
