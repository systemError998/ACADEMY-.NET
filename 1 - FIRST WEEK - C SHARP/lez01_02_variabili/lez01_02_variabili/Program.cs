namespace lez01_02_variabili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int eta = 37;
            //Console.WriteLine(eta); //questo eta è un puntatore che punta alla variabile dichiarata eta che punta a sua volta alla cella di memoria con il valore contenuto

            //int eta_due;  // questa dichiarazione "prenota" una cella di memoria da occupare
            //eta_due = 26; // assegnazione

            //--------------------------------------------

            //string nome = "Giovanni"; //una stringa è una sequenza di caratteri
            //Console.WriteLine(nome);
            //string cognome;
            //cognome = "Pace";
            //Console.WriteLine(nome + " " + cognome);

            //string? secondo_nome = null; //una variabile null ha un puntatore che non punta a nulla, ergo, non occupa spazio in memoria
            //// ? nullable operator => la variabile può essere stringa o essere null

            //secondo_nome = "Giovanni";

            //--------------------------------------------

            //OPERAZIONI
            // Console.WriteLine(2+5);  //le parentesi stabiliscono una priorità di esecuzione (prima viene eseguita la somma poi il writeLine)
            // questo tipo di operazioni vengono definite di RUNTIME , ovvero che non usano memoria RAM

            // OPERATORI =>  + - x / % < > = != etc sono le uniche operazioni che può eseguire il processore.

            // Console.WriteLine( 6 == 5);   //out: false
            // Console.WriteLine();

            //--------------------------------------------
            //CONTROLLO 
            /* if(condizione) {
             * codice in caso la condizione sia true }
             * else { codice in caso la condizione sia false }
             */
            //if (true)
            //{
            //    Console.WriteLine("Sono nel ramo positivo");
            //}
            //else
            //{
            //    Console.WriteLine("Sono nel ramo negativo");
            //}


            //--------------------------------------------
            // int eta = -90;

            // FALSE && TRUE = FALSE
            // 0     &&    1 = FALSE

            //TRUE && FALSE = FALSE
            //TRUE && TRUE = TRUE

            //if (eta >= 0 && eta < 120) 
            //{
            //    if (eta >= 18)
            //    {
            //        Console.WriteLine("MAGGIORENNE");
            //    }
            //    else {
            //        Console.WriteLine("MINORENNE");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("error, età non valida");
            //}

            //--------------------------------------------

            //bool isProgrammatore = false;
            //Console.WriteLine(!isProgrammatore);

        }
    }
}
