namespace lez02_02_ContenitoriSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------ARRAY-------------------------

            //Array ad istanziazione rapida 
            //Array di interi con 3 numeri. La sua dimensione non può essere modificata 
            //Un array statico ha bisogno di slot di ram sequenziali, per questo una volta allocato non può essere modificato.

            //int[] elenco = { 23, 43, 98 };
            //Console.WriteLine(elenco[0]);

            ////Modifica elemento di un array
            //elenco[2] = 666;

            //-------------------------------------------------

            // la parola chiave new serve per creare in memoria un'istanza di tot slot sequenziali
            //int[] elencoDue = new int[5];

            //elencoDue[0] = 24;
            //elencoDue[0] = 234;
            //elencoDue[0] = 2124;
            //elencoDue[0] = 232134;
            //elencoDue[0] = 274;

            //Console.WriteLine(elencoDue.Length);

            //int i = 0;
            //// int max = 5; //variabile "SCOLPITA"
            //// int max = elencoDue.Length; => lo inserisco direttamente nel while per evitare un'occupazione di memoria

            //while (i < elencoDue.Length) {
            //    Console.WriteLine(elencoDue[i]);
            //    i++;
            //}

            //-------------------------------------------------

            //string[] elencoAuto = { "BMW", "Maserati", "Lamborghini", "FIAT" };

            //int i = 0;
            //int contatore = 0;
            //while (i < elencoAuto.Length)
            //{ 
            //    if (elencoAuto[i].Equals("Lamborghini"))
            //        contatore++;

            //    i++;
            //}
            //Console.WriteLine(contatore);

            //------------------FOREACH-------------------------

            //string[] garage = { "BMW", "Maserati", "Lamborghini", "FIAT" };

            //Array.Sort(garage);

            //foreach (string auto in garage)
            //{
            //    Console.WriteLine(auto);   
            //}


            //--------------------------------------------------

            //Metodo SPLIT, per trasformare una stringa in array
            //string invitati = "Giovanni,Mario,Lucia,Edoardo";
            //string[] arrayInvitati = invitati.Split(",");

            //foreach (string persona in arrayInvitati)
            //{
            //    Console.WriteLine(persona);
            //}

            //---------------------FOR-------------------------

            //string[] garage = { "BMW", "Maserati", "Lamborghini", "FIAT" };
            //for (int i = 0; i < garage.Length; i++) {
            //    Console.WriteLine(garage[i]);
            //}

        }
    }
}
