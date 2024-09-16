using lez04_03_Statici.classes;

namespace lez04_03_Statici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studente stu = new Studente();
            Console.WriteLine(Studente.getContatore);
            Console.WriteLine(stu.getContatore);
        }
    }
}
