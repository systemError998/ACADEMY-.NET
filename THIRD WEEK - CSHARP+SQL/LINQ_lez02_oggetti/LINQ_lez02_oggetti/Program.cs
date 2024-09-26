using LINQ_lez02_oggetti.Models;

namespace LINQ_lez02_oggetti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studente> elenco = new List<Studente>()
            {
                new Studente(){ Nominativo = "Giovanni Pace", Matricola = "AB1234", Eta = 37},
                new Studente(){ Nominativo = "Valeria Verdi", Matricola = "AB1235", Eta = 35},
                new Studente(){ Nominativo = "Marika Mariko", Matricola = "AB1236", Eta = 29},
            };

            //Cerca Valeria Verdi
            var studenteTrovato = elenco.FirstOrDefault(
                stud => (stud.Matricola is not null &&  stud.Matricola.Equals("AB1235")
                )); //lambda expression

            if(studenteTrovato is null)
                Console.WriteLine("Studente non trovato");
            else
                Console.WriteLine(studenteTrovato);




        }
    }
}
