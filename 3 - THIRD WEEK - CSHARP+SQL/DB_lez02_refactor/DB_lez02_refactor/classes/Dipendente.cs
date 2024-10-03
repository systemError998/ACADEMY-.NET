using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez02_refactor.classes
{
    internal class Dipendente
    {
        public int Id { get; set; }
        public string Identificativo { get; set; } = null!; //inizialmente è null ma dopo essere stata valorizzata non può tornare ad essere null
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public string? Dipartimento { get; set; }
        public int Salario { get; set; }

        public override string ToString()
        {
            return $"[DIPENDENTE]: {Id} {Identificativo} {Nome} {Cognome} {Dipartimento} {Salario}";
        }
    }
}
