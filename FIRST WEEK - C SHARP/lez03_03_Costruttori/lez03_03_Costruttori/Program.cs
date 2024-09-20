using lez03_03_Costruttori.classes;

namespace lez03_03_Costruttori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile focus = new Automobile(); //le parentesi invocano il metodo costruttore
            focus.Marca = "FORD";
            focus.Cilindrata = 1300;
            focus.Colore = "Rosso";

            Automobile ypsilon = new Automobile("Lancia",1200,"Giallo");
            ypsilon.StampaDettaglio();
            Console.WriteLine(ypsilon.ToString());
        }
    }
}
