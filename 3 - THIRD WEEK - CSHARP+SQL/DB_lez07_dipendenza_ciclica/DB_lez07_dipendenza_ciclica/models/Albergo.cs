using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez07_dipendenza_ciclica.models
{
    internal class Albergo
    {
        public string Nome { get; set; } = null!;
        public string Indirizzo { get; set; } = null!;
        public int Stelle { get; set; }
        public List<Camera>? Cameras { get; set; }


        //Metodo per aggiungere camera
        public void AggiungiCamera(Camera objCamera)
        {
            if (Cameras is null)
                Cameras = new List<Camera>(); // se la lista di camera non c'è crea la lista e poi aggiungi una camera 

            Cameras.Add(objCamera);
            Console.WriteLine("Camera aggiunta con successo");
        }

        public string StampaDettaglio()
        {
            return $"[ALBERGO] Nome: {Nome}, Indirizzo: {Indirizzo}, Stelle: {Stelle}";
        }

        public override string ToString() 
        {
            string camereString = "";
            if(Cameras is not null)
                foreach(Camera cam in Cameras)
                {
                    camereString += cam.StampaDettaglio();
                }

            return $"[ALBERGO] Nome: {Nome}, Indirizzo: {Indirizzo}, Stelle: {Stelle}, Numero di camere: {Cameras.Count()}, Camere: [{camereString}]";
        }
    }
}
