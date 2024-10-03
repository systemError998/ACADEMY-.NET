using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez06_02_protected.Models
{
    internal class Studente : Persona
    {
        public string Matricola { get; set; }

        public Studente(string varNome, string varCognome, string matricola)
        {
            base.Nome = varNome;
            base.Cognome = varCognome;
            Matricola = matricola;
            base.Titolo = "Stud. ";
        }
    }
}
