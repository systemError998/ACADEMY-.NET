using System.Collections;
using System.Globalization;

namespace lez06_02_Hashtable_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // HASHTABLE => ARRAY ASSOCIATIVO
            Hashtable hashtable = new Hashtable();

            //Un hashtable è composta da una coppia di chiave-valore
            // è un contenitore non omogeneo perchè al suo interno posso inserire qualunque tipo di dato
            hashtable.Add(0, "Giovanni");
            hashtable.Add("pippo", "pluto");
            hashtable.Add("lista", new List<string>() { "maserati", "lamborghini" });
            //non hanno ordinamento 

            if (hashtable.ContainsKey("pippo")) {
                Console.WriteLine(hashtable["pippo"]);
            }

            //DictionaryEntry è un contenitore in grado di contenere coppie chiave-valore
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Value); //stampa solo i valori 
                Console.WriteLine(item.Key);   // stampa solo le chiavi
            }

           



            //DICTIONARY
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(0, "Giovanni");

            foreach(KeyValuePair<int, string> o in dictionary) {
                Console.WriteLine(o.Value);
            }


            //HASHTABLE INCEPTION
            Hashtable hashtable2 = new Hashtable();
          
            Hashtable gatto = new Hashtable();
            gatto.Add("razza", "testa di gatto");
            gatto.Add("nome", "gattomatto");

            hashtable2.Add("animale", gatto);

            foreach (DictionaryEntry item in hashtable2) { 
                 
            }

        }
    }
}
