using lez03_02_Properties.classes;

namespace lez03_02_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bottiglia acqua = new Bottiglia();
            acqua.Materiale = "PET";
            Console.WriteLine(acqua.Materiale);

            acqua.Marca = "Santa Lucia";
            acqua.Altezza = 10.1f;
            
        }
    }
}
