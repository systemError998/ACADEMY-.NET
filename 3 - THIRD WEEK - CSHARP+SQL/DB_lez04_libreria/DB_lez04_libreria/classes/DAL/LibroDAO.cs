using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez04_libreria.classes.DAL
{
    internal class LibroDAO : IDao<Libro>
    {
        // Con il singleton creo una struttura che può essere richiamata una sola volta
        // attributo statico che contiene me stesso
        // metodo pubblico per modificare l'attributo (Devo poterlo prendere dall'esterno) 
        // costruttore privato 

        //ATTRIBUTO STATICO
        private static LibroDAO? instance;

        //METODO
        public static LibroDAO GetInstance()
        { 
            if(instance == null)
                instance = new LibroDAO();
            return instance;
        }

        //COSTRUTTORE PRIVATO
        private LibroDAO() { } //RENDENDOLO PRIVATO NON NE PERMETTO L'ACCESSO E QUINDI LA CREAZIONE

        public List<Libro> GetAll()
        {
            List<Libro> risultato = new List<Libro>();
            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT titolo, autore,pagine,editor,isbn";

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Libro libro = new Libro();
                    }

                    conn.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public Libro? GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Libro obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Libro (titolo,autore,pagine,editor,isbn) VALUES (@tit, @aut, @pag, @edi, @isb)";

                cmd.Parameters.AddWithValue("@tit", obj.Titolo);
                cmd.Parameters.AddWithValue("@aut", obj.Autore);
                cmd.Parameters.AddWithValue("@pag", obj.Pagine);
                cmd.Parameters.AddWithValue("@edi", obj.Editor);
                cmd.Parameters.AddWithValue("@isb", obj.Isbn);

                try
                {
                    conn.Open();

                    int affectedRows = cmd.ExecuteNonQuery();
                    if(affectedRows > 0)
                        risultato = true;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

                return risultato;
        }

        public bool Update(Libro obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Libro Id)
        {
            throw new NotImplementedException();
        }
    }
}
