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
            string invitati = "";
            while (inserimentoAbilitato)
            {
                Console.WriteLine("Inserisci nome dell'invitato");
                string? nome = Console.ReadLine();

                Console.WriteLine("Inserisci cognome dell'invitato");
                string? cognome = Console.ReadLine();

                Console.WriteLine("Inserisci numero dell'invitato");
                string? numeroTel = Console.ReadLine();

                string? invitato = $"{nome}, {cognome}, {numeroTel}.  ";
                invitati += invitato;

                Console.WriteLine("Vuoi inserire un altro invitato? Se hai finito premi Q");
                string risposta = Console.ReadLine();

                if (risposta.Equals("Q"))
                {
                    Console.WriteLine(invitati);
                    inserimentoAbilitato = false;
                }
                else
                    Console.WriteLine($"{invitato}");

            }


        }
    }
}
