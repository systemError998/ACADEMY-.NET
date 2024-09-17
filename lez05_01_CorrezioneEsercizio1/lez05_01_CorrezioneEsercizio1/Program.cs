using lez05_01_CorrezioneEsercizio1.classes;

namespace lez05_01_CorrezioneEsercizio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NON PERMESSO PERCHE' IL COSTRUTTORE E' PRIVATO 
            //Calcolatrice cal = new Calcolatrice();

            double prova = Calcolatrice.Addizione(5, 6);
            Console.WriteLine(prova);

            double? divi = Calcolatrice.Divisione(5, 0);

            //CLASSE DI UTILITA': tipologia di classi che eseguono operazioni ma non immagazzinano dati 

        }
    }
}
