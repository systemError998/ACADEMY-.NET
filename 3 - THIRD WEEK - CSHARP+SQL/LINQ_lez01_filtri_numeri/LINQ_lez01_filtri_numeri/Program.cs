namespace LINQ_lez01_filtri_numeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> elenco = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11};

            //tipo non specifico di variabile, al suo interno posso metterci tutto
            var risultato = from numero in elenco
                            where numero > 5
                            orderby numero
                            select numero;
            foreach (var num in risultato)
            {
                Console.WriteLine(num);
            }
        }
    }
}
