namespace lez01_03_Variabili2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int eta; //int è un dominio primitivo, ovvero un tipo che c# può utilizzare utilizzando solo la bcl senza dover includere altre librerie
            // Console.WriteLine(eta); //le variabili non possono essere usate se non assegnate

            //int numero_intero = 2147483647;
            //float numero_float = 15.7f;
            //double numero_double = 85.7d;
            //Console.WriteLine(numero_double);

            //double prova = numero_float; //riversiamo il valore di numero_float all'interno di prova
            //// questa operazione può essere eseguita solo su DATATYPES PRIMITIVI

            //Console.WriteLine(prova);
            // out: 15,699999809265137 => arrotonda affinchè il numero sia double e quindi 8 byte (float è di 4 byte)

            //----------------------------------------

            //int valore1 = 8;                        //1 operazione
            //int valore2 = 5;                        //1 operazione
            //Console.WriteLine(valore1+ valore2);    //1 operazione
            //Console.WriteLine(valore1+ valore2);    //1 operazione
            //Console.WriteLine(valore1+ valore2);    //1 operazione
            //Console.WriteLine(valore1+ valore2);    //1 operazione = 6 operazioni della cpu MA 2 celle di memoria ram

            //int valore3 = 4;                        //1 operazione
            //int valore4 = 5;                        //1 operazione
            //int somma = valore3 + valore4;          //2 operazioni = 4 operazioni della cpu MA 3 celle di memoria ram
            //Console.WriteLine(somma);

            //----------------------------------------

            Console.WriteLine(15 + 12.8f + 100.5d); // out:  128,29999923706055 double [999923706055 si chiama Rumore]

            //int numero = 15;
            //numero = numero + 1;
            //numero = numero + 3;
            //Console.WriteLine(numero);  //incremento e SOVRASCRITTURA

            ////oppure la modalità compatta di incremento: 
            //int numero2 = 15;
            //numero2 += 1;
            //numero2 += 3;
            //Console.WriteLine(numero2);

            //----------------------------------------

            //int valoreUno = 15;
            //float valoreDue = 2.3f;
            //float rapporto = valoreUno / valoreDue; // out: 6,5217395 
            //Console.WriteLine(rapporto);

            //int risultato = (int)rapporto; //conversione 


        }
    }
}
