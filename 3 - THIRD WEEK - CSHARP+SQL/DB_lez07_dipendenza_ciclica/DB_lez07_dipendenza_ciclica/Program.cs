using DB_lez07_dipendenza_ciclica.models;

namespace DB_lez07_dipendenza_ciclica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Albergo gh = new Albergo()
            { Nome = "Grand Hotel", Indirizzo = "Via dalle palle", Stelle = 5 };

            Camera aur = new Camera("Aurora", 2, "camera molto karina", gh);
            Camera let = new Camera("Letizia", 4, "camera davvero karina", gh);

            gh.AggiungiCamera(aur);
            gh.AggiungiCamera(let);
            gh.AggiungiCamera(null); // non posso farlo perchè il set è privato

            // Console.WriteLine(aur.ToString());
            Console.WriteLine(gh);
        }
    }
}
