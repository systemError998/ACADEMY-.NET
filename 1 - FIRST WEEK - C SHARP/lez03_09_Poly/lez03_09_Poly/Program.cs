using lez03_09_Poly.classes;

namespace lez03_09_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //La variabile è polimorfica (aut e mot in questo caso)
            Veicolo aut = new Automobile(); 
            Veicolo mot = new Moto();
            //aut e mot diventeranno oggetti di tipo Automobile e Moto
            //Durante l'esecuzione del codice effettuerà il binding 

            List<Veicolo> elencoVeicoli = new List<Veicolo>();

            Console.WriteLine("get type di aut" + aut.GetType);
            Console.WriteLine("typeof automobile" + typeof(Automobile));

            foreach (Veicolo vei in elencoVeicoli) {
                // vei.StampaDettaglio();
                if (vei.GetType() == typeof(Automobile)) {
                    Automobile au = (Automobile)vei; //Eseguo il cast di vei, da veicolo lo trasformo in automobile
                }

            }

            

        }
    }
}
