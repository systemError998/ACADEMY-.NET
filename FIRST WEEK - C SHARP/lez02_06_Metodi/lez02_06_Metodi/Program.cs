namespace lez02_06_Metodi
{
    internal class Program
    {
        //Un metodo è una serie di istruzioni che può essere invocata tutte le volte in cui ne abbiamo bisogno
        static void SalutaGiovanni()
        {
            Console.WriteLine("Ciao sono Giovanni");
            Console.WriteLine("Prof di informatica");
            Console.WriteLine("ciaociccio");
        }

        static void SalutaPersona(string varNominativo)
        {
            Console.WriteLine($"Ciao {varNominativo}");
        }
        static void Main(string[] args)
        {
            SalutaGiovanni();
            SalutaGiovanni();
            SalutaGiovanni();
            SalutaPersona("Anna");
        }

        //VOID E' IL TIPO DI RITORNO, ovvero nulla
        static int Somma(int varA, int varB) {
            int somma = varA + varB;
            return somma;
        }

        //COME QUI INT E' IL TIPO DI RITORNO DELLA SOMMA DI DUE INTERI
        //Quindi quando definiamo un tipo di ritorna bisogna SEMPRE specificare il return
    }
}
