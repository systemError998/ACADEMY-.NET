﻿using LINQ_lez03_raggruppamenti.Models;

namespace LINQ_lez03_raggruppamenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Libro> elenco = new List<Libro>() {
            //    new Libro("Libro A", "Autore 1", "Fantasy"),
            //    new Libro("Libro B", "Autore 2", "Sci-Fi"),
            //    new Libro("Libro C", "Autore 1", "Horror"),
            //    new Libro("Libro D", "Autore 3", "Fantasy"),
            //    new Libro("Libro E", "Autore 2", "Horror")
            //};

            //var risultato = from libro in elenco
            //                select libro.Categoria is not null && libro.Categoria.Equals("Fantasy") ?
            //                libro.Titolo + " è un libro fantasy" : "Non mi interessa"; 
            ////In questo modo ci restituisce tutti i libri e per alcuni l'output sarà diverso
            ////Con il where ci avrebbe restituito SOLO i libri con la categoria inserita nel where 

            //foreach (var l in risultato)
            //{
            //    Console.WriteLine(l);
            //}

            // ----------------------------------------------------------------------------------------------------------

            //List<Libro> elenco = new List<Libro>() {
            //    new Libro(1, "Libro A", "Autore 1", "Fantasy"),
            //    new Libro(2, "Libro B", "Autore 2", "Sci-Fi"),
            //    new Libro(3, "Libro C", "Autore 1", "Horror"),
            //    new Libro(4, "Libro D", "Autore 3", "Fantasy"),
            //    new Libro(5, "Libro E", "Autore 2", "Horror")
            //};

            //var risultato = from libro in elenco
            //                where libro.Categoria is not null && libro.Categoria.Equals("Fantasy")
            //                select new { libro.Titolo, libro.Autore };
            ////Utile per far vedere solo determinate informazioni

            // ----------------------------------------------------------------------------------------------------------

            List<Libro> elenco = new List<Libro>() {
                new Libro(1, "Libro A", "Autore 1", "Fantasy"),
                new Libro(2, "Libro B", "Autore 2", "Sci-Fi"),
                new Libro(3, "Libro C", "Autore 1", "Horror"),
                new Libro(4, "Libro D", "Autore 3", "Fantasy"),
                new Libro(5, "Libro E", "Autore 2", "Horror")
            };

            var risultato = from libro in elenco
                            group libro by libro.Categoria into contenitoriCategorie
                            select contenitoriCategorie;

            foreach (var cat in risultato)
            {
                Console.WriteLine(cat.Key);

                foreach (var lib in cat)
                {
                    Console.WriteLine(lib);
                }
            }


        }
    }
}
