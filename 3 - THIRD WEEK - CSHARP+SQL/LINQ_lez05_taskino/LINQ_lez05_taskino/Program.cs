using LINQ_lez05_taskino.Models;
using System.Collections.Generic;

namespace LINQ_lez05_taskino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Creare una lista di prodotti caratterizzati da:
                - Nome
                - Descrizione
                - Prezzo
                - Categoria
                - Quantità
 
                Inserire un numero n di prodotti:
                - Mandare in output tutti i prodotti di una certa categoria
                - Calcolare il prezzo medio dei prodotti
                - Riepilogare le quantità numeriche per categoria di prodotto
                - Creare un report del valore del negozio calcolato come "quantità x prezzo" di ogni prodotto   
            */

            List<Prodotto> elenco = new List<Prodotto>()
            {
                new Prodotto() { Nome = "Penna" , Descrizione = "Penna rossa", Prezzo = 9.9 , Categoria = "Cancelleria" , Quantita = 10},
                new Prodotto() { Nome = "Quaderno", Descrizione = "Quaderno a righe", Prezzo = 4.5, Categoria = "Cancelleria", Quantita = 20},
                new Prodotto() { Nome = "Matita", Descrizione = "Matita HB", Prezzo = 1.2, Categoria = "Cancelleria", Quantita = 50},
                new Prodotto() { Nome = "Penna", Descrizione = "Penna rossa", Prezzo = 9.9, Categoria = "Cancelleria", Quantita = 10},
                new Prodotto() { Nome = "Sedia", Descrizione = "Sedia da ufficio ergonomica", Prezzo = 89.9, Categoria = "Arredamento", Quantita = 5},
                new Prodotto() { Nome = "Tastiera", Descrizione = "Tastiera meccanica", Prezzo = 59.9, Categoria = "Elettronica", Quantita = 15},
                new Prodotto() { Nome = "Smartphone", Descrizione = "Smartphone Android", Prezzo = 299.9, Categoria = "Elettronica", Quantita = 12},
                new Prodotto() { Nome = "Bicicletta", Descrizione = "Bicicletta da città", Prezzo = 199.9, Categoria = "Sport", Quantita = 8},
                new Prodotto() { Nome = "Scarpe da corsa", Descrizione = "Scarpe running uomo", Prezzo = 75.0, Categoria = "Abbigliamento", Quantita = 20},
                new Prodotto() { Nome = "Libro", Descrizione = "Romanzo di fantascienza", Prezzo = 15.0, Categoria = "Libri", Quantita = 50},
                new Prodotto() { Nome = "Chitarra", Descrizione = "Chitarra acustica", Prezzo = 120.0, Categoria = "Strumenti musicali", Quantita = 6},
                new Prodotto() { Nome = "Frullatore", Descrizione = "Frullatore da cucina", Prezzo = 45.0, Categoria = "Elettrodomestici", Quantita = 10},
                new Prodotto() { Nome = "Orologio", Descrizione = "Orologio da polso digitale", Prezzo = 55.0, Categoria = "Accessori", Quantita = 25},
                new Prodotto() { Nome = "Zaino", Descrizione = "Zaino per laptop", Prezzo = 39.9, Categoria = "Accessori", Quantita = 30}
            };

            // --------------------------------------------------------------------------------------------------

            // query like
            var certaCategoriaQuery = from prod in elenco
                                 where prod.Categoria is not null && prod.Categoria.Equals("Cancelleria")
                                 select prod;

            foreach (var prod in certaCategoriaQuery)
            {
                Console.WriteLine(prod.ToString());
            }

            // function like
            var certaCategoriaFunction = elenco
                                            .Where(p => p.Categoria.Equals("Alimenti"))
                                            .Select(p => p.Nome);

            // --------------------------------------------------------------------------------------------------

            // function like
            var prezzi = elenco.Select(p => p.Prezzo);
            double somma = 0;
            foreach (var p in prezzi)
            {
                somma += p;
            }
            Console.WriteLine(somma / prezzi.Count());

            //query like
            var prezziQuery = from p in elenco
                              select p.Prezzo;

            Console.WriteLine(prezzi.Average());

            // --------------------------------------------------------------------------------------------------

            var risultato = elenco.Average(p => p.Prezzo);
            Console.WriteLine(risultato);

            // --------------------------------------------------------------------------------------------------

            var quantita = from prod in elenco
                           group prod by prod.Categoria into contenitoriCategoria
                           select contenitoriCategoria;

            foreach (var gruppo in quantita)
            {
                Console.WriteLine(gruppo.Key);
                double somma = gruppo.Sum(p => p.Quantita);

            }
        }
    }
}
