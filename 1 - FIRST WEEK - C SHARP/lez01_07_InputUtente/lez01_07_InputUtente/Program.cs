namespace lez01_07_InputUtente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creare un programma che in input prenda nome, cognome ed età dell'utente 
            //e in output gli dica se è maggiorenne o minorenne 

            Console.Write("Inserisci il nome: ");
            string? nome = Console.ReadLine();

            Console.Write("Inserisci il cognome: ");
            string? cognome = Console.ReadLine();

            Console.Write("Inserisci l'età: ");
            // string? inputEta = Console.ReadLine();
            try
            {
                int eta = Convert.ToInt32(Console.ReadLine());
                string risultato = "";
                if (eta > 18)
                {
                    risultato = "maggiorenne";
                }
                else
                {
                    risultato = "minorenne";
                }

                Console.WriteLine($"Ciao {nome} {cognome}, sei {risultato}");
            }
            //POSSO GESTIRE TUTTE LE ECCEZIONI DEGLI ERRORI MA se voglio personalizzarle devo prima inserire le singole exception 
            // e inserire l'Exception come ultima , altrimenti il programma non vedrà mai le eccezioni singole 
            catch (FormatException fe)
            {
                Console.WriteLine("errore. formato non ammesso");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch (Exception ex) {
                Console.WriteLine("errore");
            }
            

        }
    }
}
