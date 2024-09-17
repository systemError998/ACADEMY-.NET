using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez05_02_CorrezioneEsercizio2.classes
{
    internal class GestoreStudente
    {
        private List<Studente> ListaStudenti { get; set; } = new List<Studente>();

        /// <summary>
        /// Metodo di stampa degli studenti
        /// </summary>
        public void StampaStudenti() {
            foreach (Studente stu in ListaStudenti)
            {
                Console.WriteLine(stu);
            }
        }

        public void ModificaStudente(Studente vecchioStu, Studente nuovoStu)
        {
            foreach (Studente stu in ListaStudenti)
            {
                if (vecchioStu.Nome is not null && 
                    vecchioStu.Nome.Equals(stu.Nome) && 
                    vecchioStu.Cognome is not null && 
                    vecchioStu.Cognome.Equals(stu.Cognome)) { 
                        stu.Nome = nuovoStu.Nome;
                        stu.Cognome = nuovoStu.Cognome;
                        stu.Voto = nuovoStu.Voto;                 
                }
            } 
        }

        public void FiltroVoti(double minDi, double magDi) {
            List<Studente> listaTemporanea = new List<Studente>();
            foreach (Studente stu in ListaStudenti) {
                if (stu.Voto >= magDi && stu.Voto <= minDi) { 
                    listaTemporanea.Add(stu);
                }
            }
            foreach (Studente tmpStu in listaTemporanea) {
                Console.WriteLine(tmpStu);
            }
        }

    }
}
