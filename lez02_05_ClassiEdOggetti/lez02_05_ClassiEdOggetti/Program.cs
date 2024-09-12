using lez02_05_ClassiEdOggetti.Classes;

namespace lez02_05_ClassiEdOggetti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quando creo una classe, creo un nuovo "tipo" [proprio come i tipi primitivi int, string etc]
            //Tipo: oggetto

            //new è il processo grazie al quale posso creare un'istanza di una classe
            Automobile ford = new Automobile();
            //l'operatore punto è un operatore di scoping, serve per accedere ad attributi e metodi all'interno di una classe
            ford.modello = "Focus";
            ford.colore = "Blu";
            ford.cilindrata = 2000;

            Automobile fiat = new Automobile();
            fiat.modello = "Panda";
            fiat.colore = "Nera";
            fiat.cilindrata = 1200;

            Automobile ferrari = new Automobile();
            fiat.modello = "Modena";
            fiat.colore = "rossa";
            fiat.cilindrata = 3000;

            
        }
    }
}
