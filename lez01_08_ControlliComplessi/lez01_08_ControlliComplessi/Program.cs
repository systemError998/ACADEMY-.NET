namespace lez01_08_ControlliComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dato in input una sigla per la provincia, voglio sapere il nome per esteso

            string provincia = "BO";

            //if (provincia.Equals("AQ"))
            //    Console.WriteLine("L'aquila");
            //else if (provincia.Equals("RM"))
            //    Console.WriteLine("Roma");
            //else if (provincia.Equals("BO"))
            //    Console.WriteLine("Bologna");
            //else Console.WriteLine("errore");

            //--------------------------------------------------

            switch (provincia)
            {
                case "AQ": 
                    Console.WriteLine("L'aquila"); 
                    break;
                case "RM": 
                    Console.WriteLine("Roma"); 
                    break;
                case "BO": 
                    Console.WriteLine("Bologna"); 
                    break; 
                default: 
                    Console.WriteLine("Provincia non trovata"); 
                    break;
            }

            //--------------------------------------------------

        }
    }
}
