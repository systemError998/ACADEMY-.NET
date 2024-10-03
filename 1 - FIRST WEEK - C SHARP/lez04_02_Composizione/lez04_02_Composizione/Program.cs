using lez04_02_Composizione.classes;

namespace lez04_02_Composizione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fiore rosa = new Fiore();
            Fiore tuli = new Fiore();  
            Fiore cale = new Fiore();   


            Mazzo ma = new Mazzo();
            ma.AggiungiFiore(rosa);
        }
    }
}
