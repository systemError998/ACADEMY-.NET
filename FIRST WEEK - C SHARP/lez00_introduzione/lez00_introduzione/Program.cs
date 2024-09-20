namespace lez00_introduzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single line comment
/* Multi line 
 * comment */
#if debug
            Console.WriteLine("Sono in modalità debug");
#elif RELEASE
            Console.WriteLine("Sono in modalità Release");
#endif
        }
    }
}
