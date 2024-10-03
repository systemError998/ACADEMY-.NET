namespace lez01_09_CicliSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* while(condizione) {
             * operazione da iterare 
             * }
             */

            //int indice = 0;
            //int max = 5;

            //while (indice < max) {
            //    Console.WriteLine($"Sono al numero {indice}");
            //    indice++;
            //}

            //---------------------------------------------------
            // CICLO DO WHILE

            //int i = 0;
            //int max = 3;

            //do
            //{
            //    Console.WriteLine($"Ciao, sono al numero {i}");
            //}
            //while (i<max);

            //---------------------------------------------------
            //GESTIRE CICLI INFINITI

            //bool inserimentoAbilitato = true;
            //while (inserimentoAbilitato)
            //{
            //    Console.WriteLine("Chi vuoi salutare? Digita Q per uscire");
            //    string? inputUtente = Console.ReadLine();

            //    if (inputUtente is not null && inputUtente.Equals("Q"))
            //        inserimentoAbilitato=false;
            //    else
            //    Console.WriteLine($"Ciao {inputUtente}");

            //}

            //---------------------------------------------------
            //ESERCIZIO 

            //Scrivere un sistema di gestione invitati alla propria festa
            //l'inserimento avviene tramite console e prende in input, in tre tempi diversi
            // il nome, il cognome ed il numero di telefono
            //All'uscita del programma verrà stampato l'elenco delle persone precedentemente inserito separato da virgola.
            //TIP: crea una stringa all'inizio del programma che ti potrà essere utile per aggiungere gli invitati


            //rendo il ciclo infinito con la condizione true
            bool inserimentoAbilitato = true;

            //creo la stringa fuori dal while altrimenti al suo interno, ad ogni ciclo, verrebbe distrutta e sovrascritta 
            string invitati = "";
            while (inserimentoAbilitato)
            {

                Console.WriteLine("Vuoi inserire un invitato? Se sì, premi Y, se hai finito premi Q");
                string risposta = Console.ReadLine();
                if (risposta is not null)
                    risposta = risposta.ToUpper();

                //SOLUZIONE PROF
                switch (risposta) 
                {
                    case "Y":
                        //todo: 
                        Console.Write("Inserisci nome dell'invitato");
                        //string? il ? indica che la variabile può essere nullable
                        string? nome = Console.ReadLine();

                        Console.Write("Inserisci cognome dell'invitato");
                        string? cognome = Console.ReadLine();

                        Console.Write("Inserisci numero dell'invitato");
                        string? numeroTel = Console.ReadLine();

                        // string? invitato = $"{nome}, {cognome}, {numeroTel}.  ";
                        invitati += $"{nome} {cognome} {numeroTel}.  ";
                        Console.WriteLine("Invitato inserito con successo.");

                        break;
                    case "Q":
                        Console.WriteLine(invitati);
                        // interrompo il ciclo infinito rendendo la condizionen falsa
                        inserimentoAbilitato = !inserimentoAbilitato;
                        break;

                    default:
                        Console.WriteLine("Comando non riconosciuto");
                        break;

                }

                // SOLUZIONE INDIVIDUALE 

                //Console.Write("Inserisci nome dell'invitato");
                ////string? il ? indica che la variabile può essere nullable
                //string? nome = Console.ReadLine();

                //Console.Write("Inserisci cognome dell'invitato");
                //string? cognome = Console.ReadLine();

                //Console.Write("Inserisci numero dell'invitato");
                //string? numeroTel = Console.ReadLine();

                //string? invitato = $"{nome}, {cognome}, {numeroTel}.  ";
                //invitati += invitato;



                //if (risposta.Equals("Q"))
                //{
                //    Console.WriteLine(invitati);
                //    // interrompo il ciclo infinito rendendo la condizionen falsa
                //    inserimentoAbilitato = !inserimentoAbilitato;
                //}
                //else {
                //    Console.WriteLine(invitati);
                //    // interrompo il ciclo infinito rendendo la condizionen falsa
                //    inserimentoAbilitato = !inserimentoAbilitato;
                //}
                    

            }


        }
    }
}
