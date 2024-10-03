using EF_lez01_intro.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_lez01_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Scaffold - DbContext "Server=ACADEMY2024-30\SQLEXPRESS;Database=lez04_libreria;User Id=academy;Password=academy2024!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false;"Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models

            //Libro libro = new Libro() { 
            //    Titolo = "titolo",
            //    Autore = "autore",
            //    Pagine = 100,
            //    Editor = "Un editore qualunque",
            //    Isbn = "1111111111111"
            //};

            //using (var contesto = new Lez04LibreriaContext())
            //{
            //    try
            //    {
            //        contesto.Libros.Add(libro);
            //        contesto.SaveChanges();

            //        Console.WriteLine("Inserimento effettuato");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
                
            //}

           //------------------------------------------------------------------- 

            using (var contesto = new Lez04LibreriaContext())
            { 
                //EQUIVALE ALLA SELECT 
                List<Libro> libri = contesto.Libros.ToList();

                foreach (Libro l in libri)
                {
                    Console.WriteLine(l);
                }
            }

            //------------------------------------------------------------------- 

            // CERCO UN LIBRO 
            using (var contesto = new Lez04LibreriaContext())
            {
                //Una single vuole sempre un valore di ritorno quindi va messa in un trycatch
                try
                {
                    Libro lib = contesto.Libros.Single(l => l.Isbn.Equals("9788811811656"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //first or default invece restituisce null se non trova nulla (o la riga se la trova) 
                Libro? libDue = contesto.Libros.FirstOrDefault(l => l.Isbn.Equals("9788811811656"));
            }
        }



        }
    }
}
