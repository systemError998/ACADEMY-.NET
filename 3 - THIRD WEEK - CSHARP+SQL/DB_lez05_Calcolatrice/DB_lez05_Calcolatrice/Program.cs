namespace DB_lez05_Calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calcolatrice.GetInstance()); //Creo un'istanza di calcolatrice
            Console.WriteLine(Calcolatrice.GetInstance().Sottrazione(10,5)); //Accedo ai suoi metodi
            Console.WriteLine(Calcolatrice.GetInstance().Divisione(10,2)); //Accedo ai suoi metodi
        }
    }
}

