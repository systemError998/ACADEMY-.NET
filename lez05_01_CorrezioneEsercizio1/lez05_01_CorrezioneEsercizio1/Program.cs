using lez05_01_CorrezioneEsercizio1.classes;

namespace lez05_01_CorrezioneEsercizio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcolatrice cal = new Calcolatrice();
            double prova = cal.Addizione(5, 6);
            Console.WriteLine(prova);

            //CLASSE DI UTILITA': tipologia di classi che eseguono operazioni ma non immagazzinano dati 

        }
    }
}
