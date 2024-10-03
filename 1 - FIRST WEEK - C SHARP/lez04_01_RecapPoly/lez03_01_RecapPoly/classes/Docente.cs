using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_01_RecapPoly.classes
{
    internal class Docente : Persona
    {
        public string? Dipartimento { get; set; }
        public bool IsPresidente { get; set; }

        public Docente() { }
        public Docente(string varNome, string varCognome, string varCodFis, string varDipartimento, bool varPresidente)
        {
            Nome = varNome;
            Cognome = varCognome;
            CodFis = varCodFis;
            Dipartimento = varDipartimento;
            IsPresidente = varPresidente;
        }

        public override string ToString()
        {
            return $"[STUDENTE] Nome: {base.Nome} Cognome: {base.Cognome} \n CODICE FISCALE: {base.CodFis}, \n " +
                $"Dipartimento: {this.Dipartimento}, \n {(this.IsPresidente ? "E' il presidente del dipartimento" : "Non è il presidente del dipartimento")}";
        }

    }
}
