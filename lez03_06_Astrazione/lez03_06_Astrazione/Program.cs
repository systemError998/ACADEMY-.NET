using lez03_06_Astrazione.classes;

namespace lez03_06_Astrazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animale ani = new Animale(); //non posso crearlo perchè la classe Animal è *abstract*
            Gatto bu = new Gatto(); 
            Cane can = new Cane(); 
            Coccodrillo cocco = new Coccodrillo(); 
        }
    }
}
