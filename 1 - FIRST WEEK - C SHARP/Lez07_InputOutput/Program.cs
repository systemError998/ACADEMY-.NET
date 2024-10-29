using System.Runtime.InteropServices.Marshalling;

namespace Lez07_InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\prova.txt";
            string contenuto = "Ciao sono Anna";

            try
            {
                using (StreamWriter sw = new StreamWriter(path)) { 
                    sw.WriteLine(contenuto);
                    sw.WriteLine("hola hola");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
