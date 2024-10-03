using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_01_RecapClassi.Classes
{
    internal class Bottiglia
    {
        //INCAPSULAMENTO 
        
        private string? materiale;
        private string? colore;
        private float diametro = 0; //VALORE DI DEFAULT
        private float altezza;
        private string? contenuto;

        //INFORMATION HIDING: gli attributi di una classe non dovrebbero essere visibili all'esterno,
        //per evitare che qualcuno utilizzi in maniera "sbagliata" il nostro programma.
        //MODIFICATORI DI ACCESSO
        //public => attributi visibili all'esterno
        //private => attributi non visibili 
        //Creo dei metodi pubblici che mi permettano di modificare gli attributi privati

        //Con il SETTER valorizzo (modifico) 
        public void SetAltezza(float varAltezza) 
        {
            if (varAltezza > 0)
                this.altezza = varAltezza;
            //con THIS valorizzo l'attributo dell'oggetto a cui mi riferisco
        }

        //Con il GETTER leggo il valore
        public float GetAltezza()
        {
            return this.altezza;
        }

        //------------------------------------------------

        //Con il SETTER valorizzo (modifico) 
        public void SetDiametro(float varDiametro)
        {
            if (varDiametro > 0)
                this.diametro = varDiametro;
            //con THIS valorizzo l'attributo dell'oggetto a cui mi riferisco
        }

        //Con il GETTER leggo il valore
        public float GetDiametro()
        {
            return this.diametro;
        }

        //-----------------------------------------------

        private float CalcolaVolume()
        {
            float raggio = diametro / 2;
            float area = (float)Math.PI * (raggio * raggio);
            return area * altezza;
        }

        public void DettaglioGeometria()
        {
            Console.WriteLine($"La bottiglia ha questi dati: \n" +
                $"altezza: {altezza},\n diamentro: {diametro}\n" +
                $"volume: {CalcolaVolume()}");
        }

    }
}
