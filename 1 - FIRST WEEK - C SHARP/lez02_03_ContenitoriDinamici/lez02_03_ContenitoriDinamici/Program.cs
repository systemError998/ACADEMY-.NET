namespace lez02_03_ContenitoriDinamici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LISTE
            //List<string> lista = new List<string>();
            //lista.Add("Giovanni");
            //lista.Add("Valeria");
            //lista.Add("Mario");

            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista[i]);
            //}

            //----------------------------------------
            /* Creare un sistema di input che mi permetta di aggiungere invitati ad una 
             * lista, che abbia una funzione di stampa della lista e che mi permetta di 
             * interrompere il programma digitando Q
             */

            bool ins = true;
            //creo la lista di invitati fuori dal while altrimenti ad ogni ciclo viene distrutta e ri-inizializzata
            List<string> invitati = new List<string>();

            while (ins) {
                Console.WriteLine("Per inserire un invitato premi Y\n L per stampare la lista\n Q per uscire");
                string? risp = Console.ReadLine();
                if (risp is not null)
                    risp = risp.ToUpper();

                switch (risp)
                {
                    case "Y":
                        Console.WriteLine("Inserisci invitato");
                        string? invitato = Console.ReadLine();

                        if (invitato is not null && invitato != "") 
                            invitato = invitato.Trim().ToLower();
                        else Console.WriteLine("non puoi inserire un valore null");

                        if ( invitati.Contains(invitato))
                            Console.WriteLine("Invitato già........ invitato");
                        else { 
                            invitati.Add(invitato);
                            Console.WriteLine("Invitato inserito");
                        } 
                        break;
                    case "Q":
                        ins = !ins;
                        break;
                    case "L":
                        foreach (string inv in invitati)
                        {
                            Console.WriteLine(inv);
                        };
                        break;
                    default:
                        Console.WriteLine("input non valido");
                        break;
                }
            }

            






        }
    }
}
