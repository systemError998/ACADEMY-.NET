namespace lez01_04_Stringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nominativo = null!; // => null solo nella fase iniziale e non sta occupando memoria 
                                       // null! mi permette di "tenere occupata" la memoria per questa var e non permette di allocarci nulla
                                       // la cella di memoria di questa variabile, dopo essere inizializzata, non può essere riallocata

            // string? nominativo = null; // con il nullable la cella di memoria può essere riallocata
            //Console.WriteLine(nominativo);
            //nominativo = "Anna";
            //Console.WriteLine(nominativo);

            //--------------------------------------------------------------

            //int a = 5;
            //int b = 5;
            //Console.WriteLine("La somma dei numeri è " + a + b);
            //// out: la somma dei numeri è 510 
            //// i numeri vengono concatenati alla stringa per via dell'ordine di esecuzione 
            //// se inserisco delle parentesi, prioritizzo la somma: 
            //Console.WriteLine("La somma dei numeri è " + (a + b));
            //Console.WriteLine(a+b+"è la somma dei due numeri"); //out: 15
            ////esce 15 perchè la somma dei numeri è la prima istruzione eseguita

            //--------------------------------------------------------------

            /* Scrivere un programma che mandi in output le seguenti due stringhe:
            *Giovanni Pace è 37 anni vecchio ed ha una temperatura corporea di 36.2°
             * Mario Rossi è 37 anni vecchio ed ha una temperatura corporea di 37.3°
             */

            //string nome = "Giovanni Pace";
            //int eta = 37;
            //float temp = 36.2f;

            //Console.WriteLine($"{nominativo} è {eta} + anni vecchio ed ha una temperatura corporea di {temp} °");

            //nominativo = "Mario Rossi";
            //eta = 35;
            //temp = 37.3f; 
            //Console.WriteLine($"{nominativo} è {eta} + anni vecchio ed ha una temperatura corporea di {temp} °");
            ////ogni volta che utilizziamo le {} creiamo un contesto, quindi è come un sottoprogramma
            ////all'interno del nostro programma

            //--------------------------------------------------------------

            //string nome2 = "Giovanni Pace";
            //Console.WriteLine($"La lunghezza del nome {nome2} è: {nominativo.Length}");
            ////questo approccio è in runtime, non alloca memoria e esegue l'output e ce lo mostra a video
            ////con l'hover sulla proprietà length posso vedere il dato che mi restitusice
            //int lunghezza = nominativo.Length;
            //Console.WriteLine($"La lunghezza del nome {nome2} è: {lunghezza}");
            //// questo approccio occupa spazio in memoria con la var lunghezza

            //--------------------------------------------------------------

            string? frase = "Mi piace tanto \"programmare\"";
            Console.WriteLine(frase);

            char carattere = 'A';
            //posso utilizzare le virgolette singole SOLO con questo tipo di var

            //--------------------------------------------------------------

            if (frase.IndexOf("programma") >= 0) {
                Console.WriteLine("Trovato");
            } else { Console.WriteLine("Non trovato"); }
        }
    }
}
