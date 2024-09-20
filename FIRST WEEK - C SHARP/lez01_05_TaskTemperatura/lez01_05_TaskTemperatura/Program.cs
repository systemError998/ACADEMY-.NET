namespace lez01_05_TaskTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di controllo accessi al ristorante, in input (sotto forma di variabile) ci sarà la temperatura.
             * Se la temperatura è maggiore o uguale a 37.5° non permettere l'accesso al ristorante.
             */


            //float temp = 25;

            //if (temp > 34 && temp < 42)
            //{
            //    if (temp <= 37.5)
            //    {
            //        Console.WriteLine("puoi entrare");
            //    }
            //    else {
            //        Console.WriteLine("non puoi entrare");
            //    }
            //}
            //else {
            //    Console.WriteLine("errore");
            //}

            //--------------------------------------------------

            //Console.WriteLine("Inserisci il tuo nome");
            //string? inputUtente = Console.ReadLine();
            //Console.WriteLine($"Benvenuto {inputUtente}");

            //--------------------------------------------------

            //Console.WriteLine("Inserisci la temperatura");
            //string inputUtente = Console.ReadLine();
            //double temp = Convert.ToDouble(inputUtente);


        //    if (temp > 34 && temp < 42)
        //    {
        //        if (temp <= 37.5)
        //    {
        //        Console.WriteLine("puoi entrare");
        //    }
        //    else
        //    {
        //        Console.WriteLine("non puoi entrare");
        //    }
        //}
        //    else
        //    {
        //        Console.WriteLine("errore");
        //    }

    //--------------------------------------------------

    Console.WriteLine("Inserisci la temperatura");
            string inputUtente = Console.ReadLine();
            

            try
            {
                double temp = Convert.ToDouble(inputUtente);
                if (temp > 34 && temp < 42)
                {
                    if (temp <= 37.5)
                    {
                        Console.WriteLine("puoi entrare");
                    }
                    else
                    {
                        Console.WriteLine("non puoi entrare");
                    }
                }
                else
                {
                    Console.WriteLine("errore");
                } 
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
