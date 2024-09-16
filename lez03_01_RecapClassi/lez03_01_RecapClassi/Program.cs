using lez03_01_RecapClassi.Classes;
using System.Security.Cryptography.X509Certificates;

namespace lez03_01_RecapClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se la classe è all'interno di una cartella *OCCHIO* all'importazione corretta con using 
            Bottiglia acqua = new Bottiglia();
            acqua.SetAltezza(15.8f);

            Console.WriteLine(acqua.GetAltezza());
            acqua.DettaglioGeometria();

        }
    }
}
