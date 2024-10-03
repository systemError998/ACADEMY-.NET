using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez07_dipendenza_ciclica.models
{
    internal class Camera
    {
        public string codice { get; set; } = null!;
        public int posti { get; set; } 
        public string descrizione { get; set; } = null!;
        public Albergo? AlbApparten { get; private set; } // rendo privato il set in maniera tale che dall'esterno non sia possibile scrivere stronzate

        //Per obbligare l'utente a creare il riferimento all'albergo
        //creiamo il costruttore con tutti i parametri obbligatori,
        // tra cui appunto l'albergo

        public Camera(string cod, int pos, string des, Albergo albApp)
        {
            codice = cod;
            posti = pos;
            descrizione = des;
            AlbApparten = albApp;
        }

        public string StampaDettaglio() {
            return $"[CAMERA] Codice: {codice}, posti: {posti}, descrizione: {descrizione}";
        }

        public override string ToString()
        {
            string albergo = AlbApparten is not null ? AlbApparten.ToString() : "";

            return $"[CAMERA] Codice: {codice}, posti: {posti}, descrizione: {descrizione}, Albergo: {albergo}";
        }
    }
}
