using DB_lez04_libreria.classes;

namespace DB_lez04_libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cicloInfinito = true;
            while (cicloInfinito) 
            {
                Console.WriteLine("Digita il comando per scegliere l'operazione\n" +
                    "I - Inserimento \n S - Stampa \n Q - Esci" );
                string? inputUtente = Console.ReadLine();

                switch (inputUtente)
                {
                    case "I":
                        Console.WriteLine("Inserisci il titolo");
                        string? inputTitolo = Console.ReadLine();
                        Console.WriteLine("Inserisci l'autore");
                        string? inputAutore = Console.ReadLine();
                        Console.WriteLine("Inserisci le pagine");
                        int inputPagine = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserisci l'editore");
                        string? inputEditore = Console.ReadLine();
                        Console.WriteLine("Inserisci l'ISBN");
                        string? inputIsbn = Console.ReadLine();

                        Libro lib = new Libro()
                        {
                            Titolo = inputTitolo is not null ? inputTitolo : "N.D.",
                            Autore = inputAutore is not null ? inputAutore : "N.D.",
                            Pagine = inputPagine,
                            Editor = inputEditore is not null ? inputEditore : "N.D.",
                            Isbn = inputIsbn is not null ? inputIsbn : "N.D."
                        };
                        break;
                    case "S":
                        break;
                    case "Q":
                        cicloInfinito = false;
                        break;
                    default:
                        Console.WriteLine("Non conosco questo comando");
                        break;
                }

            }
        }
    }
}
