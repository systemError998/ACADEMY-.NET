using lez03_08_Task.classes;

namespace lez03_08_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creare un sistema di gestione veicoli:
            //All'inserimento di un nuovo veicolo sarà concessa la scelta tra:
            // 1. Automobile
            // 2. Moto
            // Alla fine dell'inserimento delle caratteristiche del veicolo , stampare i dettagli.
            // Libera scelta degli attributi 

            bool cicloInfinito = true;
            while (cicloInfinito) {
                Console.WriteLine("Vuoi inserire un veicolo? \n Premi A per inserire un'auto, M per inserire una moto, Q per uscire");
                string? risp = Console.ReadLine();

                switch (risp)
                {
                    case "A":
                        try
                        {
                            Console.WriteLine("Modello");
                            string? varModello = Console.ReadLine();
                            Console.WriteLine("Colore");
                            string? varColore = Console.ReadLine();
                            Console.WriteLine("Cilindrata");
                            int? varCilindrata = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ruote");
                            int? varRuote = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Targa");
                            string? varTarga = Console.ReadLine();
                            Console.WriteLine("Porte");
                            int? varPorte = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Posti");
                            int? varPosti = Convert.ToInt32(Console.ReadLine());

                            Automobile auto = new Automobile()
                            {
                                Modello = varModello,
                                Colore = varColore,
                                Cilindrata = varCilindrata,
                                Ruote = varRuote,
                                Targa = varTarga,
                                Porte = varPorte,
                                Posti = varPosti
                            };

                            auto.StampaDettaglio();
                        }
                        catch (Exception ex) {
                            Console.WriteLine("ERRORE, IMPOSSIBILE CREARE AUTO");
                        }
                        break;
                    case "M":
                        try
                        {
                            Console.WriteLine("Modello");
                            string? varModelloMoto = Console.ReadLine();
                            Console.WriteLine("Colore");
                            string? varColoreMoto = Console.ReadLine();
                            Console.WriteLine("Cilindrata");
                            int? varCilindrataMoto = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ruote");
                            int? varRuoteMoto = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Targa");
                            string? varTargaMoto = Console.ReadLine();

                            Console.WriteLine("Ha il sidecar? Y/N");
                            //leggo la stringa Y o N
                            string? hasSidecarVar =Console.ReadLine();
                            //di default gli dico che è false
                            bool sidecarBool = false;
                            // se la risposta è uguale alla stringa Y cioè SI
                            if (hasSidecarVar is not null && hasSidecarVar.Equals("Y"))
                            {   
                                //senza bool altrimenti la sto ridichiarando mannaggia ai sacerdoti
                                sidecarBool = true;
                            }

                            Console.WriteLine("Ha il bauletto? Y/N");
                            //leggo la stringa Y o N
                            string? hasBaulettoVar = Console.ReadLine();
                            //di default gli dico che è false
                            bool baulettoBool = false;
                            // se la risposta è uguale alla stringa Y cioè SI
                            // ergo devo controllare se LA STRINGA non è null ed è uguale a Y
                            // ovviamente la stringa che prendo in input 
                            if (hasBaulettoVar is not null && hasBaulettoVar.Equals("Y"))
                            {
                                //senza bool altrimenti la sto ridichiarando mannaggia ai sacerdoti
                                baulettoBool = true;
                            }

                            Moto moto = new Moto() { 
                                Modello = varModelloMoto,
                                Colore = varColoreMoto,
                                Cilindrata = varCilindrataMoto,
                                Ruote = varRuoteMoto,
                                Targa = varTargaMoto,
                                HasSidecar = sidecarBool,
                                HasBauletto = baulettoBool
                            };

                            moto.StampaDettaglio();

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("ERRORE, IMPOSSIBILE CREARE MOTO");
                            throw;
                        }
                        break;
                    case "Q":
                        cicloInfinito = false;
                        break;
                    default:
                        Console.WriteLine("COMANDO ERRATO, RIPROVA");
                        break;
                }
            }


        }
    }
}
